namespace VoiceTrafficLight
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.ybtnBas = new VoiceTrafficLight.YuvarlakButon();
            this.ybtnSure = new VoiceTrafficLight.YuvarlakButon();
            this.ybtnGreen = new VoiceTrafficLight.YuvarlakButon();
            this.ybtnYellow = new VoiceTrafficLight.YuvarlakButon();
            this.ybtnRed = new VoiceTrafficLight.YuvarlakButon();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(506, 187);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // ybtnBas
            // 
            this.ybtnBas.BackColor = System.Drawing.Color.Silver;
            this.ybtnBas.FlatAppearance.BorderSize = 0;
            this.ybtnBas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ybtnBas.Location = new System.Drawing.Point(180, 262);
            this.ybtnBas.Name = "ybtnBas";
            this.ybtnBas.Size = new System.Drawing.Size(100, 100);
            this.ybtnBas.TabIndex = 4;
            this.ybtnBas.Text = "X";
            this.ybtnBas.UseVisualStyleBackColor = false;
            this.ybtnBas.Click += new System.EventHandler(this.ybtnBas_Click);
            // 
            // ybtnSure
            // 
            this.ybtnSure.BackColor = System.Drawing.Color.Silver;
            this.ybtnSure.FlatAppearance.BorderSize = 0;
            this.ybtnSure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ybtnSure.Location = new System.Drawing.Point(180, 25);
            this.ybtnSure.Name = "ybtnSure";
            this.ybtnSure.Size = new System.Drawing.Size(100, 100);
            this.ybtnSure.TabIndex = 3;
            this.ybtnSure.Text = "0";
            this.ybtnSure.UseVisualStyleBackColor = false;
            // 
            // ybtnGreen
            // 
            this.ybtnGreen.BackColor = System.Drawing.Color.Silver;
            this.ybtnGreen.FlatAppearance.BorderSize = 0;
            this.ybtnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ybtnGreen.Location = new System.Drawing.Point(64, 262);
            this.ybtnGreen.Name = "ybtnGreen";
            this.ybtnGreen.Size = new System.Drawing.Size(100, 100);
            this.ybtnGreen.TabIndex = 2;
            this.ybtnGreen.UseVisualStyleBackColor = false;
            // 
            // ybtnYellow
            // 
            this.ybtnYellow.BackColor = System.Drawing.Color.Silver;
            this.ybtnYellow.FlatAppearance.BorderSize = 0;
            this.ybtnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ybtnYellow.Location = new System.Drawing.Point(64, 140);
            this.ybtnYellow.Name = "ybtnYellow";
            this.ybtnYellow.Size = new System.Drawing.Size(100, 100);
            this.ybtnYellow.TabIndex = 1;
            this.ybtnYellow.UseVisualStyleBackColor = false;
            // 
            // ybtnRed
            // 
            this.ybtnRed.BackColor = System.Drawing.Color.Silver;
            this.ybtnRed.FlatAppearance.BorderSize = 0;
            this.ybtnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ybtnRed.Location = new System.Drawing.Point(64, 25);
            this.ybtnRed.Name = "ybtnRed";
            this.ybtnRed.Size = new System.Drawing.Size(100, 100);
            this.ybtnRed.TabIndex = 0;
            this.ybtnRed.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.ybtnBas);
            this.Controls.Add(this.ybtnSure);
            this.Controls.Add(this.ybtnGreen);
            this.Controls.Add(this.ybtnYellow);
            this.Controls.Add(this.ybtnRed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private YuvarlakButon ybtnRed;
        private YuvarlakButon ybtnYellow;
        private YuvarlakButon ybtnGreen;
        private YuvarlakButon ybtnSure;
        private YuvarlakButon ybtnBas;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
    }
}

