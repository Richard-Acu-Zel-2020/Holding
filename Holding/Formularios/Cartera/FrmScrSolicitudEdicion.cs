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
        ClsFuncionesGenerales generales = new ClsFuncionesGenerales();
        ClsVariablesGoblales globales = new ClsVariablesGoblales();
        ClsStbError RegistroError = new ClsStbError();

        public FrmScrSolicitudEdicion()
        {
            InitializeComponent();

            //Estilo de Controladores
            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

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
            cbxTipoDocumentoDNI.DataSource = generales.TodosCatalogoValorXCatalogoActivos("TIPODOCUMENTOCLIENTE");
            cbxTipoDocumentoDNI.DisplayMember = "Valor";
            cbxTipoDocumentoDNI.ValueMember = "ID";
            cbxTipoDocumentoDNI.SelectedIndex = -1;

            //Carga Datos de Tipo Persona
            cbxTipoPersona.DataSource = generales.TodosCatalogoValorXCatalogoActivos("TIPOPERSONACLIENTE");
            cbxTipoPersona.DisplayMember = "Valor";
            cbxTipoPersona.ValueMember = "ID";
            cbxTipoPersona.SelectedIndex = -1;

            //Carga Datos de Pais de Origen
            //cbxPaisOrigen.DataSource = generales.TodosCatalogoValorXCatalogoActivos("TIPOPERSONACLIENTE");
            //cbxPaisOrigen.DisplayMember = "Valor";
            //cbxPaisOrigen.ValueMember = "ID";
            //cbxPaisOrigen.SelectedIndex = -1;
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
