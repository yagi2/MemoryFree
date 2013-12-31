using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MemoryFree;

namespace emerge
{
    public partial class TaskName : Form
    {
        public TaskName()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
