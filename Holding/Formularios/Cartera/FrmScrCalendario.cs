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
    public partial class FrmScrCalendario : Form
    {
        public FrmScrCalendario()
        {
            InitializeComponent();
        }

        public delegate void fechaPoner(DateTime valor);
       // public fechaPoner fechador;

        public DateTime fechavalor;

        private void Calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            fechavalor = Calendario.SelectionStart;
            this.Hide();
        }

        private void FrmSvnCalendario_Load(object sender, EventArgs e)
        {

        }
    }
}
