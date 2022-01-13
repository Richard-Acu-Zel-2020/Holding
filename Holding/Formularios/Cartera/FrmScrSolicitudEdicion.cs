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
    public partial class FrmScrSolicitudEdicion : Form
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        FrmScrCalendario Calendario = new FrmScrCalendario();

        public FrmScrSolicitudEdicion()
        {
            InitializeComponent();

            //Estilo de Controladores
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

        private void FrmScrSolicitudEdicion_Load(object sender, EventArgs e)
        {

        }

        private void btnFechaNacimiento_Click(object sender, EventArgs e)
        {
            Calendario.Location = new Point(540, 325);
            Calendario.ShowDialog();
            txtFechaNacimiento.Text = Calendario.fechavalor.ToShortDateString();
        }

        private void btnFechaEmisionDNI_Click(object sender, EventArgs e)
        {
            Calendario.Location = new Point(1350, 325);
            Calendario.ShowDialog();
            txtFechaEmisionDNI.Text = Calendario.fechavalor.ToShortDateString();
        }

        private void btnFechaVenceDNI_Click(object sender, EventArgs e)
        {
            Calendario.Location = new Point(1620, 325);
            Calendario.ShowDialog();
            txtFechaVencimientoDNI.Text = Calendario.fechavalor.ToShortDateString();
        }
    }
}
