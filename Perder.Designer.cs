namespace J1
{
    partial class Perder
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
            panel1 = new Panel();
            lblTitulo2 = new Label();
            lblTitulo1 = new Label();
            btnSalir = new Button();
            btnReintentar = new Button();
            lblTitulo = new Label();
            MediaPerdedor = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MediaPerdedor).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(MediaPerdedor);
            panel1.Controls.Add(lblTitulo2);
            panel1.Controls.Add(lblTitulo1);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnReintentar);
            panel1.Controls.Add(lblTitulo);
            panel1.Location = new Point(220, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 312);
            panel1.TabIndex = 0;
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.Font = new Font("Consolas", 12F, FontStyle.Bold);
            lblTitulo2.ForeColor = Color.DeepSkyBlue;
            lblTitulo2.Location = new Point(30, 80);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(63, 19);
            lblTitulo2.TabIndex = 7;
            lblTitulo2.Text = "label1";
            lblTitulo2.Click += lblTitulo2_Click;
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Consolas", 14F, FontStyle.Bold);
            lblTitulo1.ForeColor = Color.Fuchsia;
            lblTitulo1.Location = new Point(30, 30);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(70, 22);
            lblTitulo1.TabIndex = 8;
            lblTitulo1.Text = "label1";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Black;
            btnSalir.FlatAppearance.BorderColor = Color.Crimson;
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.Crimson;
            btnSalir.Location = new Point(190, 160);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 40);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReintentar
            // 
            btnReintentar.BackColor = Color.Black;
            btnReintentar.FlatAppearance.BorderColor = Color.Lime;
            btnReintentar.FlatAppearance.BorderSize = 2;
            btnReintentar.FlatStyle = FlatStyle.Flat;
            btnReintentar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReintentar.ForeColor = Color.Lime;
            btnReintentar.Location = new Point(30, 160);
            btnReintentar.Name = "btnReintentar";
            btnReintentar.Size = new Size(130, 40);
            btnReintentar.TabIndex = 10;
            btnReintentar.Text = "REINTENTAR";
            btnReintentar.UseVisualStyleBackColor = false;
            btnReintentar.Click += btnReintentar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 12F, FontStyle.Italic);
            lblTitulo.ForeColor = Color.Orange;
            lblTitulo.Location = new Point(146, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(0, 19);
            lblTitulo.TabIndex = 11;
            // 
            // MediaPerdedor
            // 
            MediaPerdedor.Location = new Point(106, 206);
            MediaPerdedor.Name = "MediaPerdedor";
            MediaPerdedor.Size = new Size(127, 101);
            MediaPerdedor.TabIndex = 1;
            MediaPerdedor.TabStop = false;
            MediaPerdedor.Click += MediaPerdedor_Click;
            // 
            // Perder
            // 
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Perder";
            Text = "Has Perdido - CyberModo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MediaPerdedor).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private Button btnReintentar;
        private Label lblTitulo;
        private Button btnSalir;
        private Label lblTitulo2;
        private Label lblTitulo1;
        private PictureBox MediaPerdedor;
    }
}