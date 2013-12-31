using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

using PID;
using emerge;

namespace MemoryFree
{    
    public partial class MainForm : Form
    {
        private System.Diagnostics.PerformanceCounter MemF = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MemF = new System.Diagnostics.PerformanceCounter();
            MemF.CategoryName = "Memory";
            MemF.CounterName = "Available MBytes";
            MemF.NextValue();

            if (MemF != null)
            {
                textBox2.Text = "物理空きびふぉー\r\n" + MemF.NextValue() + " MB";
            }

            string program = @"C:\Windows\System32\empty.exe";
            string argument = @"*";

            Process extProcess = new Process();

            extProcess.StartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec");
            extProcess.StartInfo.CreateNoWindow = true;
            extProcess.StartInfo.UseShellExecute = false;
            extProcess.StartInfo.RedirectStandardInput = false;
            extProcess.StartInfo.RedirectStandardOutput = true;
            extProcess.StartInfo.FileName = program;
            extProcess.StartInfo.Arguments = argument;

            extProcess.Start();
            
            string output = extProcess.StandardOutput.ReadToEnd();
            extProcess.WaitForExit();
            textBox1.Text = output;

            MemF = new System.Diagnostics.PerformanceCounter();
            MemF.CategoryName = "Memory";
            MemF.CounterName = "Available MBytes";
            MemF.NextValue();

            if (MemF != null)
            {
                textBox3.Text = "物理空きあふたー\r\n" + MemF.NextValue() + " MB";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessID frmProcessID = new ProcessID();

            frmProcessID.ShowDialog();

            string pid = Convert.ToString(frmProcessID.textBox1.Text);

            MemF = new System.Diagnostics.PerformanceCounter();
            MemF.CategoryName = "Memory";
            MemF.CounterName = "Available MBytes";
            MemF.NextValue();

            if (MemF != null)
            {
                textBox2.Text = "物理空きびふぉー\r\n" + MemF.NextValue() + " MB";
            }

            string program = @"C:\Windows\System32\empty.exe";
            string argument = @pid;

            Process extProcess = new Process();

            extProcess.StartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec");
            extProcess.StartInfo.CreateNoWindow = true;
            extProcess.StartInfo.UseShellExecute = false;
            extProcess.StartInfo.RedirectStandardInput = false;
            extProcess.StartInfo.RedirectStandardOutput = true;
            extProcess.StartInfo.FileName = program;
            extProcess.StartInfo.Arguments = argument;

            extProcess.Start();

            string output = extProcess.StandardOutput.ReadToEnd();
            extProcess.WaitForExit();
            textBox1.Text = output;

            MemF = new System.Diagnostics.PerformanceCounter();
            MemF.CategoryName = "Memory";
            MemF.CounterName = "Available MBytes";
            MemF.NextValue();

            if (MemF != null)
            {
                textBox3.Text = "物理空きあふたー\r\n" + MemF.NextValue() + " MB";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TaskName frmTaskName = new TaskName();

            frmTaskName.ShowDialog();

            string emerge = Convert.ToString(frmTaskName.textBox1.Text);

            MemF = new System.Diagnostics.PerformanceCounter();
            MemF.CategoryName = "Memory";
            MemF.CounterName = "Available MBytes";
            MemF.NextValue();

            if (MemF != null)
            {
                textBox2.Text = "物理空きびふぉー\r\n" + MemF.NextValue() + " MB";
            }

            string program = @"C:\Windows\System32\empty.exe";
            string argument = @emerge;

            Process extProcess = new Process();

            extProcess.StartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec");
            extProcess.StartInfo.CreateNoWindow = true;
            extProcess.StartInfo.UseShellExecute = false;
            extProcess.StartInfo.RedirectStandardInput = false;
            extProcess.StartInfo.RedirectStandardOutput = true;
            extProcess.StartInfo.FileName = program;
            extProcess.StartInfo.Arguments = argument;

            extProcess.Start();

            string output = extProcess.StandardOutput.ReadToEnd();
            extProcess.WaitForExit();
            textBox1.Text = output;

            MemF = new System.Diagnostics.PerformanceCounter();
            MemF.CategoryName = "Memory";
            MemF.CounterName = "Available MBytes";
            MemF.NextValue();

            if (MemF != null)
            {
                textBox3.Text = "物理空きあふたー\r\n" + MemF.NextValue() + " MB";
            }
        }
    }
}
