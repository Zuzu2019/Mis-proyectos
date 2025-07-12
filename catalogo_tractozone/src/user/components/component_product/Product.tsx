
import "./Product.scss"

type Especificacion = string[]
type Caracteristicas = string[]
interface Product {
    nombre: string;
    imagen: string;
    parte: string;
    marca: string;
    specifications: Especificacion,
    product_details: string,
    features: Caracteristicas,
    cross_reference: string
}

function Product({imagen, nombre, parte, marca, specifications, product_details, features, cross_reference }: Product) {
    return (
        <>

            <div className="modal fade" id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" aria-labelledby="staticBackdropLabel" aria-hidden="true">
                <div className="modal-dialog">
                    <div className="modal-content">
                        <div className="modal-header">
                            <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                        </div>
                        <div className="modal-body">
                            <img className="imagen-productos d-block w-100" src={imagen} alt="" />
                        </div>
                    </div>
                    
                </div>
            </div>
            <div className="container productos-unidad">
                <div className="img-text row justify-content-start ">
                    <div className="col-6 col-lg-8">
                        <div className="carrusel-product carousel slide carousel-dark" id="carouselDemo" data-bd-ride="carousel">
                            <div className="carousel-indicators">
                                <button className="active" type="button" data-bs-target="#carouselDemo" data-bs-slide-to="0" aria-current="true" aria-label="Slide 1"><img className="min-imagen" src={imagen} alt="" /> </button>
                                <button type="button" data-bs-target="#carouselDemo" data-bs-slide-to="1" aria-label="Slide 1"><img className="min-imagen" src={imagen} alt="" /></button>
                                <button type="button" data-bs-target="#carouselDemo" data-bs-slide-to="2" aria-label="Slide 1"><img className="min-imagen" src={imagen} alt="" /></button>
                            </div>
                            <div className="carousel-inner">
                                <div className="carousel-item active" >
                                    <img className="imagen-productos d-block w-100" data-bs-toggle="modal" data-bs-target="#staticBackdrop" src={imagen} alt="" />
                                </div>
                                <div className="carousel-item">
                                    <img className="imagen-productos d-block w-100" data-bs-toggle="modal" data-bs-target="#staticBackdrop"  src={imagen} alt="" />
                                </div>
                                <div className="carousel-item">
                                    <img className="imagen-productos d-block w-100" data-bs-toggle="modal" data-bs-target="#staticBackdrop"  src={imagen} alt="" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div className="col-6 col-lg-4 ord1">
                        <p className="nombre-p">{nombre}</p>
                        <p className="parte">Parte: {parte}</p>
                        <p className="marca">Marca: {marca}</p>
                    </div>
                </div>
                <div className="row">
                    <div className="col-12 col-md-12 col-sm-12 col-lg-8 ">
                        <div className="accordion" id="">
                            <div className="accordion-item">
                                <h2 className="accordion-header">
                                    <button className="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseOne" aria-expanded="true" aria-controls="collapseOne">
                                        Especificaciones
                                    </button>
                                </h2>
                                <div id="collapseOne" className="accordion-collapse collapse show" data-bs-parent="#accordionExample">
                                    <div className=" accordion-body">
                                        <div className="especific row">
                                            <div className="col">
                                                <p className="text1">{specifications[0]}</p>
                                                <p className="text2">{specifications[1]}</p>
                                            </div>
                                            <div className="col">
                                                <p className="text3">{specifications[2]}</p>
                                                <p className="text2">{specifications[3]}</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div className="accordion-item">
                                <h2 className="accordion-header">
                                    <button className="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseTwo" aria-expanded="true" aria-controls="collapseTwo">
                                        Detalles de producto
                                    </button>
                                </h2>
                                <div id="collapseTwo" className="accordion-collapse collapse" data-bs-parent="#accordionExample">
                                    <div className="accordion-body">
                                        <p className="detalles">{product_details}</p>
                                    </div>
                                </div>
                            </div>
                            <div className="accordion-item">
                                <h2 className="accordion-header">
                                    <button className="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseThree" aria-expanded="true" aria-controls="collapseOneThree">
                                        Caracteristicas
                                    </button>
                                </h2>
                                <div id="collapseThree" className="accordion-collapse collapse" data-bs-parent="#accordionExample">
                                    <div className="accordion-body">
                                        <p className="caracteristicas">{features[0]}</p>
                                        <p className="caracteristicas">{features[1]}</p>
                                        <p className="caracteristicas">{features[2]}</p>
                                    </div>
                                </div>
                            </div>
                            <div className="accordion-item">
                                <h2 className="accordion-header">
                                    <button className="accordion-button collapsed" type="button" data-bs-toggle="collapse" data-bs-target="#collapseFour" aria-expanded="true" aria-controls="collapseOneFour">
                                        Referencia cruzada
                                    </button>
                                </h2>
                                <div id="collapseFour" className="accordion-collapse collapse" data-bs-parent="#accordionExample">
                                    <div className="accordion-body">
                                        <p className="referencia">{cross_reference[0]}</p>
                                        <p className="referencia">{cross_reference[1]}</p>
                                        <p className="referencia">{cross_reference[2]}</p>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </>
    )
}
export default Product