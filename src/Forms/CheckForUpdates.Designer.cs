﻿namespace Nikse.SubtitleEdit.Forms
{
    partial class CheckForUpdates
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxChangeLog = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonDownloadAndInstall = new System.Windows.Forms.Button();
            this.timerCheckForUpdates = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(12, 22);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(41, 13);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "label1";
            // 
            // textBoxChangeLog
            // 
            this.textBoxChangeLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxChangeLog.Location = new System.Drawing.Point(13, 38);
            this.textBoxChangeLog.Multiline = true;
            this.textBoxChangeLog.Name = "textBoxChangeLog";
            this.textBoxChangeLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxChangeLog.Size = new System.Drawing.Size(618, 46);
            this.textBoxChangeLog.TabIndex = 1;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCancel.Location = new System.Drawing.Point(556, 90);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 21);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "C&ancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonDownloadAndInstall
            // 
            this.buttonDownloadAndInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadAndInstall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonDownloadAndInstall.Location = new System.Drawing.Point(390, 90);
            this.buttonDownloadAndInstall.Name = "buttonDownloadAndInstall";
            this.buttonDownloadAndInstall.Size = new System.Drawing.Size(160, 21);
            this.buttonDownloadAndInstall.TabIndex = 4;
            this.buttonDownloadAndInstall.Text = "&OK";
            this.buttonDownloadAndInstall.UseVisualStyleBackColor = true;
            // 
            // timerCheckForUpdates
            // 
            this.timerCheckForUpdates.Tick += new System.EventHandler(this.timerCheckForUpdates_Tick);
            // 
            // CheckForUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 123);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonDownloadAndInstall);
            this.Controls.Add(this.textBoxChangeLog);
            this.Controls.Add(this.labelStatus);
            this.KeyPreview = true;
            this.Name = "CheckForUpdates";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CheckForUpdates";
            this.Shown += new System.EventHandler(this.CheckForUpdates_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckForUpdates_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxChangeLog;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonDownloadAndInstall;
        private System.Windows.Forms.Timer timerCheckForUpdates;
    }
}