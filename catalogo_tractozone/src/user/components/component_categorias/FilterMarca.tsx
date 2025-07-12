import { ChangeEvent, FormEvent, useState } from "react";
import "./FilterMarca.scss"
import { collection, query, where, getDocs } from "firebase/firestore";
import { db } from "../../firebase/database";
interface FilterMarca {
    marca: string;
    cantidad: number;

}


function FilterMarca({ marca, cantidad }: FilterMarca) {
    const [isCheck, setIsCheck] = useState(false)
    const [getproducts, setProducts] = useState<any[]>([])

    const getProductsPorMarca = async (check: boolean) => {
        if (check) {
            const q = query(collection(db, `Productos`), where("marca", "==", marca))
            const getproduct = await getDocs(q)
            const products = getproduct.docs.map(doc => doc.data())
            setProducts(products)

        } else {
            console.log("el check no esta presionado")
            setProducts([]);
        }
    }

    const handleCheckboxChange = (event: React.ChangeEvent<HTMLInputElement>) => {
        setIsCheck(event.target.checked);
        getProductsPorMarca(event.target.checked); // Asegúrate de que esta línea esté dentro del ámbito correcto
    };
      


    return (
        <>
            <div className="row">
                <div className="col-9 d-flex">
                    <p className="nombre">{marca}</p>
                    <p className="cantidad">({cantidad})</p>
                </div>
                <div>
                    {
                        getproducts.map(({ id, nombre }) => (
                            <div key={id}>
                                <p>{nombre}</p>
                            </div>
                        ))
                    }

                </div>

                <div className="col-3  input-filter">
                    <input className="form-check-input" type="checkbox" value={getproducts} id="flexCheckDefault" checked={isCheck} onChange={handleCheckboxChange} />
                </div>
            </div>
        </>

    )
}
export default FilterMarca