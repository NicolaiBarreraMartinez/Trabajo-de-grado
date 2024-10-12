using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


using CapaEntidades;
using CapaNegocios;

namespace CapaPresentacion
{

    public partial class FrmDashProfes : Form
    {
        
        public FrmDashProfes()
        {
            InitializeComponent();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
        private void peores(string ano)
        {
            try
            {
                 E_DashProfes ObjEntidad = new E_DashProfes();
                 N_Dashprofes ObjNegocio = new N_Dashprofes();
                ObjNegocio.MostrarResultados(ObjEntidad,ano);
                chart1.Series[0].Points.DataBindXY(ObjEntidad.Pprofes, ObjEntidad.Ppromedios);
                chart2.Series[0].Points.DataBindXY(ObjEntidad.Mprofes, ObjEntidad.MPromedios);

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void profesor(string ano, string nombre)
        {
            try
            {
                E_DashProfes ObjEntidad = new E_DashProfes();
                N_Dashprofes ObjNegocio = new N_Dashprofes();
                ObjNegocio.MostrarHistoricoProfes(ObjEntidad, ano, nombre);
                chart3.Series[0].Points.DataBindXY(ObjEntidad.Materias, ObjEntidad.PromedioMateria);
               

            }
            catch (Exception)
            {

                throw;
            }
        }
        private void FrmDashProfes_Load(object sender, EventArgs e)
        {
            
            comboBox2.Items.Add("2021");
            comboBox2.Items.Add("2020");
            comboBox2.Items.Add("2019");
            comboBox2.Items.Add("2018");
            comboBox2.Items.Add("2017");
            comboBox2.Items.Add("2016");
            comboBox2.Items.Add("2015");
            comboBox2.Items.Add("2014");
            comboBox2.Items.Add("2013");
            comboBox2.Items.Add("2012");
            comboBox2.Items.Add("2011");
            comboBox2.Items.Add("2010");

           // comboBox3.Items.Add("Andres");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            peores(comboBox2.Text);
            chart3.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            //comboBox3.Visible = true;
       
          
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

       // private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        //{
            //profesor(comboBox2.Text, comboBox3.Text);
        //}

        private void chart2_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            profesor(comboBox2.Text, textBox1.Text);
            
        }
    }
}
