using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocios;
using CapaEntidades;


namespace CapaPresentacion
{
    public partial class FrmInicioSesion : Form
    {
        public FrmInicioSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
                if (MessageBox.Show("¿Estás seguro de querer cerrar el programa?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            if(textBox1.Text!= "")
            {
                if(textBox2.Text!= "")
                {
                    N_InicioSesion inicioSesion = new N_InicioSesion();
                    var ValidarDatos = inicioSesion.IniciioSesion(textBox1.Text, textBox2.Text);
                    if(ValidarDatos == true)
                    {
                        Hide();
                        FrmMenu menu = new FrmMenu
                        {

                        };
                        menu.Show();  
                    }
                    else
                    {
                        MensajeError("Datos Incorrectos. Intente de nuevo");
                        textBox2.Text = "";
                        textBox1.Focus();
                    }
                }
                else
                {
                    MensajeError("Por favor ingrese su contraseña");
                    textBox2.Focus();
                }

            }
            else
            {
                MensajeError("Por favor ingrese su nombre de usuario");
                textBox1.Focus();
            }

        }
        
    }
}
