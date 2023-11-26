import { Modal, ModalContent, ModalHeader, ModalBody, ModalFooter, Button, useDisclosure, Checkbox, Input, Link } from "@nextui-org/react";
import useSWR from "swr";
import { IProduto } from "./types/produtos";
import { ModalDeProdutoProps } from "./types/modalProps";
import { obterChaveDoProdutoPorId, obterPorIdAsync, editarAsync } from "@/api/produtos";
import { ChangeEvent } from "react";


export default function ModalDeEdicaoProduto(props: ModalDeProdutoProps)
{
  const { data: produtoResposta, error, isLoading } = useSWR<IProduto, Error>(obterChaveDoProdutoPorId(props.produtoId), obterPorIdAsync, {
    keepPreviousData: true,
  });

  function atualizarNome(event: ChangeEvent<HTMLInputElement>): void
  {
    produtoResposta!.nome = event.currentTarget.value;
  }

  const conteudoDaModalComValores = (onClose: Function, props: ModalDeProdutoProps) =>
    <>
      {isLoading ? <></> : (
        <>
          <ModalHeader className="flex flex-col gap-1">{produtoResposta?.nome}</ModalHeader>
          <ModalBody>
            <Input
              labelPlacement="outside"
              autoFocus
              label="Id"
              placeholder="Id do produto"
              variant="bordered"
              isDisabled
              value={produtoResposta?.id}
            />
            <Input
              labelPlacement="outside"
              autoFocus
              label="Sequencial"
              placeholder="Sequencial do produto"
              variant="bordered"
              isDisabled
              value={produtoResposta?.sequencial?.toString()}
            />
            <Input
              labelPlacement="outside"
              autoFocus
              label="Nome"
              isDisabled={!props.editavel}
              placeholder="Nome do produto"
              variant="bordered"
              defaultValue={produtoResposta?.nome.toString()}
              onChange={atualizarNome}
            />
            <Input
              labelPlacement="outside"
              label="Descrição"
              isDisabled={!props.editavel}
              placeholder="Descrição do produto"
              variant="bordered"
              datatype="string"
              contentEditable
              defaultValue={produtoResposta?.descricao?.toString()}
            />
            <Input
              labelPlacement="outside"
              label="Valor Unitário"
              isDisabled={!props.editavel}
              placeholder="0.0"
              variant="bordered"
              type="number"
              defaultValue={produtoResposta?.preco?.toString()}
            />
            <Input
              labelPlacement="outside"
              label="Quantidade Em Estoque"
              isDisabled={!props.editavel}
              placeholder="0.0"
              type="number"
              variant="bordered"
              defaultValue={produtoResposta?.quantidadeEmEstoque?.toString()}
            />
          </ModalBody>
        </>
      )}
      <ModalFooter>
        <Button onPress={onClose} color="primary">
          Fechar
        </Button>

        <Button className={props.editavel ? "" : "hidden"} onPress={async () =>
        {
          await editarAsync(obterChaveDoProdutoPorId(produtoResposta!.id), produtoResposta!);
          props.onFechar
          onClose();
        }} color={props.cor}>
          Salvar
        </Button>
      </ModalFooter>
    </>

  return (
    <Modal isOpen={props.disclosudeProps.isOpen} onOpenChange={props.disclosudeProps.onOpenChange} backdrop="blur">

      <ModalContent>
        {(onClose: Function) => (
          conteudoDaModalComValores(onClose, props)
        )}
      </ModalContent>
    </Modal>
  )
}
