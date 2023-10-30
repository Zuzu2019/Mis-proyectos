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
    public partial class pag_datos : Form
    {
        user usr;
        public pag_datos(user ussr)
        {
            InitializeComponent();
            usr = ussr;
        }

        private void pag_datos_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            upd_datos(comboBox1.SelectedIndex);
            if (usr.genero == "Femenino")
                label5.Text = "¡Bienvenida " + usr.nombre + "!";
            else
                label5.Text = "¡Bienvenido " + usr.nombre + "!";
            if (usr.nivel != 1)
            {
                button4.Enabled = false;
                button2.Enabled = false;
            }
        }
        private void upd_datos(int modo)
        {
            SQLiteConnection conn;
            conn = new SQLiteConnection("Data Source=punto_venta.db");

            conn.Open();
            string query1;
            string query2;
            chart1.Series.Clear();
            chart2.Series.Clear();
            chart1.Series.Add("Ventas");
            chart2.Series.Add("Productos vendidos");
            chart1.ChartAreas[0].AxisY.Title = "Ganancia";
            chart1.ChartAreas[0].AxisY.Title = "Productos vendidos";

            string query_gan_hoy = "SELECT sum(total) as total from recibo WHERE DATE(fecha) = DATE('now', 'localtime')";
            string query_ven_hoy = "SELECT sum(numero_articulo) as total from recibo WHERE DATE(fecha) = DATE('now', 'localtime')";

            SQLiteCommand cmd_hoy_gan = new SQLiteCommand(query_gan_hoy, conn);
            SQLiteDataReader rdr_gan_hoy = cmd_hoy_gan.ExecuteReader();
            while (rdr_gan_hoy.Read())
            {
                var id = rdr_gan_hoy.GetDouble(0);
                label3.Text = id.ToString();
            }
            SQLiteCommand cmd_hoy_ven = new SQLiteCommand(query_ven_hoy, conn);
            SQLiteDataReader rdr_gan_ven = cmd_hoy_ven.ExecuteReader();
            while (rdr_gan_ven.Read())
            {
                var id = rdr_gan_ven.GetInt32(0);
                label2.Text = id.ToString();
            }

            string prod_dia = "select p.nombre, count(v.id_producto) as ventas from venta_productos v inner join recibo r on v.id = r.id inner JOIN producto p on p.id=v.id_producto WHERE DATE(r.fecha) = DATE('now', 'localtime') GROUP BY v.id_producto ORDER BY count(v.id_producto) DESC LIMIT 1"; //regresa el producto con mas ventas de hoy
            SQLiteCommand cmd_proddia = new SQLiteCommand(prod_dia, conn);
            SQLiteDataReader rdr_proddia = cmd_proddia.ExecuteReader();
            while (rdr_proddia.Read())
            {
                var nombre = rdr_proddia.GetString(0);
                var num = rdr_proddia.GetDouble(1);
                label11.Text = nombre + "!!";
                label9.Text = "Con "+num.ToString()+" compras la ultima semana";
            }
            switch (modo)
            {
                case 0://ultima semana
                    query1 = "select strftime('%w', fecha) as dia, sum(total) as ganancia from recibo WHERE DATE(fecha) >= DATE('now', 'weekday 0', '-7 days') GROUP BY strftime('%w', fecha)"; //devuelve ganancias de la ultima semana por dia
                    query2 = "select strftime('%w', fecha) as dia, sum(numero_articulo) as art_vendidos from recibo WHERE DATE(fecha) >= DATE('now', 'weekday 0', '-7 days') GROUP BY strftime('%w', fecha)"; //devuelve numero de articulos vendidos por dia


                    chart1.Series[0].Points.AddXY("Dom", 0);
                    chart1.Series[0].Points.AddXY("Lun", 0);
                    chart1.Series[0].Points.AddXY("Mar", 0);
                    chart1.Series[0].Points.AddXY("Mie", 0);
                    chart1.Series[0].Points.AddXY("Jue", 0);
                    chart1.Series[0].Points.AddXY("Vie", 0);
                    chart1.Series[0].Points.AddXY("Sab", 0);

                    chart1.ChartAreas[0].AxisX.Title = "Dia de la semana";

                    chart2.Series[0].Points.AddXY("Dom", 0);
                    chart2.Series[0].Points.AddXY("Lun", 0);
                    chart2.Series[0].Points.AddXY("Mar", 0);
                    chart2.Series[0].Points.AddXY("Mie", 0);
                    chart2.Series[0].Points.AddXY("Jue", 0);
                    chart2.Series[0].Points.AddXY("Vie", 0);
                    chart2.Series[0].Points.AddXY("Sab", 0);

                    chart2.ChartAreas[0].AxisX.Title = "Dia de la semana";

                    SQLiteCommand cmd1 = new SQLiteCommand(query1, conn);

                    SQLiteDataReader rdr1 = cmd1.ExecuteReader();
                    while (rdr1.Read())
                    {
                        var id = rdr1.GetString(0);
                        var valor = rdr1.GetDouble(1);
                        //chart1.Series[0].Points.Insert(Convert.ToInt32(id), rdr1.GetDouble(1));
                        chart1.Series[0].Points[Convert.ToInt32(id)].YValues[0] = valor;
                        //MessageBox.Show(id +" y "+ valor.ToString());
                    }

                    SQLiteCommand cmd2 = new SQLiteCommand(query2, conn);
                    SQLiteDataReader rdr2 = cmd2.ExecuteReader();
                    while (rdr2.Read())
                    {
                        var id = rdr2.GetString(0);
                        var valor = rdr2.GetDouble(1);
                        chart2.Series[0].Points[Convert.ToInt32(id)].YValues[0] = valor;
                    }
                    break;
                case 1: //ultimo mes
                    query1 = "select strftime('%W', fecha) as semana, sum(total) as ganancia from recibo WHERE DATE(fecha) >= DATE('now', 'start of month') GROUP BY strftime('%W', fecha)"; //devuelve ganancias desde el primer dia del presente mes por semana del año
                    query2 = "select strftime('%W', fecha) as semana, sum(numero_articulo) as art_vendidos from recibo WHERE DATE(fecha) >= DATE('now', 'start of month') GROUP BY strftime('%W', fecha)"; //devuelve articulos vendidos desde el primer dia del presente mes por numero de semana del año

                    chart1.ChartAreas[0].AxisX.Title = "Semana del año";
                    chart2.ChartAreas[0].AxisX.Title = "Semana del año";


                    SQLiteCommand cmd3 = new SQLiteCommand(query1, conn);

                    SQLiteDataReader rdr3 = cmd3.ExecuteReader();
                    while (rdr3.Read())
                    {
                        chart1.Series[0].Points.AddXY(rdr3.GetString(0), rdr3.GetDouble(1));
                    }

                    SQLiteCommand cmd4 = new SQLiteCommand(query2, conn);
                    SQLiteDataReader rdr4 = cmd4.ExecuteReader();
                    while (rdr4.Read())
                    {
                        chart2.Series[0].Points.AddXY(rdr4.GetString(0), rdr4.GetDouble(1));
                    }
                    break;
                case 2: //ultimo año
                    query1 = "select strftime('%m', fecha) as mes, sum(total) as ganancia from recibo WHERE DATE(fecha) >= DATE('now', 'start of year') GROUP BY strftime('%m', fecha)"; //devuelve ganancias desde el inicio del año por mes
                    query2 = "select strftime('%m', fecha) as mes, sum(numero_articulo) as art_vendidos from recibo WHERE DATE(fecha) >= DATE('now', 'start of year') GROUP BY strftime('%m', fecha)"; //devuelve articulos vendidos desde el inicio del año por numero de mes

                    chart1.Series[0].Points.AddXY("Ene", 0);
                    chart1.Series[0].Points.AddXY("Feb", 0);
                    chart1.Series[0].Points.AddXY("Mar", 0);
                    chart1.Series[0].Points.AddXY("Abr", 0);
                    chart1.Series[0].Points.AddXY("May", 0);
                    chart1.Series[0].Points.AddXY("Jun", 0);
                    chart1.Series[0].Points.AddXY("Jul", 0);
                    chart1.Series[0].Points.AddXY("Ago", 0);
                    chart1.Series[0].Points.AddXY("Sep", 0);
                    chart1.Series[0].Points.AddXY("Oct", 0);
                    chart1.Series[0].Points.AddXY("Nov", 0);
                    chart1.Series[0].Points.AddXY("Dic", 0);

                    chart2.Series[0].Points.AddXY("Ene", 0);
                    chart2.Series[0].Points.AddXY("Feb", 0);
                    chart2.Series[0].Points.AddXY("Mar", 0);
                    chart2.Series[0].Points.AddXY("Abr", 0);
                    chart2.Series[0].Points.AddXY("May", 0);
                    chart2.Series[0].Points.AddXY("Jun", 0);
                    chart2.Series[0].Points.AddXY("Jul", 0);
                    chart2.Series[0].Points.AddXY("Ago", 0);
                    chart2.Series[0].Points.AddXY("Sep", 0);
                    chart2.Series[0].Points.AddXY("Oct", 0);
                    chart2.Series[0].Points.AddXY("Nov", 0);
                    chart2.Series[0].Points.AddXY("Dic", 0);

                    chart1.ChartAreas[0].AxisX.Title = "Mes del año";
                    chart2.ChartAreas[0].AxisX.Title = "Mes del año";

                    SQLiteCommand cmd5 = new SQLiteCommand(query1, conn);

                    SQLiteDataReader rdr5 = cmd5.ExecuteReader();
                    while (rdr5.Read())
                    {
                        var id = rdr5.GetString(0);
                        var valor = rdr5.GetDouble(1);
                        chart1.Series[0].Points[Convert.ToInt32(id) - 1].YValues[0] = valor;
                    }

                    SQLiteCommand cmd6 = new SQLiteCommand(query2, conn);
                    SQLiteDataReader rdr6 = cmd6.ExecuteReader();
                    while (rdr6.Read())
                    {
                        var id = rdr6.GetString(0);
                        var valor = rdr6.GetDouble(1);
                        chart2.Series[0].Points[Convert.ToInt32(id) - 1].YValues[0] = valor;
                    }
                    break;
                case 3: //desde el comienzo de los tiempos
                    query1 = "select strftime('%Y', fecha) as year, sum(total) as ganancia from recibo GROUP BY strftime('%Y', fecha)"; //devuelve las ganancias de todos los tiempos ordenadas por año
                    query2 = "select strftime('%Y', fecha) as year, sum(numero_articulo) as art_vendidos from recibo GROUP BY strftime('%Y', fecha)"; //devuelve los articulos vendidos desde siempre ordenados por año
                    SQLiteCommand cmd7 = new SQLiteCommand(query1, conn);
                    chart1.ChartAreas[0].AxisX.Title = "Año";
                    chart2.ChartAreas[0].AxisX.Title = "Año";
                    SQLiteDataReader rdr7 = cmd7.ExecuteReader();
                    while (rdr7.Read())
                    {
                        chart1.Series[0].Points.AddXY(rdr7.GetString(0), rdr7.GetDouble(1));
                    }

                    SQLiteCommand cmd8 = new SQLiteCommand(query2, conn);
                    SQLiteDataReader rdr8 = cmd8.ExecuteReader();
                    while (rdr8.Read())
                    {
                        chart2.Series[0].Points.AddXY(rdr8.GetString(0), rdr8.GetDouble(1));
                    }
                    break;

                default:
                    MessageBox.Show("no ;)");
                    conn.Close();
                    Application.Exit();
                    break;
            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            upd_datos(comboBox1.SelectedIndex);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            upd_datos(comboBox1.SelectedIndex);
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            inventarioAdmin inv = new inventarioAdmin(usr);
            inv.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pag_empleados emp = new pag_empleados(usr);
            emp.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 vnta = new Form4(usr);
            vnta.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
