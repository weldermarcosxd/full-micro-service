import { Modal, ModalContent, ModalHeader, ModalBody, ModalFooter, Button, useDisclosure, Checkbox, Input, Link } from "@nextui-org/react";
import useSWR, { mutate } from "swr";
import { IProduto } from "./types/produtos";
import { ExtensoesNumericas } from "@/utils/extensoes-numericas";
import { ModalDeEdicaoProdutoProps } from "./types/modalDeEdicaoProps";


const fetcher = (url: string): Promise<IProduto> => fetch(url).then((res) => res.json());

export default function ModalDeEdicaoProduto(props: ModalDeEdicaoProdutoProps)
{
  const { data: produtoResposta, error, isLoading } = useSWR<IProduto, Error>(`https://restless-cherry-2036.fly.dev/api/produto/${props.produtoId}`, fetcher, {
    keepPreviousData: false,
    onSuccess: () => console.log("chamada a produtos")
  });

  const conteudoDaModalComValores = (onClose: Function, props: ModalDeEdicaoProdutoProps) =>
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
          placeholder="Nome do produto"
          variant="bordered"
          defaultValue={produtoResposta?.nome.toString()}
        />
        <Input
          labelPlacement="outside"
          label="Descrição"
          placeholder="Descrição do produto"
          variant="bordered"
          datatype="string"
          contentEditable
          defaultValue={produtoResposta?.descricao?.toString()}
        />
        <Input
          labelPlacement="outside"
          label="Valor Unitário"
          placeholder="0.0"
          variant="bordered"
          type="number"
          defaultValue={produtoResposta?.preco?.toString()}
        />
        <Input
          labelPlacement="outside"
          label="Quantidade Em Estoque"
          placeholder="0.0"
          type="number"
          variant="bordered"
          defaultValue={produtoResposta?.quantidadeEmEstoque?.toString()}
        />
      </ModalBody>
      <ModalFooter>
        <Button onPress={onClose} color="primary">
          Fechar
        </Button>

        <Button onPress={onClose} color={props.cor}>
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