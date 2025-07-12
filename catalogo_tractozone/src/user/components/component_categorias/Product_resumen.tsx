import { Link } from "react-router-dom";
import "./Product_resumen.scss"
interface Product_resumen {
    id: string;
    nombre: string;
    imagen: string;
    parte: string;
    marca: string;

}

function ProductResumen({id, imagen, nombre, parte, marca}: Product_resumen) {
    return(
        <>
        <div className="row product-resumen">
            <div className="col-4 col-sm-4 col-md-4 col-lg-3" >
               <center><img className="imagen-product w-50" src = {imagen} alt="" /></center> 
            </div>
            <div className="col-6 col-sm-6 col-md-6 col-lg-6 nombre">
               <Link className="card-text nombre-product" to={`/productos/${id}`}>{nombre}</Link>
               
               <div className="part-mar">
                <p className="parte">Parte: {parte}</p>
                <p className="marca">Marca: {marca}</p>
               </div>
            </div> 
            <hr />
        </div>
        
        </>
    )
}
export default ProductResumen