
namespace Holding
{
    partial class FrmSegAccionRol
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxRol = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvTodasAcciones = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAcccionXRol = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtBuscarTodasAcciones = new MaterialSkin.Controls.MaterialTextBox();
            this.btnActualizaTodasAcciones = new System.Windows.Forms.Button();
            this.btnBuscarTodasAcciones = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtBuscarAccionesRol = new MaterialSkin.Controls.MaterialTextBox();
            this.btnActualizaAccionxRol = new System.Windows.Forms.Button();
            this.btnBuscarSeccionesxRol = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidadTodasAcciones = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantidadAccionesRol = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvNuevasAcciones = new System.Windows.Forms.DataGridView();
            this.codigoaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idrol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Orden2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existe2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodasAcciones)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcccionXRol)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevasAcciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Asignar Permisos";
            // 
            // cbxRol
            // 
            this.cbxRol.AutoResize = false;
            this.cbxRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxRol.Depth = 0;
            this.cbxRol.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxRol.DropDownHeight = 174;
            this.cbxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRol.DropDownWidth = 121;
            this.cbxRol.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxRol.FormattingEnabled = true;
            this.cbxRol.Hint = "Seleccione Rol";
            this.cbxRol.IntegralHeight = false;
            this.cbxRol.ItemHeight = 43;
            this.cbxRol.Location = new System.Drawing.Point(16, 30);
            this.cbxRol.MaxDropDownItems = 4;
            this.cbxRol.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxRol.Name = "cbxRol";
            this.cbxRol.Size = new System.Drawing.Size(558, 49);
            this.cbxRol.StartIndex = 0;
            this.cbxRol.TabIndex = 4;
            this.cbxRol.SelectionChangeCommitted += new System.EventHandler(this.cbxRol_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxRol);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(23, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Rol";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvTodasAcciones);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(23, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(686, 347);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Todas las Acciones";
            // 
            // dgvTodasAcciones
            // 
            this.dgvTodasAcciones.AllowUserToAddRows = false;
            this.dgvTodasAcciones.AllowUserToDeleteRows = false;
            this.dgvTodasAcciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTodasAcciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTodasAcciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.dgvTodasAcciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodasAcciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTodasAcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodasAcciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Orden,
            this.Nombre,
            this.Código,
            this.Descripción,
            this.Existe});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTodasAcciones.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTodasAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTodasAcciones.EnableHeadersVisualStyles = false;
            this.dgvTodasAcciones.Location = new System.Drawing.Point(3, 19);
            this.dgvTodasAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTodasAcciones.MultiSelect = false;
            this.dgvTodasAcciones.Name = "dgvTodasAcciones";
            this.dgvTodasAcciones.RowHeadersVisible = false;
            this.dgvTodasAcciones.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvTodasAcciones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTodasAcciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodasAcciones.Size = new System.Drawing.Size(680, 325);
            this.dgvTodasAcciones.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAcccionXRol);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(838, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(657, 347);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones del Rol";
            // 
            // dgvAcccionXRol
            // 
            this.dgvAcccionXRol.AllowUserToAddRows = false;
            this.dgvAcccionXRol.AllowUserToDeleteRows = false;
            this.dgvAcccionXRol.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAcccionXRol.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAcccionXRol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.dgvAcccionXRol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAcccionXRol.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAcccionXRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcccionXRol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID2,
            this.Orden2,
            this.Nombre2,
            this.Código2,
            this.Descripción2,
            this.Existe2});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAcccionXRol.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAcccionXRol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAcccionXRol.EnableHeadersVisualStyles = false;
            this.dgvAcccionXRol.Location = new System.Drawing.Point(3, 19);
            this.dgvAcccionXRol.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAcccionXRol.MultiSelect = false;
            this.dgvAcccionXRol.Name = "dgvAcccionXRol";
            this.dgvAcccionXRol.ReadOnly = true;
            this.dgvAcccionXRol.RowHeadersVisible = false;
            this.dgvAcccionXRol.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvAcccionXRol.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAcccionXRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAcccionXRol.Size = new System.Drawing.Size(651, 325);
            this.dgvAcccionXRol.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEliminar);
            this.groupBox4.Controls.Add(this.btnAgregar);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(729, 337);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(89, 299);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Image = global::Holding.Properties.Resources.cancelar_Accionxrol;
            this.btnEliminar.Location = new System.Drawing.Point(7, 200);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 51);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::Holding.Properties.Resources.agregar_Accionxrol;
            this.btnAgregar.Location = new System.Drawing.Point(7, 38);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 51);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtBuscarTodasAcciones);
            this.groupBox5.Controls.Add(this.btnActualizaTodasAcciones);
            this.groupBox5.Controls.Add(this.btnBuscarTodasAcciones);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(23, 186);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(683, 101);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Buscador de Acción";
            // 
            // txtBuscarTodasAcciones
            // 
            this.txtBuscarTodasAcciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarTodasAcciones.Depth = 0;
            this.txtBuscarTodasAcciones.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarTodasAcciones.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBuscarTodasAcciones.Hint = "Código Acción";
            this.txtBuscarTodasAcciones.LeadingIcon = null;
            this.txtBuscarTodasAcciones.Location = new System.Drawing.Point(17, 34);
            this.txtBuscarTodasAcciones.MaxLength = 50;
            this.txtBuscarTodasAcciones.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarTodasAcciones.Multiline = false;
            this.txtBuscarTodasAcciones.Name = "txtBuscarTodasAcciones";
            this.txtBuscarTodasAcciones.Size = new System.Drawing.Size(524, 50);
            this.txtBuscarTodasAcciones.TabIndex = 19;
            this.txtBuscarTodasAcciones.Text = "";
            this.txtBuscarTodasAcciones.TrailingIcon = null;
            // 
            // btnActualizaTodasAcciones
            // 
            this.btnActualizaTodasAcciones.FlatAppearance.BorderSize = 0;
            this.btnActualizaTodasAcciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizaTodasAcciones.Image = global::Holding.Properties.Resources.Actualizar;
            this.btnActualizaTodasAcciones.Location = new System.Drawing.Point(616, 28);
            this.btnActualizaTodasAcciones.Name = "btnActualizaTodasAcciones";
            this.btnActualizaTodasAcciones.Size = new System.Drawing.Size(48, 51);
            this.btnActualizaTodasAcciones.TabIndex = 7;
            this.btnActualizaTodasAcciones.UseVisualStyleBackColor = true;
            this.btnActualizaTodasAcciones.Click += new System.EventHandler(this.btnActualizaTodasAcciones_Click);
            // 
            // btnBuscarTodasAcciones
            // 
            this.btnBuscarTodasAcciones.FlatAppearance.BorderSize = 0;
            this.btnBuscarTodasAcciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarTodasAcciones.Image = global::Holding.Properties.Resources.Buscador;
            this.btnBuscarTodasAcciones.Location = new System.Drawing.Point(563, 28);
            this.btnBuscarTodasAcciones.Name = "btnBuscarTodasAcciones";
            this.btnBuscarTodasAcciones.Size = new System.Drawing.Size(47, 51);
            this.btnBuscarTodasAcciones.TabIndex = 6;
            this.btnBuscarTodasAcciones.UseVisualStyleBackColor = true;
            this.btnBuscarTodasAcciones.Click += new System.EventHandler(this.btnBuscarTodasAcciones_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtBuscarAccionesRol);
            this.groupBox6.Controls.Add(this.btnActualizaAccionxRol);
            this.groupBox6.Controls.Add(this.btnBuscarSeccionesxRol);
            this.groupBox6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(838, 186);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(657, 101);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Buscador de Accion x Rol";
            // 
            // txtBuscarAccionesRol
            // 
            this.txtBuscarAccionesRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarAccionesRol.Depth = 0;
            this.txtBuscarAccionesRol.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBuscarAccionesRol.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBuscarAccionesRol.Hint = "Código Acción";
            this.txtBuscarAccionesRol.LeadingIcon = null;
            this.txtBuscarAccionesRol.Location = new System.Drawing.Point(17, 33);
            this.txtBuscarAccionesRol.MaxLength = 50;
            this.txtBuscarAccionesRol.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBuscarAccionesRol.Multiline = false;
            this.txtBuscarAccionesRol.Name = "txtBuscarAccionesRol";
            this.txtBuscarAccionesRol.Size = new System.Drawing.Size(496, 50);
            this.txtBuscarAccionesRol.TabIndex = 18;
            this.txtBuscarAccionesRol.Text = "";
            this.txtBuscarAccionesRol.TrailingIcon = null;
            // 
            // btnActualizaAccionxRol
            // 
            this.btnActualizaAccionxRol.FlatAppearance.BorderSize = 0;
            this.btnActualizaAccionxRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizaAccionxRol.Image = global::Holding.Properties.Resources.Actualizar;
            this.btnActualizaAccionxRol.Location = new System.Drawing.Point(596, 29);
            this.btnActualizaAccionxRol.Name = "btnActualizaAccionxRol";
            this.btnActualizaAccionxRol.Size = new System.Drawing.Size(48, 51);
            this.btnActualizaAccionxRol.TabIndex = 7;
            this.btnActualizaAccionxRol.UseVisualStyleBackColor = true;
            this.btnActualizaAccionxRol.Click += new System.EventHandler(this.btnActualizaAccionxRol_Click);
            // 
            // btnBuscarSeccionesxRol
            // 
            this.btnBuscarSeccionesxRol.FlatAppearance.BorderSize = 0;
            this.btnBuscarSeccionesxRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarSeccionesxRol.Image = global::Holding.Properties.Resources.Buscador;
            this.btnBuscarSeccionesxRol.Location = new System.Drawing.Point(543, 29);
            this.btnBuscarSeccionesxRol.Name = "btnBuscarSeccionesxRol";
            this.btnBuscarSeccionesxRol.Size = new System.Drawing.Size(47, 51);
            this.btnBuscarSeccionesxRol.TabIndex = 6;
            this.btnBuscarSeccionesxRol.UseVisualStyleBackColor = true;
            this.btnBuscarSeccionesxRol.Click += new System.EventHandler(this.btnBuscarSeccionesxRol_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Registros:";
            // 
            // lblCantidadTodasAcciones
            // 
            this.lblCantidadTodasAcciones.AutoSize = true;
            this.lblCantidadTodasAcciones.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadTodasAcciones.ForeColor = System.Drawing.Color.White;
            this.lblCantidadTodasAcciones.Location = new System.Drawing.Point(92, 18);
            this.lblCantidadTodasAcciones.Name = "lblCantidadTodasAcciones";
            this.lblCantidadTodasAcciones.Size = new System.Drawing.Size(19, 21);
            this.lblCantidadTodasAcciones.TabIndex = 13;
            this.lblCantidadTodasAcciones.Text = "0";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.lblCantidadTodasAcciones);
            this.groupBox7.Location = new System.Drawing.Point(589, 653);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(118, 54);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.lblCantidadAccionesRol);
            this.groupBox8.Location = new System.Drawing.Point(1373, 652);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(118, 54);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Registros:";
            // 
            // lblCantidadAccionesRol
            // 
            this.lblCantidadAccionesRol.AutoSize = true;
            this.lblCantidadAccionesRol.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadAccionesRol.ForeColor = System.Drawing.Color.White;
            this.lblCantidadAccionesRol.Location = new System.Drawing.Point(92, 18);
            this.lblCantidadAccionesRol.Name = "lblCantidadAccionesRol";
            this.lblCantidadAccionesRol.Size = new System.Drawing.Size(19, 21);
            this.lblCantidadAccionesRol.TabIndex = 13;
            this.lblCantidadAccionesRol.Text = "0";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::Holding.Properties.Resources.Guardar;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGuardar.Location = new System.Drawing.Point(1358, 756);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 58);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::Holding.Properties.Resources.Cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelar.Location = new System.Drawing.Point(1173, 756);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 58);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvNuevasAcciones
            // 
            this.dgvNuevasAcciones.AllowUserToAddRows = false;
            this.dgvNuevasAcciones.AllowUserToDeleteRows = false;
            this.dgvNuevasAcciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNuevasAcciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNuevasAcciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.dgvNuevasAcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuevasAcciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoaccion,
            this.idrol});
            this.dgvNuevasAcciones.Location = new System.Drawing.Point(766, 63);
            this.dgvNuevasAcciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNuevasAcciones.Name = "dgvNuevasAcciones";
            this.dgvNuevasAcciones.ReadOnly = true;
            this.dgvNuevasAcciones.RowHeadersVisible = false;
            this.dgvNuevasAcciones.RowHeadersWidth = 51;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dgvNuevasAcciones.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNuevasAcciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNuevasAcciones.Size = new System.Drawing.Size(707, 74);
            this.dgvNuevasAcciones.TabIndex = 18;
            this.dgvNuevasAcciones.Visible = false;
            // 
            // codigoaccion
            // 
            this.codigoaccion.HeaderText = "codigoaccion";
            this.codigoaccion.MinimumWidth = 6;
            this.codigoaccion.Name = "codigoaccion";
            this.codigoaccion.ReadOnly = true;
            // 
            // idrol
            // 
            this.idrol.HeaderText = "idrol";
            this.idrol.MinimumWidth = 6;
            this.idrol.Name = "idrol";
            this.idrol.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Orden
            // 
            this.Orden.HeaderText = "Orden";
            this.Orden.MinimumWidth = 6;
            this.Orden.Name = "Orden";
            this.Orden.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = false;
            // 
            // Código
            // 
            this.Código.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Código.FillWeight = 106.9519F;
            this.Código.HeaderText = "Código";
            this.Código.MinimumWidth = 6;
            this.Código.Name = "Código";
            this.Código.Width = 200;
            // 
            // Descripción
            // 
            this.Descripción.FillWeight = 93.04813F;
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            // 
            // Existe
            // 
            this.Existe.HeaderText = "Existe";
            this.Existe.MinimumWidth = 6;
            this.Existe.Name = "Existe";
            this.Existe.Visible = false;
            // 
            // ID2
            // 
            this.ID2.HeaderText = "ID2";
            this.ID2.MinimumWidth = 6;
            this.ID2.Name = "ID2";
            this.ID2.ReadOnly = true;
            this.ID2.Visible = false;
            // 
            // Orden2
            // 
            this.Orden2.HeaderText = "Orden2";
            this.Orden2.MinimumWidth = 6;
            this.Orden2.Name = "Orden2";
            this.Orden2.ReadOnly = true;
            this.Orden2.Visible = false;
            // 
            // Nombre2
            // 
            this.Nombre2.HeaderText = "Nombre2";
            this.Nombre2.MinimumWidth = 6;
            this.Nombre2.Name = "Nombre2";
            this.Nombre2.ReadOnly = true;
            this.Nombre2.Visible = false;
            // 
            // Código2
            // 
            this.Código2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Código2.HeaderText = "Código";
            this.Código2.MinimumWidth = 6;
            this.Código2.Name = "Código2";
            this.Código2.ReadOnly = true;
            this.Código2.Width = 200;
            // 
            // Descripción2
            // 
            this.Descripción2.HeaderText = "Descripción";
            this.Descripción2.MinimumWidth = 6;
            this.Descripción2.Name = "Descripción2";
            this.Descripción2.ReadOnly = true;
            // 
            // Existe2
            // 
            this.Existe2.HeaderText = "Existe2";
            this.Existe2.MinimumWidth = 6;
            this.Existe2.Name = "Existe2";
            this.Existe2.ReadOnly = true;
            this.Existe2.Visible = false;
            // 
            // FrmSegAccionRol
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(1516, 874);
            this.Controls.Add(this.dgvNuevasAcciones);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSegAccionRol";
            this.Text = "FrmSegAccionRol";
            this.Load += new System.EventHandler(this.FrmSegAccionRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodasAcciones)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcccionXRol)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuevasAcciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox cbxRol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnActualizaTodasAcciones;
        private System.Windows.Forms.Button btnBuscarTodasAcciones;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnActualizaAccionxRol;
        private System.Windows.Forms.Button btnBuscarSeccionesxRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidadTodasAcciones;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCantidadAccionesRol;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarTodasAcciones;
        private MaterialSkin.Controls.MaterialTextBox txtBuscarAccionesRol;
        private System.Windows.Forms.DataGridView dgvTodasAcciones;
        private System.Windows.Forms.DataGridView dgvAcccionXRol;
        private System.Windows.Forms.DataGridView dgvNuevasAcciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idrol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Orden2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existe2;
    }
}