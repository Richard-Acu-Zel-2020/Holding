using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Device.Location;

namespace Holding
{
    public partial class FrmScrSolicitudEdicion : Form
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        FrmScrCalendario Calendario = new FrmScrCalendario();
        ClsFuncionesGenerales generales = new ClsFuncionesGenerales();
        ClsVariablesGoblales globales = new ClsVariablesGoblales();
        ClsStbError RegistroError = new ClsStbError();
        string TipoAccionRecibe = "";

        public FrmScrSolicitudEdicion(string _tipoaccion)
        {
            InitializeComponent();
            TipoAccionRecibe = _tipoaccion;

            //Estilo de Controladores
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

        #region "Funciones Principales del Formulario"
        ClsScrSolicitudInversion solicitudes = null;
        internal ClsScrSolicitudInversion solicitud
        {
            set { solicitudes = value; }
        }

        private void FrmScrSolicitudEdicion_Load(object sender, EventArgs e)
        {
            //Carga Datos de Moneda
            cbxTipoMoneda.DataSource = generales.TodosCatalogoValorXCatalogoActivos("MONEDA");
            cbxTipoMoneda.DisplayMember = "Valor";
            cbxTipoMoneda.ValueMember = "ID";
            cbxTipoMoneda.SelectedIndex = -1;

            //Carga Datos del Sector
            cbxSector.DataSource = generales.TodosCatalogoValorXCatalogoActivos("SECTORECONOMICO");
            cbxSector.DisplayMember = "Valor";
            cbxSector.ValueMember = "ID";
            cbxSector.SelectedIndex = -1;

            //Carga Datos de Sexo
            cbxSexo.DataSource = generales.TodosCatalogoValorXCatalogoActivos("SEXO");
            cbxSexo.DisplayMember = "Valor";
            cbxSexo.ValueMember = "ID";
            cbxSexo.SelectedIndex = -1;

            //Carga Datos de Estado Civil
            cbxEstadoCivil.DataSource = generales.TodosCatalogoValorXCatalogoActivos("ESTADOCIVIL");
            cbxEstadoCivil.DisplayMember = "Valor";
            cbxEstadoCivil.ValueMember = "ID";
            cbxEstadoCivil.SelectedIndex = -1;

            //Carga Datos del Tipo de Documento
            cbxTipoDocumentoDNI.DataSource = generales.TodosCatalogoValorXCatalogoActivos("TIPODOCUMENTOPERSONA");
            cbxTipoDocumentoDNI.DisplayMember = "Valor";
            cbxTipoDocumentoDNI.ValueMember = "ID";
            cbxTipoDocumentoDNI.SelectedIndex = -1;

            //Carga Datos de Tipo Persona
            cbxTipoPersona.DataSource = generales.TodosCatalogoValorXCatalogoActivos("TIPOPERSONACLIENTE");
            cbxTipoPersona.DisplayMember = "Valor";
            cbxTipoPersona.ValueMember = "ID";
            cbxTipoPersona.SelectedIndex = -1;

            //Carga Datos de Pais de Origen
            cbxPaisOrigen.DataSource = generales.TipodeUbicacionXUbicacionGeografica("PAIS");
            cbxPaisOrigen.DisplayMember = "Nombre";
            cbxPaisOrigen.ValueMember = "ID";
            cbxPaisOrigen.SelectedIndex = -1;

            //Carga Datos de Departamento
            cbxDepartamento.DataSource = generales.TipodeUbicacionXUbicacionGeografica("DEP");
            cbxDepartamento.DisplayMember = "Nombre";
            cbxDepartamento.ValueMember = "ID";
            cbxDepartamento.SelectedIndex = -1;

            //Carga Datos de Periocidad Interes
            cbxPeriocidadInteres.DataSource = generales.TodosCatalogoValorXCatalogoActivos("FRECUENCIAPAGO");
            cbxPeriocidadInteres.DisplayMember = "Valor";
            cbxPeriocidadInteres.ValueMember = "ID";
            cbxPeriocidadInteres.SelectedIndex = -1;

            //Carga Datos de Periocidad Principal
            cbxPeriocidadPrincipal.DataSource = generales.TodosCatalogoValorXCatalogoActivos("FRECUENCIAPAGO");
            cbxPeriocidadPrincipal.DisplayMember = "Valor";
            cbxPeriocidadPrincipal.ValueMember = "ID";
            cbxPeriocidadPrincipal.SelectedIndex = -1;

            txtFechaNacimiento.ReadOnly = true;
            txtFechaEmisionDNI.ReadOnly = true;
            txtFechaVencimientoDNI.ReadOnly = true;
            txtUbicacionLat.ReadOnly = true;
            txtUbicacionLon.ReadOnly = true;

            if (TipoAccionRecibe == "AGREGAR")
            {
                txtIdSolicitud.Text = "0";
            }
            else if (TipoAccionRecibe == "MODIFICAR")
            {

                if (solicitudes != null)
                {
                    this.Text = "Modificar Solicitudes de Inversión";
                    txtIdSolicitud.Text = solicitudes.IdSolicitud.ToString();
                    txtNumeroSolicitud.Text = solicitudes.NumSolicitud.ToString();
                    txtPrimerNombre.Text = solicitudes.Nombre1;
                    txtSegundoNombre.Text = solicitudes.Nombre2;
                    txtPrimerApellido.Text = solicitudes.Apellido1;
                    txtSegundoApellido.Text = solicitudes.Apellido2;
                    txtFechaNacimiento.Text = solicitudes.FechaNacimiento.ToShortDateString();
                    cbxTipoDocumentoDNI.SelectedValue = solicitudes.ObjTipoDocumentoID;
                    txtDNI.Text = solicitudes.DNI;
                    txtFechaEmisionDNI.Text = solicitudes.FechaNacimiento.ToShortDateString();
                    txtFechaVencimientoDNI.Text = solicitudes.FechaNacimiento.ToShortDateString();
                    cbxTipoPersona.SelectedValue = solicitudes.ObjTipoPersonaID;
                    cbxPaisOrigen.SelectedValue = solicitudes.ObjPaisOrigenID;
                    cbxSexo.SelectedValue = solicitudes.ObjSexoID;
                    cbxEstadoCivil.SelectedValue = solicitudes.ObjEstadoCivil;
                    txtCorreo.Text = solicitudes.CorreoElectronico;
                    txtTelefono1.Text = solicitudes.Telefono1.ToString();
                    txtTelefono2.Text = solicitudes.Telefono2.ToString();
                    txtObservacion.Text = solicitudes.Observacion;
                    txtUbicacionLat.Text = solicitudes.UbicacionLat.ToString();
                    txtUbicacionLon.Text = solicitudes.UbicacionLon.ToString();
                    cbxDepartamento.SelectedValue = solicitudes.objDepartamentoID;
                    cbxMunicipio.SelectedValue = solicitudes.objMunicipioID;
                    txtIdObligacion.Text = solicitudes.IdObligacion.ToString();
                    txtPropietario.Text = solicitudes.Propietario;
                    cbxSector.SelectedValue = solicitudes.ObjSectorID;
                    cbxTipoMoneda.SelectedValue = solicitudes.ObjMonedaID;
                    cbxPeriocidadInteres.SelectedValue = solicitudes.PeriocidadInt;
                    cbxPeriocidadPrincipal.SelectedValue = solicitudes.PeriocidadPrin;
                    txtMontoInversion.Text = solicitudes.Monto.ToString();

                    if (solicitudes.objTipoClienteID == 1079)
                    {
                        rbtnSofisticado.Checked = true;
                    }
                    else
                    {
                        rbtnSofisticado.Checked = false;
                    }

                    if (solicitudes.objTipoClienteID == 1080)
                    {
                        rbtnIndividual.Checked = true;
                    }
                    else
                    {
                        rbtnIndividual.Checked = false;
                    }

                    cbxEstadoSolicitud.SelectedValue = solicitudes.ObjEstadoSolicitudID;

                    txtNumeroSolicitud.ReadOnly = true;
                }
            }
        }
        #endregion

        #region "Carga de Municipio x Departamento"
        private void cbxDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxDepartamento.SelectedValue.ToString() != null)
            {
                cbxMunicipio.DataSource = generales.DepartamentoXMunicipio(int.Parse(cbxDepartamento.SelectedValue.ToString()));
                cbxMunicipio.DisplayMember = "Nombre";
                cbxMunicipio.ValueMember = "ID";
                cbxMunicipio.SelectedIndex = -1;
            }
        }
        #endregion

        #region "Botón de Calendario con su Función"
        private void btnFechaNacimiento_Click(object sender, EventArgs e)
        {
            txtFechaNacimiento.Text = "";
            Calendario.Location = new Point(540, 325);
            Calendario.ShowDialog();

            //-- Validación de Edad - Mayor de 18 Años --//
            DateTime Hoy = DateTime.Now;
            if (Calendario.fechavalor.AddYears(18) <= Hoy)
            {
                txtFechaNacimiento.Text = Calendario.fechavalor.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Tu Edad no cumple los Requisitos para dicha Solicitud", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnFechaEmisionDNI_Click(object sender, EventArgs e)
        {
            txtFechaEmisionDNI.Text = "";
            Calendario.Location = new Point(1350, 325);
            Calendario.ShowDialog();

            //-- Validación de  Fecha Emisión - Mayor a Futuro --//
            DateTime Hoy = DateTime.Now;
            if (Calendario.fechavalor < Hoy)
            {
                txtFechaEmisionDNI.Text = Calendario.fechavalor.ToShortDateString();
            }
            else
            {
                MessageBox.Show("La Fecha de Emisión no puede ser a Futuro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnFechaVenceDNI_Click(object sender, EventArgs e)
        {
            txtFechaVencimientoDNI.Text = "";
            Calendario.Location = new Point(1620, 325);
            Calendario.ShowDialog();

          //-- Validación de  Fecha Emisión - Diferencia de 1 Año --//
          try 
          { 
            if (DateTime.Parse(txtFechaEmisionDNI.Text).AddYears(1) <= Calendario.fechavalor)
            {
                txtFechaVencimientoDNI.Text = Calendario.fechavalor.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Cuenta con menos de 1 Año para la Caducidad del DNI", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          }
          catch 
          {
                MessageBox.Show("Debe Seleccionar Primero la Fecha de Emision del DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
          }
        }
        #endregion

        #region "Botón de Cancelar"
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Botón de Guardar con sus Validaciones"
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Error.Clear();

            #region "Validaciones del boton guardar"

            if (string.IsNullOrWhiteSpace(txtPrimerNombre.Text))
            {
                Error.SetError(txtPrimerNombre, "Favor Ingrese el Primer Nombre del Cliente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSegundoNombre.Text))
            {
                Error.SetError(txtSegundoNombre, "Favor Ingrese el Segundo Nombre del Cliente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrimerApellido.Text))
            {
                Error.SetError(txtPrimerApellido, "Favor Ingrese el Primer Apellido del Cliente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSegundoApellido.Text))
            {
                Error.SetError(txtSegundoApellido, "Favor Ingrese el Segundo Apellido del Cliente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFechaNacimiento.Text))
            {
                Error.SetError(txtFechaNacimiento, "Favor ingrese un email para el usuario");
                return;
            }

            if (cbxTipoDocumentoDNI.SelectedIndex == -1)
            {
                Error.SetError(cbxTipoDocumentoDNI, "Favor Seleccione el Tipo de Documento DNI");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                Error.SetError(txtDNI, "Favor Ingrese el DNI del Cliente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFechaEmisionDNI.Text))
            {
                Error.SetError(txtFechaEmisionDNI, "Favor Ingrese la Fecha de Emisión del DNI");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFechaVencimientoDNI.Text))
            {
                Error.SetError(txtFechaVencimientoDNI, "Favor Ingrese la Fecha de Vencimiento del DNI");
                return;
            }

            if (cbxTipoPersona.SelectedIndex == -1)
            {
                Error.SetError(cbxTipoPersona, "Favor Seleccione el Tipo de Persona");
                return;
            }

            if (cbxPaisOrigen.SelectedIndex == -1)
            {
                Error.SetError(cbxPaisOrigen, "Favor Seleccione el País de Origen");
                return;
            }

            if (cbxSexo.SelectedIndex == -1)
            {
                Error.SetError(cbxSexo, "Favor Seleccione el Tipo de Sexo");
                return;
            }

            if (cbxEstadoCivil.SelectedIndex == -1)
            {
                Error.SetError(cbxEstadoCivil, "Favor Seleccione el Estado Cívil");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                Error.SetError(txtCorreo, "Favor Ingrese el Correo Electrónico del Cliente");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono1.Text))
            {
                Error.SetError(txtTelefono1, "Favor Ingrese el Teléfono 1 del Cliente");
                return;
            }

            //if (string.IsNullOrWhiteSpace(txtTelefono2.Text))
            //{
            //    Error.SetError(txtTelefono2, "Favor Ingrese el Teléfono 2 del Cliente");
            //    return;
            //}

            if (string.IsNullOrWhiteSpace(txtUbicacionLat.Text))
            {
                Error.SetError(txtUbicacionLat, "Favor Ingrese la Ubicación");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtObservacion.Text))
            {
                Error.SetError(txtObservacion, "Favor Ingrese la Observación de la Solicitud");
                return;
            }

            if (cbxDepartamento.SelectedIndex == -1)
            {
                Error.SetError(cbxDepartamento, "Favor Seleccione el Departamento");
                return;
            }

            if (cbxMunicipio.SelectedIndex == -1)
            {
                Error.SetError(cbxMunicipio, "Favor Seleccione el Municipio");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtIdObligacion.Text))
            {
                Error.SetError(txtIdObligacion, "Favor Ingrese el Id de Obligación");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPropietario.Text))
            {
                Error.SetError(txtPropietario, "Favor Ingrese el Propietario");
                return;
            }

            if (cbxSector.SelectedIndex == -1)
            {
                Error.SetError(cbxSector, "Favor Seleccione el Tipo de Sector");
                return;
            }

            if (cbxTipoMoneda.SelectedIndex == -1)
            {
                Error.SetError(cbxTipoMoneda, "Favor Seleccione el Tipo de Moneda");
                return;
            }

            if (cbxPeriocidadInteres.SelectedIndex == -1)
            {
                Error.SetError(cbxPeriocidadInteres, "Favor Seleccione la Periocidad del Interes");
                return;
            }

            if (cbxPeriocidadPrincipal.SelectedIndex == -1)
            {
                Error.SetError(cbxPeriocidadPrincipal, "Favor Seleccione la Periocidad del Principal");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMontoInversion.Text))
            {
                Error.SetError(txtMontoInversion, "Favor Ingrese el Monto de la Solicitud");
                return;
            }

            if (rbtnIndividual.Checked == false & rbtnSofisticado.Checked == false)
            {
            Error.SetError(gbxTipoCliente, "Favor Seleccione el Tipo de Cliente");
            return;
            }
            #endregion

            try 
            { 
            DialogResult Result = new System.Windows.Forms.DialogResult();
            if (TipoAccionRecibe == "AGREGAR")
            {
                Result = MessageBox.Show("¿Está seguro que desea Guardar esta Solicitud?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else if (TipoAccionRecibe == "MODIFICAR")
            {
                Result = MessageBox.Show("¿Está seguro que desea Actualizar esta Solicitud?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (Result == DialogResult.Yes)
            {
                ClsScrSolicitudInversion solicitudes = new ClsScrSolicitudInversion();
                solicitudes.IdSolicitud = int.Parse(txtIdSolicitud.Text);
                solicitudes.Nombre1 = txtPrimerNombre.Text.ToUpper();
                solicitudes.Nombre2 = txtSegundoNombre.Text.ToUpper();
                solicitudes.Apellido1 = txtPrimerApellido.Text.ToUpper();
                solicitudes.Apellido2 = txtSegundoApellido.Text.ToUpper();
                solicitudes.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
                solicitudes.ObjTipoDocumentoID = int.Parse(cbxTipoDocumentoDNI.SelectedValue.ToString());
                solicitudes.DNI = txtDNI.Text;
                solicitudes.FechaEmision = DateTime.Parse(txtFechaEmisionDNI.Text);
                solicitudes.FechaVencimiento = DateTime.Parse(txtFechaVencimientoDNI.Text);
                solicitudes.ObjTipoPersonaID = int.Parse(cbxTipoPersona.SelectedValue.ToString());
                solicitudes.ObjPaisOrigenID = int.Parse(cbxPaisOrigen.SelectedValue.ToString());
                solicitudes.ObjSexoID = int.Parse(cbxSexo.SelectedValue.ToString());
                solicitudes.ObjEstadoCivil = int.Parse(cbxEstadoCivil.SelectedValue.ToString());
                solicitudes.CorreoElectronico = txtCorreo.Text;
                solicitudes.Telefono1 = int.Parse(txtTelefono1.Text);
                solicitudes.Telefono2 = int.Parse(txtTelefono2.Text);
                solicitudes.Observacion = txtObservacion.Text.ToUpper();
                solicitudes.UbicacionLat = double.Parse(txtUbicacionLat.Text);
                solicitudes.UbicacionLon = double.Parse(txtUbicacionLon.Text);
                solicitudes.objDepartamentoID = int.Parse(cbxDepartamento.SelectedValue.ToString());
                solicitudes.objMunicipioID = int.Parse(cbxMunicipio.SelectedValue.ToString());
                solicitudes.IdObligacion = int.Parse(txtIdObligacion.Text);
                solicitudes.Propietario = txtPropietario.Text.ToUpper();
                solicitudes.ObjSectorID = int.Parse(cbxSector.SelectedValue.ToString());
                solicitudes.ObjMonedaID = int.Parse(cbxTipoMoneda.SelectedValue.ToString());
                solicitudes.PeriocidadInt = int.Parse(cbxPeriocidadInteres.SelectedValue.ToString());
                solicitudes.PeriocidadPrin = int.Parse(cbxPeriocidadPrincipal.SelectedValue.ToString());
                solicitudes.Monto = Decimal.Parse(txtMontoInversion.Text);
                solicitudes.ObjEstadoSolicitudID = int.Parse(generales.IDCatalogoValorXCodigoCatalogo("REG", "ESTADOSOLICITUDINVERSION").ToString());

                if (rbtnIndividual.Checked == true)
                {
                    solicitudes.objTipoClienteID = int.Parse(generales.IDCatalogoValorXCodigoCatalogo("INDIVIDUAL", "TIPOCLIENTE").ToString());
                }
                else
                {
                    solicitudes.objTipoClienteID = int.Parse(generales.IDCatalogoValorXCodigoCatalogo("SOFISTICADO", "TIPOCLIENTE").ToString());
                }

                if (txtIdSolicitud.Text != "0")
                {
                    if (solicitudes.ModificarSolicitud() == true)
                    {
                      MessageBox.Show("Solicitud Actualizada con Éxito!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      this.Close();
                      LimpiarCampos();
                    }
                    else
                    {
                      MessageBox.Show(globales.MsgErrorValidarDatos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      return;
                    }
                }
                else
                {
                    if (solicitudes.GuardaSolicitud() == true)
                    {
                      MessageBox.Show("Solicitud Guardada con Éxito!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      LimpiarCampos();
                      this.Close();
                    }
                    else
                    {
                      MessageBox.Show(globales.MsgErrorValidarDatos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      return;
                    }
                }
            }
        } 
            catch(Exception IO)
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
            txtPrimerNombre.Text = "";
            txtSegundoNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            txtFechaNacimiento.Text = "";
            cbxTipoDocumentoDNI.ResetText();
            txtDNI.Text = "";
            txtFechaEmisionDNI.Text = "";
            txtFechaVencimientoDNI.Text = "";
            cbxTipoPersona.ResetText();
            cbxPaisOrigen.ResetText();
            cbxSexo.ResetText();
            cbxEstadoCivil.ResetText();
            txtCorreo.Text = "";
            txtTelefono1.Text = "";
            txtTelefono2.Text = "";
            txtObservacion.Text = "";
            txtUbicacionLat.Text = "";
            txtUbicacionLon.Text = "";
            txtIdObligacion.Text = "";
            txtPropietario.Text = "";
            cbxSector.ResetText();
            cbxTipoMoneda.ResetText();
            cbxPeriocidadInteres.ResetText();
            cbxPeriocidadPrincipal.ResetText();
            txtMontoInversion.Text = "";
            rbtnSofisticado.Checked = false;
            rbtnIndividual.Checked = false;
        }
        #endregion

        #region "Botón para Mostrar las Coordenas Latitud y Longitud"
        private void btnUbicacion_Click(object sender, EventArgs e)
        {
            GeoCoordinateWatcher oWatcher = new GeoCoordinateWatcher();
            oWatcher.PositionChanged += (S, E) =>
            {
                var oCoordinate = E.Position.Location;
                txtUbicacionLat.Text = oCoordinate.Latitude.ToString();
                txtUbicacionLon.Text = oCoordinate.Longitude.ToString();
            };
            oWatcher.Start();
        }
        #endregion

    }
}
