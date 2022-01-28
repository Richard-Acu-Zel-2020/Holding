
namespace Holding
{
    partial class FrmScrSolicitudAprobacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmScrSolicitudAprobacion));
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtObservacion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNumeroSolicitud = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreCliente = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPropietario = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxTipoMoneda = new MaterialSkin.Controls.MaterialComboBox();
            this.txtMontoSolicitado = new MaterialSkin.Controls.MaterialTextBox();
            this.txtIdSolicitud = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxEstadoSolicitud = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.txtTasaInteresCor = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTasaInteresMor = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMontoApro = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTasaComision = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMontoComision = new MaterialSkin.Controls.MaterialTextBox();
            this.chbxVencimiento = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtPlazoAprobado = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxPeriocidadPrinApro = new MaterialSkin.Controls.MaterialComboBox();
            this.cbxPeriocidadIntApro = new MaterialSkin.Controls.MaterialComboBox();
            this.txtFechaDesembolso = new MaterialSkin.Controls.MaterialTextBox();
            this.btnFechaNacimiento = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Gestiones en Comité";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFechaNacimiento);
            this.groupBox2.Controls.Add(this.txtFechaDesembolso);
            this.groupBox2.Controls.Add(this.txtPropietario);
            this.groupBox2.Controls.Add(this.cbxPeriocidadIntApro);
            this.groupBox2.Controls.Add(this.cbxTipoMoneda);
            this.groupBox2.Controls.Add(this.cbxPeriocidadPrinApro);
            this.groupBox2.Controls.Add(this.txtPlazoAprobado);
            this.groupBox2.Controls.Add(this.chbxVencimiento);
            this.groupBox2.Controls.Add(this.txtMontoComision);
            this.groupBox2.Controls.Add(this.txtTasaComision);
            this.groupBox2.Controls.Add(this.txtMontoApro);
            this.groupBox2.Controls.Add(this.txtTasaInteresMor);
            this.groupBox2.Controls.Add(this.txtTasaInteresCor);
            this.groupBox2.Controls.Add(this.txtObservacion);
            this.groupBox2.Controls.Add(this.txtNumeroSolicitud);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.txtMontoSolicitado);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1083, 451);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Solicitud";
            // 
            // txtObservacion
            // 
            this.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservacion.Depth = 0;
            this.txtObservacion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtObservacion.Hint = "Observación Comité";
            this.txtObservacion.LeadingIcon = null;
            this.txtObservacion.Location = new System.Drawing.Point(822, 33);
            this.txtObservacion.MaxLength = 50;
            this.txtObservacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(236, 50);
            this.txtObservacion.TabIndex = 26;
            this.txtObservacion.Text = "";
            this.txtObservacion.TrailingIcon = null;
            // 
            // txtNumeroSolicitud
            // 
            this.txtNumeroSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroSolicitud.Depth = 0;
            this.txtNumeroSolicitud.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumeroSolicitud.Hint = "Número de Solicitud";
            this.txtNumeroSolicitud.LeadingIcon = null;
            this.txtNumeroSolicitud.Location = new System.Drawing.Point(21, 33);
            this.txtNumeroSolicitud.MaxLength = 50;
            this.txtNumeroSolicitud.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNumeroSolicitud.Multiline = false;
            this.txtNumeroSolicitud.Name = "txtNumeroSolicitud";
            this.txtNumeroSolicitud.ReadOnly = true;
            this.txtNumeroSolicitud.Size = new System.Drawing.Size(236, 50);
            this.txtNumeroSolicitud.TabIndex = 0;
            this.txtNumeroSolicitud.Text = "";
            this.txtNumeroSolicitud.TrailingIcon = null;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCliente.Depth = 0;
            this.txtNombreCliente.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreCliente.Hint = "Nombre del Cliente";
            this.txtNombreCliente.LeadingIcon = null;
            this.txtNombreCliente.Location = new System.Drawing.Point(284, 33);
            this.txtNombreCliente.MaxLength = 50;
            this.txtNombreCliente.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreCliente.Multiline = false;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(508, 50);
            this.txtNombreCliente.TabIndex = 5;
            this.txtNombreCliente.Text = "";
            this.txtNombreCliente.TrailingIcon = null;
            // 
            // txtPropietario
            // 
            this.txtPropietario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPropietario.Depth = 0;
            this.txtPropietario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPropietario.Hint = "Propietario";
            this.txtPropietario.LeadingIcon = null;
            this.txtPropietario.Location = new System.Drawing.Point(21, 384);
            this.txtPropietario.MaxLength = 50;
            this.txtPropietario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPropietario.Multiline = false;
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(236, 50);
            this.txtPropietario.TabIndex = 44;
            this.txtPropietario.Text = "";
            this.txtPropietario.TrailingIcon = null;
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
            this.cbxTipoMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxTipoMoneda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxTipoMoneda.FormattingEnabled = true;
            this.cbxTipoMoneda.Hint = "Tipo de Moneda";
            this.cbxTipoMoneda.IntegralHeight = false;
            this.cbxTipoMoneda.ItemHeight = 43;
            this.cbxTipoMoneda.Location = new System.Drawing.Point(822, 207);
            this.cbxTipoMoneda.MaxDropDownItems = 4;
            this.cbxTipoMoneda.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxTipoMoneda.Name = "cbxTipoMoneda";
            this.cbxTipoMoneda.Size = new System.Drawing.Size(236, 49);
            this.cbxTipoMoneda.StartIndex = 0;
            this.cbxTipoMoneda.TabIndex = 40;
            // 
            // txtMontoSolicitado
            // 
            this.txtMontoSolicitado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoSolicitado.Depth = 0;
            this.txtMontoSolicitado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMontoSolicitado.Hint = "Monto Solicitado";
            this.txtMontoSolicitado.LeadingIcon = null;
            this.txtMontoSolicitado.Location = new System.Drawing.Point(556, 120);
            this.txtMontoSolicitado.MaxLength = 50;
            this.txtMontoSolicitado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMontoSolicitado.Multiline = false;
            this.txtMontoSolicitado.Name = "txtMontoSolicitado";
            this.txtMontoSolicitado.Size = new System.Drawing.Size(236, 50);
            this.txtMontoSolicitado.TabIndex = 1;
            this.txtMontoSolicitado.Text = "";
            this.txtMontoSolicitado.TrailingIcon = null;
            // 
            // txtIdSolicitud
            // 
            this.txtIdSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdSolicitud.Depth = 0;
            this.txtIdSolicitud.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdSolicitud.Hint = "Id";
            this.txtIdSolicitud.LeadingIcon = null;
            this.txtIdSolicitud.Location = new System.Drawing.Point(274, 9);
            this.txtIdSolicitud.MaxLength = 50;
            this.txtIdSolicitud.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdSolicitud.Multiline = false;
            this.txtIdSolicitud.Name = "txtIdSolicitud";
            this.txtIdSolicitud.ReadOnly = true;
            this.txtIdSolicitud.Size = new System.Drawing.Size(112, 50);
            this.txtIdSolicitud.TabIndex = 16;
            this.txtIdSolicitud.Text = "";
            this.txtIdSolicitud.TrailingIcon = null;
            this.txtIdSolicitud.Visible = false;
            // 
            // cbxEstadoSolicitud
            // 
            this.cbxEstadoSolicitud.AutoResize = false;
            this.cbxEstadoSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxEstadoSolicitud.Depth = 0;
            this.cbxEstadoSolicitud.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxEstadoSolicitud.DropDownHeight = 174;
            this.cbxEstadoSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstadoSolicitud.DropDownWidth = 121;
            this.cbxEstadoSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxEstadoSolicitud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxEstadoSolicitud.FormattingEnabled = true;
            this.cbxEstadoSolicitud.Hint = "Estado Solicitud";
            this.cbxEstadoSolicitud.IntegralHeight = false;
            this.cbxEstadoSolicitud.ItemHeight = 43;
            this.cbxEstadoSolicitud.Location = new System.Drawing.Point(441, 9);
            this.cbxEstadoSolicitud.MaxDropDownItems = 4;
            this.cbxEstadoSolicitud.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxEstadoSolicitud.Name = "cbxEstadoSolicitud";
            this.cbxEstadoSolicitud.Size = new System.Drawing.Size(236, 49);
            this.cbxEstadoSolicitud.StartIndex = 0;
            this.cbxEstadoSolicitud.TabIndex = 41;
            this.cbxEstadoSolicitud.Visible = false;
            // 
            // btnAprobar
            // 
            this.btnAprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnAprobar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAprobar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprobar.ForeColor = System.Drawing.Color.White;
            this.btnAprobar.Image = global::Holding.Properties.Resources.aprobar_inversionistas;
            this.btnAprobar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAprobar.Location = new System.Drawing.Point(934, 547);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(136, 58);
            this.btnAprobar.TabIndex = 15;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAprobar.UseVisualStyleBackColor = false;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.Image = global::Holding.Properties.Resources.rechazar_inversionistas;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAnular.Location = new System.Drawing.Point(764, 547);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(136, 58);
            this.btnAnular.TabIndex = 14;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // txtTasaInteresCor
            // 
            this.txtTasaInteresCor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTasaInteresCor.Depth = 0;
            this.txtTasaInteresCor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTasaInteresCor.Hint = "Tasa Interés Corriente";
            this.txtTasaInteresCor.LeadingIcon = null;
            this.txtTasaInteresCor.Location = new System.Drawing.Point(21, 120);
            this.txtTasaInteresCor.MaxLength = 50;
            this.txtTasaInteresCor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTasaInteresCor.Multiline = false;
            this.txtTasaInteresCor.Name = "txtTasaInteresCor";
            this.txtTasaInteresCor.ReadOnly = true;
            this.txtTasaInteresCor.Size = new System.Drawing.Size(236, 50);
            this.txtTasaInteresCor.TabIndex = 27;
            this.txtTasaInteresCor.Text = "";
            this.txtTasaInteresCor.TrailingIcon = null;
            // 
            // txtTasaInteresMor
            // 
            this.txtTasaInteresMor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTasaInteresMor.Depth = 0;
            this.txtTasaInteresMor.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTasaInteresMor.Hint = "Tasa Interés Moratorio";
            this.txtTasaInteresMor.LeadingIcon = null;
            this.txtTasaInteresMor.Location = new System.Drawing.Point(284, 120);
            this.txtTasaInteresMor.MaxLength = 50;
            this.txtTasaInteresMor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTasaInteresMor.Multiline = false;
            this.txtTasaInteresMor.Name = "txtTasaInteresMor";
            this.txtTasaInteresMor.ReadOnly = true;
            this.txtTasaInteresMor.Size = new System.Drawing.Size(236, 50);
            this.txtTasaInteresMor.TabIndex = 28;
            this.txtTasaInteresMor.Text = "";
            this.txtTasaInteresMor.TrailingIcon = null;
            // 
            // txtMontoApro
            // 
            this.txtMontoApro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoApro.Depth = 0;
            this.txtMontoApro.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMontoApro.Hint = "Monto Aprobado";
            this.txtMontoApro.LeadingIcon = null;
            this.txtMontoApro.Location = new System.Drawing.Point(822, 120);
            this.txtMontoApro.MaxLength = 50;
            this.txtMontoApro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMontoApro.Multiline = false;
            this.txtMontoApro.Name = "txtMontoApro";
            this.txtMontoApro.ReadOnly = true;
            this.txtMontoApro.Size = new System.Drawing.Size(236, 50);
            this.txtMontoApro.TabIndex = 29;
            this.txtMontoApro.Text = "";
            this.txtMontoApro.TrailingIcon = null;
            // 
            // txtTasaComision
            // 
            this.txtTasaComision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTasaComision.Depth = 0;
            this.txtTasaComision.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTasaComision.Hint = "Tasa Comisión %";
            this.txtTasaComision.LeadingIcon = null;
            this.txtTasaComision.Location = new System.Drawing.Point(284, 209);
            this.txtTasaComision.MaxLength = 50;
            this.txtTasaComision.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTasaComision.Multiline = false;
            this.txtTasaComision.Name = "txtTasaComision";
            this.txtTasaComision.ReadOnly = true;
            this.txtTasaComision.Size = new System.Drawing.Size(236, 50);
            this.txtTasaComision.TabIndex = 30;
            this.txtTasaComision.Text = "";
            this.txtTasaComision.TrailingIcon = null;
            // 
            // txtMontoComision
            // 
            this.txtMontoComision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoComision.Depth = 0;
            this.txtMontoComision.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMontoComision.Hint = "Monto Comisión";
            this.txtMontoComision.LeadingIcon = null;
            this.txtMontoComision.Location = new System.Drawing.Point(21, 209);
            this.txtMontoComision.MaxLength = 50;
            this.txtMontoComision.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMontoComision.Multiline = false;
            this.txtMontoComision.Name = "txtMontoComision";
            this.txtMontoComision.ReadOnly = true;
            this.txtMontoComision.Size = new System.Drawing.Size(236, 50);
            this.txtMontoComision.TabIndex = 31;
            this.txtMontoComision.Text = "";
            this.txtMontoComision.TrailingIcon = null;
            // 
            // chbxVencimiento
            // 
            this.chbxVencimiento.AutoSize = true;
            this.chbxVencimiento.Depth = 0;
            this.chbxVencimiento.Location = new System.Drawing.Point(308, 397);
            this.chbxVencimiento.Margin = new System.Windows.Forms.Padding(0);
            this.chbxVencimiento.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbxVencimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbxVencimiento.Name = "chbxVencimiento";
            this.chbxVencimiento.Ripple = true;
            this.chbxVencimiento.Size = new System.Drawing.Size(141, 37);
            this.chbxVencimiento.TabIndex = 32;
            this.chbxVencimiento.Text = "Al Vencimiento";
            this.chbxVencimiento.UseVisualStyleBackColor = true;
            // 
            // txtPlazoAprobado
            // 
            this.txtPlazoAprobado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlazoAprobado.Depth = 0;
            this.txtPlazoAprobado.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPlazoAprobado.Hint = "Plazo Aprobado";
            this.txtPlazoAprobado.LeadingIcon = null;
            this.txtPlazoAprobado.Location = new System.Drawing.Point(556, 209);
            this.txtPlazoAprobado.MaxLength = 50;
            this.txtPlazoAprobado.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPlazoAprobado.Multiline = false;
            this.txtPlazoAprobado.Name = "txtPlazoAprobado";
            this.txtPlazoAprobado.ReadOnly = true;
            this.txtPlazoAprobado.Size = new System.Drawing.Size(236, 50);
            this.txtPlazoAprobado.TabIndex = 33;
            this.txtPlazoAprobado.Text = "";
            this.txtPlazoAprobado.TrailingIcon = null;
            // 
            // cbxPeriocidadPrinApro
            // 
            this.cbxPeriocidadPrinApro.AutoResize = false;
            this.cbxPeriocidadPrinApro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxPeriocidadPrinApro.Depth = 0;
            this.cbxPeriocidadPrinApro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxPeriocidadPrinApro.DropDownHeight = 174;
            this.cbxPeriocidadPrinApro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPeriocidadPrinApro.DropDownWidth = 121;
            this.cbxPeriocidadPrinApro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxPeriocidadPrinApro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxPeriocidadPrinApro.FormattingEnabled = true;
            this.cbxPeriocidadPrinApro.Hint = "Periocidad Principal Aprobado";
            this.cbxPeriocidadPrinApro.IntegralHeight = false;
            this.cbxPeriocidadPrinApro.ItemHeight = 43;
            this.cbxPeriocidadPrinApro.Location = new System.Drawing.Point(21, 291);
            this.cbxPeriocidadPrinApro.MaxDropDownItems = 4;
            this.cbxPeriocidadPrinApro.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxPeriocidadPrinApro.Name = "cbxPeriocidadPrinApro";
            this.cbxPeriocidadPrinApro.Size = new System.Drawing.Size(272, 49);
            this.cbxPeriocidadPrinApro.StartIndex = 0;
            this.cbxPeriocidadPrinApro.TabIndex = 43;
            // 
            // cbxPeriocidadIntApro
            // 
            this.cbxPeriocidadIntApro.AutoResize = false;
            this.cbxPeriocidadIntApro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxPeriocidadIntApro.Depth = 0;
            this.cbxPeriocidadIntApro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxPeriocidadIntApro.DropDownHeight = 174;
            this.cbxPeriocidadIntApro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPeriocidadIntApro.DropDownWidth = 121;
            this.cbxPeriocidadIntApro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxPeriocidadIntApro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxPeriocidadIntApro.FormattingEnabled = true;
            this.cbxPeriocidadIntApro.Hint = "Periocidad Interés Aprobado";
            this.cbxPeriocidadIntApro.IntegralHeight = false;
            this.cbxPeriocidadIntApro.ItemHeight = 43;
            this.cbxPeriocidadIntApro.Location = new System.Drawing.Point(340, 291);
            this.cbxPeriocidadIntApro.MaxDropDownItems = 4;
            this.cbxPeriocidadIntApro.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxPeriocidadIntApro.Name = "cbxPeriocidadIntApro";
            this.cbxPeriocidadIntApro.Size = new System.Drawing.Size(272, 49);
            this.cbxPeriocidadIntApro.StartIndex = 0;
            this.cbxPeriocidadIntApro.TabIndex = 44;
            // 
            // txtFechaDesembolso
            // 
            this.txtFechaDesembolso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFechaDesembolso.Depth = 0;
            this.txtFechaDesembolso.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFechaDesembolso.Hint = "Fecha Desembolso";
            this.txtFechaDesembolso.LeadingIcon = null;
            this.txtFechaDesembolso.Location = new System.Drawing.Point(652, 291);
            this.txtFechaDesembolso.MaxLength = 50;
            this.txtFechaDesembolso.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFechaDesembolso.Multiline = false;
            this.txtFechaDesembolso.Name = "txtFechaDesembolso";
            this.txtFechaDesembolso.Size = new System.Drawing.Size(236, 50);
            this.txtFechaDesembolso.TabIndex = 45;
            this.txtFechaDesembolso.Text = "";
            this.txtFechaDesembolso.TrailingIcon = null;
            // 
            // btnFechaNacimiento
            // 
            this.btnFechaNacimiento.FlatAppearance.BorderSize = 0;
            this.btnFechaNacimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechaNacimiento.Image = global::Holding.Properties.Resources.Calendario;
            this.btnFechaNacimiento.Location = new System.Drawing.Point(894, 291);
            this.btnFechaNacimiento.Name = "btnFechaNacimiento";
            this.btnFechaNacimiento.Size = new System.Drawing.Size(48, 50);
            this.btnFechaNacimiento.TabIndex = 46;
            this.btnFechaNacimiento.UseVisualStyleBackColor = true;
            this.btnFechaNacimiento.Click += new System.EventHandler(this.btnFechaNacimiento_Click);
            // 
            // FrmScrSolicitudAprobacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1109, 621);
            this.Controls.Add(this.cbxEstadoSolicitud);
            this.Controls.Add(this.txtIdSolicitud);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmScrSolicitudAprobacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestiones de Solicitud";
            this.Load += new System.EventHandler(this.FrmScrSolicitudAprobacion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialTextBox txtObservacion;
        private MaterialSkin.Controls.MaterialTextBox txtNumeroSolicitud;
        private MaterialSkin.Controls.MaterialTextBox txtNombreCliente;
        private MaterialSkin.Controls.MaterialTextBox txtPropietario;
        private MaterialSkin.Controls.MaterialComboBox cbxTipoMoneda;
        private MaterialSkin.Controls.MaterialTextBox txtMontoSolicitado;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnAprobar;
        private MaterialSkin.Controls.MaterialTextBox txtIdSolicitud;
        private MaterialSkin.Controls.MaterialComboBox cbxEstadoSolicitud;
        private MaterialSkin.Controls.MaterialTextBox txtTasaInteresMor;
        private MaterialSkin.Controls.MaterialTextBox txtTasaInteresCor;
        private MaterialSkin.Controls.MaterialTextBox txtFechaDesembolso;
        private MaterialSkin.Controls.MaterialComboBox cbxPeriocidadIntApro;
        private MaterialSkin.Controls.MaterialComboBox cbxPeriocidadPrinApro;
        private MaterialSkin.Controls.MaterialTextBox txtPlazoAprobado;
        private MaterialSkin.Controls.MaterialCheckbox chbxVencimiento;
        private MaterialSkin.Controls.MaterialTextBox txtMontoComision;
        private MaterialSkin.Controls.MaterialTextBox txtTasaComision;
        private MaterialSkin.Controls.MaterialTextBox txtMontoApro;
        private System.Windows.Forms.Button btnFechaNacimiento;
    }
}