import { TreeList, SearchPanel, Column, Lookup, Scrolling, Paging, Pager, Editing, RequiredRule, ColumnFixing, ColumnChooser, FilterRow, RowDragging } from 'devextreme-react/tree-list';
import React, { useEffect, useState } from 'react';
import { collection, doc, getDocs, query, setDoc } from 'firebase/firestore';
import { db } from '../../api/database';
import './CategoriasList.scss'
import { MainCollectionData } from '../../types';
import { Await } from 'react-router-dom';


const allowedPageSizes = [5, 10];

const fetchDataAll = async () => {
    const data:any = [];
    const querySnapshot = await getDocs(collection(db, 'Categorias'));
    querySnapshot.forEach(async doc =>  {
      const item = doc.data();
      item.id = doc.id;
      data.push(item);
  
    const subCollectionSnapshot = await getDocs(collection(db, `Categorias/${doc.id}/subcategoria1`));
    subCollectionSnapshot.forEach(subDoc => {
      const subItem = subDoc.data();
      subItem.id = subDoc.id;
      subItem.parentId = doc.id;
      data.push(subItem);
    });
    });
    console.log(data)
    return data;
   
  };


 
  
  

export default function CategoriasList () {

    const categoriasAdd = async () => {
        await setDoc(doc(db, "Categorias", "idCat11"), {
            name: "Los Angeles",
            icon: "https://www2.fleetpride.com/imagesns/cms/category/Engine_Engine.svg"
          });
          
    }


    console.log()

    const [categorias, setCategoriasAll] = useState([[], []]);

    useEffect(() => {
        const getData = async () => {
        const data = await fetchDataAll();
        console.log(data)
        setCategoriasAll(data);
        };
        getData();
    }, []);

    console.log(categorias)

  
  //console.log(categoriasAll)

  // Create the dataSource

  interface LoadOptions {
    parentId?: string[]; // ajusta el tipo según tus necesidades
  }
  
  interface Categoria{
    parentId: any; 
    icon: string;
    name: string;
    id: string;// ajusta el tipo según tus necesidades
    // Otros campos que puedan tener tus objetos de categoría
  }
  
  const categoriasAll: any[] = [
    categorias   
  ];
  console.log(categoriasAll)
  const dataSource: any = {
    async load(loadOptions: any) {
      const parentIdsParam = loadOptions.parentId;
      try {
        if (parentIdsParam) {
          // Simular la carga de datos filtrados por parentIds
          const filteredData = categoriasAll.filter(item => parentIdsParam.includes(item.parentId));
          console.log(filteredData);
          return filteredData;
        } else {
          // Si no hay parentIds, devolver todos los datos
          console.log(categoriasAll);
          return categoriasAll;
        }
      } catch (error) {
        console.error('Data Loading Error:', error);
        throw error;
      }
    },
  };
  

 


    const expandedRowKeys = [2]

    
    return (
        <React.Fragment>
            <h2 className={'content-block'}>Categorias</h2>
            <div className="categorialist">
            <TreeList
                 id="id"
                 dataSource={dataSource}
                 expandedRowKeys={expandedRowKeys}
                 showBorders={true}
                 showRowLines={true}
                 columnAutoWidth={true}
                 wordWrapEnabled={true}
                 keyExpr="id"
                 parentIdExpr="parentId"
            >
                
                <Scrolling
                    mode="standard" />
                <Paging
                    enabled={true}
                    defaultPageSize={5} />
                <Pager
                    showPageSizeSelector={true}
                    allowedPageSizes={allowedPageSizes}
                    showInfo={true} />
                <SearchPanel visible={true} width={400}/>
                <Column minWidth={100} dataField="id" caption='Id Categoria' >
                </Column>
                <Column minWidth={120} dataField="name" caption='Nombre' />
                <Column minWidth={120} dataField="status" caption='Status' />
                <Editing
                    mode="popup"
                    allowUpdating={true}
                    allowDeleting={true}
                    allowAdding={true}
                />
            </TreeList>
        </div>
        </React.Fragment>


    )
}