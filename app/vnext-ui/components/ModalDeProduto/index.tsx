import { Modal, ModalContent, ModalHeader, ModalBody, ModalFooter, Button, useDisclosure, Checkbox, Input, Link } from "@nextui-org/react";
import useSWR from "swr";
import { IProduto } from "./types/produtos";
import { ModalDeProdutoProps } from "./types/modalProps";
import { obterChaveDoProdutoPorId, obterPorIdAsync, editarAsync, criarAsync, obterUrlBaseDeProduto } from "@/api/produtos";
import { ChangeEvent, FormEvent, useState } from "react";
import { BareFetcher, PublicConfiguration } from "swr/_internal";


export default function ModalDeEdicaoProduto(props: ModalDeProdutoProps)
{
  const [formData, setFormData] = useState({
    id: "",
    sequencial: 0,
    nome: "",
    descricao: "",
    preco: 0,
    quantidadeEmEstoque: 0
  });

  function preencherForm(data: IProduto, key: string, config: Readonly<PublicConfiguration<IProduto, Error, BareFetcher<IProduto>>>): void
  {
    setFormData({
      id: produtoResposta?.id ?? "",
      sequencial: produtoResposta?.sequencial ?? 0,
      nome: produtoResposta!.nome,
      descricao: produtoResposta!.descricao,
      preco: produtoResposta!.preco,
      quantidadeEmEstoque: produtoResposta!.quantidadeEmEstoque,
    });
  }

  const { data: produtoResposta, error, isLoading } = useSWR<IProduto, Error>(obterChaveDoProdutoPorId(props.produtoId), obterPorIdAsync, {
    keepPreviousData: true,
    onSuccess: preencherForm
  });

  const handleInput = (e: ChangeEvent<HTMLInputElement>) =>
  {
    const fieldName = e.target.name;
    const fieldValue = e.target.value;

    setFormData((prevState) => ({
      ...prevState,
      [fieldName]: fieldValue
    }));
  }

  const enviarFormularioAsync = async (e: FormEvent<HTMLFormElement>) =>
  {
    e.preventDefault()

    const produto: IProduto = {
      id: produtoResposta?.id ?? "",
      sequencial: produtoResposta?.sequencial ?? 0,
      nome: formData.nome,
      descricao: formData.descricao,
      preco: formData.preco,
      quantidadeEmEstoque: formData.quantidadeEmEstoque,
    }

    if (produtoResposta!.id === undefined)
      await criarAsync(obterUrlBaseDeProduto(), produto);
    else
      await editarAsync(obterChaveDoProdutoPorId(produtoResposta!.id), produto);

    props.atualizarTabela();
  }

  const conteudoDaModalComValores = (onClose: Function, props: ModalDeProdutoProps) =>
    <>
      {isLoading ? <></> : (
        <form method={produtoResposta?.id == undefined ? "POST" : "PUT"} onSubmit={enviarFormularioAsync}>
          <ModalHeader className="flex flex-col gap-1">{produtoResposta?.nome ?? "Novo produto"}</ModalHeader>
          <ModalBody>
            <Input
              labelPlacement="outside"
              autoFocus
              label="Id"
              placeholder="Id do produto"
              variant="bordered"
              isDisabled
              value={produtoResposta?.id ?? ""}
            />
            <Input
              labelPlacement="outside"
              autoFocus
              label="Sequencial"
              placeholder="Sequencial do produto"
              variant="bordered"
              isDisabled
              value={produtoResposta?.sequencial?.toString() ?? ""}
            />
            <Input
              labelPlacement="outside"
              autoFocus
              label="Nome"
              name="nome"
              isDisabled={!props.editavel}
              placeholder="Nome do produto"
              variant="bordered"
              defaultValue={produtoResposta?.nome?.toString() ?? ""}
              onChange={handleInput}
            />
            <Input
              labelPlacement="outside"
              label="Descrição"
              name="descricao"
              isDisabled={!props.editavel}
              placeholder="Descrição do produto"
              variant="bordered"
              datatype="string"
              contentEditable
              defaultValue={produtoResposta?.descricao?.toString() ?? ""}
              onChange={handleInput}
            />
            <Input
              labelPlacement="outside"
              label="Valor Unitário"
              name="preco"
              isDisabled={!props.editavel}
              placeholder="0.0"
              variant="bordered"
              type="number"
              defaultValue={produtoResposta?.preco?.toString() ?? ""}
              onChange={handleInput}
            />
            <Input
              labelPlacement="outside"
              label="Quantidade Em Estoque"
              name="quantidadeEmEstoque"
              isDisabled={!props.editavel}
              placeholder="0.0"
              type="number"
              variant="bordered"
              defaultValue={produtoResposta?.quantidadeEmEstoque?.toString() ?? ""}
              onChange={handleInput}
            />
          </ModalBody>
          <ModalFooter>
            <Button onPress={onClose} color="primary">
              Fechar
            </Button>

            <Button color={props.cor} className={props.editavel ? "" : "hidden"} type="submit" onPress={async () =>
            {
              props.disclosudeProps.onClose?.();
              props.atualizarTabela();
            }}>
              Salvar
            </Button>
          </ModalFooter>
        </form>
      )}
    </>

  return (
    <Modal isOpen={props.disclosudeProps.isOpen} onOpenChange={props.disclosudeProps.onChange} onClose={props.disclosudeProps.onClose} backdrop="blur">

      <ModalContent>
        {(onClose: Function) => (
          conteudoDaModalComValores(onClose, props)
        )}
      </ModalContent>
    </Modal>
  )
}