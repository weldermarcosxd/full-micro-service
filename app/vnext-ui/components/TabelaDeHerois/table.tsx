import { useState, useMemo }  from "react";
import {Table, TableHeader, TableColumn, TableBody, TableRow, TableCell, Pagination, Spinner, getKeyValue} from "@nextui-org/react";
import useSWR from "swr";
import { IResposta } from "./types/response";
import "./styles.css"

const fetcher = (url : string) => fetch(url).then((res) => res.json());

export default function TabelaDePersonagens() {
  const [pageNumber, setPage] = useState(1);

  const rowsPerPage = 8;
  const { data, error, isLoading } = useSWR<IResposta, Error>(`https://restless-cherry-2036.fly.dev/api/produto?NumeroDaPagina=${pageNumber}&TamanhoDaPagina=${rowsPerPage}`, fetcher, {
    keepPreviousData: false,
  });


  const pages = useMemo(() => {
    return data?.totalDeRegistros ? Math.ceil(data?.totalDeRegistros / rowsPerPage) : 0;
  }, [data?.totalDeRegistros, rowsPerPage]);

  const loadingState = isLoading || data?.totalDeRegistros === 0 ? "loading" : "idle";

  return (
    <Table
      isStriped
      aria-label="Example table with client async pagination"
      bottomContentPlacement="outside"
      bottomContent={
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
        <TableColumn key="quantidadeEmEstoque">Estoque</TableColumn>
      </TableHeader>
      <TableBody
        items={data?.data ?? [] } 
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
  );
}
