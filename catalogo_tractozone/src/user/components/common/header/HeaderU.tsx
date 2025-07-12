import { useState } from 'react'
import './HeaderU.scss'
function HeaderU() {

    const [search, setSearch] = useState('')
    console.log(search)
    return (
        <>
        <div className="heade">
        <center>
             <header className="py-4">
                <div className="row head container align-items-center">
                    <div className="col-12 col-sm-12 col-md-12 col-lg-4">
                        <a href="/" className="d-flex align-items-center mb-3 mb-lg-0 me-lg-auto link-body-emphasis text-decoration-none">
                            <img src='https://tractozone.com.mx/wp-content/uploads/2021/04/cropped-logo-trzone-white.png' width="200"></img>
                        </a>
                    </div>
                    <div className="menu-align col-12 col-sm-12 col-md-12 col-lg-6">
                        <nav className="py-1 nav">
                            <div className="container d-flex flex-wrap ">
                                <ul className="list menu nav me-auto ">
                                    <li className="nav-item"><a href="#" className="list nav-link  px-2 active" aria-current="page">Inicio</a></li>
                                    <li className="nav-item"><a href="#" className="list nav-link  px-2">Catalogo</a></li>
                                    <li className="nav-item"><a href="#" className="list nav-link  px-2">Recursos</a></li>
                                    <li className="nav-item"><a href="#" className="list nav-link  px-2">Sucursales</a></li>
                                </ul>
                                {/* <ul className="nav">
                                <li className="nav-item"><a href="#" className="nav-link link-body-emphasis px-2">Login</a></li>
                                <li className="nav-item"><a href="#" className="nav-link link-body-emphasis px-2">Sign up</a></li>
                            </ul> */}
                            </div>
                        </nav>
                        <form className="search col-lg-auto mb-lg-0" role="search">
                            <input type="search" className="form-control" placeholder="Buscar" aria-label="Search" onChange={(e) => setSearch(e.target.value)}/>
                        </form>
                    </div>
                </div>
            </header>
        </center>
        </div>
       
           
        </>
    )

}

export default HeaderU