namespace punto_venta
{
    partial class pruebaDataBase
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
            this.btnConectDataBase = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConectDataBase
            // 
            this.btnConectDataBase.Location = new System.Drawing.Point(36, 33);
            this.btnConectDataBase.Name = "btnConectDataBase";
            this.btnConectDataBase.Size = new System.Drawing.Size(75, 23);
            this.btnConectDataBase.TabIndex = 0;
            this.btnConectDataBase.Text = "Conectar";
            this.btnConectDataBase.UseVisualStyleBackColor = true;
            this.btnConectDataBase.Click += new System.EventHandler(this.btnConectDataBase_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // pruebaDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConectDataBase);
            this.Name = "pruebaDataBase";
            this.Text = "pruebaDataBase";
            this.Load += new System.EventHandler(this.pruebaDataBase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectDataBase;
        private System.Windows.Forms.TextBox textBox1;
    }
}