using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using BuildSoft.VRChat.Osc.Avatar;
using BuildSoft.VRChat.Osc.Chatbox;
using System.Threading;
using System.Net;
using System.Reflection;
using System.IO;
using BuildSoft.VRChat.Osc.Input;

namespace vrchatOSC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel2.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            OscChatbox.SendMessage("PieOSC Loaded", direct: true);
            try
            {
                this.BackgroundImage = Image.FromFile("bg.png");
                this.Refresh();
            }
            catch (Exception)
            {
                try
                {
                    this.BackgroundImage = Image.FromFile("bg.jpg");
                    this.Refresh();
                }
                catch (Exception)
                {

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pie#0565");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://discord.gg/MSHCS8u7eJ");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.TopMost = true;
            }
            else
            if (checkBox1.Checked == false)
            {
                this.TopMost = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            panel2.Show();
            richTextBox1.Hide();
            button11.Hide();
            button12.Hide();
            checkBox6.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel5.Show();
            richTextBox1.Show();
            button11.Show();
            button12.Show();
            checkBox6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Pie#0565");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("steam://rungameid/438100");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("VRChat"))
            {
                process.Kill();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OscChatbox.SendMessage("PieOSC Loaded", direct: true);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 0.5 Public");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not added yet");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                timer1.Start();
            }
            else
            if (checkBox2.Checked == false)
            {
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            OscChatbox.SendMessage("PieOSC Loaded", direct: true);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                timer2.Start();
            }
            else
            if (checkBox3.Checked == false)
            {
                timer2.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string time = now.ToString("H:mm");
            OscChatbox.SendMessage("PieOSC: Time = " + "*" + time + "* ", direct: true);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                timer3.Start();
            }
            else
            if (checkBox4.Checked == false)
            {
                timer3.Stop();
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = TimeSpan.FromMilliseconds(Environment.TickCount);

            OscChatbox.SendMessage("PieOSC: System UpTime =                     " + ts.Days + "D: " + ts.Hours+ "H: " + ts.Minutes+ "M:", direct: true);
        }
        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                timer4.Start();
            }
            else
            if (checkBox5.Checked == false)
            {
                timer4.Stop();
            }
        }
        

        public PerformanceCounter theMemCounter =
   new PerformanceCounter("Memory", "Available MBytes");

        public PerformanceCounter CPU =
               new PerformanceCounter("Processor", "% Processor Time", "_Total");

        private void timer4_Tick(object sender, EventArgs e)
        {
            dynamic sc = CPU.NextValue();
            OscChatbox.SendMessage("PieOSC: System Usage  " + "          CPU: " + (int)sc + "%    " + "Free RAM: " + this.theMemCounter.NextValue() + " MB", direct: true); ; ;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string rtext = richTextBox1.Text;
            OscChatbox.SendMessage(rtext, direct: true);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                timer5.Start();
            }
            else
            if (checkBox6.Checked == false)
            {
                timer5.Stop();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            string rtext = richTextBox1.Text;
            OscChatbox.SendMessage(rtext, direct: true);

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                timer7.Start();
            }
            else
            if (checkBox7.Checked == false)
            {
                timer7.Stop();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            var procs = Process.GetProcessesByName("vrchat");
            foreach (var proc in procs)
            {
                TimeSpan runtime;
                try
                {
                    runtime = DateTime.Now - proc.StartTime;
                }
                catch (Win32Exception ex)
                {
                    if (ex.NativeErrorCode == 5)
                        continue;
                    throw;
                }
                OscChatbox.SendMessage("PieOSC: VRChat timer = " + runtime , direct: true);

            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {

        }
    }
}
