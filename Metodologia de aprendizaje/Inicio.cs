using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Audio.OpenAL;
using OpenTK.Audio;
using System.IO;
using MySql.Data.MySqlClient;

namespace Metodologia_de_aprendizaje
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            string linea = System.IO.File.ReadAllText(@"C:\Users\angelica\OneDrive\Trabajo de grado\software\Metodologia de aprendizaje\Metodologia de aprendizaje\bin\Debug\inicio.txt");

            label1.Text = linea;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ListadoTemas lt = new ListadoTemas();
            this.Hide();
            lt.ShowDialog();
            this.Close();
        }


        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BuscarEvaluaciones buscar = new BuscarEvaluaciones();
            this.Hide();
            buscar.ShowDialog();
            this.Close();
        }

    }
}
