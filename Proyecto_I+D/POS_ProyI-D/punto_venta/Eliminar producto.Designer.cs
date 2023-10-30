namespace punto_venta
{
    partial class Eliminar_producto
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttSi = new System.Windows.Forms.Button();
            this.bttNo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Está seguro de que desea eliminar el producto permanentemente?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::punto_venta.Properties.Resources.delete_product;
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bttSi
            // 
            this.bttSi.Location = new System.Drawing.Point(260, 115);
            this.bttSi.Name = "bttSi";
            this.bttSi.Size = new System.Drawing.Size(75, 23);
            this.bttSi.TabIndex = 2;
            this.bttSi.Text = "Si";
            this.bttSi.UseVisualStyleBackColor = true;
            this.bttSi.Click += new System.EventHandler(this.bttSi_Click);
            // 
            // bttNo
            // 
            this.bttNo.Location = new System.Drawing.Point(356, 115);
            this.bttNo.Name = "bttNo";
            this.bttNo.Size = new System.Drawing.Size(75, 23);
            this.bttNo.TabIndex = 3;
            this.bttNo.Text = "No";
            this.bttNo.UseVisualStyleBackColor = true;
            this.bttNo.Click += new System.EventHandler(this.bttNo_Click);
            // 
            // Eliminar_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 161);
            this.Controls.Add(this.bttNo);
            this.Controls.Add(this.bttSi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Eliminar_producto";
            this.Text = "Eliminar_producto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttSi;
        private System.Windows.Forms.Button bttNo;
    }
}