using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion
{
    public partial class FormAlerta : Form
    {
       
        public FormAlerta()
        {
            InitializeComponent();
        }

        private void FormAlerta_Load(object sender, EventArgs e)
        {
            MostrarTabla();
        }
        private void mostrar(string codigo)
        {

            try
            {
                E_Alertas ObjEntidad = new E_Alertas();
                N_Alertas ObjNegocio = new N_Alertas();
                ObjNegocio.MostrarResultados(ObjEntidad, codigo);
                chart1.Series[0].Enabled = true;
                chart1.Series[0].Points.DataBindXY(ObjEntidad.Grafica1x, ObjEntidad.Grafica1y);
                chart1.Series[0].Enabled = true;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void MostrarTabla()
        {

            N_Alertas ObjNegocio = new N_Alertas();
            dataGridView1.DataSource = N_Alertas.mostrar();


        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            mostrar(textBox1.Text);
            //MostrarTabla();
            MostrarLblEdad(textBox1.Text);
            MostrarLblSexo (textBox1.Text);
            MostrarLblGrado(textBox1.Text);
            MostrarLblEstrato(textBox1.Text);

        }
        public void MostrarLblEdad(string codigo)
        {
            E_Alertas ObjEntidad = new E_Alertas();
            N_Alertas ObjNegocio = new N_Alertas();
            ObjNegocio.MostrarLblEdad(ObjEntidad, codigo);
            label8.Text = ObjEntidad.edad;

        }
        public void MostrarLblSexo(string codigo)
        {
            E_Alertas ObjEntidad = new E_Alertas();
            N_Alertas ObjNegocio = new N_Alertas();
            ObjNegocio.MostrarLblSexo(ObjEntidad, codigo);
            label11.Text = ObjEntidad.sexo;

        }
        public void MostrarLblGrado(string codigo)
        {
            E_Alertas ObjEntidad = new E_Alertas();
            N_Alertas ObjNegocio = new N_Alertas();
            ObjNegocio.MostrarLblGrado(ObjEntidad, codigo);
            label9.Text = ObjEntidad.grado;

        }
        public void MostrarLblEstrato(string codigo)
        {
            E_Alertas ObjEntidad = new E_Alertas();
            N_Alertas ObjNegocio = new N_Alertas();
            ObjNegocio.MostrarLblEstrato(ObjEntidad, codigo);
            label10.Text = ObjEntidad.estrato;

        }
    }
}
