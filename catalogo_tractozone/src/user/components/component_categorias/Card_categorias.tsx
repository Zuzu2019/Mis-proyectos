import { Link, useParams } from "react-router-dom";
import "./Card_categorias.scss"
interface Card {
    id: string
    nombre: string
    imagen: string
}

function Cards({imagen, nombre, id}: Card) {
    const params = useParams()


    return(
        <div className="card-subcategoria">
            <div key={id} className="imagen-card">
                <img  src={imagen} alt="" />
            </div>
            <div className="title">
                 <Link to={`/categorias/${params.id}/subcategoria/${id}`} className="nombre-card">{nombre}</Link> 
            </div>
        </div>
    )
}

export default Cards