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
    public partial class FrmSegRolEdicion : Form
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public FrmSegRolEdicion( string _tipoaccion)
        {
            InitializeComponent();
            TipoAccionRecibe = _tipoaccion;

            //Estilo de Controladores
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

        #region Funciones Principales del Formulario
        ClsVariablesGoblales globales = new ClsVariablesGoblales();
        ClsStbError RegistroError = new ClsStbError();

        String TipoAccionRecibe = "";

        ClsSegRoles Roles = null;
        internal ClsSegRoles Rols
        {
            set { Roles = value; }
        }

        private void FrmSegRolEdicion_Load(object sender, EventArgs e)
        {
            txtIdRol.Visible = false;

            if (TipoAccionRecibe == "AGREGAR")
            {
                txtIdRol.Text = "0";
                this.Text = "Agregar Rol";
            }
            else if (TipoAccionRecibe == "MODIFICAR")
            {
                if (Roles != null)
                {
                    this.Text = "Modificar Rol";
                    txtIdRol.Text = Roles.IdRol.ToString();
                    txtCodigo.Text = Roles.Codigo;
                    txtNombre.Text = Roles.NombreRol;
                    txtDescripcion.Text = Roles.Descripcion;
                    txtCodigo.Enabled = false;

                    //txtCodigo.Enabled = false;
                }
            }
        }
        #endregion


        #region Función - Cancelar
        //Limpiar los Campos del Formulario
        public void LimpiaCampos()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Función - Guardar y Actualizar Rol
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Error.Clear();
            if (txtCodigo.Text.TrimEnd() == "")
            {
                Error.SetError(txtCodigo, "Favor colocar un código para el rol.");
                return;
            }
            if (txtNombre.Text.TrimEnd() == "")
            {
                Error.SetError(txtNombre, "Favor colocar un nombre para el rol.");
                return;
            }
            try
            {
                ClsVariablesGoblales VariablesGlobales = new ClsVariablesGoblales();
                ClsSegRoles clsRol = new ClsSegRoles();
                clsRol.IdRol = int.Parse(txtIdRol.Text);
                clsRol.Codigo = txtCodigo.Text.ToUpper();
                clsRol.NombreRol = txtNombre.Text.ToUpper();
                clsRol.Descripcion = txtDescripcion.Text.ToUpper();
                clsRol.UsuarioCreacion = VariablesGlobales.RetornaLogin();

                //Se ejecuta si se va modificar el rol
                if (txtIdRol.Text != "0")
                {
                    if (clsRol.ModificaRol() == true)
                    {
                        MessageBox.Show(globales.MsgRegistroExitosoActualiza, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiaCampos();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(globales.MsgErrorValidarDatos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else // eso se jejecuta si se va agregar un rol
                {
                    if (VerificaCodigoDuplicado() == true)
                    {
                        Error.SetError(txtCodigo, "Código de rol ya existe.");
                        return;
                    }

                    if (clsRol.GuardaRol() == true)
                    {

                        MessageBox.Show(globales.MsgRegistroExitosoInserta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(globales.MsgErrorValidarDatos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
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


        #region Validaciones
        //Funcion que verifica si el codigo del rol ya existe 
        public bool VerificaCodigoDuplicado()
        {
            ClsSegRoles rol = new ClsSegRoles();
            DataTable Roles = new DataTable();
            Roles = rol.RolesXNombre("");
            bool ExisteRol = false;
            //i sera la variable que determine el registro que se va recorriendo
            for (int i = 0; i < Roles.Rows.Count; i++)
            {
                if (txtCodigo.Text == Roles.Rows[i][1].ToString())
                {
                    ExisteRol = true;
                    return ExisteRol;
                }
            }
            return ExisteRol;
        }
        #endregion
    }
}
