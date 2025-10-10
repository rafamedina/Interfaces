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
    public partial class FormCarta : Form
    {
        public FormCarta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPedidos formp = new FormPedidos();
            formp.Show();
            this.SetVisibleCore(false);
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPrincipal formPrincipal = new FormPrincipal();
            formPrincipal.Show();
        }
    }
}
