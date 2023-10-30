namespace punto_venta
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totallbl = new System.Windows.Forms.Label();
            this.lb_productos = new System.Windows.Forms.Label();
            this.lb_venta = new System.Windows.Forms.Label();
            this.dgv_venta = new System.Windows.Forms.DataGridView();
            this.dgv_productos = new System.Windows.Forms.DataGridView();
            this.confirmar = new System.Windows.Forms.Button();
            this.lb_total = new System.Windows.Forms.Label();
            this.eliminar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Can = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totallbl);
            this.groupBox2.Controls.Add(this.lb_productos);
            this.groupBox2.Controls.Add(this.lb_venta);
            this.groupBox2.Controls.Add(this.dgv_venta);
            this.groupBox2.Controls.Add(this.dgv_productos);
            this.groupBox2.Controls.Add(this.confirmar);
            this.groupBox2.Controls.Add(this.lb_total);
            this.groupBox2.Controls.Add(this.eliminar);
            this.groupBox2.Controls.Add(this.agregar);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // totallbl
            // 
            resources.ApplyResources(this.totallbl, "totallbl");
            this.totallbl.Name = "totallbl";
            // 
            // lb_productos
            // 
            resources.ApplyResources(this.lb_productos, "lb_productos");
            this.lb_productos.Name = "lb_productos";
            // 
            // lb_venta
            // 
            resources.ApplyResources(this.lb_venta, "lb_venta");
            this.lb_venta.Name = "lb_venta";
            // 
            // dgv_venta
            // 
            this.dgv_venta.AllowUserToAddRows = false;
            this.dgv_venta.AllowUserToDeleteRows = false;
            this.dgv_venta.AllowUserToResizeColumns = false;
            this.dgv_venta.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgv_venta, "dgv_venta");
            this.dgv_venta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_venta.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_venta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewTextBoxColumn1,
            this.Pre,
            this.Can,
            this.DescripcionV,
            this.Total});
            this.dgv_venta.Name = "dgv_venta";
            this.dgv_venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dgv_productos
            // 
            this.dgv_productos.AllowUserToAddRows = false;
            this.dgv_productos.AllowUserToDeleteRows = false;
            this.dgv_productos.AllowUserToResizeColumns = false;
            this.dgv_productos.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dgv_productos, "dgv_productos");
            this.dgv_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_productos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nom,
            this.precio,
            this.cantidad,
            this.Descripcion});
            this.dgv_productos.Name = "dgv_productos";
            this.dgv_productos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // confirmar
            // 
            this.confirmar.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.confirmar, "confirmar");
            this.confirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmar.Name = "confirmar";
            this.confirmar.UseVisualStyleBackColor = false;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click_1);
            // 
            // lb_total
            // 
            resources.ApplyResources(this.lb_total, "lb_total");
            this.lb_total.Name = "lb_total";
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.eliminar, "eliminar");
            this.eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eliminar.Name = "eliminar";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click_1);
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.agregar, "agregar");
            this.agregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.agregar.Name = "agregar";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click_1);
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btn_productos);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Column2
            // 
            resources.ApplyResources(this.Column2, "Column2");
            this.Column2.Name = "Column2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Pre
            // 
            resources.ApplyResources(this.Pre, "Pre");
            this.Pre.Name = "Pre";
            // 
            // Can
            // 
            resources.ApplyResources(this.Can, "Can");
            this.Can.Name = "Can";
            // 
            // DescripcionV
            // 
            resources.ApplyResources(this.DescripcionV, "DescripcionV");
            this.DescripcionV.Name = "DescripcionV";
            // 
            // Total
            // 
            resources.ApplyResources(this.Total, "Total");
            this.Total.Name = "Total";
            // 
            // Column1
            // 
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            // 
            // nom
            // 
            resources.ApplyResources(this.nom, "nom");
            this.nom.Name = "nom";
            // 
            // precio
            // 
            resources.ApplyResources(this.precio, "precio");
            this.precio.Name = "precio";
            // 
            // cantidad
            // 
            resources.ApplyResources(this.cantidad, "cantidad");
            this.cantidad.Name = "cantidad";
            // 
            // Descripcion
            // 
            resources.ApplyResources(this.Descripcion, "Descripcion");
            this.Descripcion.Name = "Descripcion";
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::punto_venta.Properties.Resources.icon_ventas;
            resources.ApplyResources(this.button5, "button5");
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::punto_venta.Properties.Resources.icon_datos2;
            resources.ApplyResources(this.button4, "button4");
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::punto_venta.Properties.Resources.icon_empleados;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_productos
            // 
            resources.ApplyResources(this.btn_productos, "btn_productos");
            this.btn_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click_1);
            // 
            // Form4
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_productos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label totallbl;
        private System.Windows.Forms.Label lb_productos;
        private System.Windows.Forms.Label lb_venta;
        private System.Windows.Forms.DataGridView dgv_venta;
        private System.Windows.Forms.DataGridView dgv_productos;
        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Can;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}