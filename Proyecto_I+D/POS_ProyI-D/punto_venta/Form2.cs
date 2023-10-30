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
using System.Security.Cryptography;

namespace punto_venta
{
    public partial class Form2 : Form
    {
        SQLiteConnection conn;
        public Form2()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=punto_venta.db");
        }



        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form1 form2 = new Form1();
            //form2.Show();
            //Hide();
            //AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
            if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Llena los campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Application.Exit();
            }
            else
            {
                string contra = MD5Hash.Hash.GetMD5(textBox2.Text); // Encriptar lo que tenga el campo de textBox2.Text
                string query = @"SELECT * FROM usuarios WHERE usuario= '" + textBox1.Text + "' AND contrasena= '" + contra + "'";
                conn.Open();
                var con = new SQLiteCommand(query, conn); 
                //MessageBox.Show(Application.StartupPath);
                SQLiteDataReader dr = con.ExecuteReader();
               

                int count = 0;
                int usrid = 0;
                user nwuser = new user();

                while (dr.Read())
                {
                    
                    nwuser.username = dr["usuario"].ToString();
                    nwuser.nombre = dr["nombre"].ToString();
                    nwuser.nivel = Convert.ToInt32(dr["nivel"]);
                    nwuser.genero = dr["sexo"].ToString();
                    nwuser.atencion = Convert.ToInt32(dr["atencion"]);
                    count++;
                }
                if (count == 1)
                {
                    //MessageBox.Show("Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    inventarioAdmin frm = new inventarioAdmin(nwuser);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error con el usuario proporcionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                conn.Close();


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres cerrrar la aplicación?", "Cerrar aplicación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Ingrese un usuario para recuperacion de contraseña");
            }
            else
            {
                errorProvider1.Clear();
                string query = "UPDATE usuarios set atencion = 1 where usuario = '"+textBox1.Text+"'";


                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);

                cmd.CommandType = CommandType.Text;

                //devuelve la cantidad de filas afectadas ya sea insertada o actualizada
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Se ha enviado una solicitud de reinicio de contraseña, consultar con el administrador para mas detalles", "Solicitud enviada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
