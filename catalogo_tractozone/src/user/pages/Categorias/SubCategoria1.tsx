
import { useParams } from "react-router-dom"
import ProductResumen from "../../components/component_categorias/Product_resumen"
import "./Categorias.scss"
import { useEffect, useState } from "react"
import { Paginacion } from "../../components/component_categorias/Paginacion"
import { collection, getDocs, query, where, doc, orderBy} from "firebase/firestore";
import { db } from "../../firebase/database";
import Cards2 from "../../components/component_categorias/Card_subcategorias"



const Subcategoria = () => {

    const params = useParams()
    //const API_CAT = process.env.REACT_APP_CATEGORIAS 

    const [subcategoria, setSubcategoria] = useState<any[]>([]);
    const [pagina, setPagina] = useState(1)
    const [porpagina, setPorPagina] = useState(5)
    const [product, setProducts] = useState<any[]>([]);
    const [marca, setMarca] = useState<any[]>([]);
    const [total_por_marca, setTotalPorMarca] = useState([]);
    const [search, setSearch] = useState('')
    const [isCheck, setIsCheck] = useState(false)

    useEffect(() => {
        getMarca()
        getProductosAll() 
        getCategorias()
    }, [])

    //OBTENER PRODUCTOS DE LA BASE DE DATOS
    const ref = doc(db, `Categorias/${params.id}/subcategoria1/${params.idcat}`)     
    const getproduct = query(collection(db, `Productos`), where("subcategoriaId", "==", ref)) 


    //CATEGORIAS
    const getCategorias = async () =>{
        const subcategoriasRef = collection(db, `Categorias/${params.id}/subcategoria1/${params.idcat}/subcategoria2`)
        const q = await getDocs(subcategoriasRef)
        const categorias = q.docs.map((doc) => {
            return { ...doc.data(), id: doc.id }
        })
        setSubcategoria(categorias)
    }

    //Productos
    const getProductosAll = async () => {
         const q = await getDocs(getproduct)
         const productos = q.docs.map((doc) => {
            return { ...doc.data(), id: doc.id }
        })
         setProducts(productos)
    } 
   

    //OBTENER MARCAS DE PRODUCTOS SIN REPETIR EXISTENTES Y CONTAR EL NUMERO DE PRODUCTOS QUE HAY POR CADA MARCA
    const getMarca = async () => {              
        const m = query(getproduct, orderBy("marca"))
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
        if (check) {  
            const q = query(collection(db, `Productos`), where("marca", "==", select_marca))
            const g = await getDocs(q)
            const nuevosProductos = g.docs.map(doc => doc.data())
            setProducts(nuevosProductos);
        }
        else {
            console.log("el check no esta presionado")   
            const g = await getDocs(getproduct)
            const p = g.docs.map(doc => doc.data()) 
            setProducts(p)
        }
    }

    const handleCheckboxChange = (event: React.ChangeEvent<HTMLInputElement>, s: string) => {
        setIsCheck(event.target.checked);
        getProductsPorMarca(event.target.checked, s); // Asegúrate de que esta línea esté dentro del ámbito correcto
    };

    const maximo = getproduct.firestore.toJSON.length / porpagina

    console.log(subcategoria)

    return (
        <>
            <div className="container-xxl">
                <div className="row">
                    <div className="col-6 col-sm-3 col-md-3 col-lg-3 filtros">
                        <p>Filtros</p>
                        <form className="search-filter " role="search">
                            <input type="search" className="form-control" placeholder="Buscar" aria-label="Search" checked onChange={(e) => setSearch(e.target.value)}/>
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

                    <div className="col-12 col-sm-9 col-md-9 col-lg-9 py-4">
                       <p>Compre controles de calefacción y aire acondicionado</p>
                        <div className="cards">
                            <div className="d-flex cards justify-content-start py-2">
                                {
                                   
                                    subcategoria.map(({name, icon, id}) => (
                                        <div key={id}>
                                            <Cards2
                                                nombre={name}
                                                imagen={icon}
                                                id={id}
                                            />
                                        </div>
                                    ))
                                }
                            </div>
                        </div>          
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

export default Subcategoria