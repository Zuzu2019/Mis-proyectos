namespace punto_venta
{
    partial class add_prod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_prod));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nombre_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.precio_tb = new System.Windows.Forms.TextBox();
            this.cantidad_tb = new System.Windows.Forms.TextBox();
            this.categoria_cb = new System.Windows.Forms.ComboBox();
            this.descripcion_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;";
            this.openFileDialog1.Title = "Elija una imagen";
            // 
            // nombre_tb
            // 
            this.nombre_tb.Location = new System.Drawing.Point(36, 56);
            this.nombre_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombre_tb.Name = "nombre_tb";
            this.nombre_tb.Size = new System.Drawing.Size(287, 24);
            this.nombre_tb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categoria";
            // 
            // precio_tb
            // 
            this.precio_tb.Location = new System.Drawing.Point(36, 122);
            this.precio_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.precio_tb.Name = "precio_tb";
            this.precio_tb.Size = new System.Drawing.Size(132, 24);
            this.precio_tb.TabIndex = 5;
            // 
            // cantidad_tb
            // 
            this.cantidad_tb.Location = new System.Drawing.Point(191, 122);
            this.cantidad_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cantidad_tb.Name = "cantidad_tb";
            this.cantidad_tb.Size = new System.Drawing.Size(132, 24);
            this.cantidad_tb.TabIndex = 6;
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
            this.categoria_cb.Location = new System.Drawing.Point(36, 196);
            this.categoria_cb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categoria_cb.Name = "categoria_cb";
            this.categoria_cb.Size = new System.Drawing.Size(287, 25);
            this.categoria_cb.TabIndex = 7;
            // 
            // descripcion_tb
            // 
            this.descripcion_tb.Location = new System.Drawing.Point(36, 281);
            this.descripcion_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descripcion_tb.Name = "descripcion_tb";
            this.descripcion_tb.Size = new System.Drawing.Size(287, 24);
            this.descripcion_tb.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 248);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripcion (opcional)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 352);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fotografía (opcional)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(208, 345);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Examinar...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(347, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(249, 261);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagen";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::punto_venta.Properties.Resources.placeholder;
            this.pictureBox1.Location = new System.Drawing.Point(8, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.SeaGreen;
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbtn.Location = new System.Drawing.Point(365, 333);
            this.addbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(100, 30);
            this.addbtn.TabIndex = 13;
            this.addbtn.Text = "Añadir";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.SeaGreen;
            this.cancelbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancelbtn.Location = new System.Drawing.Point(496, 333);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(100, 30);
            this.cancelbtn.TabIndex = 14;
            this.cancelbtn.Text = "Cancelar";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // add_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 407);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descripcion_tb);
            this.Controls.Add(this.categoria_cb);
            this.Controls.Add(this.cantidad_tb);
            this.Controls.Add(this.precio_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre_tb);
            this.Font = new System.Drawing.Font("Book Antiqua", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "add_prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Añadir un nuevo producto";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox nombre_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox precio_tb;
        private System.Windows.Forms.TextBox cantidad_tb;
        private System.Windows.Forms.ComboBox categoria_cb;
        private System.Windows.Forms.TextBox descripcion_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button cancelbtn;
    }
}