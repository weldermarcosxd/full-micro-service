import { useState, useMemo, useCallback } from "react";
import { Table, TableHeader, TableColumn, TableBody, TableRow, TableCell, Spinner, getKeyValue, Dropdown, Button, DropdownTrigger, DropdownMenu, DropdownItem, TableVariantProps, UseDisclosureProps, AvatarIcon } from "@nextui-org/react";
import { Input, Selection, useDisclosure } from "@nextui-org/react";
import { Select, SelectItem } from "@nextui-org/react";
import { Pagination } from "@nextui-org/pagination";

import { obterAsync, removerAsync, obterChaveDaPagina, obterChaveDoProdutoPorId } from '../../api/produtos'
import { IResposta, IProduto } from "./types/response";
import "./styles.css"
import { IconeDePesquisa } from "./icones/IconeDePesquisa";
import { PontosVerticais } from "./icones/PontosVerticais";
import ModalDeProduto from "../ModalDeProduto";
import useSWR from "swr";
import { PlusIcon } from "../TabelaDePessoas/PlusIcon";
import { IconeDeRemocao } from "./icones/IconeDeRemocao";

export default function TabelaDePersonagens(propriedadesDaTabela: TableVariantProps)
{
  const disclosureProps = useDisclosure();

  const [pageNumber, setPage] = useState(1);
  const [filterValue, setFilterValue] = useState("");
  const [parametrosDePesquisa, setParametrosDePesquisa] = useState("");
  const [rowsPerPage, setRowsPerPage] = useState(10);
  const [selectedKeys, setSelectedKeys] = useState<Selection>(new Set([]));
  const [produtoSelecionado, setProdutoSelecionado] = useState("");
  const [timer, setTimer] = useState<NodeJS.Timeout>();
  const [editando, setEditando] = useState(false);

  const { data: respostaDeProdutos, error, isLoading, mutate } = useSWR<IResposta, Error>(obterChaveDaPagina(pageNumber, rowsPerPage, parametrosDePesquisa), obterAsync, {
    keepPreviousData: false,
    revalidateOnFocus: false
  });

  const doRefresh = () => mutate(respostaDeProdutos);

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
    acoes: (item) => adicionarAcoes(item.id, propriedadesDaTabela, doRefresh, disclosureProps, setProdutoSelecionado, setEditando)
  };

  const onRowsPerPageChange = useCallback((e: React.ChangeEvent<HTMLSelectElement>) =>
  {
    setRowsPerPage(Number(e.target.value) ?? 10);
    setPage(1);
  }, []);


  const pages = useMemo(() =>
  {
    return respostaDeProdutos?.totalDeRegistros ? Math.ceil(respostaDeProdutos?.totalDeRegistros / rowsPerPage) : 0;
  }, [respostaDeProdutos?.totalDeRegistros, rowsPerPage]);

  const loadingState = isLoading ? "loading" : "idle";

  const bottomContent = useMemo(() =>
  {
    return (
      <div className="py-2 px-2 flex justify-between items-center">
        <span className="text-small text-default-400">
          {selectedKeys === "all"
            ? "Todos os itens foram selecionados"
            : `${selectedKeys.size} de ${respostaDeProdutos?.totalDeRegistros ?? 0} selecionados`}
        </span>
        <span className="text-default-400 text-small">Total {respostaDeProdutos?.totalDeRegistros} produtos</span>
      </div>
    );
  }, [selectedKeys, respostaDeProdutos?.totalDeRegistros]);

  const topContent = useMemo(() => 
  {
    const opcoesDePaginas: number[] = [5, 10, 20];

    function aplicarFiltros(pesquisa: string)
    {
      clearTimeout(timer);

      const newTimer = setTimeout(() =>
      {
        setParametrosDePesquisa(pesquisa);
        setPage(1);
      }, 500);

      setTimer(newTimer);
    }

    const onSearchChange = (value?: string) =>
    {
      if (value)
        setFilterValue(value);
      else
        setFilterValue("");

      aplicarFiltros(value ?? "");
    };

    return (
      <>
        <div className="flex flex-col relative gap-3">
          <div className="flex justify-between items-center">
            <Input isClearable
              className="w-1/3"
              placeholder="Pesquisar..." 
              size="sm" 
              startContent={<IconeDePesquisa />}
              value={filterValue}
              variant="bordered"
              color={propriedadesDaTabela.color}
              onClear={() => setFilterValue("")}
              onValueChange={onSearchChange}
            />
            {selectedKeys === "all" || selectedKeys.size ? (<Button color="danger" endContent={<IconeDeRemocao />}>
              Remover
            </Button>) : ""}
            <Button color={propriedadesDaTabela.color} endContent={<PlusIcon />} onClick={() => {
              setProdutoSelecionado("");
              setEditando(true);
              disclosureProps.onOpen?.();
            }}>
              Adicionar
            </Button>
          </div>
          <div className="flex justify-between items-center">
          <Select
              label="Linhas por página:"
              placeholder="10"
              className="w-1/3"
              onChange={onRowsPerPageChange}
              defaultValue={10}
              size="sm"
            >
              {opcoesDePaginas.map((opcao) => (
                <SelectItem key={opcao} value={opcao}>
                  {opcao.toString()}
                </SelectItem>
              ))}
            </Select>
            {pages > 0 ? (
              <div className="gap-4">
                <Pagination
                  isCompact
                  showControls
                  showShadow
                  color={propriedadesDaTabela.color}
                  page={pageNumber}
                  total={pages}
                  onChange={(page: number) => setPage(page)}
                />
              </div>
            ) : null}
          </div>
        </div>
      </>
    )
  }, [disclosureProps, filterValue, onRowsPerPageChange, pageNumber, pages, propriedadesDaTabela.color, selectedKeys, timer]);

  return (
    <>
      <Table
        onSelectionChange={setSelectedKeys}
        selectionMode="multiple"
        title="Produtos"
        color={propriedadesDaTabela.color}
        aria-label="Example table with client async pagination"
        bottomContent={bottomContent}
        topContentPlacement="outside"
        topContent={topContent}
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
          items={(respostaDeProdutos?.data ?? []) as IProduto[]}
          loadingContent={<Spinner />}
          loadingState={loadingState}
          emptyContent={isLoading ? "" : "Sem registros para mostrar."}
        >
          {(item: IProduto) => (
            <TableRow key={item?.id}>
              {
                (columnKey: string) =>
                {
                  return <TableCell>
                    <div className="long-text-elipses">
                      {columnMap[columnKey] ? columnMap[columnKey](item) : getKeyValue(item, columnKey)}
                    </div>
                  </TableCell>;
                }
              }
            </TableRow>
          )}
        </TableBody>
      </Table>
      <ModalDeProduto atualizarTabela={() => mutate(respostaDeProdutos)} editavel={editando} produtoId={produtoSelecionado} disclosudeProps={disclosureProps} cor={propriedadesDaTabela!.color || "danger"}></ModalDeProduto>
    </>
  );

  function adicionarAcoes(id: string, propriedadesDaTabela: TableVariantProps, doRefresh: Function, disclosureProps: UseDisclosureProps, setProdutoSelecionado: Function, setEditando: Function): React.ReactNode
  {
    function onEditar(event: React.MouseEvent<HTMLLIElement, MouseEvent>, id: string): void
    {
      event.preventDefault();
      setProdutoSelecionado(id);
      setEditando(true);
      disclosureProps.onOpen?.();
    }

    async function onDeletar(event: React.MouseEvent<HTMLLIElement, MouseEvent>, id: string): Promise<void>
    {
      event.preventDefault();
      await removerAsync(obterChaveDoProdutoPorId(id))
      await doRefresh();
    }

    function onVisualizar(event: React.MouseEvent<HTMLLIElement, MouseEvent>, id: string): void
    {
      event.preventDefault();
      setProdutoSelecionado(id);
      setEditando(false);
      disclosureProps.onOpen?.();
    }

    return (
      <div className="relative flex container-do-botao-de-acoes">
        <Dropdown>
          <DropdownTrigger>
            <Button isIconOnly size="sm" variant="light">
              <PontosVerticais className="botao-de-acoes" />
            </Button>
          </DropdownTrigger>
          <DropdownMenu aria-label="menu-de-edicao" color={propriedadesDaTabela.color}>
            <DropdownItem onClick={(event: React.MouseEvent<HTMLLIElement, MouseEvent>) => onVisualizar(event, id)}>Visualizar</DropdownItem>
            <DropdownItem onClick={(event: React.MouseEvent<HTMLLIElement, MouseEvent>) => onEditar(event, id)}>Editar</DropdownItem>
            <DropdownItem onClick={(event: React.MouseEvent<HTMLLIElement, MouseEvent>) => onDeletar(event, id)}>Excluir</DropdownItem>
          </DropdownMenu>
        </Dropdown>
      </div>
    )
  }
}
