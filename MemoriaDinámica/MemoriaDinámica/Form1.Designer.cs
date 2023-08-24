namespace MemoriaDinámica
{
    partial class Form1
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
            this.btnAllocate = new System.Windows.Forms.Button();
            this.btnDeallocate = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAllocate
            // 
            this.btnAllocate.Location = new System.Drawing.Point(12, 87);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Size = new System.Drawing.Size(146, 77);
            this.btnAllocate.TabIndex = 0;
            this.btnAllocate.Text = "button1";
            this.btnAllocate.UseVisualStyleBackColor = true;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // btnDeallocate
            // 
            this.btnDeallocate.Location = new System.Drawing.Point(191, 87);
            this.btnDeallocate.Name = "btnDeallocate";
            this.btnDeallocate.Size = new System.Drawing.Size(151, 68);
            this.btnDeallocate.TabIndex = 1;
            this.btnDeallocate.Text = "button1";
            this.btnDeallocate.UseVisualStyleBackColor = true;
            this.btnDeallocate.Click += new System.EventHandler(this.btnDeallocate_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(348, 87);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(426, 22);
            this.txtValue.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnDeallocate);
            this.Controls.Add(this.btnAllocate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAllocate;
        private System.Windows.Forms.Button btnDeallocate;
        private System.Windows.Forms.TextBox txtValue;
    }
}

