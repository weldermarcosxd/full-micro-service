"use client"

import { Divider } from "@nextui-org/divider";
import React from "react";
import TabelaDePersonagens from "@/components/TabelaDeHerois/table";

export default function ProdutosPage()
{
	return (
		<>
			<div className="space-y-2 text-center">
				<h1 className="tracking-tight inline font-semibold text-[2.3rem] lg:text-5xl leading-9 m2">Produtos</h1>
			</div>
			<Divider className="my-4" />
			<TabelaDePersonagens></TabelaDePersonagens>
		</>
	)
}
