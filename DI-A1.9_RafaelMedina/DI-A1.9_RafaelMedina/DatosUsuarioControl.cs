﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_A1._9_RafaelMedina
{
    public partial class DatosUsuarioControl : UserControl
    {
        public DatosUsuarioControl()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbEdad.Text = string.Empty;
            tbName.Text = string.Empty;
         
        }
    }
}
