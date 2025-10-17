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
    public partial class FormOfertas : Form
    {
        public FormOfertas()
        {
            InitializeComponent();
        }

        private void linklbl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           FormDestinos formd = new FormDestinos();
            formd.Show();
            this.Close();

        }

        private void userControl11_Load(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDestinos formd = new FormDestinos();
            formd.Show();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormReservas formr = new FormReservas();
            formr.Show();
            this.Close();
        }
    }
}
