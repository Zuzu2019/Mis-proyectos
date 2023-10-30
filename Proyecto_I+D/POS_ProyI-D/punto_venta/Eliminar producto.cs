using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace punto_venta
{
    public partial class Eliminar_producto : Form
    {
        private int product_id;
        public Eliminar_producto(int id)
        {
            InitializeComponent();
            product_id = id;
        }

        private void bttSi_Click(object sender, EventArgs e)
        {
            Inventario myInventario = new Inventario();
            myInventario.deleteProduct(product_id);
            myInventario.finish();
            Hide();
        }

        private void bttNo_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
