using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Evaluable_DI_1_Aplicación_de_escritorio
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FormHome form = new FormHome();
            form.Show();
        }

        private void destinosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormDestinos formD = new FormDestinos();
            formD.Show();
            
        }

        private void ofertasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOfertas formOfertas = new FormOfertas();
            formOfertas.Show();

        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormReservas formReservas = new FormReservas();  
            formReservas.Show();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
