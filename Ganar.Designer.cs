namespace J1
{
    partial class Ganar
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            MediaGanador = new PictureBox();
            btnCerrar = new Button();
            lblResultado = new Label();
            lblFelicitaciones = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MediaGanador).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(lblResultado);
            panel1.Controls.Add(lblFelicitaciones);
            panel1.Controls.Add(MediaGanador);
            panel1.Location = new Point(121, 62);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 203);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // MediaGanador
            // 
            MediaGanador.Location = new Point(-20, -18);
            MediaGanador.Name = "MediaGanador";
            MediaGanador.Size = new Size(503, 251);
            MediaGanador.TabIndex = 4;
            MediaGanador.TabStop = false;
            MediaGanador.Click += MediaGanador_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Magenta;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Consolas", 10F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.Black;
            btnCerrar.Location = new Point(177, 155);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(88, 30);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblResultado.ForeColor = Color.Cyan;
            lblResultado.Location = new Point(84, 74);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(135, 19);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Resultado aquí";
            lblResultado.Click += lblResultado_Click;
            // 
            // lblFelicitaciones
            // 
            lblFelicitaciones.AutoSize = true;
            lblFelicitaciones.Font = new Font("Consolas", 16F, FontStyle.Bold);
            lblFelicitaciones.ForeColor = Color.Cyan;
            lblFelicitaciones.Location = new Point(84, 22);
            lblFelicitaciones.Name = "lblFelicitaciones";
            lblFelicitaciones.Size = new Size(168, 26);
            lblFelicitaciones.TabIndex = 0;
            lblFelicitaciones.Text = "¡Felicidades!";
            lblFelicitaciones.TextAlign = ContentAlignment.MiddleCenter;
            lblFelicitaciones.Click += lblFelicitaciones_Click;
            // 
            // Ganar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(700, 338);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Ganar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Victoria";
            Load += Ganar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MediaGanador).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblFelicitaciones;
        private System.Windows.Forms.Button btnCerrar;
        private PictureBox MediaGanador;
    }
}
