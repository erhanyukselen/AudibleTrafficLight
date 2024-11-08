using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoiceTrafficLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sure, devir;

        private void ybtnBas_Click(object sender, EventArgs e)
        {
            timer1.Start();
            axWindowsMediaPlayer1.URL = "C:\\Users\\Erhan\\Downloads\\ses1.mp3";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure = sure - 1;
            ybtnSure.Text = sure.ToString();
            if (devir==0)
            {
                if (sure==1)
                {
                    ybtnRed.BackColor = Color.Gray;
                    ybtnGreen.BackColor = Color.Gray;
                    ybtnYellow.BackColor = Color.Yellow;
                }
                if (sure==0)
                {
                    axWindowsMediaPlayer1.URL = "C:\\Users\\Erhan\\Desktop\\ses2.mp3";
                    ybtnYellow.BackColor = Color.Gray;
                    ybtnRed.BackColor= Color.Gray;
                    ybtnGreen.BackColor= Color.Green;
                    devir = 1;
                    sure = 10;
                }
            }
            if (devir==1)
            {
                if (sure==1)
                {
                    ybtnGreen.BackColor = Color.Gray;
                    ybtnRed.BackColor = Color.Gray;
                    ybtnYellow.BackColor= Color.Yellow;
                }
                if (sure==0)
                {
                    ybtnRed.BackColor = Color.Red;
                    ybtnGreen.BackColor = Color.Gray;
                    ybtnYellow.BackColor = Color.Gray;
                    timer1.Stop();
                    devir = 0;
                    sure = 10;
                    ybtnSure.Text = "10";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Visible = false;
            timer1.Stop();
            ybtnRed.BackColor = Color.Red;
            ybtnYellow.BackColor = Color.Gray;
            ybtnGreen.BackColor = Color.Gray;
            ybtnSure.Text = "10";
            sure = 10;


        }
    }
}
