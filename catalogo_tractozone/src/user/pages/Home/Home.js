import { useEffect, useState } from "react";
import Circles from "../../components/component_home/Circle";
import "./Home.scss"
import Carrusel from "./Carrusel";
import { collection, getDocs } from "firebase/firestore";
import { db } from "../../firebase/database";


//const API_CAT = process.env.REACT_APP_CATEGORIAS 


function HomePublic() {

    const [categorias, setCategorias] = useState([])
    // useEffect(() => {
    //     fetch(`${API_CAT}Categorias`)
    //     .then((resp) => resp.json())
    //     .then((data) => {
    //         setCategorias(data)
    //     })
    //     .catch(() => {
    //         console.log("la peticion fallo")
    //     })

    // }, [])

    useEffect(() => {
        const categoriasRef = collection(db, "Categorias")

        getDocs(categoriasRef)
            .then((datos) => {
                setCategorias(
                    datos.docs.map((doc) => {
                        return { ...doc.data(), id: doc.id }
                    })
                )
            })
            .catch(() => {
                console.log("la peticion fallo")
            })

    }, [])

    if (!categorias) return <span className="loading">Cargando...</span>

    return (
        <>
            <div className="container column-flex">
                <div className="row justify-content-center">
                    <div className="col-12 col-lg-10">
                    <Carrusel />
                    </div>
                </div>
                <div className="row justify-content-center">
                    <h2>Categorias</h2>
                    <div className="col-9 col-sm-9 col-md-10 col-lg-12 d-flex flex-wrap">
                    {
                        categorias.map(({ id, name, icon }) => (
                            <div className="" key={id}>
                                <Circles
                                    nombre={name}
                                    imagen={icon}
                                    id={id}
                                />
                            </div>
                        ))
                    }
                    </div>
                </div>
            </div>
        </>

    )
}

export default HomePublic