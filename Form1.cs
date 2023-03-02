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
            WebClient webclientupdate = new WebClient();
            WebClient WebClient = new WebClient();
            if (!webclientupdate.DownloadString("https://pastebin.com/raw/UTMfD7SA").Contains("0.4"))

                if (MessageBox.Show("New Upate\nyou want to download it?", "New update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    WebClient auto = new WebClient();

                    string file = WebClient.DownloadString("https://pastebin.com/raw/qqtDsLAt");
                    WebClient.DownloadFile(file, "PieOSC.zip");
                    Application.Exit();
                    string batchCommands = string.Empty;
                    string exeFileName = Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", string.Empty).Replace("/", "\\");

                    batchCommands += "@ECHO OFF\n";
                    batchCommands += "title Updating do not close or touch!!!\n";
                    batchCommands += "timeout /T 3 /NOBREAK > nul\n";
                    batchCommands += "echo j | del /F ";
                    batchCommands += exeFileName + "\n";
                    batchCommands += "tar -xf PieOSC.zip > nul\n";
                    batchCommands += "del PieOSC.zip > nul\n";
                    batchCommands += "echo j | del updater.bat > nul\n";

                    File.WriteAllText("updater.bat", batchCommands);

                    Process.Start("updater.bat");

                }
                else
                {
                    Application.Exit();
                }
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
            OscChatbox.SendMessage("PieOSC: System UpTime = " + "*"  + "* ", direct: true);
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

        private void timer4_Tick(object sender, EventArgs e)
        {
            
            OscChatbox.SendMessage("PieOSC: System Usage = " + "CPU ", direct: true);
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
    }
}
