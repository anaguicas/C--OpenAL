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
    public partial class ContenidoSubtema : Form
    {
        public ContenidoSubtema()
        {
            InitializeComponent();
        }

        public ContenidoSubtema(string subtema)
            : this()
        {
            this.Text = subtema;

            int baseX = 150;
            int baseY = 250;            

            string MyConnectionString = "Server=localhost;DataBase=metodologia_de_aprendizaje;Uid=angelica;Pwd=angelica";

            MySqlConnection connection = new MySqlConnection(MyConnectionString);

            string Query = "SELECT subtemas.nombre, subtemas.contenido FROM subtemas,listado_subtemas where id_sub=listado_subtemas.id AND subtemas.nombre='" + subtema + "'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            MySqlDataReader rd = cmd.ExecuteReader();
            rd.Read();

            Label nombre = new Label();
            nombre.Text = subtema;
            nombre.Location = new Point(250, 80);
            nombre.Width = 500;
            nombre.Height = 30;
            nombre.BackColor = System.Drawing.Color.White;
            nombre.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombre.TextAlign = ContentAlignment.TopCenter;
            this.Controls.Add(nombre);

            

            Label contenido = new Label();
            contenido.Location = new Point(200, 150);
            contenido.Width = 550;
            contenido.Height = 100;
            contenido.BackColor = System.Drawing.Color.White;
            contenido.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contenido.Text = rd["contenido"].ToString();
            contenido.TextAlign = ContentAlignment.MiddleLeft;
            this.Controls.Add(contenido);

            Button rep_sonido = new Button();
            rep_sonido.Location = new Point(200, 250);
            rep_sonido.Width = 200;
            rep_sonido.Height = 30;
            rep_sonido.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rep_sonido.Text = "Reproducir Sonido";
            rep_sonido.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(rep_sonido);

            cmd.Dispose();
            rd.Close();
        }
    }
}
