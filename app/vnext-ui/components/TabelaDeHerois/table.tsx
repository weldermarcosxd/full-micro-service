import { useState, useMemo, useCallback } from "react";
import { Table, TableHeader, TableColumn, TableBody, TableRow, TableCell, Pagination, Spinner, getKeyValue, Dropdown, Button, DropdownTrigger, DropdownMenu, DropdownItem, TableVariantProps, UseDisclosureProps } from "@nextui-org/react";
import { Modal, ModalBody, ModalContent, ModalFooter, ModalHeader, useDisclosure } from "@nextui-org/react";
import { Input, Selection } from "@nextui-org/react";
import useSWR, { mutate } from "swr";

import { IResposta, IProduto } from "./types/response";
import "./styles.css"
import { IconeDePesquisa } from "./icones/IconeDePesquisa";
import { PontosVerticais } from "./icones/PontosVerticais";

const fetcher = (url: string) : Promise<IResposta> => fetch(url).then((res) => res.json());

export default function TabelaDePersonagens(propriedadesDaTabela: TableVariantProps)
{
  const [pageNumber, setPage] = useState(1);
  const [filterValue, setFilterValue] = useState("");
  const [rowsPerPage, setRowsPerPage] = useState(10);
  const [selectedKeys, setSelectedKeys] = useState<Selection>(new Set([]));
  const disclosureProps  = useDisclosure();

  const { data: respostaDeProdutos, error, isLoading } = useSWR<IResposta, Error>(`https://restless-cherry-2036.fly.dev/api/produto?NumeroDaPagina=${pageNumber}&TamanhoDaPagina=${rowsPerPage}`, fetcher, {
    keepPreviousData: false,
  });

  const doRefresh = () => {
    mutate(`https://restless-cherry-2036.fly.dev/api/produto?NumeroDaPagina=${pageNumber}&TamanhoDaPagina=${rowsPerPage}`);
  };

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
    acoes: (item) => adicionarAcoes(item.id, propriedadesDaTabela, doRefresh, disclosureProps)
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
    return respostaDeProdutos?.totalDeRegistros ? Math.ceil(respostaDeProdutos?.totalDeRegistros / rowsPerPage) : 0;
  }, [respostaDeProdutos?.totalDeRegistros, rowsPerPage]);

  const loadingState = isLoading || respostaDeProdutos?.totalDeRegistros === 0 ? "loading" : "idle";

  const bottomContent = useMemo(() => {
    return (
      <div className="py-2 px-2 flex justify-end items-center">
        <span className="text-small text-default-400">
          {selectedKeys === "all"
            ? "Todos os itens foram selecionados"
            : `${selectedKeys.size} of ${respostaDeProdutos?.totalDeRegistros ?? 0} selecionados`}
        </span>
      </div>
    );
  }, [selectedKeys, respostaDeProdutos?.totalDeRegistros]);

  return (
    <>
      <div className="flex flex-col relative gap-4">
        <div className="flex justify-between items-center">
          <span className="text-default-400 text-small">Total {respostaDeProdutos?.totalDeRegistros} produtos</span>
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
            items={(respostaDeProdutos?.data ?? []) as IProduto[]}
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
      <Modal isOpen={disclosureProps.isOpen} onOpenChange={disclosureProps.onOpenChange}>
        <ModalContent>
          {(onClose) => (
            <>
              <ModalHeader className="flex flex-col gap-1">Modal Title</ModalHeader>
              <ModalBody>
                <p> 
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                  Nullam pulvinar risus non risus hendrerit venenatis.
                  Pellentesque sit amet hendrerit risus, sed porttitor quam.
                </p>
                <p>
                  Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                  Nullam pulvinar risus non risus hendrerit venenatis.
                  Pellentesque sit amet hendrerit risus, sed porttitor quam.
                </p>
                <p>
                  Magna exercitation reprehenderit magna aute tempor cupidatat consequat elit
                  dolor adipisicing. Mollit dolor eiusmod sunt ex incididunt cillum quis. 
                  Velit duis sit officia eiusmod Lorem aliqua enim laboris do dolor eiusmod. 
                  Et mollit incididunt nisi consectetur esse laborum eiusmod pariatur 
                  proident Lorem eiusmod et. Culpa deserunt nostrud ad veniam.
                </p>
              </ModalBody>
              <ModalFooter>
                <Button color="danger" variant="light" onPress={onClose }>
                  Close
                </Button>
                <Button color="primary" onPress={disclosureProps.onClose}>
                  Action
                </Button>
              </ModalFooter>
            </>
          )}
        </ModalContent>
      </Modal>

    </>
  );
}

function adicionarAcoes(id: string, propriedadesDaTabela: TableVariantProps, doRefresh : Function, disclosureProps : UseDisclosureProps): React.ReactNode
{
  function onEditar(event: React.MouseEvent<HTMLLIElement, MouseEvent>, id: string): void
  {
    event.stopPropagation();
    console.log(`quer editar o id ${id}`)
  }

  async function onDeletar(event: React.MouseEvent<HTMLLIElement, MouseEvent>, id: string): Promise<void>
  {
    event.target
    await fetch(`https://restless-cherry-2036.fly.dev/api/produto/${id}`, { method: "DELETE" });
    doRefresh();
  }

  function onVisualizar(event: React.MouseEvent<HTMLLIElement, MouseEvent>, id: string): void
  {
    event.stopPropagation();
    disclosureProps.onOpen?.();
    console.log(`quer visualizar o id ${id}`)
  }

  return (
    <div className="relative flex items-center gap-2">
      <Dropdown>
        <DropdownTrigger>
          <Button isIconOnly size="sm" variant="light">
            <PontosVerticais className="text-default-300" />
          </Button>
        </DropdownTrigger>
        <DropdownMenu aria-label="menu-de-edicao" color={propriedadesDaTabela.color}>
          <DropdownItem onClick={(event) => onVisualizar(event, id)}>Visualizar</DropdownItem>
          <DropdownItem onClick={(event) => onEditar(event, id)}>Editar</DropdownItem>
          <DropdownItem onClick={(event) => onDeletar(event, id)}>Excluir</DropdownItem>
        </DropdownMenu>
      </Dropdown>
    </div>
  )
}

