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
    public partial class Form1 : Form
    {
        SQLiteConnection conn;
        int id_user = 0;
        publicDataUser user_actual;
        user user = new user();
        //el userID proveera el nivel de acceso del usuario
        public Form1(int usr_id)
        {
            id_user = usr_id;
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=punto_venta.db");
            user_actual = new publicDataUser();
            user_actual = getusrdata(id_user);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //comprobacion, recordar que los valores se interpretan de la siguiente manera: 
            // 0 es un valor por defecto, debe tirar error si algun usuario por alguna razon tiene user id 0
            // 1 es admin
            // 2 es empleado
            if (id_user == 0)
            {
                MessageBox.Show("El perfil seleccionado tiene un error, se ha notificado al administrador y se tomaran las acciones correspondientes", "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
            label5.Text = "¡Bienvenido, " + user_actual.usrname + "!";

            if (user_actual.nivel != 1)
            {
                button1.Enabled = false;
                button4.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(user);
            form4.Show();
            Hide();
            
        }
        //private int getuserlvl(int iduser)
        //{
        //    string sql =  @"SELECT nivel FROM usuarios WHERE id="+iduser;
        //    conn.Open();
        //    var con = new SQLiteCommand(sql, conn);
        //    con.ExecuteNonQuery();
        //    SQLiteDataReader dr = con.ExecuteReader();
        //    conn.Close();

        //    return Convert.ToInt32(dr["nivel"]);
            
        //}

        public publicDataUser getusrdata(int usr_id)
        {
            publicDataUser ret = new publicDataUser();
            string sql = @"SELECT usuario, nivel, atencion FROM usuarios WHERE id=" + usr_id;
            conn.Open();
            var con = new SQLiteCommand(sql, conn);
            con.ExecuteNonQuery();
            SQLiteDataReader dr = con.ExecuteReader();
            
            while (dr.Read())
            {
                ret.id_usr = usr_id;
                ret.usrname=Convert.ToString(dr["usuario"]);
                ret.nivel = Convert.ToInt32(dr["nivel"]);
                ret.atencion= Convert.ToInt32(dr["atencion"]);

                break;
            }
            
            
            conn.Close();
            return ret;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)//boton empleados
        {
            
        }
    }
    public class publicDataUser
    {
        public int id_usr { get; set; }
        public string usrname { get; set; }
        public int nivel { get; set; }
        public int atencion { get; set; }
        
    }
}
