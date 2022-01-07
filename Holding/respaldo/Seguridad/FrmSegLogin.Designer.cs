namespace Holding
{
    partial class FrmSegLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSegLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.PtUserLock = new FontAwesome.Sharp.IconPictureBox();
            this.txtUsuario = new MaterialSkin.Controls.MaterialTextBox();
            this.txtContraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcceder = new FontAwesome.Sharp.IconButton();
            this.linkOlvidoContrasena = new System.Windows.Forms.LinkLabel();
            this.btnCerrar = new FontAwesome.Sharp.IconPictureBox();
            this.Error = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtUserLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.PtUserLock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 481);
            this.panel1.TabIndex = 0;
            // 
            // PtUserLock
            // 
            this.PtUserLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.PtUserLock.ForeColor = System.Drawing.Color.Gainsboro;
            this.PtUserLock.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.PtUserLock.IconColor = System.Drawing.Color.Gainsboro;
            this.PtUserLock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PtUserLock.IconSize = 129;
            this.PtUserLock.Location = new System.Drawing.Point(39, 92);
            this.PtUserLock.Name = "PtUserLock";
            this.PtUserLock.Size = new System.Drawing.Size(158, 129);
            this.PtUserLock.TabIndex = 0;
            this.PtUserLock.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoWordSelection = true;
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsuario.ForeColor = System.Drawing.Color.Yellow;
            this.txtUsuario.HideSelection = false;
            this.txtUsuario.Hint = "Usuario";
            this.txtUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUsuario.LeadingIcon = null;
            this.txtUsuario.Location = new System.Drawing.Point(298, 63);
            this.txtUsuario.MaxLength = 100;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ShortcutsEnabled = false;
            this.txtUsuario.Size = new System.Drawing.Size(374, 50);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.Text = "";
            this.txtUsuario.TrailingIcon = null;
            this.txtUsuario.UseAccent = false;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Depth = 0;
            this.txtContraseña.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtContraseña.ForeColor = System.Drawing.Color.Red;
            this.txtContraseña.HideSelection = false;
            this.txtContraseña.Hint = "Contraseña";
            this.txtContraseña.LeadingIcon = null;
            this.txtContraseña.Location = new System.Drawing.Point(298, 136);
            this.txtContraseña.MaxLength = 100;
            this.txtContraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Password = true;
            this.txtContraseña.ShortcutsEnabled = false;
            this.txtContraseña.Size = new System.Drawing.Size(374, 50);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.TabStop = false;
            this.txtContraseña.Text = "";
            this.txtContraseña.TrailingIcon = null;
            this.txtContraseña.UseAccent = false;
            this.txtContraseña.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraseña_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(453, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.White;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(117)))), ((int)(((byte)(1)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAcceder.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnAcceder.IconColor = System.Drawing.Color.Black;
            this.btnAcceder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAcceder.IconSize = 40;
            this.btnAcceder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAcceder.Location = new System.Drawing.Point(298, 210);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(374, 50);
            this.btnAcceder.TabIndex = 3;
            this.btnAcceder.Text = "Entrar";
            this.btnAcceder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // linkOlvidoContrasena
            // 
            this.linkOlvidoContrasena.AutoSize = true;
            this.linkOlvidoContrasena.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.linkOlvidoContrasena.ForeColor = System.Drawing.Color.Black;
            this.linkOlvidoContrasena.LinkColor = System.Drawing.Color.Black;
            this.linkOlvidoContrasena.Location = new System.Drawing.Point(395, 283);
            this.linkOlvidoContrasena.Name = "linkOlvidoContrasena";
            this.linkOlvidoContrasena.Size = new System.Drawing.Size(183, 20);
            this.linkOlvidoContrasena.TabIndex = 4;
            this.linkOlvidoContrasena.TabStop = true;
            this.linkOlvidoContrasena.Text = "¿Olvidó su contraseña?";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 35;
            this.btnCerrar.Location = new System.Drawing.Point(725, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Error
            // 
            this.Error.ContainerControl = this;
            this.Error.Icon = ((System.Drawing.Icon)(resources.GetObject("Error.Icon")));
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.materialTextBox1.Hint = "Saludo";
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(240, 56);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(483, 50);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // FrmSegLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1342, 481);
            this.Controls.Add(this.materialTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmSegLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSegLogin";
            this.Load += new System.EventHandler(this.FrmSegLogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtUserLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnAcceder;
        private System.Windows.Forms.LinkLabel linkOlvidoContrasena;
        private FontAwesome.Sharp.IconPictureBox btnCerrar;
        private FontAwesome.Sharp.IconPictureBox PtUserLock;
        private System.Windows.Forms.ErrorProvider Error;
        public MaterialSkin.Controls.MaterialTextBox txtUsuario;
        public MaterialSkin.Controls.MaterialTextBox txtContraseña;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}