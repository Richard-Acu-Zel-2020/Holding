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
    public partial class FrmScrSolicitudAprobacion : Form
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        ClsFuncionesGenerales generales = new ClsFuncionesGenerales();
        ClsVariablesGoblales globales = new ClsVariablesGoblales();
        ClsStbError RegistroError = new ClsStbError();

        public FrmScrSolicitudAprobacion()
        {
            InitializeComponent();

            //Estilo de Controladores
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

        #region "Funciones Principales del Formulario"
        ClsScrSolicitudInversion gestiones = null;
        internal ClsScrSolicitudInversion solicitud
        {
            set { gestiones = value; }
        }

        private void FrmScrSolicitudAprobacion_Load(object sender, EventArgs e)
        {
            //Carga Datos de Moneda
            cbxTipoMoneda.DataSource = generales.TodosCatalogoValorXCatalogoActivos("MONEDA");
            cbxTipoMoneda.DisplayMember = "Valor";
            cbxTipoMoneda.ValueMember = "ID";
            cbxTipoMoneda.SelectedIndex = -1;
            
            //Carga Datos de Periocidad Interes Apro
            cbxPeriocidadIntApro.DataSource = generales.TodosCatalogoValorXCatalogoActivos("FRECUENCIAPAGO");
            cbxPeriocidadIntApro.DisplayMember = "Valor";
            cbxPeriocidadIntApro.ValueMember = "ID";
            cbxPeriocidadIntApro.SelectedIndex = -1;

            //Carga Datos de Periocidad Principal Apro
            cbxPeriocidadPrinApro.DataSource = generales.TodosCatalogoValorXCatalogoActivos("FRECUENCIAPAGO");
            cbxPeriocidadPrinApro.DisplayMember = "Valor";
            cbxPeriocidadPrinApro.ValueMember = "ID";
            cbxPeriocidadPrinApro.SelectedIndex = -1;

            //Carga Datos de Estado Solicitud
            cbxEstadoSolicitud.DataSource = generales.TodosCatalogoValorXCatalogoActivos("ESTADOSOLICITUDINVERSION");
            cbxEstadoSolicitud.DisplayMember = "Valor";
            cbxEstadoSolicitud.ValueMember = "ID";
            cbxEstadoSolicitud.SelectedIndex = -1;

            if (gestiones != null)
            {
                txtIdSolicitud.Text = gestiones.IdSolicitud.ToString();
                txtNumeroSolicitud.Text = gestiones.NumSolicitud.ToString();
                txtNombreCliente.Text = gestiones.Nombre1 + ' ' + gestiones.Nombre2 + ' ' + gestiones.Apellido1 + ' ' + gestiones.Apellido2;
                txtPropietario.Text = gestiones.Propietario;
                cbxTipoMoneda.SelectedValue = gestiones.ObjMonedaID;
                txtMontoSolicitado.Text = gestiones.Monto.ToString();
                cbxEstadoSolicitud.SelectedValue = gestiones.ObjEstadoSolicitudID;

                txtNumeroSolicitud.ReadOnly = true;
                txtNombreCliente.ReadOnly = true;
                txtPropietario.ReadOnly = true;
                txtMontoSolicitado.ReadOnly = true;
            }
        }
        #endregion

        #region "Función para Aprobar Solicitud"
        private void btnAprobar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DialogResult Result = new System.Windows.Forms.DialogResult();
            //    Result = MessageBox.Show("¿Seguro que desea Aprobar esta Solicitud?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (Result == DialogResult.Yes)
            //    {
            //        ClsScrSolicitudInversion gestion = new ClsScrSolicitudInversion();
            //        gestion.IdSolicitud = int.Parse(txtIdSolicitud.Text);
            //        gestion.Nombre1 = txtPrimerNombre.Text.ToUpper();
            //        gestion.Nombre2 = txtSegundoNombre.Text.ToUpper();
            //        gestion.Apellido1 = txtPrimerApellido.Text.ToUpper();
            //        gestion.Apellido2 = txtSegundoApellido.Text.ToUpper();
            //        gestion.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            //        gestion.ObjTipoDocumentoID = int.Parse(cbxTipoDocumentoDNI.SelectedValue.ToString());
            //        gestion.DNI = txtDNI.Text;
            //        gestion.FechaEmision = DateTime.Parse(txtFechaEmisionDNI.Text);
            //        gestion.FechaVencimiento = DateTime.Parse(txtFechaVencimientoDNI.Text);
            //        gestion.ObjTipoPersonaID = int.Parse(cbxTipoPersona.SelectedValue.ToString());
            //        gestion.ObjPaisOrigenID = int.Parse(cbxPaisOrigen.SelectedValue.ToString());
            //        gestion.ObjSexoID = int.Parse(cbxSexo.SelectedValue.ToString());
            //        gestion.ObjEstadoCivil = int.Parse(cbxEstadoCivil.SelectedValue.ToString());
            //        gestion.CorreoElectronico = txtCorreo.Text;
            //        gestion.Telefono1 = int.Parse(txtTelefono1.Text);
            //        gestion.Telefono2 = int.Parse(txtTelefono2.Text);
            //        gestion.Observacion = txtObservacion.Text.ToUpper();
            //        gestion.UbicacionLat = double.Parse(txtUbicacionLat.Text);
            //        gestion.UbicacionLon = double.Parse(txtUbicacionLon.Text);
            //        gestion.IdObligacion = int.Parse(txtIdObligacion.Text);
            //        gestion.Propietario = txtPropietario.Text.ToUpper();
            //        gestion.ObjSectorID = int.Parse(cbxSector.SelectedValue.ToString());
            //        gestion.ObjMonedaID = int.Parse(cbxTipoMoneda.SelectedValue.ToString());
            //        gestion.PeriocidadInt = int.Parse(cbxPeriocidadInteres.SelectedValue.ToString());
            //        gestion.PeriocidadPrin = int.Parse(cbxPeriocidadPrincipal.SelectedValue.ToString());
            //        gestion.Monto = Decimal.Parse(txtMontoInversion.Text);
            //        gestion.ObjEstadoSolicitudID = int.Parse(generales.IDCatalogoValorXCodigoCatalogo("AUT", "ESTADOSOLICITUDINVERSION").ToString());

            //        if (rbtnIndividual.Checked == true)
            //        {
            //            gestion.objTipoClienteID = int.Parse(generales.IDCatalogoValorXCodigoCatalogo("INDIVIDUAL", "TIPOCLIENTE").ToString());
            //        }
            //        else
            //        {
            //            gestion.objTipoClienteID = int.Parse(generales.IDCatalogoValorXCodigoCatalogo("SOFISTICADO", "TIPOCLIENTE").ToString());
            //        }

            //        if (txtIdSolicitud.Text != "0")
            //        {
            //            if (gestion.ModificarSolicitud() == true)
            //            {
            //                MessageBox.Show("Solicitud Aprobada con Éxito!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                this.Close();
            //                LimpiarCampos();
            //            }
            //            else
            //            {
            //                MessageBox.Show(globales.MsgErrorValidarDatos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                return;
            //            }
            //        }
            //    }
            //}
            //catch (Exception IO)
            //{
            //    RegistroError.Formulario = this.ToString();
            //    RegistroError.DetalleError = IO.ToString();
            //    RegistroError.GuardaError();
            //    FrmError frmError = new FrmError(globales.MsgError, IO.ToString(), globales.MsgErrorFinal);
            //    this.Cursor = Cursors.Default;
            //    frmError.ShowDialog();
            //    return;
            //}
        }
