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

namespace Holding
{
    public partial class FrmSegUsuarioEdicion : Form
    {

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public FrmSegUsuarioEdicion(string _tipoaccion)
        {
            InitializeComponent();
            TipoAccionRecibe = _tipoaccion;
            
            //Estilo de Controladores
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

        #region Clases Principales del Formulario
        //Clase de Usuario para Transferencia de Datos
        ClsSegUsuario usuarios = null;
        internal ClsSegUsuario Users
        {
            set { usuarios = value; }
        }

        ClsVariablesGoblales globales = new ClsVariablesGoblales();
        ClsStbError RegistroError = new ClsStbError();

        string TipoAccionRecibe = "";

        //Función para Cargar los Datos del Formulario
        private void FrmSegUsuarioEdicion_Load(object sender, EventArgs e)
        {
            ClsSegRoles clsrol = new ClsSegRoles();
            ClsEncripta encripta = new ClsEncripta();

            txtIdUsuario.Visible = false;

            cbxIdRol.DataSource = clsrol.RolesXNombre("");
            cbxIdRol.DisplayMember = "Nombre";
            cbxIdRol.ValueMember = "ID";
            cbxIdRol.SelectedIndex = -1;

            if (TipoAccionRecibe == "AGREGAR")
            {
                txtIdUsuario.Text = "0";
                this.Text = "Agregar Usuario";
                ckActivo.Enabled = false;
                ckActivo.Checked = true;
            }
            else if (TipoAccionRecibe == "MODIFICAR")
            {
                if (usuarios != null)
                {
                    this.Text = "Modificar Usuario";
                    txtPrimerNom.Text = usuarios.PrimerNombre;
                    txtSegNom.Text = usuarios.SegundoNombre;
                    txtPrimApellido.Text = usuarios.PrimerApellido;
                    txtSegApellido.Text = usuarios.SegundoApellido;
                    txtCedula.Text = usuarios.Cedula;
                    txtEmail.Text = usuarios.CorreoLaboral;
                    txtIdUsuario.Text = usuarios.Idusuario.ToString();
                    txtUsuario.Text = usuarios.Login;
                    txtContrasena.Text = encripta.Desencriptar(usuarios.Clave);

                    if (usuarios.Activo == 1)
                        ckActivo.Checked = true;
                    else
                        ckActivo.Checked = false;
                    ckActivo.Enabled = true;
                    cbxIdRol.SelectedValue = usuarios.IdRol;


                    txtPrimerNom.Enabled = false;
                    txtSegNom.Enabled = false;
                    txtPrimApellido.Enabled = false;
                    txtSegApellido.Enabled = false;
                    txtCedula.Enabled = false;
                    cbxIdRol.Enabled = false;
                }
            }
        }
        #endregion


        #region Función - Guardar y Actualizar Usuario
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClsFuncionesGenerales grales = new ClsFuncionesGenerales();
           
            //Validaciones - Para TextBoxs Vacíos
            Error.Clear();
            if (string.IsNullOrWhiteSpace(txtPrimerNom.Text))
            {
                Error.SetError(txtPrimerNom, "Favor ingrese el primer nombre para el usuario");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSegNom.Text))
            {
                Error.SetError(txtSegNom, "Favor ingrese el segundo nombre para el usuario");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPrimApellido.Text))
            {
                Error.SetError(txtPrimApellido, "Favor ingrese el primer apellido para el usuario");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSegApellido.Text))
            {
                Error.SetError(txtSegApellido, "Favor ingrese el segundo apellido para el usuario");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCedula.Text))
            {
                Error.SetError(txtCedula, "Favor ingrese la cedula para el usuario");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                Error.SetError(txtEmail, "Favor ingrese un email para el usuario");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                Error.SetError(txtUsuario, "Favor ingrese un login para el usuario");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                Error.SetError(txtContrasena, "Favor ingrese una clave para el usuario");
                return;
            }

            if (cbxIdRol.SelectedIndex == -1)
            {
                Error.SetError(cbxIdRol, "Favor seleccione un rol para el usuario");
                return;
            }

            try
            {
                DialogResult Result = new System.Windows.Forms.DialogResult();
                if (TipoAccionRecibe == "AGREGAR")
                {
                    Result = MessageBox.Show("¿Está seguro que desea agregar este Usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else if (TipoAccionRecibe == "MODIFICAR")
                {
                    Result = MessageBox.Show("¿Está seguro que desea actualizar este Usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                if (Result == DialogResult.Yes)
                {
                    txtUsuario.Text = txtUsuario.Text.ToUpper();

                    ClsSegUsuario User = new ClsSegUsuario();
                    ClsEncripta encripta = new ClsEncripta();
                    User.Idusuario = int.Parse(txtIdUsuario.Text);
                    User.PrimerNombre = txtPrimerNom.Text.ToUpper();
                    User.SegundoNombre = txtSegNom.Text.ToUpper();
                    User.PrimerApellido = txtPrimApellido.Text.ToUpper();
                    User.SegundoApellido = txtSegApellido.Text.ToUpper();
                    User.Cedula = txtCedula.Text.ToUpper();
                    User.CorreoLaboral = txtEmail.Text;
                    User.Login = txtUsuario.Text.ToUpper();
                    User.Clave = encripta.Encriptar(txtContrasena.Text);
                    User.Activo = 1;
                    User.IdRol = int.Parse(cbxIdRol.SelectedValue.ToString());

                    if (txtIdUsuario.Text != "0")
                    {
                        if (ckActivo.Checked == false)
                            User.Activo = 0;

                        if (User.ModificaUsuario() == true)
                        {
                            MessageBox.Show(globales.MsgRegistroExitosoActualiza, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            LimpiarCampos();
                          //ckActivo.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show(globales.MsgErrorValidarDatos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        if (txtContrasena.Text.Length < int.Parse(grales.ValorParametro("LONGITUDMINIMACLAVE").Rows[0][0].ToString()))
                        {
                            Error.SetError(txtContrasena, "La clave debe tener al menos " + grales.ValorParametro("LONGITUDMINIMACLAVE").Rows[0][0].ToString() + " digitos");
                            return;
                        }

                        if (VerificaComplejidad() == false)
                        {
                            Error.SetError(txtContrasena, "La clave debe llevar al menos una letra mayúscula, una minúscula y un número.");
                            return;
                        }
                        if (VerificaCodigoDuplicado(txtUsuario.Text) == true)
                        {
                            Error.SetError(txtUsuario, "El usuario ya existe, favor ingresar un código diferente");
                            return;
                        }
                        if (User.GuardaUsuario() == true)
                        {
                            MessageBox.Show(globales.MsgRegistroExitosoInserta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            this.Close();
                            
                            //ckActivo.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show(globales.MsgErrorValidarDatos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }
                else
                {
                    return;
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


        #region Función - Cancelar
   
        //Funcion para reiniciar los Campos
        public void LimpiarCampos()
        {
            txtPrimerNom.Text = "";
            txtSegNom.Text = "";
            txtPrimApellido.Text = "";
            txtSegApellido.Text = "";
            txtCedula.Text = "";
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
            cbxIdRol.ResetText();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion


        #region Validaciones
        private void txtPrimApellido_Leave(object sender, EventArgs e)
        {
            try
            {
                string login = "";

                if (txtPrimerNom.Text != "" || txtPrimApellido.Text != "")
                {
                    for (int i = 1; i > 0; i++)
                    {
                        string Nombre = txtPrimerNom.Text;
                        string Apellido = txtPrimApellido.Text;

                        if (Apellido.IndexOf(" ") > 0)
                        {
                            login = Nombre.Substring(0, i) + Apellido.Substring(0, Apellido.IndexOf(" "));
                        }
                        else
                        {
                            login = Nombre.Substring(0, i) + Apellido.Substring(0, Apellido.Length);
                        }

                        if (VerificaCodigoDuplicado(login) != true)
                        {
                            txtUsuario.Text = login.ToUpper();
                            break;
                        }

                        if (i >= Nombre.Length)
                        {
                            txtUsuario.Enabled = true;
                            txtUsuario.Focus();
                            break;
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


        public bool VerificaCodigoDuplicado(string login)
        {
            ClsSegUsuario Usuarios = new ClsSegUsuario();
            DataTable users = new DataTable();
            users = Usuarios.TodosUsuarios("");
            bool ExisteUsuario = false;
            //i sera la variable que determine el registro que se va recorriendo
            for (int i = 0; i < users.Rows.Count; i++)
            {
                if (login == users.Rows[i][2].ToString())
                {
                    ExisteUsuario = true;
                    return ExisteUsuario;
                }
            }
            return ExisteUsuario;
        }

        public bool VerificaComplejidad()
        {
            ClsFuncionesGenerales grales = new ClsFuncionesGenerales();
            // ^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{4,8}$
            string formato = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{" + grales.ValorParametro("LONGITUDMINIMACLAVE").Rows[0][0].ToString() + ",}$";

            Regex r = new Regex(formato);

            if (r.IsMatch(txtContrasena.Text))
            { return true; }
            else { return false; }
        }
        #endregion
    }
}