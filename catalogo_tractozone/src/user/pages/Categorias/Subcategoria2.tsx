
import { useParams } from "react-router-dom"
import ProductResumen from "../../components/component_categorias/Product_resumen"
import { useEffect, useState } from "react"
import { Paginacion } from "../../components/component_categorias/Paginacion"
import { collection, getDocs, query, where, doc, orderBy} from "firebase/firestore";
import { db } from "../../firebase/database";


const Sub_Subcategoria = () => {



    const params = useParams()

    //const API_CAT = process.env.REACT_APP_CATEGORIAS 
    const [product, setProducts] = useState<any[]>([]);
    const [pagina, setPagina] = useState(1);
    const [porpagina, setPorPagina] = useState(5);
    const [marca, setMarca] = useState<any[]>([]);
    const [total_por_marca, setTotalPorMarca] = useState([]);
    const [isCheck, setIsCheck] = useState(false);
    const [search, setSearch] = useState('');


    useEffect(() => {
        getProductsBySubcategoria();
        getMarca()
   

    }, [])

    const ref = doc(db, `Categorias/${params.id}/subcategoria1/${params.idcat}/subcategoria2/${params.idcate}`)     
    const productos = query(collection(db, `Productos`), where("sub-subcategoriaId", "==", ref))


    //Productos
    const getProductsBySubcategoria = async() => {
        try {
            const q = await getDocs(productos)
            const getproducts = q.docs.map((doc) => {
               return { ...doc.data(), id: doc.id }
           })
            setProducts(getproducts) 

        } catch (e){
            console.log("error", e)

        }
               
    }

    //OBTENER MARCAS DE PRODUCTOS SIN REPETIR EXISTENTES Y CONTAR EL NUMERO DE PRODUCTOS QUE HAY POR CADA MARCA
    const getMarca = async () => {              
        const m = query(productos, orderBy("marca"))
        const conteo : any = {key : "value"};      
        try {
            const getdatos = await getDocs(m);
            const brand_all = getdatos.docs.map(doc => doc.data().marca)
            const res = brand_all.filter((value, index, self) => index === self.findIndex((v) => v === value))
            setMarca( res )
            brand_all.forEach((arr) => {
                if (conteo[arr]) {
                conteo[arr]++;
                } else {
                conteo[arr] = 1;
                }
            });
        }
        catch (e) {
            console.log("error", e);
        }          
        setTotalPorMarca(conteo)  
    }

     //OBTENER PRODUCTOS DE ACUERDO AL CHECK SELECCIONADO
     const getProductsPorMarca = async (check: boolean, select_marca: string) => {       
        try {
            if (check) {  
                const q = query(collection(db, `Productos`), where("marca", "==", select_marca))
                const g = await getDocs(q)
                const nuevosProductos = g.docs.map(doc => doc.data())
                setProducts(nuevosProductos);
            }
            else {
                console.log("el check no esta presionado")   
                const g = await getDocs(productos)
                const p = g.docs.map(doc => doc.data()) 
                setProducts(p)
            }

        }catch (e) {
            console.log("error", e)

        }
       
    }

    const handleCheckboxChange = (event: React.ChangeEvent<HTMLInputElement>, s: string) => {
        setIsCheck(event.target.checked);
        getProductsPorMarca(event.target.checked, s); // Asegúrate de que esta línea esté dentro del ámbito correcto
    };



    const maximo = product.length / porpagina

    return (
        <>
            <div className="container">
                <div className="row">
                    <div className="col-4 col-sm-4 col-md-4 col-lg-3 filtros">
                        <p>Filtros</p>
                        <form className="search-filter col-lg-auto mb-lg-0" role="search">
                            <input type="search" className="form-control" placeholder="Buscar" aria-label="Search" onChange={(e) => setSearch(e.target.value)}/>
                        </form>
                        {  
                            marca.filter((id) => {
                                return search.toLowerCase() === ""
                                ? id : id.toLowerCase().includes(search)
                            }).map((id) => ( 
                                <div key={id}>                        
                                    <div className="row">
                                        <div className="col-9 col-sm-8 col-md-8 col-lg-9 d-flex">
                                            <p className="nombre">{id}</p>
                                            <p className="cantidad">({total_por_marca[id]})</p>
                                        </div>
                                        <div className="col-3 col-sm-4 col-md-4 col-lg-3 input-filter">
                                            <input className="form-check-input" type="checkbox" id="flexCheckDefault" onChange={(e) => handleCheckboxChange(e, id)} />
                                        </div>
                                    </div>
                                </div>
                            ))       
                       }     
                    </div>

                    <div className="col-12 col-sm-6 col-md-8 col-lg-8 py-4">         
                        <p className="py-3">Lista de productos</p>
                        <p className="py-2">Resultados</p>
                           <div className="">     
                            {
                                product.map(({ id, nombre, marca, parte, imagen }) => (
                                    <div key={id}>
                                        <ProductResumen
                                            imagen={imagen}
                                            nombre={nombre}
                                            marca={marca}
                                            parte={parte}
                                            id={id}
                                        />
                                    </div>

                                ))
                                    .slice((pagina - 1) * porpagina, (pagina - 1) * porpagina + porpagina)

                            }          
                           </div>
                           <Paginacion
                                pagina={pagina}
                                setPagina={setPagina}
                                maximo={maximo} />
                    </div>
                </div>
            </div>

        </>
    )
}

export default Sub_Subcategoria