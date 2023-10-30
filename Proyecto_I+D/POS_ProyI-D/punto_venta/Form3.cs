using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using punto_venta;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace punto_venta
{
    public partial class Form3 : Form
    {
        private const int V = 0;
        user user;
        public Form3(user usr)
        {
            user = usr;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            nivel.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            validarcampos();
            if(validarcampos()== true)
            {
                textusuario.Text = obtener_username();
                Persona objeto = new Persona()
                {
                    Nombre = textnombre.Text,
                    ApellidoP = textapellido1.Text,
                    ApellidoM = textapellido2.Text,
                    //Sexo = radioButton1.Text,
                    Usuario = textusuario.Text,
                    Contrasena = MD5Hash.Hash.GetMD5(contrasena.Text),
                };

                if (radioButton1.Checked == true)
                {
                    objeto.Sexo = "Masculino";
                }
                else
                {
                    objeto.Sexo = "Femenino";
                }
                if (nivel.SelectedIndex == 1)
                {
                    objeto.Nivel = "1";
                }
                else
                {
                    objeto.Nivel = "2";
                }
                PersonaLogica.Instancia.Guardar(objeto);
                MessageBox.Show(@"Usuario agregado: El nombre de tu usuario es: " + textusuario.Text, @"Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                textnombre.Text = "";
                textapellido1.Text = "";
                textapellido2.Text = "";
                textusuario.Text = "";
                contrasena.Text = "";
                contrasenaV.Text = "";
                pagEmpleados();
            }
            else
            {
                MessageBox.Show("Error, no se pudo agregar el usuario...", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            


        }
        private void pagEmpleados()
        {
            pag_empleados pag_Empleados = new pag_empleados(user);
            pag_Empleados.Show();
            Hide();
            //Close();


        }
        private bool validarcampos()
        {
            bool val = true;
            if (textnombre.Text == "")
            {
                val = false;
                errorProvider1.SetError(textnombre, "El campo nombre esta vacio");
            }
            if (textapellido1.Text == "")
            {
                val = false;
                errorProvider1.SetError(textapellido1, "El campo apellido paterno esta vacio");
            }
            if (textapellido2.Text == "")
            {
                val = false;
                errorProvider1.SetError(textapellido2, "El campo apellido materno esta vacio");
            }
            if (contrasena.Text == "" && contrasenaV.Text == "")
            {
                val = false;
                errorProvider1.SetError(contrasena, "Campo contraseña esta vacio");
            }
            if (contrasena.Text != contrasenaV.Text)
            {
                val = false;
                errorProvider1.SetError(contrasena, "Los campos contraseña no coinciden");
                errorProvider1.SetError(contrasenaV, "Los campos contraseña no coinciden");
            }

            return val;
        }

        private string obtener_username()
        {
            string cadena = this.textnombre.Text;
            string cadena2 = this.textapellido1.Text;
            string caracter = cadena.Substring(0, 3);
            string caracter2 = cadena2.Substring(0, 2);

            //string nombre = textnombre.Text;
            //string[] subs = nombre.Split(' ');
            return caracter + caracter2;
        }

        private void nivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Seguro que no quiere agregar otro empleado, realmente no lo necesita?", @"Atención",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.DialogResult = DialogResult.None;
                //txtUsuario.Focus();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Seguro que no quiere agregar otro empleado, realmente no lo necesita?", @"Atención",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Application.Exit();
                pag_empleados pag_Empleados = new pag_empleados(user);
                pag_Empleados.Show();
                Hide();
            }
            else
            {
                this.DialogResult = DialogResult.None;
                //txtUsuario.Focus();
            }
        }
    }
}

