import { Modal, ModalBody, ModalContent, ModalFooter, ModalHeader } from "@nextui-org/react";
import { Button } from "@nextui-org/react";
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

    return (
        <Modal isOpen={props.disclosudeProps.isOpen} onOpenChange={props.disclosudeProps.onOpenChange} backdrop="blur">
        <ModalContent>
          {(onClose: Function) => (
            <>
              <ModalHeader className="flex flex-col gap-1">{produtoResposta?.nome}</ModalHeader>
              <ModalBody>
                <p> 
                    {isLoading ? "Carregando..." : "Id: " + produtoResposta?.id}
                </p>
                <p> 
                    {isLoading ? "Carregando..." : "Sequencial: " + produtoResposta?.sequencial}
                </p>
                <p> 
                    {isLoading ? "Carregando..." : "Descrição: " + produtoResposta?.descricao}
                </p>
                <p> 
                    {isLoading ? "Carregando..." : "Preço: " + ExtensoesNumericas.formatarValorMonetario(produtoResposta!.preco)}
                </p>
                <p> 
                    {isLoading ? "Carregando..." : "Quantidade Em Estoque: " + ExtensoesNumericas.formatarQuantidade(produtoResposta!.quantidadeEmEstoque)}
                </p>

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