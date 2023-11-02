import { useState, useMemo }  from "react";
import {Table, TableHeader, TableColumn, TableBody, TableRow, TableCell, Pagination, Spinner, getKeyValue} from "@nextui-org/react";
import useSWR from "swr";
import { Cerveja } from "./types/cervejas";

const fetcher = (url : string) => fetch(url).then((res) => res.json());

export default function TabelaDePersonagens() {
  const [pageNumber, setPage] = useState(1);

  const rowsPerPage = 15;
  const {data, isLoading} = useSWR(`https://api.punkapi.com/v2/beers?per_page=${rowsPerPage}&page=${pageNumber}`, fetcher, {
    keepPreviousData: true,
  });


  const pages = useMemo(() => {
    return data?.results?.length ? Math.ceil(data.count / rowsPerPage) : 0;
  }, [data?.count, rowsPerPage]);

  const loadingState = isLoading || data?.results.length === 0 ? "loading" : "idle";

  return (
    <Table
      isStriped
      aria-label="Example table with client async pagination"
      bottomContentPlacement="outside"
      bottomContent={
        pages > 0 ? (
          <div className="flex w-full justify-center">
            <Pagination
              isCompact
              showControls
              showShadow
              color="primary"
              page={pageNumber}
              total={pages}
              onChange={(page) => setPage(page)}
            />
          </div>
        ) : null
      }
    >
      <TableHeader className="text-center">
        <TableColumn align="center" key="id">#</TableColumn>
        <TableColumn align="center" key="name">Name</TableColumn>
        <TableColumn align="center" key="image_url">Url</TableColumn>
        <TableColumn align="center" key="first_brewed">Mass</TableColumn>
        <TableColumn key="brewers_tips">Birth year</TableColumn>
      </TableHeader>
      <TableBody
        items={(data?.results ?? []) as Cerveja[] } 
        loadingContent={<Spinner />}
        loadingState={loadingState}
      >
        {(item) => (
          <TableRow key={item?.name}>
            {(columnKey) => <TableCell align="center">{getKeyValue(item, columnKey)}</TableCell>}
          </TableRow>
        )}
      </TableBody>
    </Table>
  );
}
