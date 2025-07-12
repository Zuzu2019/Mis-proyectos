import path from "path";

export const navigation = [

  {
    text: 'Home',
    path: '/home',
    icon: 'home'
  },
  {
    text: 'Catalogo',
    icon: 'folder',
    items: [
      {
        text: 'Categorias',
        path: '/categoriasadmin'
      },
      {
        text: 'Productos',
        path: '/productosadmin'
      }
    ]
  }
  ];
