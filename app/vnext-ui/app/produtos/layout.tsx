export default function ProdutosLayout({
	children,
}: {
	children: React.ReactNode;
}) {
	return (
		<section className="flex flex-col items-center justify-center gap-8">
			<div className="inline-block justify-center w-full">
				{children}
			</div>
		</section>
	);
}
