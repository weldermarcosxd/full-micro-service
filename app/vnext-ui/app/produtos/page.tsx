"use client"

import dynamic from 'next/dynamic'
import { Divider } from "@nextui-org/divider";
import React from "react";

const TabelaDePersonagens = dynamic(
    () => import('@/components/TabelaDeHerois/table'),
    { ssr: false }
  )


export default function ProdutosPage()
{
	return (
		<>
			<div className="space-y-2 text-center">
				<h1 className="tracking-tight inline font-semibold text-[2.3rem] lg:text-5xl leading-9 m2">Produtos</h1>
			</div>
			<Divider className="my-4" />
			<TabelaDePersonagens color='secondary'></TabelaDePersonagens>
		</>
	)
}
