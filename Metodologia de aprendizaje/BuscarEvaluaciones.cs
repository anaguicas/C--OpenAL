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



namespace Metodologia_de_aprendizaje
{
    public partial class BuscarEvaluaciones : Form
    {
        public BuscarEvaluaciones()
        {
            InitializeComponent();
        }

        private void BuscarEvaluaciones_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = textBox1.Text;
            string nombreArchivo = textBox1.Text + ".txt";
            string lineaActual;
            //ArrayList archivo = new ArrayList();
            //string cadena = "";

            //string Directorio = "C:\Users\angelica\OneDrive\Trabajo de grado\software\Metodologia de aprendizaje";            

            StreamReader sr = new StreamReader(nombreArchivo);

            int numlineas = 10;
            int baseX = 150;
            int baseY = 250;
            lineaActual = sr.ReadLine();

            for (int i = 0; i < numlineas && lineaActual != null; i++)
            {
                System.Windows.Forms.LinkLabel Bevaluaciones = new System.Windows.Forms.LinkLabel();
                Bevaluaciones.Location = new Point(baseY, baseX + (20 * i));
                Bevaluaciones.Width = 500;
                Bevaluaciones.Height = 20;
                Bevaluaciones.Text = lineaActual;
                Bevaluaciones.TextAlign = ContentAlignment.MiddleCenter;
                lineaActual = sr.ReadLine();

                this.Controls.Add(Bevaluaciones);
            }

            //while (lineaActual != null)
            //{                
                //archivo.Add(lineaActual);
                //cadena = cadena + lineaActual + "\n";
              //  lineaActual = sr.ReadLine();                
            //}
            
            //linkLabel1.Text = cadena;
            
            sr.Close();


        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListadoTemas lt = new ListadoTemas();
            this.Hide();
            lt.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
