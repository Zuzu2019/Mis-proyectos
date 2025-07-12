import { Routes, Route, BrowserRouter, Outlet } from 'react-router-dom';
import Categoria from './user/pages/Categorias/Categorias';
import Subcategoria from './user/pages/Categorias/SubCategoria1';
import Sub_Subcategoria from './user/pages/Categorias/Subcategoria2';
import Productos from './user/pages/productos/Productos';
import HomePublic from './user/pages/Home/Home';
import HeaderU from './user/components/common/header/HeaderU';
import FooterU from './user/components/common/footer/FooterU';


const RutasPublicas: React.FC = ()  => {
  function ViewUser() {
    return (
      <>
        <HeaderU />
        <Outlet />
        <FooterU />
      </>
    );
  }
  return (
    <>
        <Routes>
          <Route path="/" element={<ViewUser />}>
            <Route index element={<HomePublic />} />
          </Route>
          <Route path="/categorias" element={<ViewUser />}>
            <Route index element={<Categoria />} />
            <Route path=':id' element={<Categoria />} />
            <Route path=':id/subcategoria/:idcat' element={<Subcategoria />} />
            <Route path=':id/subcategoria/:idcat/sub-subcategoria/:idcate' element={<Sub_Subcategoria />} />
          </Route>
          <Route path="/productos" element={<ViewUser />}>
            <Route index element={<Productos />} />
            <Route path=':id' element={<Productos />} />
          </Route>
          {/* <Route path='*' element={<Navigate to={'/'} />}></Route>   */}
        </Routes>    
    </>
  );
}

export default RutasPublicas

