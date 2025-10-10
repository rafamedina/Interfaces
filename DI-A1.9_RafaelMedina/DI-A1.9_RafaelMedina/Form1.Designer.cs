namespace DI_A1._9_RafaelMedina
{
    partial class FormPrincipal
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
            this.datosUsuarioControl1 = new DI_A1._9_RafaelMedina.DatosUsuarioControl();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datosUsuarioControl1
            // 
            this.datosUsuarioControl1.Location = new System.Drawing.Point(111, 103);
            this.datosUsuarioControl1.Name = "datosUsuarioControl1";
            this.datosUsuarioControl1.Size = new System.Drawing.Size(262, 346);
            this.datosUsuarioControl1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(214, 478);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(124, 49);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "Abrir 2 form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 597);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.datosUsuarioControl1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private DatosUsuarioControl datosUsuarioControl1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button button1;
    }
}

