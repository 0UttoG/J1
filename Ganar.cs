using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace J1
{
    public partial class Ganar : Form
    {
        private string gifPath = @"C:\Users\Nestor Uto\Desktop\Videos - juego\Videos - juego\GIF\YQgT.gif"; // ← Reemplazá con tu ruta real
        private Image gifImage;

        public Ganar(string nombreJugador, int respuestasCorrectas, int totalPreguntas)
        {
            InitializeComponent();

            double porcentajeCorrectas = (double)respuestasCorrectas / totalPreguntas * 100;

            string medalla = porcentajeCorrectas switch
            {
                >= 90 => "Medalla de Oro",
                >= 70 => "Medalla de Plata",
                >= 50 => "Medalla de Bronce",
                _ => "No hay medalla"
            };

            lblFelicitaciones.Text = $"¡Felicidades {nombreJugador}!";
            lblResultado.Text = $"Acertaste {respuestasCorrectas} de {totalPreguntas} preguntas\nTu medalla: {medalla}";

            this.Load += Ganar_Load;
            this.Resize += Ganar_Resize;
            this.FormClosing += Ganar_FormClosing;

            CentrarPanel();
        }

        private void Ganar_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(gifPath))
                {
                    gifImage = Image.FromFile(gifPath);
                    MediaGanador.Image = gifImage;
                    MediaGanador.SizeMode = PictureBoxSizeMode.Zoom;
                    MediaGanador.SendToBack(); // Se asegura de estar al fondo
                }
                else
                {
                    MessageBox.Show("GIF no encontrado 💀", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el GIF: " + ex.Message);
            }
        }

        private void Ganar_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Liberar recursos del GIF
            if (gifImage != null)
            {
                gifImage.Dispose();
                gifImage = null;
            }

            if (MediaGanador.Image != null)
            {
                MediaGanador.Image.Dispose();
                MediaGanador.Image = null;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ganar_Resize(object sender, EventArgs e)
        {
            CentrarPanel();
        }

        private void CentrarPanel()
        {
            panel1.Location = new Point(
                (this.ClientSize.Width - panel1.Width) / 2,
                (this.ClientSize.Height - panel1.Height) / 2
            );
        }

        // Eventos no usados pero declarados en el Designer
        private void lblFelicitaciones_Click(object sender, EventArgs e) { }
        private void lblResultado_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void MediaGanador_Enter(object sender, EventArgs e) { }
        private void MediaGanador_Click(object sender, EventArgs e) { }
    }
}


