using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Metodologia_de_aprendizaje
{

    
    public partial class ListadoTemas : Form
    {
        public struct infoTemas
        {
            public int x;
            public int y;
            public string texto;
        }


        public ListadoTemas()
        {
            InitializeComponent();

            int baseX = 130;
            int baseY = 250;

            Label listado_temas = new Label();
            listado_temas.Text = "Listado Temas";
            listado_temas.Location = new Point(250, 80);
            listado_temas.Width = 500;
            listado_temas.Height = 30;
            listado_temas.BackColor = System.Drawing.Color.White;
            listado_temas.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listado_temas.TextAlign = ContentAlignment.TopCenter;
            this.Controls.Add(listado_temas);

            string MyConnectionString = "Server=localhost;DataBase=metodologia_de_aprendizaje;Uid=angelica;Pwd=angelica";

            MySqlConnection connection = new MySqlConnection(MyConnectionString);
            //SqlConnection connection = new SqlConnection(MyConnectionString);
            //MySqlCommand cmd= connection.CreateCommand();
            connection.Open();
            //cmd.CommandText = "SELECT listado_temas.nombre FROM listado_temas,temas WHERE id_tema=temas.id";
            string Query= "SELECT titulo FROM temas";
            //SqlCommand cmd = new SqlCommand(Query,connection);
            //SqlDataReader reader = cmd.ExecuteReader();
            //cmd.Connection.Open();
            //connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            int i = 0;

            while (reader.Read())
            {                
                System.Windows.Forms.LinkLabel titulos = new System.Windows.Forms.LinkLabel();
                titulos.Location = new Point(baseY, baseX + (20 * i));
                titulos.Width = 500;
                titulos.Height = 20;
                titulos.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                titulos.Click += new EventHandler(titulos_Click);
                titulos.Text = reader["titulo"].ToString();
                titulos.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(titulos);
                i++;
            }
            
            cmd.Dispose();
            reader.Close();
        }


        private void titulos_Click(object sender, EventArgs e)
        {
            Lista_subtemas lista = new Lista_subtemas((sender as LinkLabel).Text);
            this.Hide();
            lista.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.ShowDialog();
            this.Close();
        }


        private void toolStripMenuItem2_Click_2(object sender, EventArgs e)
        {
            BuscarEvaluaciones buscar = new BuscarEvaluaciones();
            this.Hide();
            buscar.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
