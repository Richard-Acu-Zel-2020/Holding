namespace Holding
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PanelMenuLateral = new System.Windows.Forms.Panel();
            this.btnSalir = new FontAwesome.Sharp.IconButton();
            this.btnOtrasOpciones = new FontAwesome.Sharp.IconButton();
            this.PanelConfiguracion = new System.Windows.Forms.Panel();
            this.btnCatalogos = new FontAwesome.Sharp.IconButton();
            this.btnProductos = new FontAwesome.Sharp.IconButton();
            this.btnTasaCambio = new FontAwesome.Sharp.IconButton();
            this.btnParametros = new FontAwesome.Sharp.IconButton();
            this.btnConfiguración = new FontAwesome.Sharp.IconButton();
            this.PanelSeguridad = new System.Windows.Forms.Panel();
            this.btnAsignarPermisos = new FontAwesome.Sharp.IconButton();
            this.btnRoles = new FontAwesome.Sharp.IconButton();
            this.btnAcciones = new FontAwesome.Sharp.IconButton();
            this.btnUsuarios = new FontAwesome.Sharp.IconButton();
            this.btnSeguridad = new FontAwesome.Sharp.IconButton();
            this.PanelCartera = new System.Windows.Forms.Panel();
            this.btnReportería = new FontAwesome.Sharp.IconButton();
            this.btnFondoFinanciamiento = new FontAwesome.Sharp.IconButton();
            this.btnPagosInversion = new FontAwesome.Sharp.IconButton();
            this.bnAcreedoresFondo = new FontAwesome.Sharp.IconButton();
            this.btnCartera = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnCerrarPrincipal = new FontAwesome.Sharp.IconPictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.TimerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.PanelBarraInferior = new System.Windows.Forms.Panel();
            this.btnReimprimirBoucher = new FontAwesome.Sharp.IconButton();
            this.btnReporteCaja = new FontAwesome.Sharp.IconButton();
            this.btnVentanilla = new FontAwesome.Sharp.IconButton();
            this.PanelVentanilla = new System.Windows.Forms.Panel();
            this.PanelMenuLateral.SuspendLayout();
            this.PanelConfiguracion.SuspendLayout();
            this.PanelSeguridad.SuspendLayout();
            this.PanelCartera.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPrincipal)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            this.PanelVentanilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenuLateral
            // 
            this.PanelMenuLateral.AutoScroll = true;
            this.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(83)))));
            this.PanelMenuLateral.Controls.Add(this.btnSalir);
            this.PanelMenuLateral.Controls.Add(this.btnOtrasOpciones);
            this.PanelMenuLateral.Controls.Add(this.PanelVentanilla);
            this.PanelMenuLateral.Controls.Add(this.btnVentanilla);
            this.PanelMenuLateral.Controls.Add(this.PanelConfiguracion);
            this.PanelMenuLateral.Controls.Add(this.btnConfiguración);
            this.PanelMenuLateral.Controls.Add(this.PanelSeguridad);
            this.PanelMenuLateral.Controls.Add(this.btnSeguridad);
            this.PanelMenuLateral.Controls.Add(this.PanelCartera);
            this.PanelMenuLateral.Controls.Add(this.btnCartera);
            this.PanelMenuLateral.Controls.Add(this.panelLogo);
            this.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuLateral.Name = "PanelMenuLateral";
            this.PanelMenuLateral.Size = new System.Drawing.Size(261, 909);
            this.PanelMenuLateral.TabIndex = 1;
            this.PanelMenuLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMenuLateral_Paint);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(152)))), ((int)(((byte)(48)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 1070);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(240, 65);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnOtrasOpciones
            // 
            this.btnOtrasOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOtrasOpciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(152)))), ((int)(((byte)(48)))));
            this.btnOtrasOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtrasOpciones.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnOtrasOpciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOtrasOpciones.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnOtrasOpciones.IconColor = System.Drawing.Color.White;
            this.btnOtrasOpciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOtrasOpciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtrasOpciones.Location = new System.Drawing.Point(0, 1002);
            this.btnOtrasOpciones.Name = "btnOtrasOpciones";
            this.btnOtrasOpciones.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnOtrasOpciones.Size = new System.Drawing.Size(240, 68);
            this.btnOtrasOpciones.TabIndex = 20;
            this.btnOtrasOpciones.Text = "Otras opciones";
            this.btnOtrasOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtrasOpciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOtrasOpciones.UseVisualStyleBackColor = true;
            this.btnOtrasOpciones.Click += new System.EventHandler(this.btnOtrasOpciones_Click);
            // 
            // PanelConfiguracion
            // 
            this.PanelConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelConfiguracion.Controls.Add(this.btnCatalogos);
            this.PanelConfiguracion.Controls.Add(this.btnProductos);
            this.PanelConfiguracion.Controls.Add(this.btnTasaCambio);
            this.PanelConfiguracion.Controls.Add(this.btnParametros);
            this.PanelConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelConfiguracion.Location = new System.Drawing.Point(0, 639);
            this.PanelConfiguracion.Name = "PanelConfiguracion";
            this.PanelConfiguracion.Size = new System.Drawing.Size(240, 166);
            this.PanelConfiguracion.TabIndex = 15;
            this.PanelConfiguracion.TabStop = true;
            // 
            // btnCatalogos
            // 
            this.btnCatalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogos.FlatAppearance.BorderSize = 0;
            this.btnCatalogos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatalogos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnCatalogos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCatalogos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCatalogos.IconColor = System.Drawing.Color.Black;
            this.btnCatalogos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCatalogos.Location = new System.Drawing.Point(0, 121);
            this.btnCatalogos.Name = "btnCatalogos";
            this.btnCatalogos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCatalogos.Size = new System.Drawing.Size(240, 37);
            this.btnCatalogos.TabIndex = 19;
            this.btnCatalogos.Text = "Catálogos";
            this.btnCatalogos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogos.UseVisualStyleBackColor = true;
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnProductos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProductos.IconColor = System.Drawing.Color.Black;
            this.btnProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductos.Location = new System.Drawing.Point(0, 84);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(240, 37);
            this.btnProductos.TabIndex = 18;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = true;
            // 
            // btnTasaCambio
            // 
            this.btnTasaCambio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTasaCambio.FlatAppearance.BorderSize = 0;
            this.btnTasaCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasaCambio.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnTasaCambio.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTasaCambio.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTasaCambio.IconColor = System.Drawing.Color.Black;
            this.btnTasaCambio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTasaCambio.Location = new System.Drawing.Point(0, 42);
            this.btnTasaCambio.Name = "btnTasaCambio";
            this.btnTasaCambio.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTasaCambio.Size = new System.Drawing.Size(240, 42);
            this.btnTasaCambio.TabIndex = 17;
            this.btnTasaCambio.Text = "Tasa de cambio";
            this.btnTasaCambio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasaCambio.UseVisualStyleBackColor = true;
            // 
            // btnParametros
            // 
            this.btnParametros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnParametros.FlatAppearance.BorderSize = 0;
            this.btnParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametros.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnParametros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnParametros.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnParametros.IconColor = System.Drawing.Color.Black;
            this.btnParametros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnParametros.Location = new System.Drawing.Point(0, 0);
            this.btnParametros.Name = "btnParametros";
            this.btnParametros.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnParametros.Size = new System.Drawing.Size(240, 42);
            this.btnParametros.TabIndex = 16;
            this.btnParametros.Text = "Parámetros";
            this.btnParametros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParametros.UseVisualStyleBackColor = true;
            // 
            // btnConfiguración
            // 
            this.btnConfiguración.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfiguración.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(152)))), ((int)(((byte)(48)))));
            this.btnConfiguración.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfiguración.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfiguración.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConfiguración.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnConfiguración.IconColor = System.Drawing.Color.White;
            this.btnConfiguración.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfiguración.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguración.Location = new System.Drawing.Point(0, 574);
            this.btnConfiguración.Name = "btnConfiguración";
            this.btnConfiguración.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnConfiguración.Size = new System.Drawing.Size(240, 65);
            this.btnConfiguración.TabIndex = 14;
            this.btnConfiguración.Text = "Configuración";
            this.btnConfiguración.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfiguración.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfiguración.UseVisualStyleBackColor = true;
            this.btnConfiguración.Click += new System.EventHandler(this.btnConfiguración_Click);
            // 
            // PanelSeguridad
            // 
            this.PanelSeguridad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelSeguridad.Controls.Add(this.btnAsignarPermisos);
            this.PanelSeguridad.Controls.Add(this.btnRoles);
            this.PanelSeguridad.Controls.Add(this.btnAcciones);
            this.PanelSeguridad.Controls.Add(this.btnUsuarios);
            this.PanelSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelSeguridad.Location = new System.Drawing.Point(0, 407);
            this.PanelSeguridad.Name = "PanelSeguridad";
            this.PanelSeguridad.Size = new System.Drawing.Size(240, 167);
            this.PanelSeguridad.TabIndex = 10;
            this.PanelSeguridad.TabStop = true;
            // 
            // btnAsignarPermisos
            // 
            this.btnAsignarPermisos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsignarPermisos.FlatAppearance.BorderSize = 0;
            this.btnAsignarPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarPermisos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnAsignarPermisos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAsignarPermisos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAsignarPermisos.IconColor = System.Drawing.Color.Black;
            this.btnAsignarPermisos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsignarPermisos.Location = new System.Drawing.Point(0, 126);
            this.btnAsignarPermisos.Name = "btnAsignarPermisos";
            this.btnAsignarPermisos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAsignarPermisos.Size = new System.Drawing.Size(240, 37);
            this.btnAsignarPermisos.TabIndex = 13;
            this.btnAsignarPermisos.Text = "Asignar Permisos";
            this.btnAsignarPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarPermisos.UseVisualStyleBackColor = true;
            this.btnAsignarPermisos.Click += new System.EventHandler(this.btnAsignarPermisos_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnRoles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRoles.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRoles.IconColor = System.Drawing.Color.Black;
            this.btnRoles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRoles.Location = new System.Drawing.Point(0, 84);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRoles.Size = new System.Drawing.Size(240, 42);
            this.btnRoles.TabIndex = 12;
            this.btnRoles.Text = "Roles";
            this.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoles.UseVisualStyleBackColor = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRolesAcciones_Click);
            // 
            // btnAcciones
            // 
            this.btnAcciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcciones.FlatAppearance.BorderSize = 0;
            this.btnAcciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcciones.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnAcciones.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAcciones.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAcciones.IconColor = System.Drawing.Color.Black;
            this.btnAcciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAcciones.Location = new System.Drawing.Point(0, 42);
            this.btnAcciones.Name = "btnAcciones";
            this.btnAcciones.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAcciones.Size = new System.Drawing.Size(240, 42);
            this.btnAcciones.TabIndex = 14;
            this.btnAcciones.Text = "Acciones";
            this.btnAcciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAcciones.UseVisualStyleBackColor = true;
            this.btnAcciones.Click += new System.EventHandler(this.btnAcciones_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnUsuarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsuarios.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUsuarios.IconColor = System.Drawing.Color.Black;
            this.btnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(240, 42);
            this.btnUsuarios.TabIndex = 11;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeguridad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(152)))), ((int)(((byte)(48)))));
            this.btnSeguridad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguridad.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnSeguridad.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSeguridad.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnSeguridad.IconColor = System.Drawing.Color.White;
            this.btnSeguridad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.Location = new System.Drawing.Point(0, 342);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSeguridad.Size = new System.Drawing.Size(240, 65);
            this.btnSeguridad.TabIndex = 9;
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeguridad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSeguridad.UseVisualStyleBackColor = true;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // PanelCartera
            // 
            this.PanelCartera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelCartera.Controls.Add(this.btnReportería);
            this.PanelCartera.Controls.Add(this.btnFondoFinanciamiento);
            this.PanelCartera.Controls.Add(this.bnAcreedoresFondo);
            this.PanelCartera.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCartera.Location = new System.Drawing.Point(0, 218);
            this.PanelCartera.Name = "PanelCartera";
            this.PanelCartera.Size = new System.Drawing.Size(240, 124);
            this.PanelCartera.TabIndex = 4;
            this.PanelCartera.TabStop = true;
            // 
            // btnReportería
            // 
            this.btnReportería.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportería.FlatAppearance.BorderSize = 0;
            this.btnReportería.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportería.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnReportería.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReportería.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReportería.IconColor = System.Drawing.Color.Black;
            this.btnReportería.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReportería.Location = new System.Drawing.Point(0, 79);
            this.btnReportería.Name = "btnReportería";
            this.btnReportería.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReportería.Size = new System.Drawing.Size(240, 37);
            this.btnReportería.TabIndex = 8;
            this.btnReportería.Text = "Reportería";
            this.btnReportería.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportería.UseVisualStyleBackColor = true;
            // 
            // btnFondoFinanciamiento
            // 
            this.btnFondoFinanciamiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFondoFinanciamiento.FlatAppearance.BorderSize = 0;
            this.btnFondoFinanciamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFondoFinanciamiento.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnFondoFinanciamiento.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFondoFinanciamiento.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFondoFinanciamiento.IconColor = System.Drawing.Color.Black;
            this.btnFondoFinanciamiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFondoFinanciamiento.Location = new System.Drawing.Point(0, 42);
            this.btnFondoFinanciamiento.Name = "btnFondoFinanciamiento";
            this.btnFondoFinanciamiento.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFondoFinanciamiento.Size = new System.Drawing.Size(240, 37);
            this.btnFondoFinanciamiento.TabIndex = 7;
            this.btnFondoFinanciamiento.Text = "Fondos Fnanciamiento";
            this.btnFondoFinanciamiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFondoFinanciamiento.UseVisualStyleBackColor = true;
            // 
            // btnPagosInversion
            // 
            this.btnPagosInversion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagosInversion.FlatAppearance.BorderSize = 0;
            this.btnPagosInversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagosInversion.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnPagosInversion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPagosInversion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnPagosInversion.IconColor = System.Drawing.Color.Black;
            this.btnPagosInversion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPagosInversion.Location = new System.Drawing.Point(0, 0);
            this.btnPagosInversion.Name = "btnPagosInversion";
            this.btnPagosInversion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPagosInversion.Size = new System.Drawing.Size(240, 42);
            this.btnPagosInversion.TabIndex = 6;
            this.btnPagosInversion.Text = "Pagos a Inversión";
            this.btnPagosInversion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagosInversion.UseVisualStyleBackColor = true;
            this.btnPagosInversion.Click += new System.EventHandler(this.btnPagosProveedores_Click);
            // 
            // bnAcreedoresFondo
            // 
            this.bnAcreedoresFondo.Dock = System.Windows.Forms.DockStyle.Top;
            this.bnAcreedoresFondo.FlatAppearance.BorderSize = 0;
            this.bnAcreedoresFondo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnAcreedoresFondo.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.bnAcreedoresFondo.ForeColor = System.Drawing.Color.Gainsboro;
            this.bnAcreedoresFondo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.bnAcreedoresFondo.IconColor = System.Drawing.Color.Black;
            this.bnAcreedoresFondo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bnAcreedoresFondo.Location = new System.Drawing.Point(0, 0);
            this.bnAcreedoresFondo.Name = "bnAcreedoresFondo";
            this.bnAcreedoresFondo.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bnAcreedoresFondo.Size = new System.Drawing.Size(240, 42);
            this.bnAcreedoresFondo.TabIndex = 5;
            this.bnAcreedoresFondo.Text = "Acreedores de Fondos";
            this.bnAcreedoresFondo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnAcreedoresFondo.UseVisualStyleBackColor = true;
            this.bnAcreedoresFondo.Click += new System.EventHandler(this.btnProveedorFondo_Click);
            // 
            // btnCartera
            // 
            this.btnCartera.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCartera.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(152)))), ((int)(((byte)(48)))));
            this.btnCartera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartera.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnCartera.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCartera.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btnCartera.IconColor = System.Drawing.Color.White;
            this.btnCartera.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCartera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartera.Location = new System.Drawing.Point(0, 153);
            this.btnCartera.Name = "btnCartera";
            this.btnCartera.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCartera.Size = new System.Drawing.Size(240, 65);
            this.btnCartera.TabIndex = 3;
            this.btnCartera.Text = "Cartera";
            this.btnCartera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCartera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCartera.UseVisualStyleBackColor = true;
            this.btnCartera.Click += new System.EventHandler(this.btnCartera_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(240, 153);
            this.panelLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Holding.Properties.Resources.Logo_Holding;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.PanelBarraTitulo.Controls.Add(this.btnCerrarPrincipal);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(261, 0);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(1516, 35);
            this.PanelBarraTitulo.TabIndex = 3;
            this.PanelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseDown);
            // 
            // btnCerrarPrincipal
            // 
            this.btnCerrarPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnCerrarPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarPrincipal.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrarPrincipal.IconColor = System.Drawing.Color.White;
            this.btnCerrarPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrarPrincipal.IconSize = 35;
            this.btnCerrarPrincipal.Location = new System.Drawing.Point(1480, 2);
            this.btnCerrarPrincipal.Name = "btnCerrarPrincipal";
            this.btnCerrarPrincipal.Size = new System.Drawing.Size(35, 35);
            this.btnCerrarPrincipal.TabIndex = 9;
            this.btnCerrarPrincipal.TabStop = false;
            this.btnCerrarPrincipal.Click += new System.EventHandler(this.btnCerrarPrincipal_Click);
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(43)))), ((int)(((byte)(76)))));
            this.PanelContenedor.Controls.Add(this.label1);
            this.PanelContenedor.Controls.Add(this.lblHora);
            this.PanelContenedor.Controls.Add(this.lblFecha);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(261, 35);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1516, 874);
            this.PanelContenedor.TabIndex = 4;
            this.PanelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenedor_Paint_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1297, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "BIENVENIDO AL SISTEMA DE ADMINISTRACION DE FONDO DE PROVEEDORES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(43, 289);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(517, 88);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Hora";
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(51, 377);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(710, 60);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimerFechaHora
            // 
            this.TimerFechaHora.Enabled = true;
            this.TimerFechaHora.Tick += new System.EventHandler(this.TimerFechaHora_Tick);
            // 
            // PanelBarraInferior
            // 
            this.PanelBarraInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.PanelBarraInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBarraInferior.Location = new System.Drawing.Point(261, 874);
            this.PanelBarraInferior.Name = "PanelBarraInferior";
            this.PanelBarraInferior.Size = new System.Drawing.Size(1516, 35);
            this.PanelBarraInferior.TabIndex = 5;
            // 
            // btnReimprimirBoucher
            // 
            this.btnReimprimirBoucher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReimprimirBoucher.FlatAppearance.BorderSize = 0;
            this.btnReimprimirBoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReimprimirBoucher.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnReimprimirBoucher.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReimprimirBoucher.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReimprimirBoucher.IconColor = System.Drawing.Color.Black;
            this.btnReimprimirBoucher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReimprimirBoucher.Location = new System.Drawing.Point(0, 84);
            this.btnReimprimirBoucher.Name = "btnReimprimirBoucher";
            this.btnReimprimirBoucher.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReimprimirBoucher.Size = new System.Drawing.Size(240, 42);
            this.btnReimprimirBoucher.TabIndex = 24;
            this.btnReimprimirBoucher.Text = "Reimprimir Boucher";
            this.btnReimprimirBoucher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReimprimirBoucher.UseVisualStyleBackColor = true;
            // 
            // btnReporteCaja
            // 
            this.btnReporteCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporteCaja.FlatAppearance.BorderSize = 0;
            this.btnReporteCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteCaja.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnReporteCaja.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReporteCaja.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnReporteCaja.IconColor = System.Drawing.Color.Black;
            this.btnReporteCaja.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporteCaja.Location = new System.Drawing.Point(0, 42);
            this.btnReporteCaja.Name = "btnReporteCaja";
            this.btnReporteCaja.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReporteCaja.Size = new System.Drawing.Size(240, 42);
            this.btnReporteCaja.TabIndex = 23;
            this.btnReporteCaja.Text = "Reporte de Caja";
            this.btnReporteCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteCaja.UseVisualStyleBackColor = true;
            // 
            // btnVentanilla
            // 
            this.btnVentanilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentanilla.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(152)))), ((int)(((byte)(48)))));
            this.btnVentanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentanilla.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnVentanilla.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVentanilla.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnVentanilla.IconColor = System.Drawing.Color.White;
            this.btnVentanilla.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVentanilla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentanilla.Location = new System.Drawing.Point(0, 805);
            this.btnVentanilla.Name = "btnVentanilla";
            this.btnVentanilla.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnVentanilla.Size = new System.Drawing.Size(240, 65);
            this.btnVentanilla.TabIndex = 22;
            this.btnVentanilla.Text = "Ventanilla";
            this.btnVentanilla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentanilla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVentanilla.UseVisualStyleBackColor = true;
            this.btnVentanilla.Click += new System.EventHandler(this.btnVentanilla_Click);
            // 
            // PanelVentanilla
            // 
            this.PanelVentanilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelVentanilla.Controls.Add(this.btnReimprimirBoucher);
            this.PanelVentanilla.Controls.Add(this.btnReporteCaja);
            this.PanelVentanilla.Controls.Add(this.btnPagosInversion);
            this.PanelVentanilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelVentanilla.Location = new System.Drawing.Point(0, 870);
            this.PanelVentanilla.Name = "PanelVentanilla";
            this.PanelVentanilla.Size = new System.Drawing.Size(240, 132);
            this.PanelVentanilla.TabIndex = 25;
            this.PanelVentanilla.TabStop = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 909);
            this.Controls.Add(this.PanelBarraInferior);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.PanelBarraTitulo);
            this.Controls.Add(this.PanelMenuLateral);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holding Versión 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PanelMenuLateral.ResumeLayout(false);
            this.PanelConfiguracion.ResumeLayout(false);
            this.PanelSeguridad.ResumeLayout(false);
            this.PanelCartera.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarPrincipal)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            this.PanelVentanilla.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenuLateral;
        private System.Windows.Forms.Panel PanelCartera;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel PanelConfiguracion;
        private FontAwesome.Sharp.IconButton btnProductos;
        private FontAwesome.Sharp.IconButton btnTasaCambio;
        private FontAwesome.Sharp.IconButton btnParametros;
        private System.Windows.Forms.Panel PanelSeguridad;
        private FontAwesome.Sharp.IconButton btnAsignarPermisos;
        private FontAwesome.Sharp.IconButton btnRoles;
        private FontAwesome.Sharp.IconButton btnUsuarios;
        private FontAwesome.Sharp.IconButton btnFondoFinanciamiento;
        private FontAwesome.Sharp.IconButton btnPagosInversion;
        private FontAwesome.Sharp.IconButton bnAcreedoresFondo;
        private FontAwesome.Sharp.IconButton btnReportería;
        private FontAwesome.Sharp.IconButton btnCatalogos;
        private FontAwesome.Sharp.IconButton btnCartera;
        private FontAwesome.Sharp.IconButton btnSeguridad;
        private FontAwesome.Sharp.IconButton btnConfiguración;
        private FontAwesome.Sharp.IconButton btnOtrasOpciones;
        private FontAwesome.Sharp.IconButton btnSalir;
        private System.Windows.Forms.Panel PanelBarraTitulo;
        private FontAwesome.Sharp.IconPictureBox btnCerrarPrincipal;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer TimerFechaHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelBarraInferior;
        private FontAwesome.Sharp.IconButton btnAcciones;
        private FontAwesome.Sharp.IconButton btnReimprimirBoucher;
        private FontAwesome.Sharp.IconButton btnReporteCaja;
        private FontAwesome.Sharp.IconButton btnVentanilla;
        private System.Windows.Forms.Panel PanelVentanilla;
    }
}

