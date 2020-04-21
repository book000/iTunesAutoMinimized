using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTunesAutoMinimized
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Visible = false;
            ShowInTaskbar = false;
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Opacity = 0.0;
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("User32.Dll")]
        public static extern long ShowWindow(
          IntPtr hWnd,    // 送信先ウィンドウのハンドル
          uint nCmdShow       // メッセージ
        );

        private void timer_iTunesMinimize_Tick(object sender, EventArgs e)
        {
            bool closed = false;

            Process[] ps = Process.GetProcessesByName("iTunes");
            for (int i = 0; i < ps.Length; i++)
            {
                Process p = ps[i];
                try
                {
                    IntPtr mainHandle = p.MainWindowHandle;
                    ShowWindow(p.MainWindowHandle, 2);
                }
                catch
                {
                }
                finally
                {
                    p.Dispose();
                    p = null;
                }
                closed = true;
            }
            if (closed)
            {
                timer_iTunesMinimize.Stop();
                timer_MainClose.Stop();
                Application.Exit();
            }
        }

        private void timer_MainClose_Tick(object sender, EventArgs e)
        {
            timer_iTunesMinimize.Stop();
            timer_MainClose.Stop();
            Application.Exit();
        }
    }
}
