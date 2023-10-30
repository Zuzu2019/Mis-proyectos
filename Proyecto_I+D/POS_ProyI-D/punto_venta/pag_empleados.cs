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
    public partial class pag_empleados : Form
    {
        //publicDataUser user_actual;
        SQLiteConnection conn;
        //int idusr = 0;
        user usr;
        public pag_empleados(user nwser)
        {
            InitializeComponent();
            //user_actual = new publicDataUser();
            //idusr = iduser;
            conn = new SQLiteConnection("Data Source=punto_venta.db");
            usr = nwser;
        }

        private void pag_empleados_Load(object sender, EventArgs e)
        {
            //user_actual = getusrdata(idusr);
            llenarTablaEmpleados();
            if (usr.genero == "Femenino")
                label2.Text = "¡Bienvenida " + usr.nombre + "!";
            else
                label2.Text = "¡Bienvenido " + usr.nombre + "!";
        }
        private void llenarTablaEmpleados()
        {
            string consulta = @"SELECT * FROM usuarios";
            conn.Open();
            var con = new SQLiteCommand(consulta, conn);
            con.ExecuteNonQuery();
            SQLiteDataReader dr = con.ExecuteReader();
            
            while (dr.Read())
            {
                int rowEscribir = dataGridView1.Rows.Count;
                dataGridView1.Rows.Add(1);
                if (Convert.ToString(dr["atencion"]) == "1")
                {
                    dataGridView1.Rows[rowEscribir].DefaultCellStyle.BackColor = Color.Orange;
                }
                else
                {
                    dataGridView1.Rows[rowEscribir].DefaultCellStyle.BackColor = Color.White;
                }
                dataGridView1.Rows[rowEscribir].Cells[0].Value = Convert.ToString(dr["id"]);
                dataGridView1.Rows[rowEscribir].Cells[1].Value = Convert.ToString(dr["usuario"]); 
                dataGridView1.Rows[rowEscribir].Cells[2].Value = Convert.ToString(dr["nivel"]);
                dataGridView1.Rows[rowEscribir].Cells[3].Value = Convert.ToString(dr["atencion"]);
                //dataGridView1.Rows[rowEscribir].Cells[3].Value = Convert.ToString(dr["nombre"]);
            }
            conn.Close();
        }
        public publicDataUser getusrdata(int usr_id)
        {
            publicDataUser ret = new publicDataUser();
            string sql = @"SELECT * FROM usuarios WHERE id=" + usr_id;
            conn.Open();
            var con = new SQLiteCommand(sql, conn);
            con.ExecuteNonQuery();
            SQLiteDataReader dr = con.ExecuteReader();

            while (dr.Read())
            {
                ret.id_usr = usr_id;
                ret.usrname = Convert.ToString(dr["usuario"]);
                ret.nivel = Convert.ToInt32(dr["nivel"]);
                ret.atencion = Convert.ToInt32(dr["atencion"]);
                break;
            }


            conn.Close();
            return ret;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(usr);
            form3.ShowDialog();
            Hide();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            inventarioAdmin inventarioAdmin = new inventarioAdmin(usr);
            inventarioAdmin.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pag_datos pag = new pag_datos(usr);
            pag.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 formVentas = new Form4(usr);
            formVentas.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idd=0;
            if (dataGridView1.SelectedCells.Count > 0)
            {
                string id = dataGridView1.SelectedCells[0].Value.ToString();
                idd = Convert.ToInt32(id);
            }
            cambiar_pass pass = new cambiar_pass(idd);
            pass.ShowDialog();
            dataGridView1.Rows.Clear();
            llenarTablaEmpleados();
        }
        //el codigo anterior es de LALO por cierto voto por Consuelo 
        //25/05/2023
        public void perfil(int id)
        {
            //publicDataUser ret = new publicDataUser();
            string sql = @"SELECT * FROM usuarios WHERE id=" + id;
            conn.Open();
            var con = new SQLiteCommand(sql, conn);
            con.ExecuteNonQuery();
            SQLiteDataReader dr = con.ExecuteReader();

            if (dr.Read())
            {
                textBox1.Text = Convert.ToString(dr["nombre"]) + " " + Convert.ToString(dr["apellidoP"]) + " " + Convert.ToString(dr["apellidoM"]);
                textBox2.Text = Convert.ToString(dr["usuario"]);
                if (Convert.ToString(dr["nivel"]) == "1")
                {
                    textBox3.Text = "Administrador";
                }
                else
                {
                    textBox3.Text = "Empleado";
                }
                if (Convert.ToString(dr["atencion"]) == "0")
                {
                    textBox4.Text = "Requiere atención";
                }
                else
                {
                    textBox4.Text = "Buen empleado";
                }
            }


            conn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int FilaSelected = dataGridView1.CurrentRow.Index;
            int id = Convert.ToInt32(dataGridView1.Rows[FilaSelected].Cells[0].Value.ToString());

            if (id >= 0)
            {
                //MessageBox.Show("Se genero" + id);
                perfil(id);

            }
        }
    }
}
