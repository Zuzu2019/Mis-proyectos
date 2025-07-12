import { Link, useParams } from "react-router-dom";
import "./Card_categorias.scss"
interface Card {
    id: string
    nombre: string
    imagen: string
}
function Cards2({imagen, nombre, id}: Card) {
    const params = useParams()
    return(
        <div className="card-subcategoria" key={id}>
            <div className="imagen-card">
                <img  src={imagen} alt="" />
            </div>
            <div className="title">
                 <Link to={`/categorias/${params.id}/subcategoria/${params.idcat}/sub-subcategoria/${id}`} className="nombre-card">{nombre}</Link> 
            </div>
        </div>
    )
}

export default Cards2