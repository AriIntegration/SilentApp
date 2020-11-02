namespace SilentApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.rtbConfigFile = new System.Windows.Forms.RichTextBox();
            this.lblConfigFile = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.rtbAppConfig = new System.Windows.Forms.RichTextBox();
            this.lblAppConfig = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // rtbConfigFile
            // 
            this.rtbConfigFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbConfigFile.Location = new System.Drawing.Point(12, 29);
            this.rtbConfigFile.Name = "rtbConfigFile";
            this.rtbConfigFile.ReadOnly = true;
            this.rtbConfigFile.Size = new System.Drawing.Size(560, 150);
            this.rtbConfigFile.TabIndex = 0;
            this.rtbConfigFile.Text = "";
            // 
            // lblConfigFile
            // 
            this.lblConfigFile.AutoSize = true;
            this.lblConfigFile.Location = new System.Drawing.Point(12, 13);
            this.lblConfigFile.Name = "lblConfigFile";
            this.lblConfigFile.Size = new System.Drawing.Size(109, 13);
            this.lblConfigFile.TabIndex = 1;
            this.lblConfigFile.Text = "c:\\folder\\path\\file.cfg";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(12, 364);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(78, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version 1.2.3.4";
            // 
            // rtbAppConfig
            // 
            this.rtbAppConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAppConfig.Location = new System.Drawing.Point(12, 198);
            this.rtbAppConfig.Name = "rtbAppConfig";
            this.rtbAppConfig.ReadOnly = true;
            this.rtbAppConfig.Size = new System.Drawing.Size(560, 150);
            this.rtbAppConfig.TabIndex = 3;
            this.rtbAppConfig.Text = "";
            // 
            // lblAppConfig
            // 
            this.lblAppConfig.AutoSize = true;
            this.lblAppConfig.Location = new System.Drawing.Point(12, 182);
            this.lblAppConfig.Name = "lblAppConfig";
            this.lblAppConfig.Size = new System.Drawing.Size(109, 13);
            this.lblAppConfig.TabIndex = 4;
            this.lblAppConfig.Text = "c:\\folder\\path\\file.cfg";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 386);
            this.Controls.Add(this.lblAppConfig);
            this.Controls.Add(this.rtbAppConfig);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblConfigFile);
            this.Controls.Add(this.rtbConfigFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 425);
            this.Name = "frmMain";
            this.ShowInTaskbar = false;
            this.Text = "SilentApp";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RichTextBox rtbConfigFile;
        private System.Windows.Forms.Label lblConfigFile;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.RichTextBox rtbAppConfig;
        private System.Windows.Forms.Label lblAppConfig;
    }
}

