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
using System.IO;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using MemoryFree;

namespace trayset
{
    public partial class TrayControl : Form
    {
        // mciSendStrings()を使うための参照
        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer,
          int bufferSize, IntPtr hwndCallback);

        private System.Diagnostics.PerformanceCounter MemF = null;

        public TrayControl()
        {
            InitializeComponent();

            // どうせトレイ全部ここから操作するならあけるだけtrueにしておく。（不便と感じたら両方trueにする）
            TrayCloseButton.Enabled = false;;
            TrayOpenButton.Enabled = true;
        }

        // あけるボタンをクリックされた時の動作
        private void TrayOpenButton_Click(object sender, EventArgs e)
        {
            // トレイをオープン
            mciSendString("Set CDaudio Door Open", null, 0, IntPtr.Zero);

            // 時間を開けてクリック可否を交換(5秒たってからクリック可能）
            TrayOpenButton.Enabled = false;
            System.Threading.Thread.Sleep(5000);
            TrayCloseButton.Enabled = true;
            
        }

        // しめるボタンをクリックされた時の動作
        private void TrayCloseButton_Click(object sender, EventArgs e)
        {
            // トレイをクローズ
            mciSendString("Set CDaudio Door Closed", null, 0, IntPtr.Zero);

            // 時間を開けてクリック可否を交換(5秒たってからクリック可能）
            TrayCloseButton.Enabled = false;
            System.Threading.Thread.Sleep(5000);
            TrayOpenButton.Enabled = true;
        }
    }
}
