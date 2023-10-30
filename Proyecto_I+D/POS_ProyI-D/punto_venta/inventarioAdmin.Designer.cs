namespace punto_venta
{
    partial class inventarioAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventarioAdmin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msjBienvenida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbBusqueda = new System.Windows.Forms.GroupBox();
            this.rbttProductAgotados = new System.Windows.Forms.RadioButton();
            this.rbttVerTodo = new System.Windows.Forms.RadioButton();
            this.rbttProductExistentes = new System.Windows.Forms.RadioButton();
            this.bttBuscar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agotado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbViewProduct = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.categoria_cb = new System.Windows.Forms.ComboBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.bttEliminarProducto = new System.Windows.Forms.Button();
            this.bttGuardarCambios = new System.Windows.Forms.Button();
            this.txtAgotado = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbAgotado = new System.Windows.Forms.Label();
            this.lbFechaIngreso = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.lbCategoria = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imgProduct = new System.Windows.Forms.PictureBox();
            this.bttRefresh = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.gbViewProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.msjBienvenida);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(16, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(1424, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Realizar Venta";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estadísticas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuarios";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Inventario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // msjBienvenida
            // 
            this.msjBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msjBienvenida.AutoSize = true;
            this.msjBienvenida.Location = new System.Drawing.Point(1135, 21);
            this.msjBienvenida.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.msjBienvenida.Name = "msjBienvenida";
            this.msjBienvenida.Size = new System.Drawing.Size(88, 18);
            this.msjBienvenida.TabIndex = 4;
            this.msjBienvenida.Text = "¡Bienvenido!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nuevo\nProducto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbBusqueda
            // 
            this.gbBusqueda.Controls.Add(this.bttRefresh);
            this.gbBusqueda.Controls.Add(this.rbttProductAgotados);
            this.gbBusqueda.Controls.Add(this.rbttVerTodo);
            this.gbBusqueda.Controls.Add(this.rbttProductExistentes);
            this.gbBusqueda.Controls.Add(this.bttBuscar);
            this.gbBusqueda.Controls.Add(this.tbBuscar);
            this.gbBusqueda.Location = new System.Drawing.Point(120, 112);
            this.gbBusqueda.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbBusqueda.Name = "gbBusqueda";
            this.gbBusqueda.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbBusqueda.Size = new System.Drawing.Size(851, 109);
            this.gbBusqueda.TabIndex = 7;
            this.gbBusqueda.TabStop = false;
            this.gbBusqueda.Text = "Buscar:";
            // 
            // rbttProductAgotados
            // 
            this.rbttProductAgotados.AutoSize = true;
            this.rbttProductAgotados.Location = new System.Drawing.Point(307, 63);
            this.rbttProductAgotados.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbttProductAgotados.Name = "rbttProductAgotados";
            this.rbttProductAgotados.Size = new System.Drawing.Size(183, 22);
            this.rbttProductAgotados.TabIndex = 4;
            this.rbttProductAgotados.Text = "Solo productos agotados";
            this.rbttProductAgotados.UseVisualStyleBackColor = true;
            // 
            // rbttVerTodo
            // 
            this.rbttVerTodo.AutoSize = true;
            this.rbttVerTodo.Checked = true;
            this.rbttVerTodo.Location = new System.Drawing.Point(9, 63);
            this.rbttVerTodo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbttVerTodo.Name = "rbttVerTodo";
            this.rbttVerTodo.Size = new System.Drawing.Size(83, 22);
            this.rbttVerTodo.TabIndex = 3;
            this.rbttVerTodo.TabStop = true;
            this.rbttVerTodo.Text = "Ver todo";
            this.rbttVerTodo.UseVisualStyleBackColor = true;
            // 
            // rbttProductExistentes
            // 
            this.rbttProductExistentes.AutoSize = true;
            this.rbttProductExistentes.Location = new System.Drawing.Point(104, 63);
            this.rbttProductExistentes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.rbttProductExistentes.Name = "rbttProductExistentes";
            this.rbttProductExistentes.Size = new System.Drawing.Size(187, 22);
            this.rbttProductExistentes.TabIndex = 2;
            this.rbttProductExistentes.Text = "Solo productos existentes";
            this.rbttProductExistentes.UseVisualStyleBackColor = true;
            // 
            // bttBuscar
            // 
            this.bttBuscar.BackColor = System.Drawing.Color.SeaGreen;
            this.bttBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttBuscar.Location = new System.Drawing.Point(361, 26);
            this.bttBuscar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bttBuscar.Name = "bttBuscar";
            this.bttBuscar.Size = new System.Drawing.Size(101, 30);
            this.bttBuscar.TabIndex = 1;
            this.bttBuscar.Text = "Buscar";
            this.bttBuscar.UseVisualStyleBackColor = false;
            this.bttBuscar.Click += new System.EventHandler(this.bttBuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.AccessibleDescription = "";
            this.tbBuscar.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbBuscar.Location = new System.Drawing.Point(8, 26);
            this.tbBuscar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(345, 24);
            this.tbBuscar.TabIndex = 0;
            this.tbBuscar.Tag = "";
            this.tbBuscar.Text = "Ingrese nombre, categoría o descripción";
            this.tbBuscar.Enter += new System.EventHandler(this.tbBuscar_enter);
            this.tbBuscar.Leave += new System.EventHandler(this.tbBuscar_leave);
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AllowUserToResizeColumns = false;
            this.dgv_productos.AllowUserToResizeRows = false;
            this.dgv_productos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nom,
            this.categoria,
            this.precio,
            this.cantidad,
            this.fechaingreso,
            this.descripcion,
            this.agotado});
            this.dgv_productos.Location = new System.Drawing.Point(0, 229);
            this.dgv_productos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_productos.Size = new System.Drawing.Size(969, 472);
            this.dgv_productos.TabIndex = 8;
            this.dgv_productos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_productos_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nombre";
            this.nom.Name = "nom";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // fechaingreso
            // 
            this.fechaingreso.HeaderText = "Fecha de ingreso";
            this.fechaingreso.Name = "fechaingreso";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descrición";
            this.descripcion.Name = "descripcion";
            // 
            // agotado
            // 
            this.agotado.HeaderText = "Agotado";
            this.agotado.Name = "agotado";
            // 
            // gbViewProduct
            // 
            this.gbViewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbViewProduct.Controls.Add(this.txtid);
            this.gbViewProduct.Controls.Add(this.lbID);
            this.gbViewProduct.Controls.Add(this.categoria_cb);
            this.gbViewProduct.Controls.Add(this.tbDescripcion);
            this.gbViewProduct.Controls.Add(this.lbDescripcion);
            this.gbViewProduct.Controls.Add(this.bttEliminarProducto);
            this.gbViewProduct.Controls.Add(this.bttGuardarCambios);
            this.gbViewProduct.Controls.Add(this.txtAgotado);
            this.gbViewProduct.Controls.Add(this.txtFecha);
            this.gbViewProduct.Controls.Add(this.tbPrecio);
            this.gbViewProduct.Controls.Add(this.tbCantidad);
            this.gbViewProduct.Controls.Add(this.tbNombre);
            this.gbViewProduct.Controls.Add(this.lbAgotado);
            this.gbViewProduct.Controls.Add(this.lbFechaIngreso);
            this.gbViewProduct.Controls.Add(this.lbCantidad);
            this.gbViewProduct.Controls.Add(this.lbPrecio);
            this.gbViewProduct.Controls.Add(this.lbCategoria);
            this.gbViewProduct.Controls.Add(this.lbNombre);
            this.gbViewProduct.Controls.Add(this.imgProduct);
            this.gbViewProduct.ForeColor = System.Drawing.Color.Black;
            this.gbViewProduct.Location = new System.Drawing.Point(991, 113);
            this.gbViewProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbViewProduct.Name = "gbViewProduct";
            this.gbViewProduct.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbViewProduct.Size = new System.Drawing.Size(329, 588);
            this.gbViewProduct.TabIndex = 10;
            this.gbViewProduct.TabStop = false;
            this.gbViewProduct.Text = "Vizualizar Producto";
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(283, 484);
            this.txtid.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(18, 16);
            this.txtid.TabIndex = 19;
            this.txtid.Text = "- -";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(251, 486);
            this.lbID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(28, 18);
            this.lbID.TabIndex = 18;
            this.lbID.Text = "ID:";
            // 
            // categoria_cb
            // 
            this.categoria_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoria_cb.FormattingEnabled = true;
            this.categoria_cb.Items.AddRange(new object[] {
            "Alimentos y bebidas",
            "Bimbo",
            "Cosméticos",
            "Dulces",
            "Frituras",
            "Mascotas",
            "Miscelaneo",
            "Productos de limpieza"});
            this.categoria_cb.Location = new System.Drawing.Point(91, 286);
            this.categoria_cb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.categoria_cb.Name = "categoria_cb";
            this.categoria_cb.Size = new System.Drawing.Size(214, 25);
            this.categoria_cb.TabIndex = 17;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(101, 420);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(205, 24);
            this.tbDescripcion.TabIndex = 16;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(9, 423);
            this.lbDescripcion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(86, 18);
            this.lbDescripcion.TabIndex = 15;
            this.lbDescripcion.Text = "Descripción:";
            // 
            // bttEliminarProducto
            // 
            this.bttEliminarProducto.BackColor = System.Drawing.Color.SeaGreen;
            this.bttEliminarProducto.Enabled = false;
            this.bttEliminarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttEliminarProducto.Location = new System.Drawing.Point(184, 522);
            this.bttEliminarProducto.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bttEliminarProducto.Name = "bttEliminarProducto";
            this.bttEliminarProducto.Size = new System.Drawing.Size(123, 46);
            this.bttEliminarProducto.TabIndex = 14;
            this.bttEliminarProducto.Text = "Eliminar Producto";
            this.bttEliminarProducto.UseVisualStyleBackColor = false;
            this.bttEliminarProducto.Click += new System.EventHandler(this.bttEliminarProducto_Click);
            // 
            // bttGuardarCambios
            // 
            this.bttGuardarCambios.BackColor = System.Drawing.Color.SeaGreen;
            this.bttGuardarCambios.Enabled = false;
            this.bttGuardarCambios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttGuardarCambios.Location = new System.Drawing.Point(27, 522);
            this.bttGuardarCambios.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bttGuardarCambios.Name = "bttGuardarCambios";
            this.bttGuardarCambios.Size = new System.Drawing.Size(123, 46);
            this.bttGuardarCambios.TabIndex = 13;
            this.bttGuardarCambios.Text = "Guardar cambios";
            this.bttGuardarCambios.UseVisualStyleBackColor = false;
            this.bttGuardarCambios.Click += new System.EventHandler(this.bttGuardarCambios_Click);
            // 
            // txtAgotado
            // 
            this.txtAgotado.AutoSize = true;
            this.txtAgotado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgotado.Location = new System.Drawing.Point(87, 484);
            this.txtAgotado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtAgotado.Name = "txtAgotado";
            this.txtAgotado.Size = new System.Drawing.Size(18, 16);
            this.txtAgotado.TabIndex = 12;
            this.txtAgotado.Text = "- -";
            // 
            // txtFecha
            // 
            this.txtFecha.AutoSize = true;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(142, 463);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(47, 16);
            this.txtFecha.TabIndex = 11;
            this.txtFecha.Text = "--/--/----";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(93, 326);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(132, 24);
            this.tbPrecio.TabIndex = 9;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(93, 377);
            this.tbCantidad.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(132, 24);
            this.tbCantidad.TabIndex = 8;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(93, 243);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(132, 24);
            this.tbNombre.TabIndex = 7;
            // 
            // lbAgotado
            // 
            this.lbAgotado.AutoSize = true;
            this.lbAgotado.Location = new System.Drawing.Point(11, 488);
            this.lbAgotado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbAgotado.Name = "lbAgotado";
            this.lbAgotado.Size = new System.Drawing.Size(68, 18);
            this.lbAgotado.TabIndex = 6;
            this.lbAgotado.Text = "Agotado:";
            // 
            // lbFechaIngreso
            // 
            this.lbFechaIngreso.AutoSize = true;
            this.lbFechaIngreso.Location = new System.Drawing.Point(11, 463);
            this.lbFechaIngreso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbFechaIngreso.Name = "lbFechaIngreso";
            this.lbFechaIngreso.Size = new System.Drawing.Size(119, 18);
            this.lbFechaIngreso.TabIndex = 5;
            this.lbFechaIngreso.Text = "Fecha de ingreso:";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(9, 381);
            this.lbCantidad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(71, 18);
            this.lbCantidad.TabIndex = 4;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(9, 332);
            this.lbPrecio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(62, 18);
            this.lbPrecio.TabIndex = 3;
            this.lbPrecio.Text = "Precio: $";
            // 
            // lbCategoria
            // 
            this.lbCategoria.AutoSize = true;
            this.lbCategoria.Location = new System.Drawing.Point(9, 291);
            this.lbCategoria.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCategoria.Name = "lbCategoria";
            this.lbCategoria.Size = new System.Drawing.Size(74, 18);
            this.lbCategoria.TabIndex = 2;
            this.lbCategoria.Text = "Categoría:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(9, 246);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(65, 18);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // imgProduct
            // 
            this.imgProduct.Image = global::punto_venta.Properties.Resources.productos;
            this.imgProduct.Location = new System.Drawing.Point(36, 25);
            this.imgProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.imgProduct.Name = "imgProduct";
            this.imgProduct.Size = new System.Drawing.Size(271, 190);
            this.imgProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProduct.TabIndex = 0;
            this.imgProduct.TabStop = false;
            // 
            // bttRefresh
            // 
            this.bttRefresh.BackgroundImage = global::punto_venta.Properties.Resources.refresh;
            this.bttRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttRefresh.Location = new System.Drawing.Point(782, 55);
            this.bttRefresh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bttRefresh.Name = "bttRefresh";
            this.bttRefresh.Size = new System.Drawing.Size(53, 38);
            this.bttRefresh.TabIndex = 5;
            this.bttRefresh.UseVisualStyleBackColor = true;
            this.bttRefresh.Click += new System.EventHandler(this.bttRefresh_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::punto_venta.Properties.Resources.icon_add___copia;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(16, 112);
            this.button6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 71);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::punto_venta.Properties.Resources.icon_ventas;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(267, 12);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 44);
            this.button5.TabIndex = 3;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::punto_venta.Properties.Resources.icon_datos2;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(184, 13);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 44);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::punto_venta.Properties.Resources.icon_empleados;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(101, 14);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 42);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(8, 13);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 42);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // inventarioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1334, 701);
            this.Controls.Add(this.gbViewProduct);
            this.Controls.Add(this.dgv_productos);
            this.Controls.Add(this.gbBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "inventarioAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Inventario Administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.inventarioAdmin_FormClosing);
            this.Load += new System.EventHandler(this.inventarioAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbBusqueda.ResumeLayout(false);
            this.gbBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.gbViewProduct.ResumeLayout(false);
            this.gbViewProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label msjBienvenida;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbBusqueda;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.RadioButton rbttProductAgotados;
        private System.Windows.Forms.RadioButton rbttVerTodo;
        private System.Windows.Forms.RadioButton rbttProductExistentes;
        private System.Windows.Forms.Button bttBuscar;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn agotado;
        private System.Windows.Forms.GroupBox gbViewProduct;
        private System.Windows.Forms.Label lbAgotado;
        private System.Windows.Forms.Label lbFechaIngreso;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.Label lbCategoria;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.PictureBox imgProduct;
        private System.Windows.Forms.Button bttEliminarProducto;
        private System.Windows.Forms.Button bttGuardarCambios;
        private System.Windows.Forms.Label txtAgotado;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button bttRefresh;
        private System.Windows.Forms.ComboBox categoria_cb;
        private System.Windows.Forms.Label txtid;
        private System.Windows.Forms.Label lbID;
    }
}