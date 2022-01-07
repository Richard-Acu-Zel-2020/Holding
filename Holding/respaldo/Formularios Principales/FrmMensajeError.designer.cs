namespace Holding
{
    partial class FrmError
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
            this.btnInfo = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtError = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtErrorSQL = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarError = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.Location = new System.Drawing.Point(468, 125);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(16, 20);
            this.btnInfo.TabIndex = 4;
            this.btnInfo.TabStop = false;
            this.btnInfo.Visible = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.LightGray;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptar.Location = new System.Drawing.Point(468, 90);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(14, 27);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.Color.White;
            this.txtError.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtError.Location = new System.Drawing.Point(468, 67);
            this.txtError.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(16, 15);
            this.txtError.TabIndex = 1;
            this.txtError.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtErrorSQL);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(7, 186);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(511, 173);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle del Error";
            // 
            // txtErrorSQL
            // 
            this.txtErrorSQL.BackColor = System.Drawing.Color.White;
            this.txtErrorSQL.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErrorSQL.Location = new System.Drawing.Point(8, 20);
            this.txtErrorSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtErrorSQL.Multiline = true;
            this.txtErrorSQL.Name = "txtErrorSQL";
            this.txtErrorSQL.ReadOnly = true;
            this.txtErrorSQL.Size = new System.Drawing.Size(493, 145);
            this.txtErrorSQL.TabIndex = 2;
            this.txtErrorSQL.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtErrorSQL_MouseClick);
            this.txtErrorSQL.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtErrorSQL_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Holding.Properties.Resources.icono_error;
            this.pictureBox2.Location = new System.Drawing.Point(7, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 65);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hemos tenido un problema ténico con el software, favor diríjase con Informática.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAceptarError
            // 
            this.btnAceptarError.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptarError.Depth = 0;
            this.btnAceptarError.DrawShadows = true;
            this.btnAceptarError.HighEmphasis = true;
            this.btnAceptarError.Icon = null;
            this.btnAceptarError.Location = new System.Drawing.Point(220, 147);
            this.btnAceptarError.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptarError.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptarError.Name = "btnAceptarError";
            this.btnAceptarError.Size = new System.Drawing.Size(86, 36);
            this.btnAceptarError.TabIndex = 3;
            this.btnAceptarError.Text = "Aceptar";
            this.btnAceptarError.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAceptarError.UseAccentColor = false;
            this.btnAceptarError.UseVisualStyleBackColor = true;
            this.btnAceptarError.Click += new System.EventHandler(this.btnAceptarError_Click);
            // 
            // FrmError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(529, 372);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.btnAceptarError);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmError";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmError_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmError_KeyPress);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmError_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmError_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.btnInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.PictureBox btnInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtErrorSQL;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnAceptarError;
    }
}