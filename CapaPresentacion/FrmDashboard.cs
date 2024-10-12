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
    public partial class FrmDashboard : Form
    {
        
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void peores(string ano)
        {
            try
            {
                 E_DashMaterias ObjEntidad = new E_DashMaterias();
                 N_DashMaterias ObjNegocio = new N_DashMaterias();
                ObjNegocio.MostrarResultados(ObjEntidad, ano);
                chart1.Series[0].Points.DataBindXY(ObjEntidad.Materias, ObjEntidad.cantidadMaterias);
                chart2.Series[0].Points.DataBindXY(ObjEntidad.Promedios, ObjEntidad.cantidadPromedios);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Historico(string materia)
        {
            try
            {
                E_DashMaterias ObjEntidad = new E_DashMaterias();
                N_DashMaterias ObjNegocio = new N_DashMaterias();
                ObjNegocio.Mostrarfechas(ObjEntidad, materia);
               chart3.Series[0].Points.DataBindXY(ObjEntidad.anos, ObjEntidad.PromedioHistorico);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("2021");
            comboBox1.Items.Add("2020");
            comboBox1.Items.Add("2019");
            comboBox1.Items.Add("2018");
            comboBox1.Items.Add("2017");
            comboBox1.Items.Add("2016");
            comboBox1.Items.Add("2015");
            comboBox1.Items.Add("2014");
            comboBox1.Items.Add("2013");
            comboBox1.Items.Add("2012");
            comboBox1.Items.Add("2011");
            comboBox1.Items.Add("2010");

            comboBox2.Items.Add("Ciencias Naturales");
            comboBox2.Items.Add("Biología");
            comboBox2.Items.Add("Sociales");
            comboBox2.Items.Add("Ciencias Económicas y Políticas");
            comboBox2.Items.Add("Etica");
            comboBox2.Items.Add("Educación Física");
            comboBox2.Items.Add("Educación Religiosa");
            comboBox2.Items.Add("Español");
            comboBox2.Items.Add("Inglés Básico");
            comboBox2.Items.Add("Inglés Técnico");
            comboBox2.Items.Add("Matemáticas");
            comboBox2.Items.Add("Cálculo");
            comboBox2.Items.Add("Tecnología e informática");
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            peores(comboBox1.Text);
           

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            peores(comboBox1.Text);
            chart3.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            comboBox2.Visible = true;
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Historico(comboBox2.Text);
        }
    }
}