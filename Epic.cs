using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginSeguro;
using static System.Windows.Forms.DataFormats;

namespace J1
{
    public partial class Epic : Form
    {
        public Epic()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void Tienda_Click(object sender, EventArgs e)
        {

        }

        private void Noticias_Click(object sender, EventArgs e)
        {

        }

        private void Preguntas_Click(object sender, EventArgs e)
        {

        }

        private void Ayuda_Click(object sender, EventArgs e)
        {

        }

        private void IniciarSeccion_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio inicio = new Inicio();
            inicio.Show();
        }

        private void Descargar_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Todo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Epic_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelJuegos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImagenJuego1_Click(object sender, EventArgs e)
        {

        }

        private void targetaJuego1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Rush_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario FromInicio
            FromInicio inicioForm = new FromInicio();

            // Ocultar el formulario actual (opcional)
            this.Hide();

            // Mostrar el formulario FromInicio como diálogo
            inicioForm.ShowDialog();

            // Si decides no cerrar el formulario actual, puedes usar:
            // inicioForm.Show(); // En lugar de ShowDialog()

            // Cerrar el formulario actual cuando FromInicio se cierre (opcional)
            this.Close();
        }

        private void ImagenJuego2_Click(object sender, EventArgs e)
        {

        }

        private void CartaJuego2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Juego2_Click(object sender, EventArgs e)
        {

        }

        private void targetaJuego3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImagenJuego3_Click(object sender, EventArgs e)
        {

        }

        private void Juego3_Click(object sender, EventArgs e)
        {

        }

        private void ImagenJuego4_Click(object sender, EventArgs e)
        {

        }

        private void targetaJuego4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ImagenJuego5_Click(object sender, EventArgs e)
        {

        }

        private void targetaJuego5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Juego5_Click(object sender, EventArgs e)
        {

        }

        private void ImagenJuego6_Click(object sender, EventArgs e)
        {

        }

        private void targetaJuego6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Juego6_Click(object sender, EventArgs e)
        {

        }

        private void ImagenJuego7_Click(object sender, EventArgs e)
        {

        }

        private void targetaJuego7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Juego7_Click(object sender, EventArgs e)
        {

        }

        private void ImagenJuego8_Click(object sender, EventArgs e)
        {

        }

        private void targetaJuego8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Juego8_Click(object sender, EventArgs e)
        {

        }

        private void ImagenJuego9_Click(object sender, EventArgs e)
        {

        }

        private void targetaJuego9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Juego9_Click(object sender, EventArgs e)
        {

        }

        private void ImagenJuego10_Click(object sender, EventArgs e)
        {

        }

        private void targetaJuego10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Juego10_Click(object sender, EventArgs e)
        {

        }
    }
}
