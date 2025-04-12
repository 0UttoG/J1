using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace J1
{
    public partial class Perder : Form
    {
        private string gifPath = @"C:\Users\Nestor Uto\Desktop\Videos - juego\Videos - juego\GIF\bAV.gif";
        private Image gifImage;

        public Perder(string nombreJugador, int preguntasCorrectas, int totalPreguntas)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;
            this.KeyDown += Perder_KeyDown;
            this.Resize += Perder_Resize;
            this.Load += Perder_Load;
            this.FormClosing += Perder_FormClosing;

            lblTitulo1.Text = $"¡HAS PERDIDO, {nombreJugador.ToUpper()}!";
            lblTitulo2.Text = $"Respondiste {preguntasCorrectas} de {totalPreguntas} preguntas correctamente.";

            btnReintentar.Text = "REINTENTAR";
            btnSalir.Text = "SALIR";
        }

        private void Perder_Load(object sender, EventArgs e)
        {
            CentrarPanel();

            try
            {
                if (File.Exists(gifPath))
                {
                    gifImage = Image.FromFile(gifPath);
                    MediaPerdedor.Image = gifImage;
                    MediaPerdedor.SizeMode = PictureBoxSizeMode.Zoom;
                    MediaPerdedor.SendToBack();
                }
                else
                {
                    MessageBox.Show("GIF de derrota no encontrado 😞", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el GIF: " + ex.Message);
            }
        }

        private void Perder_Resize(object sender, EventArgs e)
        {
            CentrarPanel();
        }

        private void CentrarPanel()
        {
            if (panel1 != null)
            {
                panel1.Location = new Point(
                    (this.ClientSize.Width - panel1.Width) / 2,
                    (this.ClientSize.Height - panel1.Height) / 2
                );
            }
        }

        private void Perder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gifImage != null)
            {
                gifImage.Dispose();
                gifImage = null;
            }

            if (MediaPerdedor.Image != null)
            {
                MediaPerdedor.Image.Dispose();
                MediaPerdedor.Image = null;
            }
        }

        private void btnReintentar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void Perder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();
            }
        }

        private void lblTitulo2_Click(object sender, EventArgs e) { }
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e) { }
        private void MediaPerdedor_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}




