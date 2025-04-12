using System;
using System.Windows.Forms;

namespace J1
{
    public partial class FromInicio : Form
    {
        private bool glowIn = true; // Controla el ciclo de animación (entra o sale)
        private bool fullscreen = true; // Controla el estado de pantalla completa

        public FromInicio()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.KeyPreview = true; // Permite capturar eventos de teclado

            ConfigurarReproductor();
            ConfigurarBoton();
        }

        private void ConfigurarReproductor()
        {
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.BringToFront();
        }

        private void ConfigurarBoton()
        {
            BtnJugar.BackColor = System.Drawing.Color.Transparent;
            BtnJugar.FlatStyle = FlatStyle.Flat;
            BtnJugar.FlatAppearance.BorderSize = 0;
            BtnJugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            BtnJugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;

            BtnJugar.Anchor = AnchorStyles.None;
            BtnJugar.Location = new System.Drawing.Point(
                (this.ClientSize.Width - BtnJugar.Width) / 2,
                (this.ClientSize.Height - BtnJugar.Height) / 2);
            BtnJugar.BringToFront();
        }

        private void FromInicio_Load(object sender, EventArgs e)
        {
            string videoPath = @"C:\Users\Nestor Uto\Desktop\J1\CyberpunkIntro.mp4";

            if (System.IO.File.Exists(videoPath))
            {
                axWindowsMediaPlayer1.URL = videoPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Video no encontrado. Se mostrará sin video introductorio.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnJugar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            FromAjustes ajustesForm = new FromAjustes();
            this.Hide();
            ajustesForm.ShowDialog();
          
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            // Centrado dinámico del botón
            BtnJugar.Location = new System.Drawing.Point(
                (this.ClientSize.Width - BtnJugar.Width) / 2,
                (this.ClientSize.Height - BtnJugar.Height) / 2);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            BtnJugar.BringToFront();
        }

        // Manejo de tecla ESC para mostrar/ocultar bordes
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Escape)
            {
                ToggleFullscreen();
            }
        }

        private void ToggleFullscreen()
        {
            fullscreen = !fullscreen;

            if (fullscreen)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
            }
        }

        // Efecto de glow para el botón
        private void GlowTimer_Tick(object sender, EventArgs e)
        {
            if (glowIn)
            {
                // Aumentar el brillo (neón)
                BtnJugar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 0);
                BtnJugar.Font = new System.Drawing.Font(BtnJugar.Font.FontFamily, 14, System.Drawing.FontStyle.Bold);
                BtnJugar.BackColor = System.Drawing.Color.FromArgb(255, 0, 255, 255); // Cyan brillante
            }
            else
            {
                // Disminuir el brillo
                BtnJugar.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
                BtnJugar.Font = new System.Drawing.Font(BtnJugar.Font.FontFamily, 12, System.Drawing.FontStyle.Regular);
                BtnJugar.BackColor = System.Drawing.Color.Transparent;
            }

            // Cambiar la dirección del efecto de glow
            glowIn = !glowIn;
        }
    }
}
