using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SilentApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (!CheckAppConfig())
            {
                Application.Exit();
            }
            else
            {
                try
                {
                    this.Text = BL.Globals.AppName;
                    timer.Interval = BL.Globals.Timer;
                    timer.Enabled = true;

                    lblConfigFile.Text = System.IO.Directory.GetCurrentDirectory().ToString() + "\\" + BL.Globals.FileName;
                    rtbConfigFile.Text = "CMD file contents:" + Environment.NewLine + Environment.NewLine + File.ReadAllText(lblConfigFile.Text);
                    lblAppConfig.Text = System.IO.Directory.GetCurrentDirectory().ToString() + "\\SilentApp.exe.config";
                    rtbAppConfig.Text = "App.config file contents:" + Environment.NewLine + Environment.NewLine + File.ReadAllText(lblAppConfig.Text);
                    lblVersion.Text = "SilentApp Version: " + Application.ProductVersion.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool CheckAppConfig()
        {
            bool AppConfigGoodToGo = true;

            if (BL.Globals.Timer < 5000)
            {
                AppConfigGoodToGo = false;
                MessageBox.Show("Timer must be set to greater than 5000 milliseconds (5 seconds).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (BL.Globals.AppName == String.Empty)
            {
                AppConfigGoodToGo = false;
                MessageBox.Show("Application name is not defined in config file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (BL.Globals.FileName == String.Empty)
            {
                AppConfigGoodToGo = false;
                MessageBox.Show("Filename is not defined in config file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!File.Exists(BL.Globals.FileName))
            {
                AppConfigGoodToGo = false;
                MessageBox.Show(BL.Globals.FileName + " does not exisit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return AppConfigGoodToGo;
        }

        private void TimerProcess()
        {
            Process proc;

            try
            {
                string Dir = System.IO.Directory.GetCurrentDirectory();
                proc = new Process();
                proc.StartInfo.WorkingDirectory = Dir;
                proc.StartInfo.FileName = BL.Globals.FileName;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
                proc.WaitForExit();
                proc.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimerProcess();
        }
    }
}
