"use client"

import { Divider } from "@nextui-org/divider";
import React from "react";
import { use } from "react";
import TabelaDePessoas from "@/components/TabelaDePessoas/table";

async function obterProdutos(){
	var response = await fetch("https://6533e2f5e1b6f4c590465a9a.mockapi.io/api/v1/produtos", { next: { revalidate: 3600 } });

	if (!response.ok) 
		throw new Error('Falha ao obter produtos')

	return response.json();
}


export default function ProdutosPage()
{
	const produtos = use(obterProdutos());
	return (
		<>
			<div className="space-y-2">
				<h1 className="tracking-tight inline font-semibold text-[2.3rem] lg:text-5xl leading-9 m2">Produtos</h1>
			</div>
			<Divider className="my-4" />
			<TabelaDePessoas></TabelaDePessoas>
		</>
	)
}
