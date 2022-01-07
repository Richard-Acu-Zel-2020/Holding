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
    public partial class FrmSegAccionRol : Form
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public FrmSegAccionRol()
        {
            InitializeComponent();

            //Estilo de Controladores
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

        ClsVariablesGoblales globales = new ClsVariablesGoblales();
        ClsStbError RegistroError = new ClsStbError();

        DataTable TableTodasAcciones = new DataTable();
        DataTable TableAccionesxRol = new DataTable();

        ClsSegAccionxRol ClaseAccionXRol = new ClsSegAccionxRol();
        ClsSegAccion ClaseAccion = new ClsSegAccion();
        ClsSegRoles ClaseRol = new ClsSegRoles();


        private void FrmSegAccionRol_Load(object sender, EventArgs e)
        {
            try
            {
                #region"Carga la tabla de las Acciones y el combo"

                cbxRol.DataSource = ClaseRol.RolesXNombre("");
                cbxRol.DisplayMember = "Nombre";
                cbxRol.ValueMember = "ID";
                

                TableTodasAcciones = ClaseAccion.TodasLasAcciones(0);

                dgvTodasAcciones.Rows.Clear();
                for (int rows = 0; rows < TableTodasAcciones.Rows.Count; rows++)
                {
                    dgvTodasAcciones.Rows.Add();
                    dgvTodasAcciones.Rows[rows].Cells[0].Value = TableTodasAcciones.Rows[rows][0].ToString(); // ID
                    dgvTodasAcciones.Rows[rows].Cells[1].Value = TableTodasAcciones.Rows[rows][1].ToString(); // Orden
                    dgvTodasAcciones.Rows[rows].Cells[2].Value = TableTodasAcciones.Rows[rows][2].ToString(); // Nombre

                    dgvTodasAcciones.Rows[rows].Cells[3].Value = TableTodasAcciones.Rows[rows][3].ToString(); // Existe
                    dgvTodasAcciones.Rows[rows].Cells[4].Value = TableTodasAcciones.Rows[rows][4].ToString(); // Código
                    dgvTodasAcciones.Rows[rows].Cells[5].Value = TableTodasAcciones.Rows[rows][5].ToString(); // Descripción
                }

                TableAccionesxRol = ClaseAccion.AccionesXRol(0);

                dgvAcccionXRol.Rows.Clear();
                for (int rows = 0; rows < TableAccionesxRol.Rows.Count; rows++)
                {
                    dgvAcccionXRol.Rows.Add();
                    dgvAcccionXRol.Rows[rows].Cells[0].Value = TableAccionesxRol.Rows[rows][0].ToString(); // ID
                    dgvAcccionXRol.Rows[rows].Cells[1].Value = TableAccionesxRol.Rows[rows][1].ToString(); // Orden
                    dgvAcccionXRol.Rows[rows].Cells[2].Value = TableAccionesxRol.Rows[rows][2].ToString(); // Nombre

                    dgvAcccionXRol.Rows[rows].Cells[3].Value = TableAccionesxRol.Rows[rows][3].ToString(); // Existe
                    dgvAcccionXRol.Rows[rows].Cells[4].Value = TableAccionesxRol.Rows[rows][4].ToString(); // Código
                    dgvAcccionXRol.Rows[rows].Cells[5].Value = TableAccionesxRol.Rows[rows][5].ToString(); // Descripción
                }

                cbxRol.SelectedIndex = -1;

                //Seguridad();

                lblCantidadTodasAcciones.Text = dgvTodasAcciones.Rows.Count.ToString();
                lblCantidadAccionesRol.Text = dgvAcccionXRol.Rows.Count.ToString();

                #endregion
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

        private void cbxRol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(cbxRol.SelectedValue.ToString()) >= 1)
                {
                    TableTodasAcciones = ClaseAccion.AccionesNoAsignadas(int.Parse(cbxRol.SelectedValue.ToString()));

                    dgvTodasAcciones.Rows.Clear();
                    for (int rows = 0; rows < TableTodasAcciones.Rows.Count; rows++)
                    {
                        dgvTodasAcciones.Rows.Add();
                        dgvTodasAcciones.Rows[rows].Cells[0].Value = TableTodasAcciones.Rows[rows][0].ToString(); // ID
                        dgvTodasAcciones.Rows[rows].Cells[1].Value = TableTodasAcciones.Rows[rows][1].ToString(); // Orden
                        dgvTodasAcciones.Rows[rows].Cells[2].Value = TableTodasAcciones.Rows[rows][2].ToString(); // Nombre

                        dgvTodasAcciones.Rows[rows].Cells[3].Value = TableTodasAcciones.Rows[rows][3].ToString(); // Existe
                        dgvTodasAcciones.Rows[rows].Cells[4].Value = TableTodasAcciones.Rows[rows][4].ToString(); // Código
                        dgvTodasAcciones.Rows[rows].Cells[5].Value = TableTodasAcciones.Rows[rows][5].ToString(); // Descripción
                    }

                    TableAccionesxRol = ClaseAccion.AccionesXRol(int.Parse(cbxRol.SelectedValue.ToString()));

                    dgvAcccionXRol.Rows.Clear();
                    for (int rows = 0; rows < TableAccionesxRol.Rows.Count; rows++)
                    {
                        dgvAcccionXRol.Rows.Add();
                        dgvAcccionXRol.Rows[rows].Cells[0].Value = TableAccionesxRol.Rows[rows][0].ToString(); // ID
                        dgvAcccionXRol.Rows[rows].Cells[1].Value = TableAccionesxRol.Rows[rows][1].ToString(); // Orden
                        dgvAcccionXRol.Rows[rows].Cells[2].Value = TableAccionesxRol.Rows[rows][2].ToString(); // Nombre

                        dgvAcccionXRol.Rows[rows].Cells[3].Value = TableAccionesxRol.Rows[rows][3].ToString(); // Existe
                        dgvAcccionXRol.Rows[rows].Cells[4].Value = TableAccionesxRol.Rows[rows][4].ToString(); // Código
                        dgvAcccionXRol.Rows[rows].Cells[5].Value = TableAccionesxRol.Rows[rows][5].ToString(); // Descripción
                    }

                    dgvNuevasAcciones.Rows.Clear();

                    lblCantidadTodasAcciones.Text = dgvTodasAcciones.Rows.Count.ToString();
                    lblCantidadAccionesRol.Text = dgvAcccionXRol.Rows.Count.ToString();

                    if (dgvAcccionXRol.Rows.Count > 0)
                        dgvAcccionXRol.Rows[dgvAcccionXRol.Rows.Count - 1].Selected = true;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbxRol.SelectedIndex < 0)
            {
                MessageBox.Show("Favor seleccione un rol", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {

                ClsSegAccionxRol acciones = new ClsSegAccionxRol();

                //i es la variable que representa las acciones.
                for (int i = 0; i < dgvNuevasAcciones.RowCount; i++)
                {
                    acciones.IdAccionRol = 0;
                    acciones.CodigoAccion = dgvNuevasAcciones.Rows[i].Cells[0].Value.ToString();
                    acciones.IdRol = int.Parse(cbxRol.SelectedValue.ToString());

                    if (acciones.GuardaAccionPorRol() == false) /*Creado por ricardo*/
                    {
                        MessageBox.Show(globales.MsgErrorValidarDatos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                MessageBox.Show(globales.MsgRegistroExitosoInserta, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
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

        #region "Seguridad"
        //Verifica la seguridad del usuario que ingresa a este.
        public void Seguridad()
        {
            //ClsVerificaSeguridad Seguridad = new ClsVerificaSeguridad();
            //if (Seguridad.VerificaSeguridad("ASOCIARACCIONES") == true)
            //{
            //    btnGuardar.Enabled = true;
            //}
        }
        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Reinicia el tiempo de actividad
                globales.ReiniciaContadorTiempo();
                this.Cursor = Cursors.WaitCursor;

                if (cbxRol.SelectedIndex < 0)
                {
                    MessageBox.Show("Favor seleccione un rol", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                    return;
                }

                if(dgvTodasAcciones.Rows.Count == 0)
                {
                    MessageBox.Show("No hay acciones para asignar al rol seleccionado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                    return;
                } 

                int existeTodosAcciones = int.Parse(dgvTodasAcciones.Rows[dgvTodasAcciones.CurrentCell.RowIndex].Cells["Existe"].Value.ToString());

                string codigo = (dgvTodasAcciones.Rows[dgvTodasAcciones.CurrentCell.RowIndex].Cells["Código"].Value.ToString());
                string descripcion = (dgvTodasAcciones.Rows[dgvTodasAcciones.CurrentCell.RowIndex].Cells["Descripción"].Value.ToString());

                if (dgvTodasAcciones.Rows.Count <= 0)
                {
                    MessageBox.Show("No hay acciones por asignar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Cursor = Cursors.Default;
                    return;
                }
                else
                {
                    if (existeTodosAcciones == 1)
                    {
                        MessageBox.Show("Ésta acción ya está asignada a ese rol", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Cursor = Cursors.Default;
                        dgvAcccionXRol.Rows[dgvAcccionXRol.Rows.Count - 1].Selected = true;
                        dgvAcccionXRol.FirstDisplayedScrollingRowIndex = dgvAcccionXRol.RowCount - 1;
                        return;

                    }
                    else
                    {
                        for (int fila = 0; fila < dgvNuevasAcciones.Rows.Count; fila++)
                        {
                            if (codigo == (dgvNuevasAcciones.Rows[fila].Cells["codigoaccion"].Value.ToString()))
                            {
                                MessageBox.Show("Ésta acción ya está asignada a ese rol", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Cursor = Cursors.Default;
                                dgvAcccionXRol.Rows[dgvAcccionXRol.Rows.Count - 1].Selected = true;
                                dgvAcccionXRol.FirstDisplayedScrollingRowIndex = dgvAcccionXRol.RowCount - 1;
                                return;
                            }
                        }

                        dgvAcccionXRol.Rows.Add();
                        dgvAcccionXRol.Rows[dgvAcccionXRol.Rows.Count - 1].Cells[0].Value = 0;  // ID
                        dgvAcccionXRol.Rows[dgvAcccionXRol.Rows.Count - 1].Cells[1].Value = 0;  // Orden
                        dgvAcccionXRol.Rows[dgvAcccionXRol.Rows.Count - 1].Cells[2].Value = ""; // Nombre      
                        dgvAcccionXRol.Rows[dgvAcccionXRol.Rows.Count - 1].Cells[5].Value = 0;  // Existe      
                        dgvAcccionXRol.Rows[dgvAcccionXRol.Rows.Count - 1].Cells[3].Value = codigo; // Código
                        dgvAcccionXRol.Rows[dgvAcccionXRol.Rows.Count - 1].Cells[4].Value = descripcion; // Descripción

                        dgvNuevasAcciones.Rows.Add();
                        dgvNuevasAcciones.Rows[dgvNuevasAcciones.Rows.Count - 1].Cells[0].Value = codigo;  // codigoaccion
                        dgvNuevasAcciones.Rows[dgvNuevasAcciones.Rows.Count - 1].Cells[1].Value = int.Parse(cbxRol.SelectedValue.ToString());  // idrol
                    }
                }

                lblCantidadTodasAcciones.Text = dgvTodasAcciones.Rows.Count.ToString();
                lblCantidadAccionesRol.Text = dgvAcccionXRol.Rows.Count.ToString();

                dgvAcccionXRol.Rows[dgvAcccionXRol.Rows.Count - 1].Selected = true;
                dgvAcccionXRol.FirstDisplayedScrollingRowIndex = dgvAcccionXRol.RowCount - 1;

                this.Cursor = Cursors.Default;
            }
            catch (Exception IO)
            {
                //Reinicia el tiempo de actividad
                globales.ReiniciaContadorTiempo();

                RegistroError.Formulario = this.ToString();
                RegistroError.DetalleError = IO.ToString();
                RegistroError.GuardaError();
                FrmError frmError = new FrmError(globales.MsgError, IO.ToString(), globales.MsgErrorFinal);
                this.Cursor = Cursors.Default;
                frmError.ShowDialog();
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();

            if (dgvAcccionXRol.RowCount <= 0)
            {
                MessageBox.Show("No hay acciones por eliminar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Cursor = Cursors.Default;
                return;

            }

            string codigoAcc = (dgvAcccionXRol.Rows[dgvAcccionXRol.CurrentCell.RowIndex].Cells["Código2"].Value.ToString());

            ClaseAccion.EliminarAccionxRol(int.Parse(cbxRol.SelectedValue.ToString()), codigoAcc);
            dgvAcccionXRol.Rows.Remove(dgvAcccionXRol.CurrentRow);

            for (int fila = 0; fila < dgvNuevasAcciones.Rows.Count; fila++)
            {
                if (codigoAcc == (dgvNuevasAcciones.Rows[fila].Cells["codigoaccion"].Value.ToString()))
                {
                    //dgvNuevasAcciones.Rows.Remove(dgvNuevasAcciones.CurrentRow);
                    dgvNuevasAcciones.Rows.RemoveAt(fila);
                    dgvAcccionXRol.Rows[dgvAcccionXRol.Rows.Count - 1].Selected = true;
                }
            }

            TableTodasAcciones = ClaseAccion.TodasLasAcciones(int.Parse(cbxRol.SelectedValue.ToString()));

            dgvTodasAcciones.Rows.Clear();
            for (int rows = 0; rows < TableTodasAcciones.Rows.Count; rows++)
            {
                dgvTodasAcciones.Rows.Add();
                dgvTodasAcciones.Rows[rows].Cells[0].Value = TableTodasAcciones.Rows[rows][0].ToString(); // ID
                dgvTodasAcciones.Rows[rows].Cells[1].Value = TableTodasAcciones.Rows[rows][1].ToString(); // Orden
                dgvTodasAcciones.Rows[rows].Cells[2].Value = TableTodasAcciones.Rows[rows][2].ToString(); // Nombre

                dgvTodasAcciones.Rows[rows].Cells[3].Value = TableTodasAcciones.Rows[rows][3].ToString(); // Existe
                dgvTodasAcciones.Rows[rows].Cells[4].Value = TableTodasAcciones.Rows[rows][4].ToString(); // Código
                dgvTodasAcciones.Rows[rows].Cells[5].Value = TableTodasAcciones.Rows[rows][5].ToString(); // Descripción
            }

            lblCantidadTodasAcciones.Text = dgvTodasAcciones.Rows.Count.ToString();
            lblCantidadAccionesRol.Text = dgvAcccionXRol.Rows.Count.ToString();

            if(dgvAcccionXRol.Rows.Count > 0)
            {
                dgvAcccionXRol.Rows[dgvAcccionXRol.Rows.Count - 1].Selected = true;
                dgvAcccionXRol.FirstDisplayedScrollingRowIndex = dgvAcccionXRol.RowCount - 1;
            }
            
            MessageBox.Show("Registro eliminado satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarTodasAcciones_Click(object sender, EventArgs e)
        {
            if (cbxRol.SelectedIndex != -1)
            {
                TableTodasAcciones = ClaseAccion.BuscarTodasAccionesPorRolCodigo(int.Parse(cbxRol.SelectedValue.ToString()), txtBuscarTodasAcciones.Text);

                dgvTodasAcciones.Rows.Clear();
                for (int rows = 0; rows < TableTodasAcciones.Rows.Count; rows++)
                {
                    dgvTodasAcciones.Rows.Add();
                    dgvTodasAcciones.Rows[rows].Cells[0].Value = TableTodasAcciones.Rows[rows][0].ToString(); // ID
                    dgvTodasAcciones.Rows[rows].Cells[1].Value = TableTodasAcciones.Rows[rows][1].ToString(); // Orden
                    dgvTodasAcciones.Rows[rows].Cells[2].Value = TableTodasAcciones.Rows[rows][2].ToString(); // Nombre

                    dgvTodasAcciones.Rows[rows].Cells[3].Value = TableTodasAcciones.Rows[rows][3].ToString(); // Existe
                    dgvTodasAcciones.Rows[rows].Cells[4].Value = TableTodasAcciones.Rows[rows][4].ToString(); // Código
                    dgvTodasAcciones.Rows[rows].Cells[5].Value = TableTodasAcciones.Rows[rows][5].ToString(); // Descripción
                }

                lblCantidadTodasAcciones.Text = dgvTodasAcciones.Rows.Count.ToString();

                if (dgvTodasAcciones.Rows.Count > 0)
                    dgvTodasAcciones.Rows[dgvTodasAcciones.Rows.Count - 1].Selected = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol para buscar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnBuscarSeccionesxRol_Click(object sender, EventArgs e)
        {
            if (cbxRol.SelectedIndex != -1)
            {
                TableAccionesxRol = ClaseAccion.BuscarAccionesXRolCodigo(int.Parse(cbxRol.SelectedValue.ToString()), txtBuscarAccionesRol.Text);

                dgvAcccionXRol.Rows.Clear();
                for (int rows = 0; rows < TableAccionesxRol.Rows.Count; rows++)
                {
                    dgvAcccionXRol.Rows.Add();
                    dgvAcccionXRol.Rows[rows].Cells[0].Value = TableAccionesxRol.Rows[rows][0].ToString(); // ID
                    dgvAcccionXRol.Rows[rows].Cells[1].Value = TableAccionesxRol.Rows[rows][1].ToString(); // Orden
                    dgvAcccionXRol.Rows[rows].Cells[2].Value = TableAccionesxRol.Rows[rows][2].ToString(); // Nombre

                    dgvAcccionXRol.Rows[rows].Cells[3].Value = TableAccionesxRol.Rows[rows][3].ToString(); // Existe
                    dgvAcccionXRol.Rows[rows].Cells[4].Value = TableAccionesxRol.Rows[rows][4].ToString(); // Código
                    dgvAcccionXRol.Rows[rows].Cells[5].Value = TableAccionesxRol.Rows[rows][5].ToString(); // Descripción
                }

                lblCantidadAccionesRol.Text = dgvAcccionXRol.Rows.Count.ToString();

                if (dgvAcccionXRol.Rows.Count > 0)
                    dgvAcccionXRol.Rows[dgvAcccionXRol.Rows.Count - 1].Selected = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un rol para buscar", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void btnActualizaTodasAcciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxRol.SelectedIndex != -1)
                {
                    txtBuscarTodasAcciones.Text = "";

                    TableTodasAcciones = ClaseAccion.TodasLasAcciones(int.Parse(cbxRol.SelectedValue.ToString()));

                    dgvTodasAcciones.Rows.Clear();
                    for (int rows = 0; rows < TableTodasAcciones.Rows.Count; rows++)
                    {
                        dgvTodasAcciones.Rows.Add();
                        dgvTodasAcciones.Rows[rows].Cells[0].Value = TableTodasAcciones.Rows[rows][0].ToString(); // ID
                        dgvTodasAcciones.Rows[rows].Cells[1].Value = TableTodasAcciones.Rows[rows][1].ToString(); // Orden
                        dgvTodasAcciones.Rows[rows].Cells[2].Value = TableTodasAcciones.Rows[rows][2].ToString(); // Nombre

                        dgvTodasAcciones.Rows[rows].Cells[3].Value = TableTodasAcciones.Rows[rows][3].ToString(); // Existe
                        dgvTodasAcciones.Rows[rows].Cells[4].Value = TableTodasAcciones.Rows[rows][4].ToString(); // Código
                        dgvTodasAcciones.Rows[rows].Cells[5].Value = TableTodasAcciones.Rows[rows][5].ToString(); // Descripción
                    }

                    lblCantidadTodasAcciones.Text = dgvTodasAcciones.Rows.Count.ToString();
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

        private void btnActualizaAccionxRol_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxRol.SelectedIndex != -1)
                {
                    txtBuscarAccionesRol.Text = "";

                    TableAccionesxRol = ClaseAccion.AccionesXRol(int.Parse(cbxRol.SelectedValue.ToString()));

                    dgvAcccionXRol.Rows.Clear();
                    for (int rows = 0; rows < TableAccionesxRol.Rows.Count; rows++)
                    {
                        dgvAcccionXRol.Rows.Add();
                        dgvAcccionXRol.Rows[rows].Cells[0].Value = TableAccionesxRol.Rows[rows][0].ToString(); // ID
                        dgvAcccionXRol.Rows[rows].Cells[1].Value = TableAccionesxRol.Rows[rows][1].ToString(); // Orden
                        dgvAcccionXRol.Rows[rows].Cells[2].Value = TableAccionesxRol.Rows[rows][2].ToString(); // Nombre

                        dgvAcccionXRol.Rows[rows].Cells[3].Value = TableAccionesxRol.Rows[rows][3].ToString(); // Existe
                        dgvAcccionXRol.Rows[rows].Cells[4].Value = TableAccionesxRol.Rows[rows][4].ToString(); // Código
                        dgvAcccionXRol.Rows[rows].Cells[5].Value = TableAccionesxRol.Rows[rows][5].ToString(); // Descripción
                    }

                    lblCantidadAccionesRol.Text = dgvAcccionXRol.Rows.Count.ToString();

                    if (dgvAcccionXRol.Rows.Count > 0)
                        dgvAcccionXRol.Rows[dgvAcccionXRol.Rows.Count - 1].Selected = true;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
