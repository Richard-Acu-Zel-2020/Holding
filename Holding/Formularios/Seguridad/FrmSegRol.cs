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
    public partial class FrmSegRol : Form
    {
        public FrmSegRol()
        {
            InitializeComponent();
        }

        ClsVariablesGoblales globales = new ClsVariablesGoblales();
        ClsStbError RegistroError = new ClsStbError();

        private void FrmSegRol_Load(object sender, EventArgs e)
        {
            Carga();
        }

        #region Botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string TipoAccion = "";
            TipoAccion = "AGREGAR";

            FrmSegRolEdicion AgregarRol = new FrmSegRolEdicion(TipoAccion);
            AgregarRol.ShowDialog();
            Carga();
        }
        #endregion


        #region Botón Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificaRoles();
        }
        #endregion


        #region Función para Modificar Roles
        public void ModificaRoles()
        {
            string TipoAccion = "";
            TipoAccion = "MODIFICAR";

            if (dgvRol.RowCount > 0)
            {
                try
                {
                    FrmSegRolEdicion ModificarRol = new FrmSegRolEdicion(TipoAccion);
                    ClsSegRoles clsRol = new ClsSegRoles();
                    clsRol.IdRol = int.Parse(dgvRol.Rows[dgvRol.SelectedRows[0].Index].Cells[0].Value.ToString());
                    clsRol.NombreRol = dgvRol.Rows[dgvRol.SelectedRows[0].Index].Cells[2].Value.ToString();
                    clsRol.Codigo = dgvRol.Rows[dgvRol.SelectedRows[0].Index].Cells[1].Value.ToString();
                    clsRol.Descripcion = dgvRol.Rows[dgvRol.SelectedRows[0].Index].Cells[3].Value.ToString();
                    ModificarRol.Rols = clsRol;
                    ModificarRol.ShowDialog();
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
            ClsSegRoles clsrol = new ClsSegRoles();
            dgvRol.DataSource = clsrol.RolesXNombre("");

            dgvRol.Columns[0].Visible = false;
            dgvRol.Columns[1].Width = 200;
            lblContador.Text = String.Format("{0:N0}", double.Parse(dgvRol.RowCount.ToString()));

        }
        #endregion


        #region Función para Buscar x Nombre
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            ClsSegRoles clsrol = new ClsSegRoles();
            dgvRol.DataSource = clsrol.RolesXNombre(txtBuscar.Text);
        }
        #endregion
    }
}
