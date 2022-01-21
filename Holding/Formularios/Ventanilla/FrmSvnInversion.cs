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
    public partial class FrmSvnInversion : Form
    {
        public FrmSvnInversion()
        {
            InitializeComponent();
        }

        ClsVariablesGoblales globales = new ClsVariablesGoblales();
        ClsStbError RegistroError = new ClsStbError();

        private void FrmSvnInversion_Load(object sender, EventArgs e)
        {
            Carga();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            PagarInversion();
        }

        #region Función para Cargar Datos
        public void Carga()
        {
            ClsScrInversion clsinversion = new ClsScrInversion();
            dgvInversion.DataSource = clsinversion.Inversiones();
            dgvInversion.Columns[0].Visible = false;
            dgvInversion.Columns[14].Visible = false;
            dgvInversion.Columns[15].Visible = false;
            //dgvInversion.Columns[1].Width = 70;
            txtBuscar.Text = "";
            lblContador.Text = String.Format("{0:N0}", double.Parse(dgvInversion.RowCount.ToString()));
        }
        #endregion

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ClsScrInversion clsinversion = new ClsScrInversion();
            dgvInversion.DataSource = clsinversion.BuscarXNombre(txtBuscar.Text);
        }

        #region Función para Cargar Datos al Otro Formulario
        public void PagarInversion()
        {
            if (dgvInversion.RowCount > 0)
            {
                try

                {
                    ClsScrInversion clsInversion = new ClsScrInversion();
                    FrmSvnPagoInversionistas PagarInversion = new FrmSvnPagoInversionistas();
                    clsInversion.IdInversion = int.Parse(dgvInversion.Rows[dgvInversion.SelectedRows[0].Index].Cells[0].Value.ToString());
                    clsInversion.Numero = dgvInversion.Rows[dgvInversion.SelectedRows[0].Index].Cells[1].Value.ToString();
                    clsInversion.NombreCliente = dgvInversion.Rows[dgvInversion.SelectedRows[0].Index].Cells[2].Value.ToString();
                    clsInversion.Monto = Decimal.Parse(dgvInversion.Rows[dgvInversion.SelectedRows[0].Index].Cells[3].Value.ToString());
                    clsInversion.IdMoneda = int.Parse(dgvInversion.Rows[dgvInversion.SelectedRows[0].Index].Cells[14].Value.ToString());
                    clsInversion.IdEstadoInversion = int.Parse(dgvInversion.Rows[dgvInversion.SelectedRows[0].Index].Cells[15].Value.ToString());
                    PagarInversion.inversion = clsInversion;
                    PagarInversion.ShowDialog();
                    Carga();
                }
                catch (Exception IO)
                {
                    RegistroError.Formulario = this.ToString();
                    RegistroError.DetalleError = IO.ToString();
                    RegistroError.GuardaError();
                    FrmError frmError = new FrmError(globales.MsgError, IO.ToString(), globales.MsgErrorFinal);
                    this.Cursor = Cursors.Default;
                    frmError.ShowDialog();
                    return;
                }
            }
        }
        #endregion
<<<<<<< HEAD

        #region "Función Buscar x Nombre"
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ClsScrInversion clsinversion = new ClsScrInversion();
            dgvInversion.DataSource = clsinversion.BuscarXNombre(txtBuscar.Text);
            lblContador.Text = String.Format("{0:N0}", double.Parse(dgvInversion.RowCount.ToString()));
        }
        #endregion

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            String NumeroInversion = dgvInversion.Rows[dgvInversion.SelectedRows[0].Index].Cells[1].Value.ToString();

            Holding.Formularios.Cartera.Reportes.RptScrEstadoCuentaInversion RptEstadoCuenta = new Formularios.Cartera.Reportes.RptScrEstadoCuentaInversion();
            ClsScrInversion ClaseInversion = new ClsScrInversion();
            RptEstadoCuenta.SetParameterValue("@NumeroInversion", NumeroInversion);
            ClaseInversion.ImprimirReporte(RptEstadoCuenta, "Estado de cuenta");
        }
=======
>>>>>>> parent of 9736d37 (Completado Insert y Modificar FrmScrSolicitudEdicion y Carga de Datos FrmScrSolicitud)
    }
}
