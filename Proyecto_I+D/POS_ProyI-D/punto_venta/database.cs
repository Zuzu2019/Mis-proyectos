using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Drawing;

namespace punto_venta
{
    public class DataBase
    {
        private string namedb;
        private SQLiteConnection conection;
        private SQLiteCommand command;

        public DataBase()
        {
            namedb = "punto_venta.db";
            string dataSource = "Data Source=" + namedb;
            conection = new SQLiteConnection(dataSource);
            conection.Open();
        }
        public DataBase(string namedb)
        {
            this.namedb = namedb;
            string dataSource = "Data Source=" + this.namedb;
            conection = new SQLiteConnection(dataSource);
            conection.Open();
        }

        public bool executeQuery(string query)
        {
            bool respuesta = true;

            command = new SQLiteCommand(query,conection);

            //devuelve la cantidad de filas afectadas ya sea insertada o actualizada
            if (command.ExecuteNonQuery() < 1)
            {
                respuesta = false;
            }
            //conection.Close();
            return respuesta;


        }
        public SQLiteDataReader getData(string query)
        {
            command = new SQLiteCommand(query, conection);
            command.ExecuteNonQuery();
            SQLiteDataReader dr = command.ExecuteReader();
            return dr;
        }
        public void closeDB()
        {
            conection.Close();
        }
    }

    
}
