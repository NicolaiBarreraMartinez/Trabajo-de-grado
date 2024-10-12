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
    public partial class DashboardDefinitivo : Form
    {


        string anoau = "2018";

        public DashboardDefinitivo()
        {

            InitializeComponent();
        }
        private void mostrar(string ano)
        {

            try
            {
                E_DashboardDef ObjEntidad = new E_DashboardDef();
                N_DashDef ObjNegocio = new N_DashDef();
                ObjNegocio.MostrarResultados(ObjEntidad, ano);

                    
                chart1.Series[0].Enabled = true;

                chart1.Series[0].Points.DataBindXY(ObjEntidad.Grafica1x, ObjEntidad.Grafica1y);

                chart1.Series[0].Enabled = true;

                chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chart2.Series[0].Points.DataBindXY(ObjEntidad.Grafica2x, ObjEntidad.Grafica2y);

                //chart2.Series[1].Points.DataBindXY(ObjEntidad.Grafica1x, ObjEntidad.Grafica1y);
                //chart2.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void DashboardDefinitivo_Load(object sender, EventArgs e)
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


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            mostrar(comboBox1.Text);
            MostrarTabla(comboBox1.Text);
            MostrarLbl1(comboBox1.Text);
            MostrarLbl2(comboBox1.Text);



        }

        public void MostrarLbl1(string ano)
        {
            E_DashboardDef ObjEntidad = new E_DashboardDef();
            N_DashDef ObjNegocio = new N_DashDef();
            ObjNegocio.MostrarLbl1(ObjEntidad, ano);
            label8.Text = ObjEntidad.TOTALPERDIDOS;

        }
        public void MostrarLbl2(string ano)
        {
            E_DashboardDef ObjEntidad = new E_DashboardDef();
            N_DashDef ObjNegocio = new N_DashDef();
            ObjNegocio.MostrarLbl1(ObjEntidad, ano);
            //label7.Text = ObjEntidad.TOTALPERDIDOSPASADO;

        }

        public void MostrarTabla(string ano)
        {

            N_DashDef ObjNegocio = new N_DashDef();
            dataGridView1.DataSource = N_DashDef.mostrar(ano);
            

        }
    }
}
