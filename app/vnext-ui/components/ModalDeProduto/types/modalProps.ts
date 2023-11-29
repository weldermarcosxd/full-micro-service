import { IResposta } from "@/components/TabelaDeHerois/types/response";
import { UseDisclosureProps } from "@nextui-org/react";

export interface ModalDeProdutoProps 
{
    produtoId: string,
    atualizarTabela: () => Promise<IResposta | undefined>,
    disclosudeProps: UseDisclosureProps
    cor: string,
    editavel: boolean
}