import { useState, useMemo, useCallback } from "react";
import { Table, TableHeader, TableColumn, TableBody, TableRow, TableCell, Pagination, Spinner, getKeyValue } from "@nextui-org/react";
import { Input } from "@nextui-org/react";
import useSWR from "swr";
import { IResposta, Produto } from "./types/response";
import "./styles.css"
import { SearchIcon } from "./icones/SearchIcon";

const fetcher = (url: string) => fetch(url).then((res) => res.json());

export default function TabelaDePersonagens()
{
  const [pageNumber, setPage] = useState(1);
  const [filterValue, setFilterValue] = useState("");
  const [rowsPerPage, setRowsPerPage] = useState(5);

  const { data, error, isLoading } = useSWR<IResposta, Error>(`https://restless-cherry-2036.fly.dev/api/produto?NumeroDaPagina=${pageNumber}&TamanhoDaPagina=${rowsPerPage}`, fetcher, {
    keepPreviousData: false,
  });

  const onSearchChange = useCallback((value?: string) =>
  {
    if (value)
    {
      setFilterValue(value);
      setPage(1);
    } else
    {
      setFilterValue("");
    }
  }, []);

  const onRowsPerPageChange = useCallback((e: React.ChangeEvent<HTMLSelectElement>) =>
  {
    setRowsPerPage(Number(e.target.value) ?? 5);
    setPage(1);
  }, []);


  const pages = useMemo(() =>
  {
    return data?.totalDeRegistros ? Math.ceil(data?.totalDeRegistros / rowsPerPage) : 0;
  }, [data?.totalDeRegistros, rowsPerPage]);

  const loadingState = isLoading || data?.totalDeRegistros === 0 ? "loading" : "idle";

  return (
    <>
      <div className="flex flex-col relative gap-4">
        <div className="flex justify-between gap-3 items-end">
          <Input isClearable
            placeholder="Search by name..." size="sm" startContent={<SearchIcon />}
            value={filterValue}
            variant="bordered"
            onClear={() => setFilterValue("")}
            onValueChange={onSearchChange}
          />
          <div className="flex justify-between items-center">
            <span className="text-default-400 text-small">Total {data?.totalDeRegistros} produtos</span>
            <label className="flex items-center text-default-400 text-small">
              Linhas por página:
              <select
                className="bg-transparent outline-none text-default-400 text-small"
                onChange={onRowsPerPageChange}
              >
                <option value="5">5</option>
                <option value="10">10</option>
                <option value="20">20</option>
              </select>
            </label>
          </div>
        </div>
        <Table
          isStriped
          aria-label="Example table with client async pagination"
          topContentPlacement="outside"
          topContent={
            pages > 0 ? (
              <div className="flex w-full justify-center">
                <Pagination
                  isCompact
                  showControls
                  showShadow
                  color="primary"
                  page={pageNumber}
                  total={pages}
                  onChange={(page) => setPage(page)}
                />
              </div>
            ) : null
          }
        >
          <TableHeader className="text-center">
            <TableColumn key="sequencial">#</TableColumn>
            <TableColumn key="nome">Nome</TableColumn>
            <TableColumn key="descricao" width={"30%"}>Descrição</TableColumn>
            <TableColumn key="preco">Preço Unitário</TableColumn>
            <TableColumn key="precoFormatado">Preço Unitário</TableColumn>
            <TableColumn key="quantidadeEmEstoqueFormatada">Estoque</TableColumn>
          </TableHeader>
          <TableBody
            items={(data?.data ?? []) as Produto[]}
            loadingContent={<Spinner />}
            loadingState={loadingState}
          >
            {(item) => (
              <TableRow key={item?.id}>
                {(columnKey) => <TableCell><div className="long-text-elipses">{getKeyValue(item, columnKey)}</div></TableCell>}
              </TableRow>
            )}
          </TableBody>
        </Table>
      </div>
    </>
  );
}
