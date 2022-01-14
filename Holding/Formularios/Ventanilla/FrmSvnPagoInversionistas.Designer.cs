
namespace Holding
{
    partial class FrmSvnPagoInversionistas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSvnPagoInversionistas));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreCliente = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxMoneda = new MaterialSkin.Controls.MaterialComboBox();
            this.txtMontoInversion = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalPagar = new MaterialSkin.Controls.MaterialTextBox();
            this.txtInteresCorriente = new MaterialSkin.Controls.MaterialTextBox();
            this.txtInteresMoratorio = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrincipal = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPlanPago = new System.Windows.Forms.DataGridView();
            this.Pagar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbDocumentos = new System.Windows.Forms.TabPage();
            this.txtObservacion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMonto = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNumRecibo = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxTipoMoneda = new MaterialSkin.Controls.MaterialComboBox();
            this.txtFechaPago = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxFormaPago = new MaterialSkin.Controls.MaterialComboBox();
            this.txtIdInversion = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnActualizaTodasAcciones = new System.Windows.Forms.Button();
            this.txtNombreEmpresa = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRuc = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPersona = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCodPersona = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIdEstadoInver = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPago)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbDocumentos.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pago Inversión";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.cbxMoneda);
            this.groupBox1.Controls.Add(this.txtMontoInversion);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(28, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 220);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumen de Inversión";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCliente.Depth = 0;
            this.txtNombreCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreCliente.Hint = "Nombre del Cliente";
            this.txtNombreCliente.LeadingIcon = null;
            this.txtNombreCliente.Location = new System.Drawing.Point(97, 133);
            this.txtNombreCliente.MaxLength = 50;
            this.txtNombreCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreCliente.Multiline = false;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(511, 50);
            this.txtNombreCliente.TabIndex = 17;
            this.txtNombreCliente.Text = "";
            this.txtNombreCliente.TrailingIcon = null;
            // 
            // txtNumero
            // 
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Depth = 0;
            this.txtNumero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumero.Hint = "Número de la Inversión";
            this.txtNumero.LeadingIcon = null;
            this.txtNumero.Location = new System.Drawing.Point(15, 54);
            this.txtNumero.MaxLength = 50;
            this.txtNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumero.Multiline = false;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(195, 50);
            this.txtNumero.TabIndex = 15;
            this.txtNumero.Text = "";
            this.txtNumero.TrailingIcon = null;
            // 
            // cbxMoneda
            // 
            this.cbxMoneda.AutoResize = false;
            this.cbxMoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxMoneda.Depth = 0;
            this.cbxMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxMoneda.DropDownHeight = 174;
            this.cbxMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMoneda.DropDownWidth = 121;
            this.cbxMoneda.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxMoneda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxMoneda.FormattingEnabled = true;
            this.cbxMoneda.Hint = "Moneda";
            this.cbxMoneda.IntegralHeight = false;
            this.cbxMoneda.ItemHeight = 43;
            this.cbxMoneda.Location = new System.Drawing.Point(233, 53);
            this.cbxMoneda.MaxDropDownItems = 4;
            this.cbxMoneda.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxMoneda.Name = "cbxMoneda";
            this.cbxMoneda.Size = new System.Drawing.Size(195, 49);
            this.cbxMoneda.StartIndex = 0;
            this.cbxMoneda.TabIndex = 12;
            // 
            // txtMontoInversion
            // 
            this.txtMontoInversion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoInversion.Depth = 0;
            this.txtMontoInversion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMontoInversion.Hint = "Monto Inversión";
            this.txtMontoInversion.LeadingIcon = null;
            this.txtMontoInversion.Location = new System.Drawing.Point(449, 54);
            this.txtMontoInversion.MaxLength = 50;
            this.txtMontoInversion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMontoInversion.Multiline = false;
            this.txtMontoInversion.Name = "txtMontoInversion";
            this.txtMontoInversion.Size = new System.Drawing.Size(257, 50);
            this.txtMontoInversion.TabIndex = 10;
            this.txtMontoInversion.Text = "";
            this.txtMontoInversion.TrailingIcon = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalPagar);
            this.groupBox2.Controls.Add(this.txtInteresCorriente);
            this.groupBox2.Controls.Add(this.txtInteresMoratorio);
            this.groupBox2.Controls.Add(this.txtPrincipal);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(28, 486);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(723, 240);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Desglose de Pago";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPagar.Depth = 0;
            this.txtTotalPagar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalPagar.ForeColor = System.Drawing.Color.White;
            this.txtTotalPagar.Hint = "Total a Pagar";
            this.txtTotalPagar.LeadingIcon = null;
            this.txtTotalPagar.Location = new System.Drawing.Point(253, 161);
            this.txtTotalPagar.MaxLength = 50;
            this.txtTotalPagar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalPagar.Multiline = false;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(211, 50);
            this.txtTotalPagar.TabIndex = 13;
            this.txtTotalPagar.Text = "";
            this.txtTotalPagar.TrailingIcon = null;
            // 
            // txtInteresCorriente
            // 
            this.txtInteresCorriente.BackColor = System.Drawing.SystemColors.Window;
            this.txtInteresCorriente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInteresCorriente.Depth = 0;
            this.txtInteresCorriente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtInteresCorriente.ForeColor = System.Drawing.Color.White;
            this.txtInteresCorriente.Hint = "Interés Corriente a Pagar";
            this.txtInteresCorriente.LeadingIcon = null;
            this.txtInteresCorriente.Location = new System.Drawing.Point(495, 65);
            this.txtInteresCorriente.MaxLength = 50;
            this.txtInteresCorriente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInteresCorriente.Multiline = false;
            this.txtInteresCorriente.Name = "txtInteresCorriente";
            this.txtInteresCorriente.Size = new System.Drawing.Size(211, 50);
            this.txtInteresCorriente.TabIndex = 12;
            this.txtInteresCorriente.Text = "";
            this.txtInteresCorriente.TrailingIcon = null;
            // 
            // txtInteresMoratorio
            // 
            this.txtInteresMoratorio.BackColor = System.Drawing.SystemColors.Window;
            this.txtInteresMoratorio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInteresMoratorio.Depth = 0;
            this.txtInteresMoratorio.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtInteresMoratorio.ForeColor = System.Drawing.Color.White;
            this.txtInteresMoratorio.Hint = "Interés Moratorio a Pagar";
            this.txtInteresMoratorio.LeadingIcon = null;
            this.txtInteresMoratorio.Location = new System.Drawing.Point(253, 65);
            this.txtInteresMoratorio.MaxLength = 50;
            this.txtInteresMoratorio.MouseState = MaterialSkin.MouseState.OUT;
            this.txtInteresMoratorio.Multiline = false;
            this.txtInteresMoratorio.Name = "txtInteresMoratorio";
            this.txtInteresMoratorio.Size = new System.Drawing.Size(214, 50);
            this.txtInteresMoratorio.TabIndex = 11;
            this.txtInteresMoratorio.Text = "";
            this.txtInteresMoratorio.TrailingIcon = null;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrincipal.Depth = 0;
            this.txtPrincipal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrincipal.ForeColor = System.Drawing.Color.White;
            this.txtPrincipal.Hint = "Principal a Pagar";
            this.txtPrincipal.LeadingIcon = null;
            this.txtPrincipal.Location = new System.Drawing.Point(15, 65);
            this.txtPrincipal.MaxLength = 50;
            this.txtPrincipal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrincipal.Multiline = false;
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(211, 50);
            this.txtPrincipal.TabIndex = 10;
            this.txtPrincipal.Text = "";
            this.txtPrincipal.TrailingIcon = null;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPlanPago);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(757, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(723, 306);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plan de Pago";
            // 
            // dgvPlanPago
            // 
            this.dgvPlanPago.AllowUserToAddRows = false;
            this.dgvPlanPago.AllowUserToDeleteRows = false;
            this.dgvPlanPago.AllowUserToResizeColumns = false;
            this.dgvPlanPago.AllowUserToResizeRows = false;
            this.dgvPlanPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlanPago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlanPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pagar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlanPago.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlanPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanPago.EnableHeadersVisualStyles = false;
            this.dgvPlanPago.Location = new System.Drawing.Point(3, 19);
            this.dgvPlanPago.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPlanPago.MultiSelect = false;
            this.dgvPlanPago.Name = "dgvPlanPago";
            this.dgvPlanPago.RowHeadersVisible = false;
            this.dgvPlanPago.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvPlanPago.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlanPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPlanPago.Size = new System.Drawing.Size(717, 284);
            this.dgvPlanPago.TabIndex = 1;
            // 
            // Pagar
            // 
            this.Pagar.HeaderText = "Pagar";
            this.Pagar.MinimumWidth = 6;
            this.Pagar.Name = "Pagar";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tabControl1);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(757, 384);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(723, 342);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle de Forma de Pago";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbDocumentos);
            this.tabControl1.Location = new System.Drawing.Point(6, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(714, 314);
            this.tabControl1.TabIndex = 16;
            // 
            // tbDocumentos
            // 
            this.tbDocumentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.tbDocumentos.Controls.Add(this.txtObservacion);
            this.tbDocumentos.Controls.Add(this.txtMonto);
            this.tbDocumentos.Controls.Add(this.txtNumRecibo);
            this.tbDocumentos.Controls.Add(this.cbxTipoMoneda);
            this.tbDocumentos.Controls.Add(this.txtFechaPago);
            this.tbDocumentos.Controls.Add(this.cbxFormaPago);
            this.tbDocumentos.Location = new System.Drawing.Point(4, 25);
            this.tbDocumentos.Name = "tbDocumentos";
            this.tbDocumentos.Padding = new System.Windows.Forms.Padding(3);
            this.tbDocumentos.Size = new System.Drawing.Size(706, 285);
            this.tbDocumentos.TabIndex = 0;
            this.tbDocumentos.Text = "Documentos";
            // 
            // txtObservacion
            // 
            this.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservacion.Depth = 0;
            this.txtObservacion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtObservacion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtObservacion.Hint = "Observación";
            this.txtObservacion.LeadingIcon = null;
            this.txtObservacion.Location = new System.Drawing.Point(393, 190);
            this.txtObservacion.MaxLength = 50;
            this.txtObservacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtObservacion.Multiline = false;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(269, 50);
            this.txtObservacion.TabIndex = 17;
            this.txtObservacion.Text = "";
            this.txtObservacion.TrailingIcon = null;
            // 
            // txtMonto
            // 
            this.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMonto.Depth = 0;
            this.txtMonto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMonto.Hint = "Monto";
            this.txtMonto.LeadingIcon = null;
            this.txtMonto.Location = new System.Drawing.Point(49, 190);
            this.txtMonto.MaxLength = 50;
            this.txtMonto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMonto.Multiline = false;
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(269, 50);
            this.txtMonto.TabIndex = 16;
            this.txtMonto.Text = "";
            this.txtMonto.TrailingIcon = null;
            // 
            // txtNumRecibo
            // 
            this.txtNumRecibo.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumRecibo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumRecibo.Depth = 0;
            this.txtNumRecibo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumRecibo.ForeColor = System.Drawing.Color.White;
            this.txtNumRecibo.Hint = "Número de Transferencia";
            this.txtNumRecibo.LeadingIcon = null;
            this.txtNumRecibo.Location = new System.Drawing.Point(70, 25);
            this.txtNumRecibo.MaxLength = 50;
            this.txtNumRecibo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumRecibo.Multiline = false;
            this.txtNumRecibo.Name = "txtNumRecibo";
            this.txtNumRecibo.Size = new System.Drawing.Size(233, 50);
            this.txtNumRecibo.TabIndex = 14;
            this.txtNumRecibo.Text = "";
            this.txtNumRecibo.TrailingIcon = null;
            // 
            // cbxTipoMoneda
            // 
            this.cbxTipoMoneda.AutoResize = false;
            this.cbxTipoMoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxTipoMoneda.Depth = 0;
            this.cbxTipoMoneda.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxTipoMoneda.DropDownHeight = 174;
            this.cbxTipoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoMoneda.DropDownWidth = 121;
            this.cbxTipoMoneda.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxTipoMoneda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxTipoMoneda.FormattingEnabled = true;
            this.cbxTipoMoneda.Hint = "Tipo Moneda";
            this.cbxTipoMoneda.IntegralHeight = false;
            this.cbxTipoMoneda.ItemHeight = 43;
            this.cbxTipoMoneda.Location = new System.Drawing.Point(414, 24);
            this.cbxTipoMoneda.MaxDropDownItems = 4;
            this.cbxTipoMoneda.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxTipoMoneda.Name = "cbxTipoMoneda";
            this.cbxTipoMoneda.Size = new System.Drawing.Size(233, 49);
            this.cbxTipoMoneda.StartIndex = 0;
            this.cbxTipoMoneda.TabIndex = 9;
            // 
            // txtFechaPago
            // 
            this.txtFechaPago.BackColor = System.Drawing.SystemColors.Window;
            this.txtFechaPago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaPago.Depth = 0;
            this.txtFechaPago.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaPago.ForeColor = System.Drawing.Color.White;
            this.txtFechaPago.Hint = "Fecha de Pago";
            this.txtFechaPago.LeadingIcon = null;
            this.txtFechaPago.Location = new System.Drawing.Point(70, 104);
            this.txtFechaPago.MaxLength = 50;
            this.txtFechaPago.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFechaPago.Multiline = false;
            this.txtFechaPago.Name = "txtFechaPago";
            this.txtFechaPago.Size = new System.Drawing.Size(233, 50);
            this.txtFechaPago.TabIndex = 15;
            this.txtFechaPago.Text = "";
            this.txtFechaPago.TrailingIcon = null;
            // 
            // cbxFormaPago
            // 
            this.cbxFormaPago.AutoResize = false;
            this.cbxFormaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxFormaPago.Depth = 0;
            this.cbxFormaPago.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxFormaPago.DropDownHeight = 174;
            this.cbxFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFormaPago.DropDownWidth = 121;
            this.cbxFormaPago.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxFormaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxFormaPago.FormattingEnabled = true;
            this.cbxFormaPago.Hint = "Forma de Pago";
            this.cbxFormaPago.IntegralHeight = false;
            this.cbxFormaPago.ItemHeight = 43;
            this.cbxFormaPago.Location = new System.Drawing.Point(414, 103);
            this.cbxFormaPago.MaxDropDownItems = 4;
            this.cbxFormaPago.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxFormaPago.Name = "cbxFormaPago";
            this.cbxFormaPago.Size = new System.Drawing.Size(233, 49);
            this.cbxFormaPago.StartIndex = 0;
            this.cbxFormaPago.TabIndex = 8;
            // 
            // txtIdInversion
            // 
            this.txtIdInversion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdInversion.Depth = 0;
            this.txtIdInversion.Enabled = false;
            this.txtIdInversion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdInversion.Hint = "Id";
            this.txtIdInversion.LeadingIcon = null;
            this.txtIdInversion.Location = new System.Drawing.Point(186, 16);
            this.txtIdInversion.MaxLength = 50;
            this.txtIdInversion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdInversion.Multiline = false;
            this.txtIdInversion.Name = "txtIdInversion";
            this.txtIdInversion.Size = new System.Drawing.Size(41, 50);
            this.txtIdInversion.TabIndex = 16;
            this.txtIdInversion.Text = "";
            this.txtIdInversion.TrailingIcon = null;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.btnActualizaTodasAcciones);
            this.groupBox5.Controls.Add(this.txtNombreEmpresa);
            this.groupBox5.Controls.Add(this.txtRuc);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(28, 72);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(723, 182);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Info. Persona que Paga";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Holding.Properties.Resources.persona;
            this.pictureBox1.Location = new System.Drawing.Point(30, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Holding.Properties.Resources.agregar_persona;
            this.button1.Location = new System.Drawing.Point(633, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 51);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnActualizaTodasAcciones
            // 
            this.btnActualizaTodasAcciones.FlatAppearance.BorderSize = 0;
            this.btnActualizaTodasAcciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizaTodasAcciones.Image = global::Holding.Properties.Resources.Actualizar;
            this.btnActualizaTodasAcciones.Location = new System.Drawing.Point(633, 109);
            this.btnActualizaTodasAcciones.Name = "btnActualizaTodasAcciones";
            this.btnActualizaTodasAcciones.Size = new System.Drawing.Size(48, 51);
            this.btnActualizaTodasAcciones.TabIndex = 18;
            this.btnActualizaTodasAcciones.UseVisualStyleBackColor = true;
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreEmpresa.Depth = 0;
            this.txtNombreEmpresa.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmpresa.Hint = "Nombre Empresa";
            this.txtNombreEmpresa.LeadingIcon = null;
            this.txtNombreEmpresa.Location = new System.Drawing.Point(204, 40);
            this.txtNombreEmpresa.MaxLength = 50;
            this.txtNombreEmpresa.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEmpresa.Multiline = false;
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(404, 50);
            this.txtNombreEmpresa.TabIndex = 17;
            this.txtNombreEmpresa.Text = "";
            this.txtNombreEmpresa.TrailingIcon = null;
            // 
            // txtRuc
            // 
            this.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRuc.Depth = 0;
            this.txtRuc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRuc.Hint = "Numero RUC";
            this.txtRuc.LeadingIcon = null;
            this.txtRuc.Location = new System.Drawing.Point(204, 110);
            this.txtRuc.MaxLength = 50;
            this.txtRuc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRuc.Multiline = false;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(404, 50);
            this.txtRuc.TabIndex = 16;
            this.txtRuc.Text = "";
            this.txtRuc.TrailingIcon = null;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::Holding.Properties.Resources.Cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelar.Location = new System.Drawing.Point(1160, 746);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 58);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Holding.Properties.Resources.Guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGuardar.Location = new System.Drawing.Point(1347, 746);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 58);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // txtPersona
            // 
            this.txtPersona.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersona.Depth = 0;
            this.txtPersona.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPersona.Hint = "Persona que Paga";
            this.txtPersona.LeadingIcon = null;
            this.txtPersona.Location = new System.Drawing.Point(325, 16);
            this.txtPersona.MaxLength = 50;
            this.txtPersona.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPersona.Multiline = false;
            this.txtPersona.Name = "txtPersona";
            this.txtPersona.Size = new System.Drawing.Size(311, 50);
            this.txtPersona.TabIndex = 18;
            this.txtPersona.Text = "";
            this.txtPersona.TrailingIcon = null;
            // 
            // txtCodPersona
            // 
            this.txtCodPersona.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodPersona.Depth = 0;
            this.txtCodPersona.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodPersona.Hint = "Código de Persona";
            this.txtCodPersona.LeadingIcon = null;
            this.txtCodPersona.Location = new System.Drawing.Point(713, 16);
            this.txtCodPersona.MaxLength = 50;
            this.txtCodPersona.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCodPersona.Multiline = false;
            this.txtCodPersona.Name = "txtCodPersona";
            this.txtCodPersona.Size = new System.Drawing.Size(264, 50);
            this.txtCodPersona.TabIndex = 19;
            this.txtCodPersona.Text = "";
            this.txtCodPersona.TrailingIcon = null;
            // 
            // txtIdEstadoInver
            // 
            this.txtIdEstadoInver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdEstadoInver.Depth = 0;
            this.txtIdEstadoInver.Enabled = false;
            this.txtIdEstadoInver.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdEstadoInver.Hint = "Id Estado Inversion";
            this.txtIdEstadoInver.LeadingIcon = null;
            this.txtIdEstadoInver.Location = new System.Drawing.Point(1054, 16);
            this.txtIdEstadoInver.MaxLength = 50;
            this.txtIdEstadoInver.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdEstadoInver.Multiline = false;
            this.txtIdEstadoInver.Name = "txtIdEstadoInver";
            this.txtIdEstadoInver.Size = new System.Drawing.Size(204, 50);
            this.txtIdEstadoInver.TabIndex = 20;
            this.txtIdEstadoInver.Text = "";
            this.txtIdEstadoInver.TrailingIcon = null;
            // 
            // FrmSvnPagoInversionistas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1498, 827);
            this.Controls.Add(this.txtIdEstadoInver);
            this.Controls.Add(this.txtCodPersona);
            this.Controls.Add(this.txtPersona);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.txtIdInversion);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSvnPagoInversionistas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pago Inversión";
            this.Load += new System.EventHandler(this.FrmSvnPagoInversionistas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanPago)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbDocumentos.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private MaterialSkin.Controls.MaterialTextBox txtTotalPagar;
        private MaterialSkin.Controls.MaterialTextBox txtInteresCorriente;
        private MaterialSkin.Controls.MaterialTextBox txtInteresMoratorio;
        private MaterialSkin.Controls.MaterialTextBox txtPrincipal;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialTextBox txtMontoInversion;
        private MaterialSkin.Controls.MaterialComboBox cbxMoneda;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbDocumentos;
        private MaterialSkin.Controls.MaterialTextBox txtFechaPago;
        private MaterialSkin.Controls.MaterialTextBox txtNumRecibo;
        private MaterialSkin.Controls.MaterialComboBox cbxTipoMoneda;
        private MaterialSkin.Controls.MaterialComboBox cbxFormaPago;
        private MaterialSkin.Controls.MaterialTextBox txtNumero;
        private MaterialSkin.Controls.MaterialTextBox txtMonto;
        private MaterialSkin.Controls.MaterialTextBox txtIdInversion;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialTextBox txtNombreEmpresa;
        private MaterialSkin.Controls.MaterialTextBox txtRuc;
        private System.Windows.Forms.Button btnActualizaTodasAcciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox txtNombreCliente;
        private System.Windows.Forms.DataGridView dgvPlanPago;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Pagar;
        private MaterialSkin.Controls.MaterialTextBox txtObservacion;
        private System.Windows.Forms.ErrorProvider Error;
        private MaterialSkin.Controls.MaterialTextBox txtCodPersona;
        private MaterialSkin.Controls.MaterialTextBox txtPersona;
        private MaterialSkin.Controls.MaterialTextBox txtIdEstadoInver;
    }
}