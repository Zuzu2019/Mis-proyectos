import { useState } from "react"

export const Paginacion = ({pagina, setPagina, maximo}) => {
    const [pagelink, setPagelink] = useState(1)

    const pageNumbers = []
    for ( let i = 1; i <= maximo; i++){
        pageNumbers.push(i);
    }

    const nextPage = () => {
        setPagelink (parseInt(pagelink) + 1);
        setPagina (parseInt(pagina) + 1);
    }
    const previosPage = () => {
        setPagelink (parseInt(pagelink) - 1);
        setPagina (parseInt(pagina) - 1);
    }

    const onSpecificPage = (n) => {
          setPagina(n)
    }
    return (
        <nav aria-label="Page navigation example">
            <ul className="pagination justify-content-end">
                <li className="page-item ">
                <a className="page-link"  href="#" onClick={previosPage}>Previous</a>
                </li>
                {
                    pageNumbers.map( noPage => (
                        <li className= {`"page-item" ${noPage === pagina ? "page-item active": ''}`} onClick={() => onSpecificPage(noPage)}>
                            <a className="page-link"  href="#">{noPage}</a>
                        </li>     
                    ))

                }
                
                
                <li className="page-item">
                <a className="page-link" href="#" onClick={nextPage}>Next</a>
                </li>
            </ul>
        </nav>
    )

}