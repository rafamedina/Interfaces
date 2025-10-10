using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private String _mensaje;
        public String Mensaje
        {
            get { return _mensaje; }
            set { _mensaje = value;
                label1.Text = _mensaje;
                label2.Text = _mensaje;
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
