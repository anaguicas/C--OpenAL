using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Metodologia_de_aprendizaje
{
    public partial class subtemas : Form
    {
        public subtemas()
        {
            InitializeComponent();
        }

        public subtemas(string subtema)
            : this()
        {
            this.Text = subtema;

            int baseX = 250;
            int baseY = 200;

            Label nombre_subtema = new Label();
            nombre_subtema.Text = subtema;
            nombre_subtema.Location = new Point(250, 80);
            nombre_subtema.Width = 500;
            nombre_subtema.Height = 30;
            nombre_subtema.BackColor = System.Drawing.Color.White;
            nombre_subtema.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre_subtema.TextAlign = ContentAlignment.TopCenter;
            this.Controls.Add(nombre_subtema);

            string MyConnectionString = "Server=localhost;DataBase=metodologia_de_aprendizaje;Uid=angelica;Pwd=angelica";

            MySqlConnection connection = new MySqlConnection(MyConnectionString);

            string Query = "SELECT * FROM listado_subtemas where listado_subtemas.nombre='" + subtema + "'";

            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader rd = cmd.ExecuteReader();
            
            
            rd.Read();
            Label contenido = new Label();
            contenido.Text = rd["contenido"].ToString();
            contenido.Location = new Point(200, 150);
            contenido.Width = 550;
            contenido.Height = 100;
            contenido.BackColor = System.Drawing.Color.White;
            contenido.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contenido.TextAlign = ContentAlignment.MiddleLeft;
            this.Controls.Add(contenido);

            rd.Close();

            string Query2= "SELECT subtemas FROM listado_subtemas where listado_subtemas.nombre='" + subtema + "'";
            MySqlCommand cmd2 = new MySqlCommand(Query2, connection);
            MySqlDataReader rd2 = cmd2.ExecuteReader();

            rd2.Read();
            string subte = rd2["subtemas"].ToString();

            rd2.Close();

            if (subte=="si")
            {                
                int i = 0;

                string Query3 = "SELECT subtemas.nombre FROM subtemas,listado_subtemas where id_sub=listado_subtemas.id AND listado_subtemas.nombre='" + subtema + "'";
                MySqlCommand cmd3 = new MySqlCommand(Query3, connection);
                MySqlDataReader rd3 = cmd3.ExecuteReader();

                while (rd3.Read())
                {
                    System.Windows.Forms.LinkLabel subtemas = new System.Windows.Forms.LinkLabel();
                    subtemas.Location = new Point(baseY, baseX + (20 * i));
                    subtemas.Width = 500;
                    subtemas.Height = 20;
                    subtemas.BackColor = System.Drawing.Color.White;
                    subtemas.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    subtemas.Click += new EventHandler(subtemas_Click);
                    subtemas.Text = rd3["nombre"].ToString();
                    subtemas.TextAlign = ContentAlignment.MiddleLeft;
                    this.Controls.Add(subtemas);
                    i++;
                }

                Button rep_sonido = new Button();
                rep_sonido.Location = new Point(baseY, baseX + (40 * i));
                rep_sonido.Width = 200;
                rep_sonido.Height = 30;
                rep_sonido.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                rep_sonido.Text = "Reproducir Sonido";
                rep_sonido.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(rep_sonido);

                rd3.Close();
            }
            else
            {
                Button rep_sonido = new Button();
                rep_sonido.Location = new Point(200,350);
                rep_sonido.Width = 200;
                rep_sonido.Height = 30;
                rep_sonido.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                rep_sonido.Text = "Reproducir Sonido";
                rep_sonido.TextAlign = ContentAlignment.MiddleCenter;
                this.Controls.Add(rep_sonido);
            }


            cmd.Dispose();
            
        }

        private void subtemas_Click(object sender, EventArgs e)
        {
            ContenidoSubtema contenido = new ContenidoSubtema((sender as LinkLabel).Text);
            this.Hide();
            contenido.ShowDialog();
            this.Close();
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

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.ShowDialog();
            this.Close();
        }
    }
}
