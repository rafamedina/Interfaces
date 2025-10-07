namespace WindowsFormsApp1
{
    partial class btnSaludar
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
            this.btn = new System.Windows.Forms.Button();
            this.foto = new System.Windows.Forms.PictureBox();
            this.progreso = new System.Windows.Forms.ProgressBar();
            this.web1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(338, 405);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(195, 73);
            this.btn.TabIndex = 1;
            this.btn.Text = "Sorpresa";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // foto
            // 
            this.foto.Location = new System.Drawing.Point(631, 12);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(183, 197);
            this.foto.TabIndex = 3;
            this.foto.TabStop = false;
            this.foto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // progreso
            // 
            this.progreso.Location = new System.Drawing.Point(366, 383);
            this.progreso.Name = "progreso";
            this.progreso.Size = new System.Drawing.Size(143, 29);
            this.progreso.TabIndex = 5;
            // 
            // web1
            // 
            this.web1.Location = new System.Drawing.Point(40, 52);
            this.web1.MinimumSize = new System.Drawing.Size(20, 20);
            this.web1.Name = "web1";
            this.web1.Size = new System.Drawing.Size(572, 325);
            this.web1.TabIndex = 6;
            this.web1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web1_DocumentCompleted);
            // 
            // btnSaludar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 597);
            this.Controls.Add(this.web1);
            this.Controls.Add(this.progreso);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.btn);
            this.Name = "btnSaludar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.ProgressBar progreso;
        private System.Windows.Forms.WebBrowser web1;
    }
}