#endregion

        #region "Función para Reiniciar Campos"
        //Funcion para reiniciar los Campos
        public void LimpiarCampos()
        {
            //txtIdSolicitud.Text = "";
            //cbxEstadoSolicitud.ResetText();
            //txtNumeroSolicitud.Text = "";
            //txtPrimerNombre.Text = "";
            //txtSegundoNombre.Text = "";
            //txtPrimerApellido.Text = "";
            //txtSegundoApellido.Text = "";
            //txtFechaNacimiento.Text = "";
            //cbxTipoDocumentoDNI.ResetText();
            //txtDNI.Text = "";
            //txtFechaEmisionDNI.Text = "";
            //txtFechaVencimientoDNI.Text = "";
            //cbxTipoPersona.ResetText();
            //cbxPaisOrigen.ResetText();
            //cbxSexo.ResetText();
            //cbxEstadoCivil.ResetText();
            //txtCorreo.Text = "";
            //txtTelefono1.Text = "";
            //txtTelefono2.Text = "";
            //txtObservacion.Text = "";
            //txtUbicacionLat.Text = "";
            //txtUbicacionLon.Text = "";
            //txtIdObligacion.Text = "";
            //txtPropietario.Text = "";
            //cbxSector.ResetText();
            //cbxTipoMoneda.ResetText();
            //cbxPeriocidadInteres.ResetText();
            //cbxPeriocidadPrincipal.ResetText();
            //txtMontoInversion.Text = "";
            //rbtnSofisticado.Checked = false;
            //rbtnIndividual.Checked = false;
        }

        #endregion

        #region "Función para Anular la Solicitud"
        private void btnAnular_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    DialogResult Result = new System.Windows.Forms.DialogResult();
            //    Result = MessageBox.Show("¿Seguro que desea Anular esta Solicitud?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //    if (Result == DialogResult.Yes)
            //    {
            //        ClsScrSolicitudInversion gestiones = new ClsScrSolicitudInversion();
            //        gestiones.IdSolicitud = int.Parse(txtIdSolicitud.Text);
            //        gestiones.Nombre1 = txtPrimerNombre.Text.ToUpper();
            //        gestiones.Nombre2 = txtSegundoNombre.Text.ToUpper();

            //        gestiones.Apellido1 = txtPrimerApellido.Text.ToUpper();
            //        gestiones.Apellido2 = txtSegundoApellido.Text.ToUpper();
            //        gestiones.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            //        gestiones.ObjTipoDocumentoID = int.Parse(cbxTipoDocumentoDNI.SelectedValue.ToString());
            //        gestiones.DNI = txtDNI.Text;
            //        gestiones.FechaEmision = DateTime.Parse(txtFechaEmisionDNI.Text);
            //        gestiones.FechaVencimiento = DateTime.Parse(txtFechaVencimientoDNI.Text);
            //        gestiones.ObjTipoPersonaID = int.Parse(cbxTipoPersona.SelectedValue.ToString());
            //        gestiones.ObjPaisOrigenID = int.Parse(cbxPaisOrigen.SelectedValue.ToString());
            //        gestiones.ObjSexoID = int.Parse(cbxSexo.SelectedValue.ToString());
            //        gestiones.ObjEstadoCivil = int.Parse(cbxEstadoCivil.SelectedValue.ToString());
            //        gestiones.CorreoElectronico = txtCorreo.Text;
            //        gestiones.Telefono1 = int.Parse(txtTelefono1.Text);
            //        gestiones.Telefono2 = int.Parse(txtTelefono2.Text);
            //        gestiones.Observacion = txtObservacion.Text.ToUpper();
            //        gestiones.UbicacionLat = double.Parse(txtUbicacionLat.Text);
            //        gestiones.UbicacionLon = double.Parse(txtUbicacionLon.Text);
            //        gestiones.IdObligacion = int.Parse(txtIdObligacion.Text);
            //        gestiones.Propietario = txtPropietario.Text.ToUpper();
            //        gestiones.ObjSectorID = int.Parse(cbxSector.SelectedValue.ToString());
            //        gestiones.ObjMonedaID = int.Parse(cbxTipoMoneda.SelectedValue.ToString());
            //        gestiones.PeriocidadInt = int.Parse(cbxPeriocidadInteres.SelectedValue.ToString());
            //        gestiones.PeriocidadPrin = int.Parse(cbxPeriocidadPrincipal.SelectedValue.ToString());
            //        gestiones.Monto = Decimal.Parse(txtMontoInversion.Text);
            //        gestiones.ObjEstadoSolicitudID = int.Parse(generales.IDCatalogoValorXCodigoCatalogo("RECH", "ESTADOSOLICITUDINVERSION").ToString());

            //        if (rbtnIndividual.Checked == true)
            //        {
            //            gestiones.objTipoClienteID = int.Parse(generales.IDCatalogoValorXCodigoCatalogo("INDIVIDUAL", "TIPOCLIENTE").ToString());
            //        }
            //        else
            //        {
            //            gestiones.objTipoClienteID = int.Parse(generales.IDCatalogoValorXCodigoCatalogo("SOFISTICADO", "TIPOCLIENTE").ToString());
            //        }

            //        if (txtIdSolicitud.Text != "0")
            //        {
            //            if (gestiones.ModificarSolicitud() == true)
            //            {
            //                MessageBox.Show("Solicitud Anulada con Éxito!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                this.Close();
            //                LimpiarCampos();
            //            }
            //            else
            //            {
            //                MessageBox.Show(globales.MsgErrorValidarDatos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //                return;
            //            }
            //        }
            //    }
            //}
            //catch (Exception IO)
            //{
            //    RegistroError.Formulario = this.ToString();
            //    RegistroError.DetalleError = IO.ToString();
            //    RegistroError.GuardaError();
            //    FrmError frmError = new FrmError(globales.MsgError, IO.ToString(), globales.MsgErrorFinal);
            //    this.Cursor = Cursors.Default;
            //    frmError.ShowDialog();
            //    return;
            //}
        }
        #endregion

        #region "Función para Mostrar el Calendario"
        private void btnFechaNacimiento_Click(object sender, EventArgs e)
        {
            FrmScrCalendario Calendario = new FrmScrCalendario();
            Calendario.Location = new Point(1120, 650);
            Calendario.ShowDialog();
            txtFechaDesembolso.Text = Calendario.fechavalor.ToShortDateString();
        }
        #endregion
    }
}
