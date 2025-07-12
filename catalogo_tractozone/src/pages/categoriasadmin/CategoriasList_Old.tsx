import { TreeList, SearchPanel, Column, Lookup, Scrolling, Paging, Pager, Editing, RequiredRule, ColumnFixing, ColumnChooser, FilterRow, RowDragging } from 'devextreme-react/tree-list';
import React, { useEffect, useState } from 'react';
import { collection, doc, getDocs, query, setDoc } from 'firebase/firestore';
import { db } from '../../api/database';
import './CategoriasList.scss'


const allowedPageSizes = [5, 10];



export default function CategoriasList () {


    const [categorias, setCategorias] = useState<any[]>([])
    const [subcategoria, setSubcategoria] = useState<any[]>([]);
   
   const fetchData = async () => {
    const data = [];

       //CATEGORIAS
    const subcategoriasRef = collection(db, `Categorias`)
    const q = await getDocs(subcategoriasRef)
    const categorias = q.docs.map((doc) => {
        return { ...doc.data(), id: doc.id }
    })
    //setCategorias(subcategorias)
    data.push(categorias)


    const subcategoriasRefe = collection(db, `Categorias/idCat/subcategoria1/idCate1/subcategoria2`)
    const qu = await getDocs(subcategoriasRefe)
    const subcategorias = qu.docs.map((doc) => {
        return { ...doc.data(), id: doc.id }
    })
    //setSubcategoria(categorias)
    data.push(subcategorias)


    return data;
  
   }

//    //CATEGORIAS
//    const getCategorias = async () => {
//     const subcategoriasRef = collection(db, `Categorias`)
//     const q = await getDocs(subcategoriasRef)
//     const categorias = q.docs.map((doc) => {
//         return { ...doc.data(), id: doc.id }
//     })
//     //setCategorias(subcategorias)
//     data.push(categorias)

// }
//  //SUBCATEGORIAS
//  const getSubCategorias = async () =>{
//     const subcategoriasRef = collection(db, `Categorias/idCat/subcategoria1/idCate1/subcategoria2`)
//     const q = await getDocs(subcategoriasRef)
//     const subcategorias = q.docs.map((doc) => {
//         return { ...doc.data(), id: doc.id }
//     })
//     //setSubcategoria(categorias)
//     data.push(subcategorias)

// }

    const categoriasAdd = async () => {
        await setDoc(doc(db, "Categorias", "idCat11"), {
            name: "Los Angeles",
            icon: "https://www2.fleetpride.com/imagesns/cms/category/Engine_Engine.svg"
          });
          
    }


    console.log()

    const [categoriasAll, setcategoriasAll] = useState<any[]>([])
    useEffect(() => {

    
        // getCategorias()
        // getSubCategorias()
        // categoriasAdd()


        const getData = async () => {
            const data = await fetchData();
            setcategoriasAll(data)
        };
        getData();
        
       

    }, [])


    console.log(categoriasAll)

    





    return (
        <React.Fragment>
            <h2 className={'content-block'}>Categorias</h2>
            <div className="categorialist">
            <TreeList
                id='id'
                dataSource={categoriasAll[0]}
                columnAutoWidth={true}
                wordWrapEnabled={true}
                showBorders={true}
                keyExpr={'id'}
                itemsExpr={categoriasAll[1]}
                dataStructure='tree'
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