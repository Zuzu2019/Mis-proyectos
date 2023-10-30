using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace punto_venta
{

    public class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public string Sexo { get; set; }
        public string Nivel { get; set; }
        public string Atencion { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
    }

    public class PersonaLogica
    {
        //necesitamos agregar un referencia de servicio "System.Configuration"


        //Singleton : es un patrón de diseño que permite nos permite hacer una instancia unica, restringir crear objetos
        private static PersonaLogica _instancia = null;
        private SQLiteConnection conn;

        public PersonaLogica()
        {

        }

        public static PersonaLogica Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new PersonaLogica();

                return _instancia;
            }
        }

        //IMPORTAR System.Data.SQLite
        public bool Guardar(Persona objeto)
        {

            bool respuesta = true;

            conn = new SQLiteConnection("Data Source=punto_venta.db");
            {

                conn.Open();
                string query = "insert into usuarios(nombre,apellidoP, apellidoM, sexo, nivel, atencion, usuario, contrasena ) values (@nombre, @apellidoP, @apellidoM, @sexo, @nivel, 1, @usuario, @contrasena)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.Add(new SQLiteParameter("@nombre", objeto.Nombre));
                cmd.Parameters.Add(new SQLiteParameter("@apellidoP", objeto.ApellidoP));
                cmd.Parameters.Add(new SQLiteParameter("@apellidoM", objeto.ApellidoM));
                cmd.Parameters.Add(new SQLiteParameter("@sexo", objeto.Sexo));
                cmd.Parameters.Add(new SQLiteParameter("@nivel", objeto.Nivel));
                //cmd.Parameters.Add(new SQLiteParameter("1", objeto.Atencion));
                cmd.Parameters.Add(new SQLiteParameter("@usuario", objeto.Usuario));
                cmd.Parameters.Add(new SQLiteParameter("@contrasena", objeto.Contrasena));
                cmd.CommandType = System.Data.CommandType.Text;

                //devuelve la cantidad de filas afectadas ya sea insertada o actualizada
                if (cmd.ExecuteNonQuery() < 1)
                {
                    respuesta = false;
                }
                conn.Close();
            }

            return respuesta;
        }
    }

}

