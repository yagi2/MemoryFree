using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MemoryFree;

namespace PID
{
    public partial class ProcessID : Form
    {
        public ProcessID()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
