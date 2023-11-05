import React, { useState, useMemo, useCallback } from "react";
import { Table, TableHeader, TableColumn, TableBody, TableRow, TableCell, Pagination, Spinner, getKeyValue } from "@nextui-org/react";
import { Input, Button, Selection } from "@nextui-org/react";
import useSWR from "swr";

import { IResposta, IProduto } from "./types/response";
import "./styles.css"
import { SearchIcon } from "./icones/SearchIcon";

const fetcher = (url: string) => fetch(url).then((res) => res.json());

export default function TabelaDePersonagens()
{
  const [pageNumber, setPage] = useState(1);
  const [filterValue, setFilterValue] = useState("");
  const [rowsPerPage, setRowsPerPage] = useState(10);
  const [selectedKeys, setSelectedKeys] = useState<Selection>(new Set([]));

  const { data, error, isLoading } = useSWR<IResposta, Error>(`https://restless-cherry-2036.fly.dev/api/produto?NumeroDaPagina=${pageNumber}&TamanhoDaPagina=${rowsPerPage}`, fetcher, {
    keepPreviousData: false,
  });

  function formatarMoeda(value: number)
  {
    return new Intl.NumberFormat('pt-BR', {
      style: 'currency',
      currency: 'BRL',
    }).format(value);
  }

  function formatarQuantidade(value: number)
  {
    return new Intl.NumberFormat('pt-BR').format(value);
  }

  const columnMap: Record<string, (item: IProduto) => React.ReactNode> = {
    id: (item) => item.id,
    sequencial: (item) => item.sequencial,
    nome: (item) => item.nome,
    descricao: (item) => item.descricao,
    preco: (item) => formatarMoeda(item.preco),
    quantidadeEmEstoque: (item) => formatarQuantidade(item.quantidadeEmEstoque),
  };

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

  const onNextPage = React.useCallback(() => {
    if (pageNumber < pages) {
      setPage(pageNumber + 1);
    }
  }, [pageNumber, data?.data]);
  
  const onPreviousPage = React.useCallback(() => {
    if (pageNumber > 1) {
      setPage(pageNumber - 1);
    }
  }, [pageNumber]);

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

  const bottomContent = useMemo(() => {
    return (
      <div className="py-2 px-2 flex justify-end items-center">
        <span className="text-small text-default-400">
          {selectedKeys === "all"
            ? "All items selected"
            : `${selectedKeys.size} of ${data?.totalDeRegistros} selected`}
        </span>
      </div>
    );
  }, [selectedKeys, data?.totalDeRegistros, pageNumber, pages, filterValue]);

  return (
    <>
      <div className="flex flex-col relative gap-4">
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
        <Table
          onSelectionChange={setSelectedKeys}
          selectionMode="multiple"
          title="Produtos"
          color="success"
          aria-label="Example table with client async pagination"
          bottomContent={bottomContent}
          topContentPlacement="outside"
          topContent={
            pages > 0 ? (
              <div className="flex justify-between items-center">
                <Input isClearable
                  className="gap-4 w-1/3"
                  placeholder="Pesquisar..." size="sm" startContent={<SearchIcon />}
                  value={filterValue}
                  variant="bordered"
                  onClear={() => setFilterValue("")}
                  onValueChange={onSearchChange}
                />
                <div className="gap-4">
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
              </div>
            ) : null
          }
        >
          <TableHeader>
            <TableColumn key="sequencial">#</TableColumn>
            <TableColumn key="nome">Nome</TableColumn>
            <TableColumn key="descricao" className="w-1/3">Descrição</TableColumn>
            <TableColumn key="preco" align="end">Preço Unitário</TableColumn>
            <TableColumn key="quantidadeEmEstoque">Estoque</TableColumn>
          </TableHeader>
          <TableBody
            items={(data?.data ?? []) as IProduto[]}
            loadingContent={<Spinner />}
            loadingState={loadingState}
          >
            {(item) => (
              <TableRow key={item?.id}>
                {
                  (columnKey) =>
                    <TableCell>
                      <div className="long-text-elipses">
                        {columnMap[columnKey] ? columnMap[columnKey](item) : getKeyValue(item, columnKey)}
                      </div>
                    </TableCell>
                }
              </TableRow>
            )}
          </TableBody>
        </Table>
      </div>
    </>
  );
}
