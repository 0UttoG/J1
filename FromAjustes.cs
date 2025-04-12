using System;
using System.Drawing;
using System.Windows.Forms;

namespace J1
{
    public partial class FromAjustes : Form
    {
        private bool fullscreen = true;
        private string videoPath = @"C:\Users\Nestor Uto\Desktop\J1\CyberpunkIntro.mp4";

        public FromAjustes()
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.KeyPreview = true;

            ConfigurarReproductor();
            this.Resize += new EventHandler(FromAjustes_Resize);
        }

        private void ConfigurarReproductor()
        {
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.SendToBack();
        }

        private void FromAjustes_Load(object sender, EventArgs e)
        {
            // Cargar video
            if (System.IO.File.Exists(videoPath))
            {
                axWindowsMediaPlayer1.URL = videoPath;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                MessageBox.Show("Video de fondo no encontrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Configuración de estilo visual
            this.BackColor = Color.Black;
            PanelControl.BackColor = Color.FromArgb(100, 0, 0, 0); // Transparente oscuro
            PanelControl.Parent = this;
            PanelControl.BringToFront();

            // Forzar estilos en todos los controles
            foreach (Control ctrl in PanelControl.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.ForeColor = Color.Cyan;
                    lbl.Font = new Font("Consolas", 12F, FontStyle.Bold);
                }
                else if (ctrl is TextBox tb)
                {
                    tb.BackColor = Color.Black;
                    tb.ForeColor = Color.Cyan;
                    tb.BorderStyle = BorderStyle.None;
                    tb.Font = new Font("Consolas", 12F, FontStyle.Bold);
                }
                else if (ctrl is ComboBox cb)
                {
                    cb.BackColor = Color.Black;
                    cb.ForeColor = Color.Cyan;
                    cb.FlatStyle = FlatStyle.Flat;
                    cb.Font = new Font("Consolas", 12F, FontStyle.Bold);
                }
                else if (ctrl is Button btn)
                {
                    btn.BackColor = Color.Magenta;
                    btn.ForeColor = Color.Black;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Consolas", 10F, FontStyle.Bold);
                }
            }

            // Configurar combos
            CgoriadePreguntas.Items.AddRange(new object[] { "Historia", "Matemáticas", "Ciencia", "Deportes", "Aleatoria" });
            CgoriadePreguntas.SelectedIndex = 0;

            NmdeIntentos.Items.AddRange(new object[] { "1", "3", "5", "10" });
            NmdeIntentos.SelectedIndex = 1;

            // Centrar panel
            CentrarPanel();
        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NmJugador.Text.Trim()))
            {
                MessageBox.Show("Por favor, ingresa tu nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            axWindowsMediaPlayer1.Ctlcontrols.stop();

            Jugar frmJuego = new Jugar(
                NmJugador.Text.Trim(),
                CgoriadePreguntas.SelectedItem.ToString(),
                int.Parse(NmdeIntentos.SelectedItem.ToString()));

            this.Hide();
            frmJuego.ShowDialog();

            axWindowsMediaPlayer1.Ctlcontrols.play();
            this.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Close();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Escape)
            {
                fullscreen = !fullscreen;

                this.FormBorderStyle = fullscreen ? FormBorderStyle.None : FormBorderStyle.Sizable;
                this.WindowState = fullscreen ? FormWindowState.Maximized : FormWindowState.Normal;
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            PanelControl.BringToFront();
        }

        private void CentrarPanel()
        {
            PanelControl.Left = (this.ClientSize.Width - PanelControl.Width) / 2;
            PanelControl.Top = (this.ClientSize.Height - PanelControl.Height) / 2;
        }

        private void FromAjustes_Resize(object sender, EventArgs e)
        {
            CentrarPanel();
        }

        private void PanelControl_Paint(object sender, PaintEventArgs e)
        {
            // Si querés meter efectos visuales al panel, lo hacés acá.
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void NmJugador_TextChanged(object sender, EventArgs e)
        {

        }

        private void CgoriadePreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}






