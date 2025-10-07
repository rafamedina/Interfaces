using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class btnSaludar : Form
    {
        public btnSaludar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Inicializa el progress bar
            progreso.Minimum = 0;
            progreso.Maximum = 100;
            progreso.Value = 0;

            // Simula el progreso
            for (int i = 0; i <= 100; i++)
            {
                progreso.Value = i;
                System.Threading.Thread.Sleep(10); // Simula trabajo
                Application.DoEvents(); // Refresca el ProgressBar
            }

            // Cuando termina, muestra la imagen
            try
            {
                web1.Navigate("https://www.wordreference.com/");
                foto.Image = Image.FromFile(@"C:\Users\CAMPUSFP\Pictures\ChatGPT Image 17 sept 2025, 12_26_43.png");
                foto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
            }
        }

        private void Ikimamonazo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void web1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
    }
}
