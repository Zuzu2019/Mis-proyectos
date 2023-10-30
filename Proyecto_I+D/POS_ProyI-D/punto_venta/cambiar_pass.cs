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
    public partial class cambiar_pass : Form
    {
        SQLiteConnection conn;
        int id;
        public cambiar_pass(int id)
        {
            this.id = id;
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=punto_venta.db");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text == "")
            {
                errorProvider1.SetError(button1, "rellene los campos de contraseña");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            if(textBox1.Text != textBox2.Text)
            {
                errorProvider1.SetError(button1, "ambas contraseñas deben coincidir");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            
            string query = "UPDATE usuarios set contrasena = '"+MD5Hash.Hash.GetMD5(textBox1.Text)+"', atencion=0 where id = " + id.ToString() + "";


            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            cmd.CommandType = CommandType.Text;

            //devuelve la cantidad de filas afectadas ya sea insertada o actualizada
            cmd.ExecuteNonQuery();
            conn.Close();
            Close();
        }
    }
}
