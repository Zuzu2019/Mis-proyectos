
import "../../components/component_home/Circle.scss"
import { Link } from "react-router-dom";
interface Circle {
    id: string;
    nombre: string;
    imagen: string;
}

function Circles({imagen, nombre, id}: Circle) {
    return(
        <div className="circle">
            <div className="image">
                <img src = {imagen} alt="" />
            </div>
            <div className="title">
                <Link to={`/categorias/${id}`} className="nombre-cat">{nombre}</Link>
            </div>
        </div>

    )
}
export default Circles