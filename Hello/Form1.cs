using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    public partial class Form1 : Form
    {
        int time = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello C#!!", "はじめまして");
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time--;
            if (time == 0)
            {
                timer1.Enabled = false;
                labelRemaining.Text = "0秒";
                MessageBox.Show("時間です！！", "タイムアップ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                labelRemaining.Text = time.ToString() + "秒";

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxTime.Text == "")
            {
                MessageBox.Show("時間が指定されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                time = int.Parse(textBoxTime.Text);
                labelRemaining.Text = textBoxTime.Text + "秒";
                timer1.Interval = 1000;
                timer1.Enabled = true;

            }
        }
    }
}
