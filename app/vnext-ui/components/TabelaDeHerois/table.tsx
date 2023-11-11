import React, { useState, useMemo, useCallback } from "react";
import { Table, TableHeader, TableColumn, TableBody, TableRow, TableCell, Pagination, Spinner, getKeyValue, Dropdown, Button, DropdownTrigger, DropdownMenu, DropdownItem, TableVariantProps } from "@nextui-org/react";
import { Input, Selection } from "@nextui-org/react";
import useSWR from "swr";

import { IResposta, IProduto } from "./types/response";
import "./styles.css"
import { IconeDePesquisa } from "./icones/IconeDePesquisa";
import { PontosVerticais } from "./icones/PontosVerticais";

const fetcher = (url: string) => fetch(url).then((res) => res.json());

export default function TabelaDePersonagens(propriedadesDaTabela: TableVariantProps)
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
    const valor = new Intl.NumberFormat('pt-BR', {
      style: 'currency',
      currency: 'BRL',
    }).format(value);
    return <div className="text-right">{valor}</div>
  }

  function formatarQuantidade(value: number)
  {
    const valor = new Intl.NumberFormat('pt-BR').format(value);
    return <div className="text-right">{valor}</div>
  }

  const columnMap: Record<string, (item: IProduto) => React.ReactNode> = {
    id: (item) => item.id,
    sequencial: (item) => item.sequencial,
    nome: (item) => item.nome,
    descricao: (item) => item.descricao,
    preco: (item) => formatarMoeda(item.preco),
    quantidadeEmEstoque: (item) => formatarQuantidade(item.quantidadeEmEstoque),
    acoes: (item) => adicionarAcoes(item.id, propriedadesDaTabela)
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
            ? "Todos os itens foram selecionados"
            : `${selectedKeys.size} of ${data?.totalDeRegistros ?? 0} selecionados`}
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
          color={propriedadesDaTabela.color}
          aria-label="Example table with client async pagination"
          bottomContent={bottomContent}
          topContentPlacement="outside"
          topContent={
            pages > 0 ? (
              <div className="flex justify-between items-center">
                <Input isClearable
                  className="gap-4 w-1/3"
                  placeholder="Pesquisar..." size="sm" startContent={<IconeDePesquisa />}
                  value={filterValue}
                  variant="bordered"
                  color={propriedadesDaTabela.color}
                  onClear={() => setFilterValue("")}
                  onValueChange={onSearchChange}
                />
                <div className="gap-4">
                  <Pagination
                    isCompact
                    showControls
                    showShadow
                    color={propriedadesDaTabela.color}
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
            <TableColumn className="text-right" key="preco">Preço Unitário</TableColumn>
            <TableColumn className="text-right" key="quantidadeEmEstoque">Estoque</TableColumn>
            <TableColumn key="acoes">Ações</TableColumn>
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

function adicionarAcoes(id: string, propriedadesDaTabela: TableVariantProps): React.ReactNode
{
  return (
    <div className="relative flex justify-end items-center gap-2" aria-label="botoes-de-edicao">
      <Dropdown>
        <DropdownTrigger>
          <Button isIconOnly size="sm" variant="light">
            <PontosVerticais className="text-default-300" />
          </Button>
        </DropdownTrigger>
        <DropdownMenu color={propriedadesDaTabela.color}>
          <DropdownItem aria-labelledby="{id}" aria-label="Visualizar">Visualizar</DropdownItem>
          <DropdownItem aria-labelledby="{id}" aria-label="Editar">Editar</DropdownItem>
          <DropdownItem aria-labelledby="{id}" aria-label="Excluir">Excluir</DropdownItem>
        </DropdownMenu>
      </Dropdown>
    </div>
  )
}

