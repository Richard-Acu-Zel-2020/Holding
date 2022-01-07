using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Holding
{
    public partial class FrmError : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager skinManager;

        public FrmError(String _Mensaje, String _MensajeError,String _Texto)
        {
            InitializeComponent();

            skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.EnforceBackcolorOnAllComponents = false;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

            this.Mensaje = _Mensaje;
            this.MensajeError = _MensajeError;
            this.Texto = _Texto;
        }
        ClsVariablesGoblales globales = new ClsVariablesGoblales();
        ClsStbError RegistroError = new ClsStbError();

        String Mensaje, MensajeError, Texto;

        //Muestra o esconde el mensaje de error lazado por la aplicacion.
        private void btnInfo_Click(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
            
            if (this.Height == 161)
                this.Size = new Size(415, 346);
            else
                this.Size = new Size(415, 161);          
        }

        //Cierra la pantalla.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();

            this.Close();                
        }

        //Al cargar la pantalla muestra los mensajes de error que se ingresaron.
        private void FrmError_Load(object sender, EventArgs e)
        {
                //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();

            this.Text = Texto;
            txtError.Text = Mensaje;
            txtErrorSQL.Text = MensajeError;
            //this.Size = new Size(415, 161);
            this.Size = new Size(529, 372);
            this.BringToFront();            
        }

        #region"Control de inactividad"

        private void FrmError_MouseMove(object sender, MouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmError_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmError_MouseClick(object sender, MouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptarError_Click(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();

            this.Close();
        }

        private void txtErrorSQL_MouseMove(object sender, MouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void txtErrorSQL_MouseClick(object sender, MouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        #endregion

    }
}
