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
    public partial class FrmSegAccion : Form
    {
        public FrmSegAccion()
        {
            InitializeComponent();
        }

        private void FrmSegAccion_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string TipoAccion = "";
            TipoAccion = "AGREGAR";

            FrmSegAccionEdicion AgregarAccion = new FrmSegAccionEdicion(TipoAccion);
            AgregarAccion.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string TipoAccion = "";
            TipoAccion = "MODIFICAR";

            FrmSegAccionEdicion ModificarAccion = new FrmSegAccionEdicion(TipoAccion);
            ModificarAccion.ShowDialog();
        }
    }
}
