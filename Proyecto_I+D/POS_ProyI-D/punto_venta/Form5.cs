using SpreadsheetLight;
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
    public partial class Form5 : Form
    {
        SQLiteConnection conn;
        public Form5()
        {
            InitializeComponent();
            conn = new SQLiteConnection("Data Source=punto_venta.db");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            llenartabla(0);
        }
        private void llenartabla(int modo)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            conn.Open();
            string query;
            switch (modo)
            {
                case 0:
                    query = "SELECT * FROM recibo";
                    var con = new SQLiteCommand(query, conn);
                    //con.ExecuteNonQuery();
                    SQLiteDataReader dr = con.ExecuteReader();
                    dataGridView1.Columns.Add("columna1", "ID");
                    dataGridView1.Columns.Add("columna2", "Total de compra");
                    dataGridView1.Columns.Add("columna3", "numero de articulos");
                    dataGridView1.Columns.Add("columna4", "fecha");

                    while (dr.Read())
                    {
                        int rowEscribir = dataGridView1.Rows.Count;
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[rowEscribir].Cells[0].Value = Convert.ToString(dr["id"]);
                        dataGridView1.Rows[rowEscribir].Cells[1].Value = Convert.ToString(dr["total"]);
                        dataGridView1.Rows[rowEscribir].Cells[2].Value = Convert.ToString(dr["numero_articulo"]);
                        dataGridView1.Rows[rowEscribir].Cells[3].Value = Convert.ToString(dr["fecha"]);
                    }
                    break;
                case 1:
                    query = "SELECT * FROM producto where eliminado != 1";
                    var con1 = new SQLiteCommand(query, conn);
                    //con1.ExecuteNonQuery();
                    SQLiteDataReader dr1 = con1.ExecuteReader();
                    dataGridView1.Columns.Add("columna1", "ID");
                    dataGridView1.Columns.Add("columna2", "Nombre del producto");
                    dataGridView1.Columns.Add("columna3", "Categoria");
                    dataGridView1.Columns.Add("columna4", "Precio");
                    dataGridView1.Columns.Add("columna5", "Cantidad");
                    dataGridView1.Columns.Add("columna6", "Agotado");
                    dataGridView1.Columns.Add("columna7", "Descripcion");

                    while (dr1.Read())
                    {
                        int rowEscribir = dataGridView1.Rows.Count;
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[rowEscribir].Cells[0].Value = Convert.ToString(dr1["id"]);
                        dataGridView1.Rows[rowEscribir].Cells[1].Value = Convert.ToString(dr1["nombre"]);
                        dataGridView1.Rows[rowEscribir].Cells[2].Value = Convert.ToString(dr1["categoria"]);
                        dataGridView1.Rows[rowEscribir].Cells[3].Value = Convert.ToString(dr1["precio"]);
                        dataGridView1.Rows[rowEscribir].Cells[4].Value = Convert.ToString(dr1["cantidad"]);
                        dataGridView1.Rows[rowEscribir].Cells[5].Value = Convert.ToString(dr1["agotado"]);
                        dataGridView1.Rows[rowEscribir].Cells[6].Value = Convert.ToString(dr1["descripcion"]);
                    }
                    break;
                case 2:
                    query = "SELECT * FROM venta_productos";
                    var con2 = new SQLiteCommand(query, conn);
                    //con1.ExecuteNonQuery();
                    SQLiteDataReader dr2 = con2.ExecuteReader();

                    dataGridView1.Columns.Add("columna1", "ID");
                    dataGridView1.Columns.Add("columna2", "ID porducto comprado");
                    dataGridView1.Columns.Add("columna3", "Cantidad comprada");
                    dataGridView1.Columns.Add("columna4", "ID del recibo");
                    while (dr2.Read())
                    {
                        int rowEscribir = dataGridView1.Rows.Count;
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[rowEscribir].Cells[0].Value = Convert.ToString(dr2["id"]);
                        dataGridView1.Rows[rowEscribir].Cells[1].Value = Convert.ToString(dr2["id_producto"]);
                        dataGridView1.Rows[rowEscribir].Cells[2].Value = Convert.ToString(dr2["cantidad"]);
                        dataGridView1.Rows[rowEscribir].Cells[3].Value = Convert.ToString(dr2["id_recibo"]);
                    }
                    break;
                default:
                    break;
            }
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenartabla(comboBox1.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument();
            SLStyle style = new SLStyle();
            style.Font.FontSize = 12;
            style.Font.Bold = true;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    int IC = 1;
                    foreach(DataGridViewColumn column in dataGridView1.Columns)
                    {
                        sl.SetCellValue(1, IC, column.HeaderText.ToString());
                        sl.SetCellStyle(1, IC, style);
                        IC++;
                    }
                    int IR = 2;
                    foreach(DataGridViewRow row in dataGridView1.Rows)
                    {
                        sl.SetCellValue(IR, 1, Convert.ToInt32(row.Cells[0].Value));
                        sl.SetCellValue(IR, 2, Convert.ToInt32(row.Cells[1].Value.ToString()));
                        sl.SetCellValue(IR, 3, Convert.ToInt32(row.Cells[2].Value.ToString()));
                        sl.SetCellValue(IR, 4, row.Cells[3].Value.ToString());
                        IR++;
                    }
                    sl.SetCellValue(IR, 1, "Generado para la aplicacion de punto de venta para la materia de proyecto I+D I");
                    break;
                case 1:
                    int IC1 = 1;
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        sl.SetCellValue(1, IC1, column.HeaderText.ToString());
                        sl.SetCellStyle(1, IC1, style);
                        IC1++;
                    }
                    int IR1 = 2;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        sl.SetCellValue(IR1, 1, Convert.ToInt32(row.Cells[0].Value));
                        sl.SetCellValue(IR1, 2, row.Cells[1].Value.ToString());
                        sl.SetCellValue(IR1, 3, row.Cells[2].Value.ToString());
                        sl.SetCellValue(IR1, 4, Convert.ToDouble(row.Cells[3].Value.ToString()));
                        sl.SetCellValue(IR1, 5, Convert.ToDouble(row.Cells[4].Value.ToString()));
                        sl.SetCellValue(IR1, 6, Convert.ToInt32(row.Cells[5].Value));
                        sl.SetCellValue(IR1, 7, row.Cells[6].Value.ToString());

                        IR1++;
                    }
                    sl.SetCellValue(IR1, 1, "Generado para la aplicacion de punto de venta para la materia de proyecto I+D I");
                    break;
                case 2:
                    int IC2 = 1;
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        sl.SetCellValue(1, IC2, column.HeaderText.ToString());
                        sl.SetCellStyle(1, IC2, style);
                        IC2++;
                    }
                    int IR2 = 2;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        sl.SetCellValue(IR2, 1, Convert.ToInt32(row.Cells[0].Value));
                        sl.SetCellValue(IR2, 2, Convert.ToInt32(row.Cells[1].Value.ToString()));
                        sl.SetCellValue(IR2, 3, Convert.ToInt32(row.Cells[2].Value.ToString()));
                        sl.SetCellValue(IR2, 4, Convert.ToInt32(row.Cells[3].Value.ToString()));
                        IR2++;
                    }
                    sl.SetCellValue(IR2, 1, "Generado para la aplicacion de punto de venta para la materia de proyecto I+D I");
                    break;
                default:
                    break;
            }
            SaveFileDialog save = new SaveFileDialog();
            //save.CheckFileExists = true;
            save.CheckPathExists = true;
            save.DefaultExt = "xlsx";
            save.Filter = "Excel |*.xlsx";
            save.FileName = "Generacion_APP_IDI";
            if (save.ShowDialog() == DialogResult.OK)
            {
                sl.SaveAs(save.FileName);
            }
            
            Close();
        }
    }
}
