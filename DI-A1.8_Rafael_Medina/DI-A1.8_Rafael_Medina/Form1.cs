using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_A1._8_Rafael_Medina
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            FormCarta formc = new FormCarta();
            formc.Show();
            this.SetVisibleCore(false);
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            FormPedidos formp = new FormPedidos();
            formp.Show();
            this.SetVisibleCore(false);
        }

        private void cartaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCarta formc = new FormCarta();
            formc.Show();
            this.SetVisibleCore(false);
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPedidos formp = new FormPedidos();
            formp.Show();
            this.SetVisibleCore(false);
        }
    }
}
