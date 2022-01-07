using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using MaterialSkin.Controls;
using MaterialSkin;

namespace Holding
{
    public partial class FrmSegLogin : Form
    {
        //readonly MaterialSkin.MaterialSkinManager skinManager;
        //materialSkinManager = MaterialSkinManager.Instance;
        public FrmSegLogin()

        {
            InitializeComponent();

            //skinManager = MaterialSkin.MaterialSkinManager.Instance;
            //skinManager.EnforceBackcolorOnAllComponents = false;

            //skinManager.AddFormToManage(this);
            //skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);
        }

        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;

        

        ClsVariablesGoblales grales = new ClsVariablesGoblales();
        ClsFuncionesGenerales fgrales = new ClsFuncionesGenerales();
        ClsStbError RegistroError = new ClsStbError();
        ClsSegUsuario SegUsuario = new ClsSegUsuario();

        private void FrmSegLogin_Load(object sender, EventArgs e)
        {
            //skinManager
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                Entrar();
            }
            catch (Exception IO)
            {
                RegistroError.Formulario = this.ToString();
                RegistroError.DetalleError = IO.ToString();
                RegistroError.GuardaError();
                FrmError frmError = new FrmError(grales.MsgError, IO.ToString(), grales.MsgErrorFinal);
                frmError.ShowDialog();
                return;
            }
        }

