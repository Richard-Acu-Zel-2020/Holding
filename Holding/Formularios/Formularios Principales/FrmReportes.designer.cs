namespace Holding
{
    partial class FrmReportesAlll
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportDocument1 = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            this.crViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportDocument1
            // 
            this.reportDocument1.RefreshReport += new System.EventHandler(this.reportDocument1_RefreshReport);
            this.reportDocument1.AfterFormatPage += new CrystalDecisions.CrystalReports.Engine.FormatPageEventHandler(this.reportDocument1_AfterFormatPage);
            this.reportDocument1.FormatSection += new CrystalDecisions.CrystalReports.Engine.FormatSectionEventHandler(this.reportDocument1_FormatSection);
            // 
            // crViewer
            // 
            this.crViewer.ActiveViewIndex = -1;
            this.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crViewer.EnableDrillDown = false;
            this.crViewer.Location = new System.Drawing.Point(0, 0);
            this.crViewer.Margin = new System.Windows.Forms.Padding(4);
            this.crViewer.Name = "crViewer";
            this.crViewer.ShowCloseButton = false;
            this.crViewer.ShowGroupTreeButton = false;
            this.crViewer.ShowParameterPanelButton = false;
            this.crViewer.ShowRefreshButton = false;
            this.crViewer.Size = new System.Drawing.Size(987, 617);
            this.crViewer.TabIndex = 0;
            this.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crViewer.Search += new CrystalDecisions.Windows.Forms.SearchEventHandler(this.crViewer_Search);
            this.crViewer.ViewZoom += new CrystalDecisions.Windows.Forms.ZoomEventHandler(this.crViewer_ViewZoom);
            this.crViewer.ReportRefresh += new CrystalDecisions.Windows.Forms.RefreshEventHandler(this.crViewer_ReportRefresh);
            this.crViewer.Navigate += new CrystalDecisions.Windows.Forms.NavigateEventHandler(this.crViewer_Navigate);
            this.crViewer.ClickPage += new CrystalDecisions.Windows.Forms.PageMouseEventHandler(this.crViewer_ClickPage);
            this.crViewer.DoubleClickPage += new CrystalDecisions.Windows.Forms.PageMouseEventHandler(this.crViewer_DoubleClickPage);
            this.crViewer.Drill += new CrystalDecisions.Windows.Forms.DrillEventHandler(this.crViewer_Drill);
            this.crViewer.Load += new System.EventHandler(this.crViewer_Load);
            this.crViewer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.crViewer_Scroll);
            this.crViewer.CursorChanged += new System.EventHandler(this.crViewer_CursorChanged);
            this.crViewer.DockChanged += new System.EventHandler(this.crViewer_DockChanged);
            this.crViewer.LocationChanged += new System.EventHandler(this.crViewer_LocationChanged);
            this.crViewer.SizeChanged += new System.EventHandler(this.crViewer_SizeChanged);
            this.crViewer.TabIndexChanged += new System.EventHandler(this.crViewer_TabIndexChanged);
            this.crViewer.Click += new System.EventHandler(this.crViewer_Click);
            this.crViewer.DoubleClick += new System.EventHandler(this.crViewer_DoubleClick);
            this.crViewer.Enter += new System.EventHandler(this.crViewer_Enter);
            this.crViewer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.crViewer_KeyDown);
            this.crViewer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.crViewer_KeyPress);
            this.crViewer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.crViewer_KeyUp);
            this.crViewer.Leave += new System.EventHandler(this.crViewer_Leave);
            this.crViewer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.crViewer_MouseClick);
            this.crViewer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.crViewer_MouseDoubleClick);
            this.crViewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.crViewer_MouseDown);
            this.crViewer.MouseEnter += new System.EventHandler(this.crViewer_MouseEnter);
            this.crViewer.MouseLeave += new System.EventHandler(this.crViewer_MouseLeave);
            this.crViewer.MouseHover += new System.EventHandler(this.crViewer_MouseHover);
            this.crViewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.crViewer_MouseMove);
            this.crViewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.crViewer_MouseUp);
            this.crViewer.Move += new System.EventHandler(this.crViewer_Move);
            this.crViewer.Validating += new System.ComponentModel.CancelEventHandler(this.crViewer_Validating);
            // 
            // FrmReportesAlll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 617);
            this.Controls.Add(this.crViewer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmReportesAlll";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmReportesAlll_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmReportesAlll_FormClosed);
            this.Load += new System.EventHandler(this.FrmReporteCatalogo_Load);
            this.Shown += new System.EventHandler(this.FrmReportesAlll_Shown);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FrmReportesAlll_Scroll);
            this.CursorChanged += new System.EventHandler(this.FrmReportesAlll_CursorChanged);
            this.DockChanged += new System.EventHandler(this.FrmReportesAlll_DockChanged);
            this.LocationChanged += new System.EventHandler(this.FrmReportesAlll_LocationChanged);
            this.TextChanged += new System.EventHandler(this.FrmReportesAlll_TextChanged);
            this.Click += new System.EventHandler(this.FrmReportesAlll_Click);
            this.DoubleClick += new System.EventHandler(this.FrmReportesAlll_DoubleClick);
            this.Enter += new System.EventHandler(this.FrmReportesAlll_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmReportesAlll_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmReportesAlll_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmReportesAlll_KeyUp);
            this.Leave += new System.EventHandler(this.FrmReportesAlll_Leave);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmReportesAlll_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FrmReportesAlll_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmReportesAlll_MouseDown);
            this.MouseEnter += new System.EventHandler(this.FrmReportesAlll_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FrmReportesAlll_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmReportesAlll_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmReportesAlll_MouseUp);
            this.Move += new System.EventHandler(this.FrmReportesAlll_Move);
            this.ResumeLayout(false);

        }



        #endregion

        private CrystalDecisions.CrystalReports.Engine.ReportDocument reportDocument1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crViewer;
    }
}