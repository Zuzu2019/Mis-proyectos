import {doc, getDoc, collection, getDocs} from "firebase/firestore";
import { db } from "../../firebase/database";
import Product from "../../components/component_product/Product"
import { useEffect, useState } from "react";
import { useParams } from "react-router-dom";

const Productos = () => {
    const params = useParams()
    console.log(params)
    
    const [products, setProducto] = useState([]);
    const [especificacion, setEspecificacion] = useState([]);
    const [caracteristica, setCaracteristica] = useState([]);
    const [detalle, setDetalle] = useState([])
    const [referencia, setReferencia] = useState([])


    useEffect(() => {
        getProductos();
        getFicha(); 
    }, [])


    const getProductos = async () =>{   
        const docRef = doc(db, "Productos", params.id);
        try {
            const getdatos = await getDoc(docRef);
            setProducto(getdatos.data())
        }
        catch (error) {
            console.log(error.message);
        }
    }
    console.log(products)

    const getFicha = async () => {
        const getFicha = await collection(db, `Productos/${params.id}/ficha`)
        try {
            const datos = await getDocs(getFicha)
            const q =  datos.docs.map(doc => doc.data([0]))
            setEspecificacion (q[0].especificaciones)
            setDetalle (q[0].detalles)
            setCaracteristica (q[0].caracteristicas)
            setReferencia (q[0].referencias)
            
        } catch (error) {
            console.log(error.message);
        }
    }
    return (
    <Product 
    imagen = {products.imagen} 
    nombre = {products.nombre}
    parte = {products.parte}
    marca = {products.marca}
    specifications= {[especificacion[0], especificacion[1], especificacion[2], especificacion[3]]}
    product_details = {detalle}
    features = {[caracteristica[0], caracteristica[1], caracteristica[2]]}
    cross_reference = {[referencia[0], referencia[1], referencia[2], referencia[3] ]}
    />
    )

}

export default Productos