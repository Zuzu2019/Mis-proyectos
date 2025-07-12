
import "./Carrusel.scss"
const Carrusel = () => {
    return (
        <>
            <div id="carouselExampleDark" className="carousel carousel-dark w-100 mx-auto slide" data-bs-ride="carousel">
                <div className="indicar">
                    <div className="indicar carousel-indicators">
                        <button type="button" data-bs-target="#carouselExampleDark" data-bs-slide-to="0" className=".btnIndicators  active" aria-current="true" aria-label="Slide 1"></button>
                        <button type="button" data-bs-target="#carouselExampleDark" data-bs-slide-to="1" aria-label="Slide 2" className=".btnIndicators "></button>
                        <button type="button" data-bs-target="#carouselExampleDark" data-bs-slide-to="2" aria-label="Slide 3" className=".btnIndicators "></button>
                    </div>
                </div>
                <div className="carrusel carousel-inner">
                    <div className="carousel-item active" data-bs-interval="4000">
                        <img src="https://tractozone.com.mx/catalogo/assets/images/slide/khd-actcat.jpg" className="d-block w-100" alt="..."/>
                    </div>
                    <div className="carousel-item" data-bs-interval="3000">
                        <img src="https://tractozone.com.mx/catalogo/assets/images/slide/pwr-pro-actcat.jpg" className="d-block w-100" alt="..." />
                    </div>
                    <div className="carousel-item" data-bs-interval="3000">
                        <img src="https://tractozone.com.mx/catalogo/assets/images/slide/khd-actcat.jpg" className="d-block w-100" alt="..." />
                    </div>
                </div>     
            </div>
        </>
    )
}

export default Carrusel