        private void Entrar()
        {
            try
            {
                Error.Clear();
                if (txtUsuario.Text.TrimEnd() == "")
                {
                    Error.SetError(txtUsuario, "Favor ingresar un código de usuario");
                    return;
                }

                if (txtContraseña.Text.TrimEnd() == "")
                {
                    Error.SetError(txtContraseña, "Favor ingresar una contraseña");
                    return;
                }

                ClsSegBitacora bitacora = new ClsSegBitacora();
                ClsStbParametros Parametro = new ClsStbParametros();

                ClsVariablesGoblales variablesGolabales = new ClsVariablesGoblales();
                DataTable Resultado = new DataTable();
                Resultado = SegUsuario.UsuarioIngresa(txtUsuario.Text, txtContraseña.Text);

                if (Resultado.Rows.Count > 0)
                {
                    DateTime FechaVencimiento = DateTime.Parse(Resultado.Rows[0][7].ToString());
                    String Login = Resultado.Rows[0][2].ToString();
                    int IdUsuario = int.Parse(Resultado.Rows[0][0].ToString());
                    string SiglaPais = Parametro.ParametroPorNombre("SIGLAPAISBASE");

                    variablesGolabales.accesarVariable(Login, ObtenerIp(), IdUsuario, SiglaPais);

                    String TextoMonedaPrincipal = Parametro.ParametroPorNombre("MONEDABASE");
                    String TextoMonedaSecundaria = Parametro.ParametroPorNombre("MONEDACONTABILIDAD");
                    String SimboloMonedaPrincipal = Parametro.ParametroPorNombre("SIMBOLOMONEDABASE");
                    String SimboloMonedaSecundaria = Parametro.ParametroPorNombre("SIMBOLOMONEDACONTABILIDAD");
                    variablesGolabales.LlenaMonedas(TextoMonedaPrincipal, TextoMonedaSecundaria, SimboloMonedaPrincipal, SimboloMonedaSecundaria);

                    //Verifico que la fecha inactiva de cuenta sea mayor que la fehca actual
                    if (Resultado.Rows[0][8].ToString() != "")
                    {
                        DateTime FechaInactivaCuenta = DateTime.Parse(Resultado.Rows[0][8].ToString());

                        if (FechaInactivaCuenta.CompareTo(DateTime.Today) <= 0)
                        {
                            Error.SetError(txtUsuario, "Su cuenta ha caducado, favor comunicarse con el área de Informática.");
                            return;
                        }
                    }

                    //Verifico que el usuario este Activo
                    if (string.Compare(Resultado.Rows[0][4].ToString(), "true") != 1)
                    {
                        bitacora.ObjEstadoSesionId = bitacora.IdEstadoSesion("ESTADOSESION", "Fallido");
                        bitacora.ObjCausaEstadoID = bitacora.IdEstadoXCausa("CAUSAESTADOSESION", "USUINACT");
                        bitacora.LoginFallido = txtUsuario.Text;
                        if (bitacora.GuardaInicioSesion() != true)
                        {
                            MessageBox.Show(grales.MsgErrorBitacora, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Error.SetError(txtUsuario, "El usuario está inactivo, favor comunicarse con el área de Informática.");
                        return;
                    }

                    //Verifico que la clave no este caducada
                    if (FechaVencimiento.CompareTo(DateTime.Today) <= 0)
                    {
                        Error.SetError(txtContraseña, "Su clave ha caducado, favor comunicarse con el área de Informática.");
                        bitacora.ObjEstadoSesionId = bitacora.IdEstadoSesion("ESTADOSESION", "Fallido");
                        bitacora.ObjCausaEstadoID = bitacora.IdEstadoXCausa("CAUSAESTADOSESION", "CLAVEVEN");
                        bitacora.LoginFallido = txtUsuario.Text;
                        if (bitacora.GuardaInicioSesion() != true)
                        {
                            MessageBox.Show(grales.MsgErrorBitacora, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        return;
                    }

                    bitacora.ObjEstadoSesionId = bitacora.IdEstadoSesion("ESTADOSESION", "CORRECTO");
                    if (bitacora.GuardaInicioSesion() != true)
                    {
                        MessageBox.Show(grales.MsgErrorBitacora, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        this.Hide();

                        FrmPrincipal FrmPrincipal = new FrmPrincipal();
                        FrmPrincipal.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña invalidos, favor verificar accesos!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Pregunto si el usuario que ingreso esta correcto
                    if (SegUsuario.UsuarioXLogin(txtUsuario.Text).Rows.Count > 0)
                    {
                        variablesGolabales.accesarVariable(txtUsuario.Text, ObtenerIp(), int.Parse(SegUsuario.UsuarioXLogin(txtUsuario.Text).Rows[0][0].ToString()), "");
                        bitacora.ObjCausaEstadoID = bitacora.IdEstadoXCausa("CAUSAESTADOSESION", "PASSWMAL");
                    }
                    else
                    {
                        variablesGolabales.accesarVariable("", ObtenerIp(), 0, "");
                        bitacora.ObjCausaEstadoID = bitacora.IdEstadoXCausa("CAUSAESTADOSESION", "LOGINMAL");
                    }

                    bitacora.LoginFallido = txtUsuario.Text;


                    //Guardo la bitacora con login Fallido
                    bitacora.ObjEstadoSesionId = bitacora.IdEstadoSesion("ESTADOSESION", "Fallido");
                    if (bitacora.GuardaInicioSesion() != true)
                    {
                        MessageBox.Show(grales.MsgErrorBitacora, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    txtContraseña.Focus();
                    txtContraseña.SelectAll();
                    return;
                }
            }
            catch (Exception IO)
            {
                FrmError frmError = new FrmError(grales.MsgError, IO.ToString(), grales.MsgErrorFinal);
                frmError.ShowDialog();
                return;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClsValidaCaracteres val = new ClsValidaCaracteres();
            e.Handled = !val.CaracterValido(e.KeyChar, ClsValidaCaracteres.TipoValidacion.LetrasNumeros);
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Entrar();
            }
            else
            {
                if (e.KeyChar == 34 || e.KeyChar == 39 || e.KeyChar == 32)
                {
                    e.Handled = true;
                }
            }
        }

        public String ObtenerIp()
        {
            try
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                String localIP = "";
                // host = Dns.GetHostEntry(Dns.GetHostName());

                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily.ToString() == "InterNetwork")
                    {
                        localIP = ip.ToString();
                    }
                }
                return localIP;
            }
            catch (Exception IO)
            {
                RegistroError.Formulario = this.ToString();
                RegistroError.DetalleError = IO.ToString();
                RegistroError.GuardaError();
                FrmError frmError = new FrmError(grales.MsgError, IO.ToString(), grales.MsgErrorFinal);
                frmError.ShowDialog();
                return "";
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            //txtUsuario.Text = CharacterCasing.Upper;
        }

        private void FrmSegLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
