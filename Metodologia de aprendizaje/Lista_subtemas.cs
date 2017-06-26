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

namespace Metodologia_de_aprendizaje
{
    public partial class Lista_subtemas : Form
    {

        public Lista_subtemas()
        {
            InitializeComponent();
        }

        public Lista_subtemas(string subtema)
            :this()
        {
            this.Text = "Subtemas " + subtema;

            int baseX = 150;
            int baseY = 250;

            Label listado_subtemas = new Label();
            listado_subtemas.Text ="Subtemas de "+ subtema;            
            listado_subtemas.Location = new Point(250, 80);
            listado_subtemas.Width = 500;
            listado_subtemas.Height = 30;
            listado_subtemas.BackColor = System.Drawing.Color.White;
            listado_subtemas.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listado_subtemas.TextAlign = ContentAlignment.TopCenter;
            this.Controls.Add(listado_subtemas);      

            string MyConnectionString = "Server=localhost;DataBase=metodologia_de_aprendizaje;Uid=angelica;Pwd=angelica";

            MySqlConnection connection = new MySqlConnection(MyConnectionString);

            //MySqlCommand cmd= connection.CreateCommand();

            //cmd.CommandText = "SELECT listado_temas.nombre FROM listado_temas,temas WHERE id_tema=temas.id";
            string Query = "SELECT listado_subtemas.nombre FROM listado_subtemas,temas where id_tema=temas.id AND temas.titulo='"+ subtema+ "'";
            //cmd.Connection.Open();
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader rd = cmd.ExecuteReader();
            int i = 0;

            while (rd.Read())
            {                
                System.Windows.Forms.LinkLabel subtemas = new System.Windows.Forms.LinkLabel();
                subtemas.Location = new Point(baseY, baseX + (20 * i));
                subtemas.Width = 500;
                subtemas.Height = 20;
                subtemas.BackColor = System.Drawing.Color.White;
                subtemas.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                subtemas.Click += new EventHandler(subtemas_Click);
                subtemas.Text = rd["nombre"].ToString();
                subtemas.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(subtemas);
                i++;
            }

            cmd.Dispose();
            rd.Close();
        }

        private void subtemas_Click(object sender, EventArgs e)
        {        
            subtemas lista = new subtemas((sender as LinkLabel).Text);
            this.Hide();
            lista.ShowDialog();
            this.Close();
        }

        private void Lista_subtemas_Load(object sender, EventArgs e)
        {

        }

        private void listarTemasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoTemas lt = new ListadoTemas();
            this.Hide();
            lt.ShowDialog();
            this.Close();
        }

        private void buscarEvaluacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarEvaluaciones buscar = new BuscarEvaluaciones();
            this.Hide();
            buscar.ShowDialog();
            this.Close();
        }

        private void inicioMenuItem_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.ShowDialog();
            this.Close();
        }
    }
}
