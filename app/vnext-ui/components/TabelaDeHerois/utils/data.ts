import useSWR from "swr";
import { Resultado } from "../types/personagens";
import md5 from "md5";

const fetcher = (url : string) => fetch(url).then((res) => res.json());

export default function ObterPersionagens(rowsPerPage: number, page: number = 1) : Resultado
{
    const apiKey = '821f1b35c8d10b34d27ed0addd122542';
    const secretKey = '5e19c60a478eff5d322d01efcd3c023d4477f338';
    const ts = 1;
    const hash = md5(ts + secretKey + apiKey);
    const urlDaRequisicao = `http://gateway.marvel.com/v1/public/comics?ts=${ts}&apikey=${apiKey}}&hash=${hash}&limit=${rowsPerPage}&offset=${(page-1)*rowsPerPage}`;
    const {data, error, isLoading} = useSWR<Resultado>(urlDaRequisicao, fetcher, {
        keepPreviousData: true,
    });
    if(error) throw error;
    
    const modal = { code: 400 } as Resultado
    if(!data) return modal; 

    return data, isLoading;
};