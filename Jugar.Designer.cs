namespace J1
{
    partial class Jugar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblPregunta = new Label();
            btnOpcion1 = new Button();
            btnOpcion2 = new Button();
            btnOpcion3 = new Button();
            btnOpcion4 = new Button();
            lblJugador = new Label();
            btnSalir = new Button();
            lblCategoria = new Label();
            lblIntentos = new Label();
            PanelDJugador = new Panel();
            lblErrores = new Label();
            PanelPreguntas = new Panel();
            progressBarTiempo = new ProgressBar();
            PnPreguntas = new Panel();
            timerPregunta = new System.Windows.Forms.Timer(components);
            TimerAnimacion = new System.Windows.Forms.Timer(components);
            PanelDJugador.SuspendLayout();
            PanelPreguntas.SuspendLayout();
            PnPreguntas.SuspendLayout();
            SuspendLayout();
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.BackColor = Color.Transparent;
            lblPregunta.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPregunta.ForeColor = Color.Cyan;
            lblPregunta.Location = new Point(-1, 17);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(81, 19);
            lblPregunta.TabIndex = 0;
            lblPregunta.Text = "Pregunta";
            // 
            // btnOpcion1
            // 
            btnOpcion1.BackColor = Color.Black;
            btnOpcion1.FlatAppearance.BorderColor = Color.Magenta;
            btnOpcion1.FlatAppearance.BorderSize = 2;
            btnOpcion1.FlatStyle = FlatStyle.Flat;
            btnOpcion1.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpcion1.ForeColor = Color.Magenta;
            btnOpcion1.Location = new Point(19, 69);
            btnOpcion1.Name = "btnOpcion1";
            btnOpcion1.Size = new Size(150, 40);
            btnOpcion1.TabIndex = 1;
            btnOpcion1.Text = "Opción 1";
            btnOpcion1.UseVisualStyleBackColor = false;
            btnOpcion1.Click += btnOpcion1_Click;
            // 
            // btnOpcion2
            // 
            btnOpcion2.BackColor = Color.Black;
            btnOpcion2.FlatAppearance.BorderColor = Color.Magenta;
            btnOpcion2.FlatAppearance.BorderSize = 2;
            btnOpcion2.FlatStyle = FlatStyle.Flat;
            btnOpcion2.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpcion2.ForeColor = Color.Magenta;
            btnOpcion2.Location = new Point(280, 69);
            btnOpcion2.Name = "btnOpcion2";
            btnOpcion2.Size = new Size(150, 40);
            btnOpcion2.TabIndex = 2;
            btnOpcion2.Text = "Opción 2";
            btnOpcion2.UseVisualStyleBackColor = false;
            btnOpcion2.Click += btnOpcion2_Click;
            // 
            // btnOpcion3
            // 
            btnOpcion3.BackColor = Color.Black;
            btnOpcion3.FlatAppearance.BorderColor = Color.Magenta;
            btnOpcion3.FlatAppearance.BorderSize = 2;
            btnOpcion3.FlatStyle = FlatStyle.Flat;
            btnOpcion3.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpcion3.ForeColor = Color.Magenta;
            btnOpcion3.Location = new Point(19, 164);
            btnOpcion3.Name = "btnOpcion3";
            btnOpcion3.Size = new Size(150, 40);
            btnOpcion3.TabIndex = 3;
            btnOpcion3.Text = "Opción 3";
            btnOpcion3.UseVisualStyleBackColor = false;
            btnOpcion3.Click += btnOpcion3_Click;
            // 
            // btnOpcion4
            // 
            btnOpcion4.BackColor = Color.Black;
            btnOpcion4.FlatAppearance.BorderColor = Color.Magenta;
            btnOpcion4.FlatAppearance.BorderSize = 2;
            btnOpcion4.FlatStyle = FlatStyle.Flat;
            btnOpcion4.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpcion4.ForeColor = Color.Magenta;
            btnOpcion4.Location = new Point(280, 164);
            btnOpcion4.Name = "btnOpcion4";
            btnOpcion4.Size = new Size(150, 40);
            btnOpcion4.TabIndex = 4;
            btnOpcion4.Text = "Opción 4";
            btnOpcion4.UseVisualStyleBackColor = false;
            btnOpcion4.Click += btnOpcion4_Click;
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJugador.ForeColor = Color.Cyan;
            lblJugador.Location = new Point(34, 20);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(63, 15);
            lblJugador.TabIndex = 5;
            lblJugador.Text = "Jugador:";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Black;
            btnSalir.FlatAppearance.BorderColor = Color.Red;
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Red;
            btnSalir.Location = new Point(196, 260);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 30);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = Color.Cyan;
            lblCategoria.Location = new Point(34, 82);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 15);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoría:";
            // 
            // lblIntentos
            // 
            lblIntentos.AutoSize = true;
            lblIntentos.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIntentos.ForeColor = Color.Cyan;
            lblIntentos.Location = new Point(34, 143);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(70, 15);
            lblIntentos.TabIndex = 8;
            lblIntentos.Text = "Intentos:";
            // 
            // PanelDJugador
            // 
            PanelDJugador.BackColor = Color.FromArgb(20, 20, 40);
            PanelDJugador.BorderStyle = BorderStyle.FixedSingle;
            PanelDJugador.Controls.Add(lblErrores);
            PanelDJugador.Controls.Add(lblJugador);
            PanelDJugador.Controls.Add(lblIntentos);
            PanelDJugador.Controls.Add(lblCategoria);
            PanelDJugador.Location = new Point(12, 12);
            PanelDJugador.Name = "PanelDJugador";
            PanelDJugador.Size = new Size(200, 300);
            PanelDJugador.TabIndex = 9;
            // 
            // lblErrores
            // 
            lblErrores.AutoSize = true;
            lblErrores.Font = new Font("Consolas", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblErrores.ForeColor = Color.Cyan;
            lblErrores.Location = new Point(34, 212);
            lblErrores.Name = "lblErrores";
            lblErrores.Size = new Size(63, 15);
            lblErrores.TabIndex = 9;
            lblErrores.Text = "Errores:";
            // 
            // PanelPreguntas
            // 
            PanelPreguntas.BackColor = Color.FromArgb(10, 10, 20);
            PanelPreguntas.BorderStyle = BorderStyle.FixedSingle;
            PanelPreguntas.Controls.Add(progressBarTiempo);
            PanelPreguntas.Controls.Add(PnPreguntas);
            PanelPreguntas.Location = new Point(218, 12);
            PanelPreguntas.Name = "PanelPreguntas";
            PanelPreguntas.Size = new Size(570, 426);
            PanelPreguntas.TabIndex = 10;
            // 
            // progressBarTiempo
            // 
            progressBarTiempo.BackColor = Color.Black;
            progressBarTiempo.ForeColor = Color.Magenta;
            progressBarTiempo.Location = new Point(80, 20);
            progressBarTiempo.Name = "progressBarTiempo";
            progressBarTiempo.Size = new Size(400, 20);
            progressBarTiempo.Style = ProgressBarStyle.Continuous;
            progressBarTiempo.TabIndex = 11;
            progressBarTiempo.Value = 100;
            // 
            // PnPreguntas
            // 
            PnPreguntas.BackColor = Color.FromArgb(30, 30, 60);
            PnPreguntas.BorderStyle = BorderStyle.FixedSingle;
            PnPreguntas.Controls.Add(btnOpcion1);
            PnPreguntas.Controls.Add(btnOpcion3);
            PnPreguntas.Controls.Add(btnOpcion2);
            PnPreguntas.Controls.Add(btnOpcion4);
            PnPreguntas.Controls.Add(btnSalir);
            PnPreguntas.Controls.Add(lblPregunta);
            PnPreguntas.Location = new Point(60, 60);
            PnPreguntas.Name = "PnPreguntas";
            PnPreguntas.Size = new Size(473, 331);
            PnPreguntas.TabIndex = 16;
            // 
            // timerPregunta
            // 
            timerPregunta.Tick += timerPregunta_Tick;
            // 
            // TimerAnimacion
            // 
            TimerAnimacion.Interval = 30;
            // 
            // Jugar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 5, 15);
            ClientSize = new Size(800, 450);
            Controls.Add(PanelPreguntas);
            Controls.Add(PanelDJugador);
            Name = "Jugar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUIZ CIBERPUNK";
            PanelDJugador.ResumeLayout(false);
            PanelDJugador.PerformLayout();
            PanelPreguntas.ResumeLayout(false);
            PnPreguntas.ResumeLayout(false);
            PnPreguntas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPregunta;
        private Button btnOpcion1;
        private Button btnOpcion2;
        private Button btnOpcion3;
        private Button btnOpcion4;
        private Label lblJugador;
        private Button btnSalir;
        private Label lblCategoria;
        private Label lblIntentos;
        private Panel PanelDJugador;
        private Panel PanelPreguntas;
        private ProgressBar progressBarTiempo;
        private System.Windows.Forms.Timer timerPregunta;
        private Label lblErrores;
        private Panel PnPreguntas;
        private System.Windows.Forms.Timer TimerAnimacion;
    }
}