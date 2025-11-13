using System;
using System.Drawing;
using System.Windows.Forms;

namespace DI_A1._10
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            // Evento para redimensionar el UserControl
            this.Resize += UserControl1_Resize;
        }

        private void UserControl1_Resize(object sender, EventArgs e)
        {
            ResizeLabelFont();
        }

        private void ResizeLabelFont()
        {
            // Escala la fuente del Label según el tamaño del Panel
            int tamañoMin = Math.Min(panel1.Width, panel1.Height);
            float tamañoFuente = Math.Max(tamañoMin / 10f, 8f); // mínimo 8px
            label1.Font = new Font(label1.Font.FontFamily, tamañoFuente, label1.Font.Style);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Aquí puedes dibujar si lo necesitas, pero no es obligatorio para lo responsive
        }
    }
}