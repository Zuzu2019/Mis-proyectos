import React, { useEffect, useState } from 'react';
import 'devextreme/data/odata/store';
import DataGrid, {
  Column,
  Pager,
  Paging,
  FilterRow,
  Lookup
} from 'devextreme-react/data-grid';
import { collection, getDocs } from 'firebase/firestore';
import { db } from '../../api/database';





export default function ProductosLista() {

  const [productosall, setProductosAll] = useState<any[]>([]);


useEffect(() =>{
  getProductosAll()

}, [])


 //Productos

 const getproduct = collection(db, `Productos`)
 const getProductosAll = async () => {
  const q = await getDocs(getproduct)
  const productos = q.docs.map((doc) => {
      return { ...doc.data(), id: doc.id }
  })
  setProductosAll(productos)
} 

console.log(productosall)
  return (
    <React.Fragment>
      <h2 className={'content-block'}>Productos</h2>
      <DataGrid
        className={'dx-card wide-card'}
        dataSource={productosall}
        showBorders={false}
        focusedRowEnabled={true}
        defaultFocusedRowIndex={0}
        columnAutoWidth={true}
        columnHidingEnabled={true}
      >
        <Paging defaultPageSize={10} />
        <Pager showPageSizeSelector={true} showInfo={true} />
        <FilterRow visible={true} />

        <Column dataField={'id'} width={90} hidingPriority={2} />
        <Column
          dataField={'nombre'}
          width={400}
          caption={'Nombre'}
          hidingPriority={8}
        />
        <Column
          dataField={'marca'}
          width={250}
          caption={'Marca'}
          hidingPriority={6}
        />
        <Column
          dataField={'parte'}
          width={250}
          caption={'Parte'}
          hidingPriority={5}
        />
        <Column
          dataField={'fecha'}
          width={250}
          caption={'Fecha en que se agrego'}
          dataType={'date'}
          hidingPriority={3}
        />
      </DataGrid>
    </React.Fragment>
)}

