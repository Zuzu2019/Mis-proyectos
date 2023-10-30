using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_venta
{
    public class Inventario
    {
        private DataBase db;

        public Inventario()
        {
            db = new DataBase();
        }

        public bool addProduct(Producto producto)
        {
            bool result;

            string query = String.Format("INSERT INTO producto (nombre, categoria, precio, cantidad, descripcion) VALUES ('{0}', '{1}','{2}', '{3}', '{4}');"
                                        ,producto.nom, producto.categoria, producto.cantidad, producto.precio, producto.descripcion);
            if (db.executeQuery(query))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public bool updateProduct(Producto producto)
        {
            bool result;

            string query = String.Format("UPDATE producto SET nombre = '{1}', categoria = '{2}', precio = '{4}', cantidad = '{3}', descripcion = '{5}', agotado = '{6}' WHERE id ='{0}';"
                                        , producto.id, producto.nom, producto.categoria, producto.cantidad, producto.precio, producto.descripcion, producto.agotado);
            result = db.executeQuery(query) == true? true: false;
            return result;
        }
        public bool deleteProduct(int productid)
        {
            bool result;

            string query = String.Format("UPDATE producto SET eliminado = 1 WHERE id = {0};", productid);
            if (db.executeQuery(query))
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        public SQLiteDataReader getProducts()
        {
            string query = @"SELECT id, nombre, categoria, precio, cantidad, descripcion, agotado
                            FROM producto
                            WHERE eliminado=0;";
            SQLiteDataReader dr = db.getData(query);
            return dr;

        }
        public SQLiteDataReader getProducts(string busqueda)
        {
            string query = string.Format( @"SELECT id, nombre, categoria, precio, cantidad, descripcion, agotado
                            FROM producto
                            WHERE nombre LIKE '%{0}%' OR categoria LIKE '%{0}%' OR descripcion LIKE '%{0}%';"
                            , busqueda);
            SQLiteDataReader dr = db.getData(query);
            return dr;

        }
        public SQLiteDataReader getProductsAgotados(string busqueda)
        {
            string query = string.Format(@"SELECT id, nombre, categoria, precio, cantidad, descripcion, agotado
                            FROM producto
                            WHERE agotado = 1 AND (nombre LIKE '%{0}%' OR categoria LIKE '%{0}%' OR descripcion LIKE '%{0}%');"
                            , busqueda);
            SQLiteDataReader dr = db.getData(query);
            return dr;

        }
        public SQLiteDataReader getProductsNOAgotados(string busqueda)
        {
            string query = string.Format(@"SELECT id, nombre, categoria, precio, cantidad, descripcion, agotado
                            FROM producto
                            WHERE agotado = 0 AND (nombre LIKE '%{0}%' OR categoria LIKE '%{0}%' OR descripcion LIKE '%{0}%');"
                            , busqueda);
            SQLiteDataReader dr = db.getData(query);
            return dr;

        }
        public void finish()
        {
            db.closeDB();
            MessageBox.Show("Inventario finished");
        }
    }
}
