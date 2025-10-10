namespace DI_A1._8_Rafael_Medina
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCarta = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cartaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userControl11 = new DI_A1._8_Rafael_Medina.UserControl1();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Café Digital 2025";
            // 
            // btnCarta
            // 
            this.btnCarta.AutoSize = true;
            this.btnCarta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarta.Location = new System.Drawing.Point(158, 273);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(152, 102);
            this.btnCarta.TabIndex = 1;
            this.btnCarta.Text = "Carta";
            this.btnCarta.UseVisualStyleBackColor = true;
            this.btnCarta.Click += new System.EventHandler(this.btnCarta_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.AutoSize = true;
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.Location = new System.Drawing.Point(385, 273);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(152, 102);
            this.btnPedidos.TabIndex = 2;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(307, 442);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartaToolStripMenuItem,
            this.pedidosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cartaToolStripMenuItem
            // 
            this.cartaToolStripMenuItem.Name = "cartaToolStripMenuItem";
            this.cartaToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.cartaToolStripMenuItem.Text = "Carta";
            this.cartaToolStripMenuItem.Click += new System.EventHandler(this.cartaToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.RosyBrown;
            this.userControl11.Location = new System.Drawing.Point(-8, 27);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(231, 302);
            this.userControl11.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(691, 534);
            this.Controls.Add(this.btnCarta);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCarta;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnSalir;
        private UserControl1 userControl11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cartaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
    }
}

