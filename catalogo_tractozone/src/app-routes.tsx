import { HomePage, CategoriasList, ProductosList } from './pages';
import { withNavigationWatcher } from './contexts/navigation';
import ProductosLista from './pages/productosadmin/ProductsList';



const routes = [
    {
        path: '/productosadmin',
        element: ProductosLista
    },
    {
        path: '/categoriasadmin',
        element: CategoriasList
    },
    {
        path: '/home',
        element: HomePage
    }
];

export default routes.map(route => {
    return {
        ...route,
        element: withNavigationWatcher(route.element, route.path)
    };
});
