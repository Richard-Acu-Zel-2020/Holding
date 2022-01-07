
namespace Holding
{
    partial class FrmSegUsuarioEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSegUsuarioEdicion));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtContrasena = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.cbxIdRol = new MaterialSkin.Controls.MaterialComboBox();
            this.ckActivo = new MaterialSkin.Controls.MaterialCheckbox();
            this.txtCedula = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSegApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSegNom = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrimApellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrimerNom = new MaterialSkin.Controls.MaterialTextBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edición de Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdUsuario);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtContrasena);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.cbxIdRol);
            this.groupBox1.Controls.Add(this.ckActivo);
            this.groupBox1.Controls.Add(this.txtCedula);
            this.groupBox1.Controls.Add(this.txtSegApellido);
            this.groupBox1.Controls.Add(this.txtSegNom);
            this.groupBox1.Controls.Add(this.txtPrimApellido);
            this.groupBox1.Controls.Add(this.txtPrimerNom);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 501);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdUsuario.Depth = 0;
            this.txtIdUsuario.Enabled = false;
            this.txtIdUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtIdUsuario.Hint = "Id";
            this.txtIdUsuario.LeadingIcon = null;
            this.txtIdUsuario.Location = new System.Drawing.Point(1024, 10);
            this.txtIdUsuario.MaxLength = 50;
            this.txtIdUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtIdUsuario.Multiline = false;
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.Size = new System.Drawing.Size(42, 50);
            this.txtIdUsuario.TabIndex = 15;
            this.txtIdUsuario.Text = "";
            this.txtIdUsuario.TrailingIcon = null;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Hint = "Correo Electrónico";
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(655, 217);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 50);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "";
            this.txtEmail.TrailingIcon = null;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::Holding.Properties.Resources.Cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelar.Location = new System.Drawing.Point(710, 418);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 58);
            this.btnCancelar.TabIndex = 12;
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
            this.btnGuardar.Location = new System.Drawing.Point(903, 418);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 58);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Holding.Properties.Resources.Logo_Usuario;
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContrasena.Depth = 0;
            this.txtContrasena.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasena.ForeColor = System.Drawing.SystemColors.Window;
            this.txtContrasena.Hint = "Contraseña";
            this.txtContrasena.LeadingIcon = null;
            this.txtContrasena.Location = new System.Drawing.Point(478, 302);
            this.txtContrasena.MaxLength = 50;
            this.txtContrasena.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContrasena.Multiline = false;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(350, 50);
            this.txtContrasena.TabIndex = 9;
            this.txtContrasena.Text = "";
            this.txtContrasena.TrailingIcon = null;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(57, 302);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(350, 50);
            this.txtUsuario.TabIndex = 8;
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            // 
            // cbxIdRol
            // 
            this.cbxIdRol.AutoResize = false;
            this.cbxIdRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxIdRol.Depth = 0;
            this.cbxIdRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxIdRol.DropDownHeight = 174;
            this.cbxIdRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdRol.DropDownWidth = 121;
            this.cbxIdRol.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxIdRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxIdRol.FormattingEnabled = true;
            this.cbxIdRol.Hint = "Rol";
            this.cbxIdRol.IntegralHeight = false;
            this.cbxIdRol.ItemHeight = 43;
            this.cbxIdRol.Location = new System.Drawing.Point(57, 394);
            this.cbxIdRol.MaxDropDownItems = 4;
            this.cbxIdRol.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxIdRol.Name = "cbxIdRol";
            this.cbxIdRol.Size = new System.Drawing.Size(350, 49);
            this.cbxIdRol.StartIndex = 0;
            this.cbxIdRol.TabIndex = 7;
            // 
            // ckActivo
            // 
            this.ckActivo.AutoSize = true;
            this.ckActivo.Depth = 0;
            this.ckActivo.Location = new System.Drawing.Point(877, 315);
            this.ckActivo.Margin = new System.Windows.Forms.Padding(0);
            this.ckActivo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckActivo.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckActivo.Name = "ckActivo";
            this.ckActivo.Ripple = true;
            this.ckActivo.Size = new System.Drawing.Size(79, 37);
            this.ckActivo.TabIndex = 6;
            this.ckActivo.Text = "Activo";
            this.ckActivo.UseVisualStyleBackColor = true;
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Depth = 0;
            this.txtCedula.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCedula.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCedula.Hint = "Cédula";
            this.txtCedula.LeadingIcon = null;
            this.txtCedula.Location = new System.Drawing.Point(277, 217);
            this.txtCedula.MaxLength = 50;
            this.txtCedula.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCedula.Multiline = false;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(350, 50);
            this.txtCedula.TabIndex = 5;
            this.txtCedula.Text = "";
            this.txtCedula.TrailingIcon = null;
            // 
            // txtSegApellido
            // 
            this.txtSegApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegApellido.Depth = 0;
            this.txtSegApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSegApellido.ForeColor = System.Drawing.Color.White;
            this.txtSegApellido.Hint = "Segundo Apellido";
            this.txtSegApellido.LeadingIcon = null;
            this.txtSegApellido.Location = new System.Drawing.Point(655, 128);
            this.txtSegApellido.MaxLength = 50;
            this.txtSegApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSegApellido.Multiline = false;
            this.txtSegApellido.Name = "txtSegApellido";
            this.txtSegApellido.Size = new System.Drawing.Size(350, 50);
            this.txtSegApellido.TabIndex = 4;
            this.txtSegApellido.Text = "";
            this.txtSegApellido.TrailingIcon = null;
            // 
            // txtSegNom
            // 
            this.txtSegNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegNom.Depth = 0;
            this.txtSegNom.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSegNom.ForeColor = System.Drawing.Color.White;
            this.txtSegNom.Hint = "Segundo Nombre";
            this.txtSegNom.LeadingIcon = null;
            this.txtSegNom.Location = new System.Drawing.Point(655, 40);
            this.txtSegNom.MaxLength = 50;
            this.txtSegNom.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSegNom.Multiline = false;
            this.txtSegNom.Name = "txtSegNom";
            this.txtSegNom.Size = new System.Drawing.Size(350, 50);
            this.txtSegNom.TabIndex = 3;
            this.txtSegNom.Text = "";
            this.txtSegNom.TrailingIcon = null;
            // 
            // txtPrimApellido
            // 
            this.txtPrimApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimApellido.Depth = 0;
            this.txtPrimApellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrimApellido.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPrimApellido.Hint = "Primer Apellido";
            this.txtPrimApellido.LeadingIcon = null;
            this.txtPrimApellido.Location = new System.Drawing.Point(277, 128);
            this.txtPrimApellido.MaxLength = 50;
            this.txtPrimApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrimApellido.Multiline = false;
            this.txtPrimApellido.Name = "txtPrimApellido";
            this.txtPrimApellido.Size = new System.Drawing.Size(350, 50);
            this.txtPrimApellido.TabIndex = 2;
            this.txtPrimApellido.Text = "";
            this.txtPrimApellido.TrailingIcon = null;
            this.txtPrimApellido.Leave += new System.EventHandler(this.txtPrimApellido_Leave);
            // 
            // txtPrimerNom
            // 
            this.txtPrimerNom.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrimerNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimerNom.Depth = 0;
            this.txtPrimerNom.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrimerNom.ForeColor = System.Drawing.Color.White;
            this.txtPrimerNom.Hint = "Primer Nombre";
            this.txtPrimerNom.LeadingIcon = null;
            this.txtPrimerNom.Location = new System.Drawing.Point(277, 40);
            this.txtPrimerNom.MaxLength = 50;
            this.txtPrimerNom.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrimerNom.Multiline = false;
            this.txtPrimerNom.Name = "txtPrimerNom";
            this.txtPrimerNom.Size = new System.Drawing.Size(350, 50);
            this.txtPrimerNom.TabIndex = 1;
            this.txtPrimerNom.Text = "";
            this.txtPrimerNom.TrailingIcon = null;
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            // 
            // FrmSegUsuarioEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1107, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSegUsuarioEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Usuario";
            this.Load += new System.EventHandler(this.FrmSegUsuarioEdicion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox txtPrimApellido;
        private MaterialSkin.Controls.MaterialTextBox txtPrimerNom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox txtContrasena;
        private MaterialSkin.Controls.MaterialTextBox txtUsuario;
        private MaterialSkin.Controls.MaterialComboBox cbxIdRol;
        private MaterialSkin.Controls.MaterialCheckbox ckActivo;
        private MaterialSkin.Controls.MaterialTextBox txtCedula;
        private MaterialSkin.Controls.MaterialTextBox txtSegApellido;
        private MaterialSkin.Controls.MaterialTextBox txtSegNom;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialTextBox txtIdUsuario;
        private System.Windows.Forms.ErrorProvider Error;
    }
}