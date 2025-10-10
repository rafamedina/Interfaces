namespace DI_A1._9_RafaelMedina
{
    partial class Form2
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.datosUsuarioControl1 = new DI_A1._9_RafaelMedina.DatosUsuarioControl();
            this.btnAcept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // datosUsuarioControl1
            // 
            this.datosUsuarioControl1.Location = new System.Drawing.Point(27, 75);
            this.datosUsuarioControl1.Name = "datosUsuarioControl1";
            this.datosUsuarioControl1.Size = new System.Drawing.Size(407, 330);
            this.datosUsuarioControl1.TabIndex = 0;
            this.datosUsuarioControl1.Load += new System.EventHandler(this.datosUsuarioControl1_Load);
            // 
            // btnAcept
            // 
            this.btnAcept.Location = new System.Drawing.Point(136, 349);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(75, 23);
            this.btnAcept.TabIndex = 1;
            this.btnAcept.Text = "Aceptar";
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 538);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.datosUsuarioControl1);
            this.Name = "Form2";
            this.Text = "FormSecundario";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private DatosUsuarioControl datosUsuarioControl1;
        private System.Windows.Forms.Button btnAcept;
    }
}