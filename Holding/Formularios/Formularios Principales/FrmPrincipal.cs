using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;
using System.Media;

namespace Holding
{
    public partial class FrmPrincipal : Form
    {
        //readonly MaterialSkin.MaterialSkinManager skinManager;

        SoundPlayer Sound;
        public Form FormularioActivo = null;
        public FrmPrincipal()
        {
            InitializeComponent();

            //skinManager = MaterialSkin.MaterialSkinManager.Instance;
            //skinManager.EnforceBackcolorOnAllComponents = false;
            //skinManager.AddFormToManage(this);
            //skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

            PersonalizarDiseño();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void AbrirFormularioHijo(Form FormHijo)
        {
            Sound = new SoundPlayer(@"C:\Sistemas\HOLDING\Sonidos\Sound_Click.wav");
            Sound.Play();

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }

            FormularioActivo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            PanelContenedor.Controls.Add(FormHijo);
            PanelContenedor.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
        }

        private void PersonalizarDiseño()
        {
            PanelCartera.Visible = false;
            PanelSeguridad.Visible = false;
            PanelConfiguracion.Visible = false;
            PanelVentanilla.Visible = false;
        }

        private void OcultarSubMenus()
        {
            if (PanelCartera.Visible == true)
                PanelCartera.Visible = false;
            if (PanelSeguridad.Visible == true)
                PanelSeguridad.Visible = false;
            if (PanelConfiguracion.Visible == true)
                PanelConfiguracion.Visible = false; 
            if (PanelVentanilla.Visible == true)
                PanelVentanilla.Visible = false;
        }

        private void MostrarSubMenu(Panel SubMenu)
        {
            this.Cursor = Cursors.WaitCursor;
            Sound = new SoundPlayer(@"C:\Sistemas\HOLDING\Sonidos\Sound_Click.wav");
            Sound.Play();

            if (SubMenu.Visible == false)
            {
                OcultarSubMenus();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
            this.Cursor = Cursors.Default;
        }

        private void PanelMenuLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCartera_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelCartera);
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelSeguridad);
        }

        private void btnConfiguración_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelConfiguracion);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Sound = new SoundPlayer(@"C:\Sistemas\HOLDING\Sonidos\Sound_Click.wav");
            Sound.Play();

            DialogResult Result = new System.Windows.Forms.DialogResult();
            Result = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnProveedorFondo_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmScrSolicitud());
        }

        private void btnRolesAcciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmSegRol());
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarPrincipal_Click(object sender, EventArgs e)
        {
            DialogResult Result = new System.Windows.Forms.DialogResult();
            Result = MessageBox.Show("¿Está seguro que desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPagosProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmSvnInversion());
        }

        private void PanelContenedor_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnOtrasOpciones_Click(object sender, EventArgs e)
        {
            Sound = new SoundPlayer(@"C:\Sistemas\HOLDING\Sonidos\Sound_Click.wav");
            Sound.Play();


        }

        private void TimerFechaHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Sound = new SoundPlayer(@"C:\Sistemas\HOLDING\Sonidos\Sound_Click.wav");
            Sound.Play();

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmSegUsuario());
        }

        private void btnAcciones_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmSegAccion());
        }

        private void btnAsignarPermisos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmSegAccionRol());
        }

        private void btnVentanilla_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(PanelVentanilla);
        }
    }
}
