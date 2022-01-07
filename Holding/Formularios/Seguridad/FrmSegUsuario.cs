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
    public partial class FrmSegUsuario : Form
    {
        public FrmSegUsuario()
        {
            InitializeComponent();
        }
       
        ClsVariablesGoblales globales = new ClsVariablesGoblales();
        ClsStbError RegistroError = new ClsStbError();
     
        private void FrmSegUsuario_Load(object sender, EventArgs e)
        {
            Carga();
        }

        #region Botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string TipoAccion = "";
            TipoAccion = "AGREGAR";

            FrmSegUsuarioEdicion AgregarUsuario = new FrmSegUsuarioEdicion(TipoAccion);
            AgregarUsuario.ShowDialog();
            Carga();
        }
        #endregion


        #region Botón Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarUsuarios();
        }
        #endregion


        #region Función para Modificar Usuarios
        public void ModificarUsuarios()
        {
            string TipoAccion = "";
            TipoAccion = "MODIFICAR"; 

            if (dgvUsuarios.RowCount > 0)
            {
                try
                {
                    ClsSegUsuario clsUsers = new ClsSegUsuario();
                    FrmSegUsuarioEdicion ModificarUsuario = new FrmSegUsuarioEdicion(TipoAccion);
                    clsUsers.Idusuario = int.Parse(dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[0].Value.ToString());
                    clsUsers.CorreoLaboral = dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[8].Value.ToString();
                    clsUsers.Cedula = dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[7].Value.ToString();
                    clsUsers.SegundoApellido = dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[6].Value.ToString();
                    clsUsers.PrimerApellido = dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[5].Value.ToString();
                    clsUsers.SegundoNombre = dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[4].Value.ToString();
                    clsUsers.PrimerNombre = dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[3].Value.ToString();
                    clsUsers.Login = dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[2].Value.ToString();
                    if (string.Compare(dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[1].Value.ToString(), "true") == 1)
                    {
                        clsUsers.Activo = 1;
                    }
                    else
                    {
                        clsUsers.Activo = 0;
                    }
                    clsUsers.IdRol = int.Parse(dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[10].Value.ToString());
                    clsUsers.Clave = dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].Cells[11].Value.ToString();
                    ModificarUsuario.Users = clsUsers;
                    ModificarUsuario.ShowDialog();
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


        #region Función para Cargar Datos
        public void Carga()
        {
            ClsSegUsuario clsusuario = new ClsSegUsuario();
            dgvUsuarios.DataSource = clsusuario.UsuariosRol(txtBuscar.Text);
            dgvUsuarios.Columns[0].Visible = false;

            dgvUsuarios.Columns[10].Visible = false;
            dgvUsuarios.Columns[11].Visible = false;
            dgvUsuarios.Columns[12].Visible = false;
            dgvUsuarios.Columns[13].Visible = false;
            dgvUsuarios.Columns[1].Width = 70;
            dgvUsuarios.Columns[2].Width = 150;
            txtBuscar.Text = "";
            lblContador.Text = String.Format("{0:N0}", double.Parse(dgvUsuarios.RowCount.ToString()));
        }
        #endregion


        #region Función Buscar x Nombre
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ClsSegUsuario clsusuario = new ClsSegUsuario();
            dgvUsuarios.DataSource = clsusuario.UsuariosRol(txtBuscar.Text);
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
