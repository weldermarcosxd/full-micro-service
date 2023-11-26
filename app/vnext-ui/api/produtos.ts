import { IProduto } from "@/components/ModalDeProduto/types/produtos";
import { IResposta } from "@/components/TabelaDeHerois/types/response";

async function obter<T>(url: string): Promise<T>
{
    const res = await fetch(url);
    return await res.json();
}

const remover = (url: string): Promise<void> => fetch(url, { method: 'DELETE' }).then(() => { });

const atualizar = (url: string, parametros: object): Promise<void> => fetch(url, parametros).then(() => { });

const baseUrl = "https://restless-cherry-2036.fly.dev/api";

export function obterChaveDaPagina(pageNumber: number, rowsPerPage: number, filtroDeTexto: string): string
{
    const parametroDePesquisaTextual = filtroDeTexto === '' ? '' : `&PesquisaTextual=${filtroDeTexto}`;
    return `${baseUrl}/produto?NumeroDaPagina=${pageNumber}&TamanhoDaPagina=${rowsPerPage}${parametroDePesquisaTextual}`;
}

export function obterChaveDoProdutoPorId(id: string): string
{
    return `${baseUrl}/produto/${id}`;
}

export async function obterAsync(urlDeProdutos: string): Promise<IResposta>
{
    return await obter<IResposta>(urlDeProdutos);
}

export async function obterPorIdAsync(urlDeProdutos: string): Promise<IProduto>
{
    return await obter<IProduto>(urlDeProdutos);
}

export async function removerAsync(urlDoProduto: string): Promise<void>
{
    return await remover(urlDoProduto);
}

export async function editarAsync(urlDoProduto: string, produto: IProduto): Promise<void>
{
    var parametros = { method: 'PUT', headers: { 'Content-Type': 'application/json'}, body: JSON.stringify(produto) };
    await atualizar(urlDoProduto, parametros);
}

