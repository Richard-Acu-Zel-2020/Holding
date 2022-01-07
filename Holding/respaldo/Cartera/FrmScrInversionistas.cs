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


namespace Holding
{

    public partial class FrmScrInversionistas : Form
    {
        //readonly MaterialSkin.MaterialSkinManager skinManager;

        public FrmScrInversionistas()
        {
            InitializeComponent();

            //skinManager = MaterialSkin.MaterialSkinManager.Instance;
            //skinManager.EnforceBackcolorOnAllComponents = false;
            //skinManager.AddFormToManage(this);
            ////skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        private void btbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmScrInversionistas_Load(object sender, EventArgs e)
        {

        }

        private void Cargar()
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmScrInversionistasEdicion frm = new FrmScrInversionistasEdicion();
            frm.ShowDialog();
        }

        private void tbHome_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            FrmScrInversionistasEdicion InversionistasEdicion = new FrmScrInversionistasEdicion();
            InversionistasEdicion.ShowDialog();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            FrmInversionistasPagos InversionistasPagos = new FrmInversionistasPagos();
            InversionistasPagos.ShowDialog();
        }
    }
}
