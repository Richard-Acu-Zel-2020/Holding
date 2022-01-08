using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Holding
{
    public partial class FrmSvnPagoInversionistas : Form
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        ClsFuncionesGenerales generales = new ClsFuncionesGenerales();

        public FrmSvnPagoInversionistas()
        {
            InitializeComponent();

            //Estilo de Controladores
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

        ClsScrInversion inversiones = null;
        internal ClsScrInversion inversion
        {
            set { inversiones = value; }
        }

        private void FrmSvnPagoInversionistas_Load(object sender, EventArgs e)
        {
            cbxMoneda.DataSource = generales.TodosCatalogoValorXCatalogoActivos("MONEDA");
            cbxMoneda.DisplayMember = "Valor";
            cbxMoneda.ValueMember = "ID";

            cbxTipoMoneda.DataSource = generales.TodosCatalogoValorXCatalogoActivos("MONEDA");
            cbxTipoMoneda.DisplayMember = "Valor";
            cbxTipoMoneda.ValueMember = "ID";
            cbxTipoMoneda.SelectedIndex = -1;

            cbxFormaPago.DataSource = generales.TodosCatalogoValorXCatalogoActivos("FORMAPAGO");
            cbxFormaPago.DisplayMember = "Valor";
            cbxFormaPago.ValueMember = "ID";
            cbxFormaPago.SelectedIndex = -1;

            txtFechaPago.Text = DateTime.Now.ToShortDateString();
            txtFechaPago.ReadOnly = true;

            if (inversiones != null)
            {
                txtIdInversion.Text = inversiones.IdInversion.ToString();
                txtNumero.Text = inversiones.Numero;
                txtNombreCliente.Text = inversiones.NombreCliente;
                txtMontoInversion.Text = inversiones.Monto.ToString();
                cbxMoneda.SelectedValue = inversiones.IdMoneda;

                this.txtIdInversion.Visible = false;
                txtNumero.ReadOnly = true;
                txtNombreCliente.ReadOnly = true;
                cbxMoneda.Enabled = false;
                txtMontoInversion.ReadOnly = true;
                Carga();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Función para Cargar Datos
        public void Carga()
        {
            ClsSvnPagoInversion clspago = new ClsSvnPagoInversion();
            dgvPlanPago.DataSource = clspago.PlanPagos(int.Parse(txtIdInversion.Text));
            //dgvPlanPago.Columns[0].Visible = false;

            dgvPlanPago.Columns[3].ReadOnly = true;
            dgvPlanPago.Columns[4].ReadOnly = true;
            dgvPlanPago.Columns[5].ReadOnly = true;
            dgvPlanPago.Columns[6].ReadOnly = true;
            dgvPlanPago.Columns[7].ReadOnly = true;
            dgvPlanPago.Columns[8].ReadOnly = true;

            dgvPlanPago.Columns[9].Visible = false;
            dgvPlanPago.Columns[10].Visible = false;
            dgvPlanPago.Columns[11].Visible = false;
            dgvPlanPago.Columns[12].Visible = false;
            dgvPlanPago.Columns[13].Visible = false;
            dgvPlanPago.Columns[1].Visible = false;
            dgvPlanPago.Columns[2].Visible = false;
        }
        #endregion

    }
}
