import {Modal, ModalContent, ModalHeader, ModalBody, ModalFooter, Button, useDisclosure, Checkbox, Input, Link} from "@nextui-org/react";
import useSWR, { mutate } from "swr";
import { IProduto } from "./types/produtos";
import { ExtensoesNumericas } from "@/utils/extensoes-numericas";
import { ModalDeEdicaoProdutoProps } from "./types/modalDeEdicaoProps";


const fetcher = (url: string) : Promise<IProduto> => fetch(url).then((res) => res.json());

export default function ModalDeEdicaoProduto(props: ModalDeEdicaoProdutoProps)
{
    const{ data: produtoResposta, error, isLoading } = useSWR<IProduto, Error>(`https://restless-cherry-2036.fly.dev/api/produto/${props.produtoId}`, fetcher, {
      keepPreviousData: false,
      onSuccess: () => console.log("chamada a produtos")
    });

    function alterarValor(valor : string){
      produtoResposta.preco = int.parse(valor);
    }

    return (
        <Modal isOpen={props.disclosudeProps.isOpen} onOpenChange={props.disclosudeProps.onOpenChange} backdrop="blur">
        <ModalContent>
          {(onClose: Function) => (
            <>
              <ModalHeader className="flex flex-col gap-1">{produtoResposta?.nome}</ModalHeader>
              <ModalBody>
              <Input
                  autoFocus
                  label="Id"
                  placeholder="Id do produto"
                  variant="bordered"
                  isDisabled
                  value={produtoResposta?.id}
                />
                <Input
                  autoFocus
                  label="Sequencial"
                  placeholder="Sequencial do produto"
                  variant="bordered"
                  isDisabled
                  value={produtoResposta?.sequencial?.toString()}
                />
                <Input
                  autoFocus
                  label="Nome"
                  placeholder="Nome do produto"
                  variant="bordered"
                  value={produtoResposta?.nome.toString()}
                  onValueChange={alterarValor}
                />
                <Input
                  autoFocus
                  label="Descrição"
                  placeholder="Descrição do produto"
                  variant="bordered"
                  defaultValue={produtoResposta?.descricao?.toString()}
                />
                <Input
                  autoFocus
                  label="Valor Unitário"
                  placeholder="0.0"
                  variant="bordered"
                  defaultValue={produtoResposta?.preco?.toString()}
                />
                <Input
                  autoFocus
                  label="Quantidade Em Estoque"
                  placeholder="0.0"
                  variant="bordered"
                  defaultValue={produtoResposta?.quantidadeEmEstoque?.toString()}
                />
              </ModalBody>
              <ModalFooter>
                <Button onPress={onClose} color={props.cor}>
                  Fechar
                </Button>
              </ModalFooter>
            </>
          )}
        </ModalContent>
      </Modal>
    )
}