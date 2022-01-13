using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;


namespace Holding
{

    public partial class FrmScrSolicitud : Form
    {

        public FrmScrSolicitud()
        {
            InitializeComponent();
        }

        private void FrmScrSolicitud_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmScrSolicitudEdicion Solicitudes = new FrmScrSolicitudEdicion();
            Solicitudes.ShowDialog();
        }
    }
}
