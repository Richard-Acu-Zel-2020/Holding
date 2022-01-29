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

    public partial class FrmScrSolicitud : Form
    {

        public FrmScrSolicitud()
        {
            InitializeComponent();
        }

        ClsVariablesGoblales globales = new ClsVariablesGoblales();
        ClsStbError RegistroError = new ClsStbError();

        private void FrmScrSolicitud_Load(object sender, EventArgs e)
        {
            Carga();
        }

        #region "Botón Agregar"
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string TipoAccion = "";
            TipoAccion = "AGREGAR";

            FrmScrSolicitudEdicion Solicitudes = new FrmScrSolicitudEdicion(TipoAccion);
            Solicitudes.ShowDialog();
            Carga();
        }
        #endregion

        #region "Botón Modificar"
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarSolicitud();
        }
        #endregion

        #region "Función para Cargar Datos al Formulario de Solicitud Edición"
        public void ModificarSolicitud()
        {
            string TipoAccion = "";
            TipoAccion = "MODIFICAR";

            if (dgvSolicitudes.RowCount > 0)
            {
                try
                {
                    ClsScrSolicitudInversion clsSolicitud = new ClsScrSolicitudInversion();
                    FrmScrSolicitudEdicion SolicitudInversion = new FrmScrSolicitudEdicion(TipoAccion);
                    clsSolicitud.IdSolicitud = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[0].Value.ToString());
                    clsSolicitud.NumSolicitud = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[1].Value.ToString());
                    clsSolicitud.Nombre1 = dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[2].Value.ToString();
                    clsSolicitud.Nombre2 = dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[3].Value.ToString();
                    clsSolicitud.Apellido1 = dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[4].Value.ToString();
                    clsSolicitud.Apellido2 = dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[5].Value.ToString();
                    clsSolicitud.FechaNacimiento = DateTime.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[6].Value.ToString());
                    clsSolicitud.ObjTipoDocumentoID = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[32].Value.ToString());
                    clsSolicitud.DNI = dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[8].Value.ToString();
                    clsSolicitud.FechaEmision = DateTime.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[9].Value.ToString());
                    clsSolicitud.FechaVencimiento = DateTime.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[10].Value.ToString());
                    clsSolicitud.ObjTipoPersonaID = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[33].Value.ToString());
                    clsSolicitud.ObjPaisOrigenID = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[34].Value.ToString());
                    clsSolicitud.ObjSexoID = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[35].Value.ToString());
                    clsSolicitud.ObjEstadoCivil = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[36].Value.ToString());
                    clsSolicitud.CorreoElectronico = dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[15].Value.ToString();
                    clsSolicitud.Telefono1 = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[16].Value.ToString());
                    clsSolicitud.Telefono2 = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[17].Value.ToString());
                    clsSolicitud.Observacion = dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[18].Value.ToString();
                    clsSolicitud.UbicacionLat = double.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[19].Value.ToString());
                    clsSolicitud.UbicacionLon = double.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[20].Value.ToString());
                    clsSolicitud.objDepartamentoID = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[37].Value.ToString());
                    clsSolicitud.objMunicipioID = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[38].Value.ToString());
                    clsSolicitud.IdObligacion = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[23].Value.ToString());
                    clsSolicitud.Propietario = dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[24].Value.ToString();
                    clsSolicitud.ObjSectorID = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[39].Value.ToString());
                    clsSolicitud.ObjMonedaID = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[40].Value.ToString());
                    clsSolicitud.PeriocidadInt = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[41].Value.ToString());
                    clsSolicitud.PeriocidadPrin = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[42].Value.ToString());
                    clsSolicitud.Monto = Decimal.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[29].Value.ToString());
                    clsSolicitud.objTipoClienteID = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[43].Value.ToString());
                    clsSolicitud.ObjEstadoSolicitudID = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[44].Value.ToString());
                    SolicitudInversion.solicitud = clsSolicitud;
                    SolicitudInversion.ShowDialog();
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

        #region "Función para Cargar Datos"
        public void Carga()
        {
            ClsScrSolicitudInversion clsSolicitud = new ClsScrSolicitudInversion();
            dgvSolicitudes.DataSource = clsSolicitud.SolicitudInversion();
            dgvSolicitudes.Columns[0].Visible = false;

            dgvSolicitudes.Columns[32].Visible = false;
            dgvSolicitudes.Columns[33].Visible = false;
            dgvSolicitudes.Columns[34].Visible = false;
            dgvSolicitudes.Columns[35].Visible = false;
            dgvSolicitudes.Columns[36].Visible = false;
            dgvSolicitudes.Columns[37].Visible = false;
            dgvSolicitudes.Columns[38].Visible = false;
            dgvSolicitudes.Columns[39].Visible = false;
            dgvSolicitudes.Columns[40].Visible = false;
            dgvSolicitudes.Columns[40].Visible = false;
            dgvSolicitudes.Columns[41].Visible = false;
            dgvSolicitudes.Columns[42].Visible = false;
            dgvSolicitudes.Columns[43].Visible = false;
            dgvSolicitudes.Columns[44].Visible = false;
            dgvSolicitudes.Columns[1].Width = 70;
            lblContador.Text = String.Format("{0:N0}", double.Parse(dgvSolicitudes.RowCount.ToString()));
        }
        #endregion

        #region "Función Buscar x Nombre"
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ClsScrSolicitudInversion clsSolicitud = new ClsScrSolicitudInversion();
            dgvSolicitudes.DataSource = clsSolicitud.BuscarSolicitudInversion(txtBuscar.Text);
            lblContador.Text = String.Format("{0:N0}", double.Parse(dgvSolicitudes.RowCount.ToString()));
        }
        #endregion

        #region "Función para Cargar Datos al Formulario de Gestión"
        public void GestionarSolicitud()
        {
            if (dgvSolicitudes.RowCount > 0)
            {
                try
                {
                    ClsScrSolicitudInversion clsSolicitud = new ClsScrSolicitudInversion();
                    FrmScrSolicitudAprobacion SolicitudGestion = new FrmScrSolicitudAprobacion();
                    clsSolicitud.IdSolicitud = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[0].Value.ToString());
                    clsSolicitud.NumSolicitud = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[1].Value.ToString());
                    clsSolicitud.Nombre1 = dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[2].Value.ToString();
                    clsSolicitud.Nombre2 = dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[3].Value.ToString();
                    clsSolicitud.Apellido1 = dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[4].Value.ToString();
                    clsSolicitud.Apellido2 = dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[5].Value.ToString();
                    clsSolicitud.Propietario = dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[24].Value.ToString();
                    clsSolicitud.ObjMonedaID = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[40].Value.ToString());
                    clsSolicitud.Monto = Decimal.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[29].Value.ToString());
                    clsSolicitud.ObjEstadoSolicitudID = int.Parse(dgvSolicitudes.Rows[dgvSolicitudes.SelectedRows[0].Index].Cells[44].Value.ToString());
                    SolicitudGestion.solicitud = clsSolicitud;
                    SolicitudGestion.ShowDialog();
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

        #region "Botón Gestionar"
        private void btnGestion_Click(object sender, EventArgs e)
        {
            GestionarSolicitud();
        }
        #endregion

    }
}
