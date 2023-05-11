import type { ReactElement } from 'react';
import { Grid, Box } from '@mui/material';
import PageContainer from '../src/components/container/PageContainer';

// components
import FullLayout from '../src/layouts/full/FullLayout';

export default function Home() {
  return (
    <PageContainer title="Dashboard" description="this is Dashboard">
      
    </PageContainer>
  );
}

Home.getLayout = function getLayout(page: ReactElement) {
  return <FullLayout>{page}</FullLayout>;
};