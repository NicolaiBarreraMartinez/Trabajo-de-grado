using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            comboBox1.Items.Add("Profesores");
            comboBox1.Items.Add("Materias");
            comboBox1.Items.Add("Cursos");
        }

        private const int tamañogrid = 10;
        private const int areamouse = 132;
        private const int botonizquierdo = 17;
        private Rectangle rectangulogrid;

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0,0,ClientRectangle.Width,ClientRectangle.Height));
            rectangulogrid = new Rectangle(ClientRectangle.Width - tamañogrid, ClientRectangle.Height - tamañogrid, tamañogrid, tamañogrid);

            region.Exclude(rectangulogrid);
            PnPrincipal.Region = region;
            Invalidate();
        }



        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message sms)
        {
            switch (sms.Msg)
            {
                case areamouse:
                    base.WndProc(ref sms);
                    var RefPoint = PointToClient(new Point(sms.LParam.ToInt32() & 0xffff, sms.LParam.ToInt32() >> 16));
                    if (!rectangulogrid.Contains(RefPoint))
                    {
                        break;
                    }
                    sms.Result = new IntPtr(botonizquierdo);
                    break;
                default:
                    base.WndProc(ref sms);
                    break;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(245,245,245));

            e.Graphics.FillRectangle(solidBrush, rectangulogrid);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, rectangulogrid);

        }
        int lx, ly;
        int sw, sh;

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro de querer cerrar el programa?", "Alerta" , MessageBoxButtons.YesNo)==DialogResult.Yes)
            { 
                Application.Exit();
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
           WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormularios<FormularioAbrir>() where FormularioAbrir: Form, new()
        {
            Form formularios;

            formularios = PnContenedor.Controls.OfType<FormularioAbrir>().FirstOrDefault();
            if(formularios == null)
            {
                formularios = new FormularioAbrir
                {
                  TopLevel = false,
                  Dock = DockStyle.Fill
                };
                PnContenedor.Controls.Add(formularios);
                PnContenedor.Tag = formularios;
                formularios.Show();

                formularios.BringToFront();
            }
            else
            {
                formularios.BringToFront();
            }
        
        }

        private void BtnCurso_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmDashCursos>();
        }

        private void BtnProfesor_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmDashProfes>();
        }

        private void BtnMateria_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmDashboard>();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FormAlerta>();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            AbrirFormularios<DashboardDefinitivo>();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            AbrirFormularios<FrmDashProfes>();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text.Equals("Profesores"))
            {
                AbrirFormularios<FrmDashProfes>();

            }
            if (comboBox1.Text.Equals("Materias"))
            {
                AbrirFormularios<FrmDashboard>();
            }
            if (comboBox1.Text.Equals("Cursos"))
            {
                AbrirFormularios<FrmDashCursos>();

            }

        }

        private void PnSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PnSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
