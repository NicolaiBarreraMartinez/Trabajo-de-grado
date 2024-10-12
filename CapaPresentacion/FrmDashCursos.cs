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
    public partial class FrmDashCursos : Form
    {
        
        public FrmDashCursos()
        {
            InitializeComponent();
        }

        private void peores(string ANO)
        {
            try
            {
                 E_DashCursos ObjEntidad = new E_DashCursos();
                 N_DashCursos ObjNegocio = new N_DashCursos();

                ObjNegocio.MostrarResultados(ObjEntidad, ANO);
                chart1.Series[0].Points.DataBindXY(ObjEntidad.Cursos, ObjEntidad.Promedios);
                chart2.Series[0].Points.DataBindXY(ObjEntidad.cantidadCursos, ObjEntidad.cantidadPromedios);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void especifico(string curso, string ano)
        {
            try
            {
                E_DashCursos ObjEntidad = new E_DashCursos();
                N_DashCursos ObjNegocio = new N_DashCursos();

                ObjNegocio.MostrarCurso(ObjEntidad, curso, ano);
                chart3.Series[0].Points.DataBindXY(ObjEntidad.cantidadGrupos, ObjEntidad.promedioCurso);
               
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void actualizar(string fecha)
        {
            

        }
        private void FrmDashCursos_Load(object sender, EventArgs e)
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


            comboBox2.Items.Add("TRANSICIÓN");
            comboBox2.Items.Add("PRIMERO");
            comboBox2.Items.Add("SEGUNDO");
            comboBox2.Items.Add("TERCERO");
            comboBox2.Items.Add("CUARTO");
            comboBox2.Items.Add("QUINTO");
            comboBox2.Items.Add("SEXTO");
            comboBox2.Items.Add("SEPTIMO");
            comboBox2.Items.Add("OCTAVO");
            comboBox2.Items.Add("NOVENO");
            comboBox2.Items.Add("DECIMO");
            comboBox2.Items.Add("UNDECIMO");

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            peores(comboBox1.Text);
            actualizar(comboBox1.Text);

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            peores(comboBox1.Text);
            chart3.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            comboBox2.Visible = true;
            especifico(comboBox2.Text, comboBox1.Text);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            especifico(comboBox2.Text, comboBox1.Text);
            
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}