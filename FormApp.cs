using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace HotKeyAutomation
{
    public class HotKeyForm : Form
    {
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(
            IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(
            IntPtr hWnd, int id);

        const int WM_HOTKEY = 0x0312;
        const int MOD_NONE = 0x0000;

        public static Action F9Pressed;
        public bool F9Registered = false;

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            F9Registered = RegisterHotKey(
                this.Handle,
                1,
                MOD_NONE,
                (uint)Keys.F9);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_HOTKEY)
            {
                int hotkeyID = m.WParam.ToInt32();

                if (hotkeyID == 1 && F9Pressed != null)
                    F9Pressed();
            }

            base.WndProc(ref m);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (F9Registered)
                UnregisterHotKey(this.Handle, 1);

            base.OnFormClosed(e);
        }
    }

    static class Program
    {
        private static bool _isRunning = false;

        static void ExecuteAutomation()
        {
            if (_isRunning)
                return;

            try
            {
                _isRunning = true;

                // Press Tab 4 times
                for (int i = 1; i <= 4; i++)
                {
                    SendKeys.SendWait("{TAB}");
                    System.Threading.Thread.Sleep(20);
                }

                // Press Down Arrow
                SendKeys.SendWait("{DOWN}");
                System.Threading.Thread.Sleep(20);

                // Press Tab
                SendKeys.SendWait("{TAB}");
                System.Threading.Thread.Sleep(20);

                // Press Space
                SendKeys.SendWait(" ");
                System.Threading.Thread.Sleep(20);

                // Press Tab
                SendKeys.SendWait("{TAB}");
                System.Threading.Thread.Sleep(20);

                // Press Down Arrow 3 times
                for (int i = 1; i <= 3; i++)
                {
                    SendKeys.SendWait("{DOWN}");
                    System.Threading.Thread.Sleep(20);
                }
            }
            catch
            {
                // Silent error handling
            }
            finally
            {
                _isRunning = false;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new HotKeyForm
            {
                WindowState = FormWindowState.Minimized,
                ShowInTaskbar = false
            };

            form.Show();

            if (!form.F9Registered)
            {
                Console.WriteLine("Hotkey registration FAILED.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("F9 Hotkey registered successfully!");
            Console.WriteLine("Press F9 to execute automation sequence");
            Console.WriteLine("Press Ctrl+C or close this window to exit");

            var timer = new Timer();
            timer.Interval = 20;

            HotKeyForm.F9Pressed = () =>
            {
                if (!timer.Enabled)
                {
                    timer.Start();
                }
            };

            timer.Tick += (sender, e) =>
            {
                timer.Stop();
                ExecuteAutomation();
            };

            Application.Run(form);
        }
    }
}