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
        ClsStbParametros parametros = new ClsStbParametros();
        ClsVariablesGoblales globales = new ClsVariablesGoblales();


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
            DataTable Table = new DataTable();
            ClsSegUsuario usuario = new ClsSegUsuario();

            //Carga Datos del Usuario Activo
            Table = usuario.UsuarioXLoginActivo(globales.RetornaLogin());
            txtPersona.Text = Table.Rows[0][0].ToString();
            txtCodPersona.Text = Table.Rows[0][1].ToString();
            txtPersona.Visible = false;
            txtCodPersona.Visible = false;

            //Carga Datos del Combobox Moneda
            cbxMoneda.DataSource = generales.TodosCatalogoValorXCatalogoActivos("MONEDA");
            cbxMoneda.DisplayMember = "Valor";
            cbxMoneda.ValueMember = "ID";

            //Carga Datos del Combobox Tipo Moneda
            cbxTipoMoneda.DataSource = generales.TodosCatalogoValorXCatalogoActivos("MONEDA");
            cbxTipoMoneda.DisplayMember = "Valor";
            cbxTipoMoneda.ValueMember = "ID";
            cbxTipoMoneda.SelectedIndex = -1;

            //Carga Datos de Forma de Pago
            cbxFormaPago.DataSource = generales.TodosCatalogoValorXCatalogoActivos("FORMAPAGO");
            cbxFormaPago.DisplayMember = "Valor";
            cbxFormaPago.ValueMember = "ID";
            cbxFormaPago.SelectedIndex = -1;

            //Muestra Datos de la Empresa
            txtNombreEmpresa.Text = parametros.ParametroPorNombre("NOMBREEMPRESA").ToString();
            txtRuc.Text = parametros.ParametroPorNombre("RUC").ToString();
            txtNombreEmpresa.ReadOnly = true;
            txtRuc.ReadOnly = true;

            //Muestra Fecha Actual
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Error.Clear();

            //Validación cuando no se Selecciona Ninguna Cuota en el Datagrid
            int filaseleccionada = 0;
            for(int fila = 0; fila < dgvPlanPago.Rows.Count; fila ++)
            {
                if (Convert.ToBoolean(dgvPlanPago.Rows[fila].Cells[0].Value) == true)
                {
                    filaseleccionada = filaseleccionada + 1;
                }

                if(filaseleccionada == 0)
                {
                    MessageBox.Show("Favor Seleccione las Cuotas a Pagar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                Error.SetError(txtMonto, "Favor Ingrese el Monto a Pagar");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtObservacion.Text))
            {
                Error.SetError(txtObservacion, "Favor Ingrese la Observación del Pago");
                return;
            }

            if (cbxTipoMoneda.SelectedIndex == -1)
            {
                Error.SetError(cbxTipoMoneda, "Favor Seleccione el Tipo de Moneda");
                return;
            }

            if (cbxFormaPago.SelectedIndex == -1)
            {
                Error.SetError(cbxFormaPago, "Favor Seleccione la Forma de Pago");
                return;
            }

            try
            {
                DialogResult Result = new System.Windows.Forms.DialogResult();
                Result = MessageBox.Show("¿Esta seguro que desea realizar este Pago?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

             if (Result == DialogResult.Yes)
             {
                    ClsSvnPagoInversion inv = new ClsSvnPagoInversion();
                    inv.NombrePersona = txtPersona.Text;
                    inv.CodigoPersona = txtCodPersona.Text;

             }
            }
            catch
            {
            }
        }
    }
}