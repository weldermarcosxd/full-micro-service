import { IResposta } from "@/components/TabelaDeHerois/types/response";
import { UseDisclosureProps } from "@nextui-org/react";

export interface ModalDeProdutoProps 
{
    produtoId: string
    disclosudeProps: UseDisclosureProps
    cor: string,
    editavel: boolean,
    onFechar: () => Promise<IResposta | undefined>
}