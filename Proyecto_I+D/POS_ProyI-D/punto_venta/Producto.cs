using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_venta
{
    public class Producto
    {
        public string id;
        public string nom;
        public string categoria;
        public string precio;
        public string cantidad;
        public string descripcion;
        private int eliminado;
        public int agotado;

        public Producto(string nom, string cat, string precio, string cant, string desc) {
            this.nom = nom;
            this.categoria = cat;
            this.precio = precio;
            this.cantidad = cant;
            this.descripcion = desc;
        }
        public Producto(string id, string nom, string cat, string precio, string cant, string desc, int agotado)
        {
            this.id = id;
            this.nom = nom;
            this.categoria = cat;
            this.precio = precio;
            this.cantidad = cant;
            this.descripcion = desc;
            this.agotado = agotado;
        }


    }
}
