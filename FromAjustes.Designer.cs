namespace J1
{
    partial class FromAjustes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromAjustes));
            label1 = new Label();
            CtPreguntas = new Label();
            NmIntentos = new Label();
            NmJugador = new TextBox();
            CgoriadePreguntas = new ComboBox();
            NmdeIntentos = new ComboBox();
            btnIniciarJuego = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            PanelControl = new Panel();
            bntSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            PanelControl.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(109, 78);
            label1.Name = "label1";
            label1.Size = new Size(261, 19);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su nombre de jugador";
            // 
            // CtPreguntas
            // 
            CtPreguntas.AutoSize = true;
            CtPreguntas.Font = new Font("Consolas", 12F, FontStyle.Bold);
            CtPreguntas.ForeColor = Color.Cyan;
            CtPreguntas.Location = new Point(109, 139);
            CtPreguntas.Name = "CtPreguntas";
            CtPreguntas.Size = new Size(207, 19);
            CtPreguntas.TabIndex = 1;
            CtPreguntas.Text = "Categoría de Preguntas";
            // 
            // NmIntentos
            // 
            NmIntentos.AutoSize = true;
            NmIntentos.Font = new Font("Consolas", 12F, FontStyle.Bold);
            NmIntentos.ForeColor = Color.Cyan;
            NmIntentos.Location = new Point(109, 223);
            NmIntentos.Name = "NmIntentos";
            NmIntentos.Size = new Size(171, 19);
            NmIntentos.TabIndex = 2;
            NmIntentos.Text = "Número de Intentos";
            // 
            // NmJugador
            // 
            NmJugador.BackColor = Color.Magenta;
            NmJugador.Font = new Font("Consolas", 12F, FontStyle.Bold);
            NmJugador.ForeColor = Color.Cyan;
            NmJugador.Location = new Point(376, 78);
            NmJugador.Name = "NmJugador";
            NmJugador.Size = new Size(200, 26);
            NmJugador.TabIndex = 3;
            NmJugador.TextChanged += NmJugador_TextChanged;
            // 
            // CgoriadePreguntas
            // 
            CgoriadePreguntas.BackColor = Color.Black;
            CgoriadePreguntas.FlatStyle = FlatStyle.Flat;
            CgoriadePreguntas.Font = new Font("Consolas", 12F, FontStyle.Bold);
            CgoriadePreguntas.ForeColor = Color.Cyan;
            CgoriadePreguntas.Location = new Point(376, 136);
            CgoriadePreguntas.Name = "CgoriadePreguntas";
            CgoriadePreguntas.Size = new Size(200, 27);
            CgoriadePreguntas.TabIndex = 4;
            CgoriadePreguntas.SelectedIndexChanged += CgoriadePreguntas_SelectedIndexChanged;
            // 
            // NmdeIntentos
            // 
            NmdeIntentos.BackColor = Color.Black;
            NmdeIntentos.FlatStyle = FlatStyle.Flat;
            NmdeIntentos.Font = new Font("Consolas", 12F, FontStyle.Bold);
            NmdeIntentos.ForeColor = Color.Cyan;
            NmdeIntentos.Location = new Point(376, 220);
            NmdeIntentos.Name = "NmdeIntentos";
            NmdeIntentos.Size = new Size(200, 27);
            NmdeIntentos.TabIndex = 5;
            // 
            // btnIniciarJuego
            // 
            btnIniciarJuego.BackColor = Color.Magenta;
            btnIniciarJuego.FlatStyle = FlatStyle.Flat;
            btnIniciarJuego.Font = new Font("Consolas", 10F, FontStyle.Bold);
            btnIniciarJuego.ForeColor = Color.Black;
            btnIniciarJuego.Location = new Point(444, 295);
            btnIniciarJuego.Name = "btnIniciarJuego";
            btnIniciarJuego.Size = new Size(100, 30);
            btnIniciarJuego.TabIndex = 6;
            btnIniciarJuego.Text = "JUGAR";
            btnIniciarJuego.UseVisualStyleBackColor = false;
            btnIniciarJuego.Click += btnIniciarJuego_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(12, 12);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(75, 23);
            axWindowsMediaPlayer1.TabIndex = 7;
            axWindowsMediaPlayer1.Enter += axWindowsMediaPlayer1_Enter;
            // 
            // PanelControl
            // 
            PanelControl.BackColor = Color.Black;
            PanelControl.BackgroundImageLayout = ImageLayout.None;
            PanelControl.BorderStyle = BorderStyle.Fixed3D;
            PanelControl.Controls.Add(NmJugador);
            PanelControl.Controls.Add(bntSalir);
            PanelControl.Controls.Add(CgoriadePreguntas);
            PanelControl.Controls.Add(btnIniciarJuego);
            PanelControl.Controls.Add(NmdeIntentos);
            PanelControl.Controls.Add(NmIntentos);
            PanelControl.Controls.Add(label1);
            PanelControl.Controls.Add(CtPreguntas);
            PanelControl.Location = new Point(53, 12);
            PanelControl.Name = "PanelControl";
            PanelControl.Size = new Size(704, 426);
            PanelControl.TabIndex = 8;
            PanelControl.Paint += PanelControl_Paint;
            // 
            // bntSalir
            // 
            bntSalir.BackColor = Color.Magenta;
            bntSalir.FlatStyle = FlatStyle.Flat;
            bntSalir.Font = new Font("Consolas", 10F, FontStyle.Bold);
            bntSalir.ForeColor = Color.Black;
            bntSalir.Location = new Point(264, 295);
            bntSalir.Name = "bntSalir";
            bntSalir.Size = new Size(100, 30);
            bntSalir.TabIndex = 11;
            bntSalir.Text = "SALIR";
            bntSalir.UseVisualStyleBackColor = false;
            bntSalir.Click += bntSalir_Click;
            // 
            // FromAjustes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelControl);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "FromAjustes";
            Text = "Ajustes del Juego";
            Load += FromAjustes_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            PanelControl.ResumeLayout(false);
            PanelControl.PerformLayout();
            ResumeLayout(false);
        }

        private Label label1;
        private Label CtPreguntas;
        private Label NmIntentos;
        private TextBox NmJugador;
        private ComboBox CgoriadePreguntas;
        private ComboBox NmdeIntentos;
        private Button btnIniciarJuego;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Panel PanelControl;
        private Button bntSalir;
    }
}

