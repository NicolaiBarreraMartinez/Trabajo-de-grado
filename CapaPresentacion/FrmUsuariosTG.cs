using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Configuration;


using CapaNegocios;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class FrmUsuariosTG : Form
    {
        
        public FrmUsuariosTG()
        {
            InitializeComponent();
        }

        private void FrmUsuariosTG_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           N_Usuario n1 = new N_Usuario();
            n1 = new N_Usuario();
            string respuesta = n1.verificarConexion();

            if(respuesta != null)
            {
                MessageBox.Show("ajam " +respuesta + " Ha sido un exito!!");
            }
            else {
                MessageBox.Show("FFFF");

            }


        }
    }
}
