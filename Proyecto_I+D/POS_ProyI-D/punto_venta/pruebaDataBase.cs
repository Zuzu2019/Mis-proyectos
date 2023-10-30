using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_venta
{
    public partial class pruebaDataBase : Form
    {
        public pruebaDataBase()
        {
            InitializeComponent();
        }

        private void btnConectDataBase_Click(object sender, EventArgs e)
        {
            Producto produc = new Producto("Nescafe Clásico","Alimentos","62.50","60","Nescafé clásico de 200g");
            Inventario Inventa = new Inventario();
            SQLiteDataReader datos = Inventa.getProducts();
            int cont = 0;
            while ( datos.Read() ){

                MessageBox.Show(cont.ToString());
                cont++;
            }
            Inventa.finish();
        }

        private void pruebaDataBase_Load(object sender, EventArgs e)
        {

        }
    }
}
