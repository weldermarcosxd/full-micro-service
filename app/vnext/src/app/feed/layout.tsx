import './styles.css'
import { Inter } from 'next/font/google'

const inter = Inter({ subsets: ['latin'] })


export default function FeedLayout({
  children,
}: {
  children: React.ReactNode
}) {
  return (
    <html lang="en">
      <body className={inter.className}>{children}</body>
    </html>
  )
}
