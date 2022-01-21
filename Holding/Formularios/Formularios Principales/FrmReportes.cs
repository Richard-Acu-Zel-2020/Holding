using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Configuration;
/*
 * Realizado por Rene Jarquin
 * Fecha 20-02-2014
 */
/* Formulario de que nos permite cargar y visualizar los reportes que se generan en el sistema */


namespace Holding
{
    public partial class FrmReportesAlll : Form
    {
        public FrmReportesAlll(string _RptName)
        {
            InitializeComponent();
            RptName = _RptName;
        }

        string RptName = "";
        ClsVariablesGoblales globales = new ClsVariablesGoblales();
        ClsStbError RegistroError = new ClsStbError();
        ClsFuncionesGenerales grales = new ClsFuncionesGenerales();

        private void FrmReporteCatalogo_Load(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();       
            //ConfigurationManager.GetSection("system.xml/xmlReader");
            crViewer.ShowExportButton = false;
            crViewer.ShowCopyButton = false;
            Seguridad();

            string reportesbloqueados = grales.ValorParametro("REPORTESBLOQUEOIMPRIMIR").Rows[0][0].ToString();

            String[] RptBlocked = new String[200];
            RptBlocked = reportesbloqueados.Split('-');
            for (int i = 0; i < RptBlocked.Length; i++)
            {
                if (RptBlocked[i] == RptName)
                {
                    crViewer.ShowPrintButton = false;
                    return;
                }
            }
        }

        public void Seguridad()
        {
            ClsVerificaSeguridad Seguridad = new ClsVerificaSeguridad();
            if (Seguridad.VerificaSeguridad("EXPORTAREPORTES") == true)
            {
                crViewer.ShowExportButton = true;
            }
        }

        #region"Control de inactividad"

        private void FrmReportesAlll_MouseUp(object sender, MouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_MouseClick(object sender, MouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_MouseMove(object sender, MouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_MouseMove(object sender, MouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_MouseClick(object sender, MouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_ReportRefresh(object source, CrystalDecisions.Windows.Forms.ViewerEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        #endregion

        private void crViewer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_Scroll(object sender, ScrollEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_Scroll(object sender, ScrollEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void reportDocument1_RefreshReport(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void reportDocument1_AfterFormatPage(CrystalDecisions.CrystalReports.Engine.FormatPageEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void reportDocument1_FormatSection(CrystalDecisions.CrystalReports.Engine.FormatSectionEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_Validating(object sender, CancelEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_ViewZoom(object source, CrystalDecisions.Windows.Forms.ZoomEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_Click(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_ClickPage(object sender, CrystalDecisions.Windows.Forms.PageMouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_CursorChanged(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_DockChanged(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_DoubleClick(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_Enter(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_MouseLeave(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_Search(object source, CrystalDecisions.Windows.Forms.SearchEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_Move(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_Leave(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_Load(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_KeyUp(object sender, KeyEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_KeyDown(object sender, KeyEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_LocationChanged(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_MouseDown(object sender, MouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_MouseEnter(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_SizeChanged(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_MouseUp(object sender, MouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_Navigate(object source, CrystalDecisions.Windows.Forms.NavigateEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_Leave(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_Move(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_KeyDown(object sender, KeyEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_KeyUp(object sender, KeyEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_LocationChanged(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_MouseDown(object sender, MouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_MouseEnter(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_MouseLeave(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_Click(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_DoubleClick(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_Enter(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_Shown(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_TextChanged(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_DockChanged(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void FrmReportesAlll_CursorChanged(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_TabIndexChanged(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_DoubleClickPage(object sender, CrystalDecisions.Windows.Forms.PageMouseEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_Drill(object source, CrystalDecisions.Windows.Forms.DrillEventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }

        private void crViewer_MouseHover(object sender, EventArgs e)
        {
            //Reinicia el tiempo de actividad
            globales.ReiniciaContadorTiempo();
        }
    }
}
