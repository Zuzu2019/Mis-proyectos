using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace punto_venta
{
    public partial class Form4 : Form
    {
        private Inventario myInventario;
        user usr;
        public Form4(user usre)
        {
            InitializeComponent();
            myInventario = new Inventario();
            usr = usre;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            actualizarTablaProductos(myInventario);
            if (usr.genero == "Femenino")
                label1.Text = "¡Bienvenida " + usr.nombre + "!";
            else
                label1.Text = "¡Bienvenido " + usr.nombre + "!";
            if (usr.nivel != 1)
            {
                button4.Enabled = false;
                button1.Enabled = false;
            }
        }
        private void actualizarTablaProductos(Inventario inventario)
        {
            DateTime fechaActual = DateTime.Now;
            SQLiteDataReader datos = inventario.getProducts();
            int rowEscribir;
            dgv_productos.Rows.Clear();
            while (datos.Read())
            {
                rowEscribir = dgv_productos.Rows.Count;
                dgv_productos.Rows.Add();
                //id, nombre, categoria, precio, cantidad, descripcion, agotado
                dgv_productos.Rows[rowEscribir].Cells[0].Value = Convert.ToString(datos["id"]);
                dgv_productos.Rows[rowEscribir].Cells[1].Value = Convert.ToString(datos["nombre"]);
                dgv_productos.Rows[rowEscribir].Cells[2].Value = Convert.ToString(datos["precio"]);
                dgv_productos.Rows[rowEscribir].Cells[3].Value = Convert.ToString(datos["cantidad"]);
                dgv_productos.Rows[rowEscribir].Cells[4].Value = Convert.ToString(datos["descripcion"]);
                //dgv_productos.Rows[rowEscribir].Cells[5].Value = fechaActual;
            }
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            //inventarioAdmin.Show();
        }
        private void dgv_venta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgv_venta.Rows.Count; i++)
            {
                decimal nuevoprecio = Convert.ToDecimal(dgv_venta.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                decimal precio = Convert.ToDecimal(dgv_venta.Rows[i].Cells[2].Value);
                decimal total = precio * nuevoprecio;
                dgv_venta.Rows[i].Cells[5].Value = total;
            }

        }
        private void agregar_Click(object sender, EventArgs e)
        {
            int FilaSelected = dgv_productos.CurrentRow.Index;
            int cantidad_productos = int.Parse(dgv_productos.Rows[FilaSelected].Cells[3].Value.ToString());

            if (FilaSelected > -1)
            {
                DateTime fechaActual = DateTime.Now;
                //Verificamos si elproducto ya existe
                decimal suma = 0, total_venta, suma2 = 0;
                decimal precio, total;
                decimal precioTotal = 0;
                bool productoExiste = false;
                int rowEscribir = dgv_venta.Rows.Count, cantidadd;
                //int suma_precio;
                foreach (DataGridViewRow fila in dgv_venta.Rows)
                {
                    if (fila.Cells[0].Value.ToString() == dgv_productos.Rows[FilaSelected].Cells[0].Value.ToString())
                    {
                        // Si el ID se repite, aumentar la cantidad en 1
                        int cantidad = int.Parse(fila.Cells[3].Value.ToString());
                        fila.Cells[3].Value = (cantidad + 1).ToString();
                        //cantidad_productos = int.Parse(dgv_productos.Rows[FilaSelected].Cells[3].Value.ToString());
                        //dgv_productos.Rows[FilaSelected].Cells[3].Value = (cantidad_productos - 1).ToString();
                        
                        if (cantidad >= 1)
                        {
                            for (int i = 0; i < dgv_venta.Rows.Count; i++)
                            {
                                // Accede al valor de la segunda columna en la fila actual

                                //int nuevoprecio = Convert.ToInt32(dgv_venta.Rows[rowEscribir].Cells[FilaSelected].Value);


                                cantidadd = int.Parse(dgv_venta.Rows[i].Cells[3].Value.ToString());
                                precio = Convert.ToDecimal(dgv_venta.Rows[i].Cells[2].Value);
                                total = precio * cantidadd;
                                dgv_venta.Rows[i].Cells[5].Value = total;
                         
                         


                            }
                        }
                        foreach (DataGridViewRow row in dgv_venta.Rows)
                        {
                            if (row.Cells[5].Value != null)
                            {
                                decimal valor = Convert.ToDecimal(row.Cells[5].Value);
                                precioTotal += valor;
                                totallbl.Text = precioTotal.ToString();
                            }
                        }
                        // Muestra el resultado de la suma en el TextBox
                        //totallbl2.Text = precioTotal.ToString();
                        productoExiste = true;
                        break;
                    }
                }

                if (!productoExiste)
                {

                    dgv_venta.Rows.Add();
                    dgv_venta.Rows[rowEscribir].Cells[0].Value = dgv_productos.Rows[FilaSelected].Cells[0].Value.ToString();
                    dgv_venta.Rows[rowEscribir].Cells[1].Value = dgv_productos.Rows[FilaSelected].Cells[1].Value.ToString();
                    dgv_venta.Rows[rowEscribir].Cells[2].Value = dgv_productos.Rows[FilaSelected].Cells[2].Value.ToString();
                    dgv_venta.Rows[rowEscribir].Cells[3].Value = 1;
                    dgv_venta.Rows[rowEscribir].Cells[4].Value = dgv_productos.Rows[FilaSelected].Cells[4].Value.ToString();
                    dgv_venta.Rows[rowEscribir].Cells[5].Value = dgv_productos.Rows[FilaSelected].Cells[2].Value.ToString();
                    //dgv_venta.Rows[rowEscribir].Cells[6].Value = fechaActual;

                    for (int i = 0; i < dgv_venta.Rows.Count; i++)
                    {
                        
                        //cantidadd = int.Parse(dgv_venta.Rows[i].Cells[3].Value.ToString());
                        int cantidad = int.Parse(dgv_venta.Rows[i].Cells[3].Value.ToString());
                        //int cantidad_productos = int.Parse(dgv_productos.Rows[FilaSelected].Cells[3].Value.ToString());
                        if (cantidad == 1)
                        {

                            // cantidad_productos = int.Parse(dgv_productos.Rows[FilaSelected].Cells[3].Value.ToString());
                            //dgv_productos.Rows[FilaSelected].Cells[3].Value = (cantidad_productos - 1).ToString();

                            DataGridViewColumn columna = dgv_venta.Columns[5];

                            int suma3 = 0;

                            foreach (DataGridViewRow fila in dgv_venta.Rows)
                            {
                                int valorCelda = Convert.ToInt32(fila.Cells[columna.Index].Value);
                                suma3 += valorCelda;
                            }

                            totallbl.Text = suma3.ToString();
                        }

                        
                    }
                }
                

            }

          



        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            decimal resta = 0, total_venta, precioTotal = 0;
            decimal suma = 0, suma2 = 0;
            decimal precio, total;
            bool productoExiste = false;
            int rowEscribir = dgv_venta.Rows.Count, cantidadd;
            if (dgv_venta.SelectedRows.Count > 0)
            {
                int FilaSelected = dgv_venta.CurrentRow.Index;
                //dgv_venta.Rows.RemoveAt(FilaSelected);


                int cantidad = int.Parse(dgv_venta.Rows[FilaSelected].Cells[3].Value.ToString());

                if (cantidad > 1)
                {
                    // Restar uno a la cantidad si es mayor a uno
                    for (int i = 0; i < dgv_venta.Rows.Count; i++)
                    {
                        dgv_venta.Rows[FilaSelected].Cells[3].Value = (cantidad - 1).ToString();

                        //Actualiza el total
                        cantidadd = int.Parse(dgv_venta.Rows[i].Cells[3].Value.ToString());
                        precio = Convert.ToDecimal(dgv_venta.Rows[i].Cells[2].Value);
                        total = precio * cantidadd;
                        dgv_venta.Rows[i].Cells[5].Value = total;

                    }

                    foreach (DataGridViewRow row in dgv_venta.Rows)
                    {
                        if (row.Cells[5].Value != null)
                        {
                            decimal valor = Convert.ToDecimal(row.Cells[5].Value);
                            precioTotal += valor;
                            precioTotal = Math.Abs(precioTotal);
                            //totallbl2.Text = precioTotal.ToString();
                            totallbl.Text = precioTotal.ToString();

                        }


                    }



                }
                else
                {
                    
                    dgv_venta.Rows.RemoveAt(FilaSelected);
                    foreach (DataGridViewRow row in dgv_venta.Rows)
                    {
                        if (row.Cells[5].Value != null)
                        {
                            decimal valor = Convert.ToDecimal(row.Cells[5].Value);
                            precioTotal += valor;
                            precioTotal = Math.Abs(precioTotal);
                            //               totallbl3.Text = precioTotal.ToString();
                            totallbl.Text = precioTotal.ToString();
                        }

                    }
                }
               
            }

            if (dgv_venta.SelectedRows.Count == 0)
            {
                // totallbl2.Text = suma.ToString();
                totallbl.Text = suma.ToString();
            }
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(totallbl.Text);
            MessageBox.Show("El total de su compra es: " + total, "Compra exitosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            foreach (DataGridViewRow fila in dgv_venta.Rows.Cast<DataGridViewRow>().ToArray())
            {
                dgv_venta.Rows.Remove(fila);
            }
            totallbl.Text = "0";
        }

        private void agregar_Click_1(object sender, EventArgs e)
        {
            int FilaSelected = dgv_productos.CurrentRow.Index;
            int cantidad_productos = int.Parse(dgv_productos.Rows[FilaSelected].Cells[3].Value.ToString());

            if (FilaSelected > -1)
            {
                //DateTime fechaActual = DateTime.Now;
                //Verificamos si elproducto ya existe
                decimal suma = 0, total_venta, suma2 = 0;
                decimal precio, total;
                decimal precioTotal = 0;
                bool productoExiste = false;
                int rowEscribir = dgv_venta.Rows.Count, cantidadd;
                //int suma_precio;
                foreach (DataGridViewRow fila in dgv_venta.Rows)
                {
                    if (fila.Cells[0].Value.ToString() == dgv_productos.Rows[FilaSelected].Cells[0].Value.ToString())
                    {
                        // Si el ID se repite, aumentar la cantidad en 1
                        int cantidad = int.Parse(fila.Cells[3].Value.ToString());
                        fila.Cells[3].Value = (cantidad + 1).ToString();
                        
                        if (cantidad >= 1)
                        {
                            for (int i = 0; i < dgv_venta.Rows.Count; i++)
                            {
                                // Accede al valor de la segunda columna en la fila actual

                                //int nuevoprecio = Convert.ToInt32(dgv_venta.Rows[rowEscribir].Cells[FilaSelected].Value);


                                cantidadd = int.Parse(dgv_venta.Rows[i].Cells[3].Value.ToString());
                                precio = Convert.ToDecimal(dgv_venta.Rows[i].Cells[2].Value);
                                total = precio * cantidadd;
                                dgv_venta.Rows[i].Cells[5].Value = total;


                            }
                        }
                        foreach (DataGridViewRow row in dgv_venta.Rows)
                        {
                            if (row.Cells[5].Value != null)
                            {
                                decimal valor = Convert.ToDecimal(row.Cells[5].Value);
                                precioTotal += valor;
                                totallbl.Text = precioTotal.ToString();
                            }
                        }
                        // Muestra el resultado de la suma en el TextBox
                        //totallbl2.Text = precioTotal.ToString();
                        productoExiste = true;
                        break;
                    }
                }

                if (!productoExiste)
                {

                    dgv_venta.Rows.Add();
                    dgv_venta.Rows[rowEscribir].Cells[0].Value = dgv_productos.Rows[FilaSelected].Cells[0].Value.ToString();
                    dgv_venta.Rows[rowEscribir].Cells[1].Value = dgv_productos.Rows[FilaSelected].Cells[1].Value.ToString();
                    dgv_venta.Rows[rowEscribir].Cells[2].Value = dgv_productos.Rows[FilaSelected].Cells[2].Value.ToString();
                    dgv_venta.Rows[rowEscribir].Cells[3].Value = 1;
                    dgv_venta.Rows[rowEscribir].Cells[4].Value = dgv_productos.Rows[FilaSelected].Cells[4].Value.ToString();
                    dgv_venta.Rows[rowEscribir].Cells[5].Value = dgv_productos.Rows[FilaSelected].Cells[2].Value.ToString();
                    //dgv_venta.Rows[rowEscribir].Cells[6].Value = fechaActual;

                    for (int i = 0; i < dgv_venta.Rows.Count; i++)
                    {
                        //cantidadd = int.Parse(dgv_venta.Rows[i].Cells[3].Value.ToString());
                        int cantidad = int.Parse(dgv_venta.Rows[i].Cells[3].Value.ToString());
                        //int cantidad_productos = int.Parse(dgv_productos.Rows[FilaSelected].Cells[3].Value.ToString());
                        if (cantidad == 1)
                        {

                            DataGridViewColumn columna = dgv_venta.Columns[5];

                            double suma3 = 0;

                            foreach (DataGridViewRow fila in dgv_venta.Rows)
                            {
                                var cel = fila.Cells[columna.Index].Value;
                                double valorCelda = Convert.ToDouble(fila.Cells[columna.Index].Value);
                                suma3 += valorCelda;
                            }

                            totallbl.Text = suma3.ToString();
                        }

                    }
                }

            }

            

        }

        private void eliminar_Click_1(object sender, EventArgs e)
        {
            decimal resta = 0, total_venta, precioTotal = 0;
            decimal suma = 0, suma2 = 0;
            decimal precio, total;
            bool productoExiste = false;
            int rowEscribir = dgv_venta.Rows.Count, cantidadd;
            if (dgv_venta.SelectedRows.Count > 0)
            {
                int FilaSelected = dgv_venta.CurrentRow.Index;
                //dgv_venta.Rows.RemoveAt(FilaSelected);


                int cantidad = int.Parse(dgv_venta.Rows[FilaSelected].Cells[3].Value.ToString());

                if (cantidad > 1)
                {
                    // Restar uno a la cantidad si es mayor a uno
                    for (int i = 0; i < dgv_venta.Rows.Count; i++)
                    {
                        dgv_venta.Rows[FilaSelected].Cells[3].Value = (cantidad - 1).ToString();

                        //Actualiza el total
                        cantidadd = int.Parse(dgv_venta.Rows[i].Cells[3].Value.ToString());
                        precio = Convert.ToDecimal(dgv_venta.Rows[i].Cells[2].Value);
                        total = precio * cantidadd;
                        dgv_venta.Rows[i].Cells[5].Value = total;

                        
                    }

                    foreach (DataGridViewRow row in dgv_venta.Rows)
                    {
                        if (row.Cells[5].Value != null)
                        {
                            decimal valor = Convert.ToDecimal(row.Cells[5].Value);
                            precioTotal += valor;
                            precioTotal = Math.Abs(precioTotal);
                            //totallbl2.Text = precioTotal.ToString();
                            totallbl.Text = precioTotal.ToString();

                        }


                    }



                }
                else
                {
                   
                    dgv_venta.Rows.RemoveAt(FilaSelected);
                    foreach (DataGridViewRow row in dgv_venta.Rows)
                    {
                        if (row.Cells[5].Value != null)
                        {
                            decimal valor = Convert.ToDecimal(row.Cells[5].Value);
                            precioTotal += valor;
                            precioTotal = Math.Abs(precioTotal);
                            //               totallbl3.Text = precioTotal.ToString();
                            totallbl.Text = precioTotal.ToString();
                        }

                    }
                }
                
            }

            if (dgv_venta.SelectedRows.Count == 0)
            {
                // totallbl2.Text = suma.ToString();
                totallbl.Text = suma.ToString();
            }
        }

        private void confirmar_Click_1(object sender, EventArgs e)
        {
            
            double total = Convert.ToDouble(totallbl.Text); //total a pagar
            double suma3 = 0;
            //obttienen la suma total de la cantidad de productos
            foreach (DataGridViewRow fila in dgv_venta.Rows)
            {
                var cel = fila.Cells[3].Value;
                double valorCelda = Convert.ToDouble(fila.Cells[3].Value);
                suma3 += valorCelda;
            }




            crear_recibo(total, suma3);

            foreach (DataGridViewRow fila in dgv_venta.Rows)
            {
                var id = fila.Cells[0].Value;
                var cantidad = fila.Cells[3].Value;

                int id2 = Convert.ToInt32(fila.Cells[0].Value);
                int cantidad2 = Convert.ToInt32(fila.Cells[3].Value);

                añadir_venta(id2, cantidad2);
            }

           
            MessageBox.Show("El total de su compra es: " + total, "Compra exitosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            foreach (DataGridViewRow fila in dgv_venta.Rows.Cast<DataGridViewRow>().ToArray())
            {
                dgv_venta.Rows.Remove(fila);
            }
            totallbl.Text = "0";
        }



        public void crear_recibo(double total, double numero_articulo)
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=punto_venta.db");

            conn.Open();
            string query = "INSERT INTO recibo(total, numero_articulo, fecha) VALUES (@total, @numero_articulo, datetime('now', 'localtime'))";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.Add(new SQLiteParameter("@total", total));
            cmd.Parameters.Add(new SQLiteParameter("@numero_articulo", numero_articulo));

            cmd.CommandType = CommandType.Text;

            //devuelve la cantidad de filas afectadas ya sea insertada o actualizada
            cmd.ExecuteNonQuery();
           
        }
        public void añadir_venta(int idproducto, int cantidad)
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=punto_venta.db");

            conn.Open();
            string query = "INSERT INTO venta_productos(id_producto, cantidad, id_recibo) VALUES (@id_producto,@cantidad, (SELECT id from recibo order by id DESC LIMIT 1))";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.Parameters.Add(new SQLiteParameter("@id_producto", idproducto));
            cmd.Parameters.Add(new SQLiteParameter("@cantidad", cantidad));

            cmd.CommandType = System.Data.CommandType.Text;

            //devuelve la cantidad de filas afectadas ya sea insertada o actualizada
            cmd.ExecuteNonQuery();
           

        }

        private void btn_productos_Click_1(object sender, EventArgs e)
        {
            inventarioAdmin inv = new inventarioAdmin(usr);
            inv.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pag_empleados emp = new pag_empleados(usr);
            emp.Show();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pag_datos datos = new pag_datos(usr);
            datos.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }

   
    
}
