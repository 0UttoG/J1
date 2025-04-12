namespace J1
{
    partial class FromInicio
    {
        private System.ComponentModel.IContainer components = null;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button BtnJugar;
        private System.Windows.Forms.Timer GlowTimer;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromInicio));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.BtnJugar = new System.Windows.Forms.Button();
            this.GlowTimer = new System.Windows.Forms.Timer(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();

            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(800, 450);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);

            // 
            // BtnJugar
            // 
            this.BtnJugar.BackColor = System.Drawing.Color.Transparent;
            this.BtnJugar.FlatAppearance.BorderSize = 0;
            this.BtnJugar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(150, 0, 255, 255);
            this.BtnJugar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(100, 255, 0, 255);
            this.BtnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJugar.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnJugar.ForeColor = System.Drawing.Color.Magenta;
            this.BtnJugar.Location = new System.Drawing.Point(300, 200);
            this.BtnJugar.Name = "BtnJugar";
            this.BtnJugar.Size = new System.Drawing.Size(200, 60);
            this.BtnJugar.TabIndex = 1;
            this.BtnJugar.Text = "JUGAR";
            this.BtnJugar.UseVisualStyleBackColor = false;
            this.BtnJugar.Click += new System.EventHandler(this.BtnJugar_Click);

            // 
            // GlowTimer
            // 
            this.GlowTimer.Enabled = true;
            this.GlowTimer.Interval = 600;
            this.GlowTimer.Tick += new System.EventHandler(this.GlowTimer_Tick);

            // 
            // FromInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnJugar);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Name = "FromInicio";
            this.Text = "FromInicio";
            this.Load += new System.EventHandler(this.FromInicio_Load);
         
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

