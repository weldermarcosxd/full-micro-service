// ** React Imports
import { useState, useEffect, ChangeEvent } from 'react'

// ** MUI Imports
import Paper from '@mui/material/Paper'
import Checkbox from '@mui/material/Checkbox';
import Table from '@mui/material/Table'
import TableRow from '@mui/material/TableRow'
import TableHead from '@mui/material/TableHead'
import TableBody from '@mui/material/TableBody'
import TableCell from '@mui/material/TableCell'
import TableContainer from '@mui/material/TableContainer'
import TablePagination from '@mui/material/TablePagination'
import { right } from '@popperjs/core';

interface Column {
  id: 'id' | 'sequencial' | 'dataDaVenda' | 'valorDaVenda'
  label: string
  minWidth?: number
  align?: 'right'
  format?: (value: any) => string
}

const columns: readonly Column[] = [
  { id: 'sequencial', label: 'Sequencial', minWidth: 100 },
  { id: 'dataDaVenda', label: 'Data da venda', minWidth: 100, format: (value : Date) => value.toLocaleString('pt-BR') },
  { id: 'valorDaVenda', label: 'Valor da Venda', minWidth: 100, align: right, format: (value : number) => value.toLocaleString('pr-BR', { style: 'currency', currency: 'BRL',  }) }
]

interface Venda{
  id: string
  sequencial: number
  dataDaVenda: Date
  valorDaVenda: number
}

const TableStickyHeader = () => {
  // ** States
  const [page, setPage] = useState<number>(0)
  const [rowsPerPage, setRowsPerPage] = useState<number>(10)

  const [vendas, setVendas] = useState<Venda[]>([]);

    useEffect(() => {
        const headers = { 'Authorization': 'Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6ImFkbWluIiwicm9sZSI6ImFkbWluIiwibmJmIjoxNjg0NzYyMTU2LCJleHAiOjE2ODUzNjY5NTYsImlhdCI6MTY4NDc2MjE1Nn0.xtDg_QROZ77QNtqwafIz_VJiYmmTxK_lteH9WZ7FQRY' };
        fetch('https://localhost:5001/api/venda', { headers })
            .then(response => response.json())
            .then(data => setVendas(data));
    }, []);

  const handleChangePage = (event: unknown, newPage: number) => {
    setPage(newPage)
  }

  const handleChangeRowsPerPage = (event: ChangeEvent<HTMLInputElement>) => {
    setRowsPerPage(+event.target.value)
    setPage(0)
  }

  return (
    <Paper sx={{ width: '100%', overflow: 'hidden' }}>
      <TableContainer sx={{ maxHeight: 440 }}>
        <Table stickyHeader aria-label='sticky table'>
          <TableHead>
            <TableRow>
              {columns.map(column => (
                <TableCell key={column.id} align={column.align} sx={{ minWidth: column.minWidth }}>
                  {column.label}
                </TableCell>
              ))}
            </TableRow>
          </TableHead>
          <TableBody>
            {vendas.slice(page * rowsPerPage, page * rowsPerPage + rowsPerPage).map((row) => {
              return (
                <TableRow hover role='checkbox' tabIndex={-1} key={row.id}>
                  {columns.map(column => {
                    const value = row[column.id]

                    return (
                      <TableCell key={column.id} align={column.align}>
                        {column.format && typeof value === 'number' ? column.format(value) : value}
                      </TableCell>
                    )
                  })}
                </TableRow>
              )
            })}
          </TableBody>
        </Table>
      </TableContainer>
      <TablePagination
        rowsPerPageOptions={[10, 25, 100]}
        component='div'
        count={vendas.length}
        rowsPerPage={rowsPerPage}
        page={page}
        onPageChange={handleChangePage}
        onRowsPerPageChange={handleChangeRowsPerPage}
      />
    </Paper>
  )
}

export default TableStickyHeader
