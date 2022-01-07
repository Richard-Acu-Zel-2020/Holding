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
    public partial class FrmSegAccionEdicion : Form
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public FrmSegAccionEdicion(string _tipoaccion)
        {
            InitializeComponent();
            TipoAccionRecibe = _tipoaccion;

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.LightGreen700, MaterialSkin.TextShade.WHITE);
        }

        string TipoAccionRecibe = "";

        private void FrmSegAccionEdicion_Load(object sender, EventArgs e)
        {
            if (TipoAccionRecibe == "AGREGAR")
            {
                this.Text = "Agregar Acción";
            }
            else if (TipoAccionRecibe == "MODIFICAR")
            {
                this.Text = "Modificar Acción";
            }
        }
    }
}
