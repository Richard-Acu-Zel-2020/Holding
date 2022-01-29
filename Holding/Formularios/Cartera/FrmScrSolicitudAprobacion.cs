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
                txtFechaDesembolso.ReadOnly = true;
            }
        }
        #endregion

        #region "Función para Aprobar Solicitud"
        private void btnAprobar_Click(object sender, EventArgs e)
        {
            Error.Clear();

            #region "Validaciones del Botón Aprobar"

            if (string.IsNullOrWhiteSpace(txtObservacionComite.Text))
            {
                Error.SetError(txtObservacionComite, "Favor Ingrese la Observación del Comité");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTasaInteresCor.Text))
            {
                Error.SetError(txtTasaInteresCor, "Favor Ingrese la Tasa Interés Corriente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTasaInteresMor.Text))
            {
                Error.SetError(txtTasaInteresMor, "Favor Ingrese la Tasa Interés Moratoria");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMontoApro.Text))
            {
                Error.SetError(txtMontoApro, "Favor Ingrese el Monto Aprobado");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMontoComision.Text))
            {
                Error.SetError(txtMontoComision, "Favor Ingrese el Monto Comisión");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTasaComision.Text))
            {
                Error.SetError(txtTasaComision, "Favor Ingrese la Tasa Comisión");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPlazoAprobado.Text))
            {
                Error.SetError(txtPlazoAprobado, "Favor Ingrese el Plazo Aprobado");
                return;
            }

            if (cbxTipoMoneda.SelectedIndex == -1)
            {
                Error.SetError(cbxTipoMoneda, "Favor Seleccione el Tipo de Moneda");
                return;
            }

            if (cbxPeriocidadIntApro.SelectedIndex == -1)
            {
                Error.SetError(cbxPeriocidadIntApro, "Favor Seleccione la Periocidad de Interes Aprobada");
                return;
            }

            if (cbxPeriocidadPrinApro.SelectedIndex == -1)
            {
                Error.SetError(cbxPeriocidadPrinApro, "Favor Seleccione la Periocidad Principal Aprobada");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFechaDesembolso.Text))
            {
                Error.SetError(txtFechaDesembolso, "Favor Ingrese la Fecha de Desembolso");
                return;
            }
            #endregion

            try
            {
                DialogResult Result = new System.Windows.Forms.DialogResult();
                Result = MessageBox.Show("¿Seguro que desea Aprobar esta Solicitud?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Result == DialogResult.Yes)
                {
                    ClsScrSolicitudInversion gestion = new ClsScrSolicitudInversion();
                    gestion.IdSolicitud = int.Parse(txtIdSolicitud.Text);
                    gestion.ObservacionComite = txtObservacionComite.Text.ToUpper();
                    gestion.TasaInteresCorriente = Decimal.Parse(txtTasaInteresCor.Text);
                    gestion.TasaInteresMoratorio = Decimal.Parse(txtTasaInteresMor.Text);
                    gestion.MontoAprobado = Decimal.Parse(txtMontoApro.Text);
                    gestion.MontoComision = Decimal.Parse(txtMontoComision.Text);
                    gestion.TasaComision = Decimal.Parse(txtTasaComision.Text);
                    gestion.PlazoAprobado = int.Parse(txtPlazoAprobado.Text);
                    gestion.ObjMonedaID = int.Parse(cbxTipoMoneda.SelectedValue.ToString());
                    gestion.objPeriocidadInteresAproID = int.Parse(cbxPeriocidadIntApro.SelectedValue.ToString());
                    gestion.objPeriocidadPrincipalAproID = int.Parse(cbxPeriocidadPrinApro.SelectedValue.ToString());
                    gestion.FechaDesembolso = DateTime.Parse(txtFechaDesembolso.Text);
                    gestion.ObjEstadoSolicitudID = int.Parse(generales.IDCatalogoValorXCodigoCatalogo("AUT", "ESTADOSOLICITUDINVERSION").ToString());

                    if (txtIdSolicitud.Text != "0")
                    {
                        if (gestion.GestionarSolicitud() == true)
                        {
                            MessageBox.Show("Solicitud Aprobada con Éxito!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show(globales.MsgErrorValidarDatos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
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
       #endregion

        #region "Función para Reiniciar Campos"
        //Funcion para reiniciar los Campos
        public void LimpiarCampos()
        {
            txtIdSolicitud.Text = "";
            cbxEstadoSolicitud.ResetText();
            txtNumeroSolicitud.Text = "";
            txtNombreCliente.Text = "";
            txtObservacionComite.Text = "";
            txtTasaInteresCor.Text = "";
            txtTasaInteresMor.Text = "";
            txtMontoSolicitado.Text = "";
            txtMontoApro.Text = "";
            txtMontoComision.Text = "";
            txtTasaComision.Text = "";
            txtPlazoAprobado.Text = "";
            cbxTipoMoneda.ResetText();
            cbxPeriocidadIntApro.ResetText();
            cbxPeriocidadPrinApro.ResetText();
            txtFechaDesembolso.Text = "";
            chbxVencimiento.Checked = false;
        }

        #endregion

        #region "Función para Anular la Solicitud"
        private void btnAnular_Click(object sender, EventArgs e)
        {
            Error.Clear();

            #region "Validaciones del Botón Anular"

            if (string.IsNullOrWhiteSpace(txtObservacionComite.Text))
            {
                Error.SetError(txtObservacionComite, "Favor Ingrese la Observación del Comité");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTasaInteresCor.Text))
            {
                Error.SetError(txtTasaInteresCor, "Favor Ingrese la Tasa Interés Corriente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTasaInteresMor.Text))
            {
                Error.SetError(txtTasaInteresMor, "Favor Ingrese la Tasa Interés Moratoria");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMontoApro.Text))
            {
                Error.SetError(txtMontoApro, "Favor Ingrese el Monto Aprobado");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMontoComision.Text))
            {
                Error.SetError(txtMontoComision, "Favor Ingrese el Monto Comisión");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTasaComision.Text))
            {
                Error.SetError(txtTasaComision, "Favor Ingrese la Tasa Comisión");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPlazoAprobado.Text))
            {
                Error.SetError(txtPlazoAprobado, "Favor Ingrese el Plazo Aprobado");
                return;
            }

            if (cbxTipoMoneda.SelectedIndex == -1)
            {
                Error.SetError(cbxTipoMoneda, "Favor Seleccione el Tipo de Moneda");
                return;
            }

            if (cbxPeriocidadIntApro.SelectedIndex == -1)
            {
                Error.SetError(cbxPeriocidadIntApro, "Favor Seleccione la Periocidad de Interes Aprobada");
                return;
            }

            if (cbxPeriocidadPrinApro.SelectedIndex == -1)
            {
                Error.SetError(cbxPeriocidadPrinApro, "Favor Seleccione la Periocidad Principal Aprobada");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFechaDesembolso.Text))
            {
                Error.SetError(txtFechaDesembolso, "Favor Ingrese la Fecha de Desembolso");
                return;
            }
            #endregion

            try
            {
                DialogResult Result = new System.Windows.Forms.DialogResult();
                Result = MessageBox.Show("¿Seguro que desea Anular esta Solicitud?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Result == DialogResult.Yes)
                {
                    ClsScrSolicitudInversion gestiones = new ClsScrSolicitudInversion();
                    gestiones.IdSolicitud = int.Parse(txtIdSolicitud.Text);
                    gestiones.ObservacionComite = txtObservacionComite.Text.ToUpper();
                    gestiones.TasaInteresCorriente = Decimal.Parse(txtTasaInteresCor.Text);
                    gestiones.TasaInteresMoratorio = Decimal.Parse(txtTasaInteresMor.Text);
                    gestiones.MontoAprobado = Decimal.Parse(txtMontoApro.Text);
                    gestiones.MontoComision = Decimal.Parse(txtMontoComision.Text);
                    gestiones.TasaComision = Decimal.Parse(txtTasaComision.Text);
                    gestiones.PlazoAprobado = int.Parse(txtPlazoAprobado.Text);
                    gestiones.ObjMonedaID = int.Parse(cbxTipoMoneda.SelectedValue.ToString());
                    gestiones.objPeriocidadInteresAproID = int.Parse(cbxPeriocidadIntApro.SelectedValue.ToString());
                    gestiones.objPeriocidadPrincipalAproID = int.Parse(cbxPeriocidadPrinApro.SelectedValue.ToString());
                    gestiones.FechaDesembolso = DateTime.Parse(txtFechaDesembolso.Text);
                    gestiones.ObjEstadoSolicitudID = int.Parse(generales.IDCatalogoValorXCodigoCatalogo("RECH", "ESTADOSOLICITUDINVERSION").ToString());

                    if (txtIdSolicitud.Text != "0")
                    {
                        if (gestiones.GestionarSolicitud() == true)
                        {
                            MessageBox.Show("Solicitud Anulada con Éxito!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show(globales.MsgErrorValidarDatos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
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
