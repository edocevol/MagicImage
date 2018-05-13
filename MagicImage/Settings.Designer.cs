using MetroFramework.Controls;
using System.Windows.Forms;

namespace MagicImage
{
    partial class Settings
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
            this.skinLabel1 = new MetroFramework.Controls.MetroLabel();
            this.skinLabel2 = new MetroFramework.Controls.MetroLabel();
            this.skinLabel3 = new MetroFramework.Controls.MetroLabel();
            this.skinLabel4 = new MetroFramework.Controls.MetroLabel();
            this.appid = new MetroFramework.Controls.MetroTextBox();
            this.secretid = new MetroFramework.Controls.MetroTextBox();
            this.secretkey = new MetroFramework.Controls.MetroTextBox();
            this.bucketname = new MetroFramework.Controls.MetroTextBox();
            this.skinButton1 = new MetroFramework.Controls.MetroButton();
            this.skinButton2 = new MetroFramework.Controls.MetroButton();
            this.skinLabel5 = new MetroFramework.Controls.MetroLabel();
            this.urlRegex = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.ForeColor = System.Drawing.Color.Green;
            this.skinLabel1.Location = new System.Drawing.Point(146, 126);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(52, 19);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "APP_ID";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.ForeColor = System.Drawing.Color.Green;
            this.skinLabel2.Location = new System.Drawing.Point(126, 194);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(72, 19);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "SECRET_ID";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.ForeColor = System.Drawing.Color.Green;
            this.skinLabel3.Location = new System.Drawing.Point(116, 262);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(82, 19);
            this.skinLabel3.TabIndex = 0;
            this.skinLabel3.Text = "SECRET_KEY";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.ForeColor = System.Drawing.Color.Green;
            this.skinLabel4.Location = new System.Drawing.Point(98, 330);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(100, 19);
            this.skinLabel4.TabIndex = 0;
            this.skinLabel4.Text = "BUCKET_NAME";
            // 
            // appid
            // 
            // 
            // 
            // 
            this.appid.CustomButton.Image = null;
            this.appid.CustomButton.Location = new System.Drawing.Point(279, 2);
            this.appid.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appid.CustomButton.Name = "";
            this.appid.CustomButton.Size = new System.Drawing.Size(24, 28);
            this.appid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.appid.CustomButton.TabIndex = 1;
            this.appid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.appid.CustomButton.UseSelectable = true;
            this.appid.CustomButton.Visible = false;
            this.appid.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.appid.Lines = new string[0];
            this.appid.Location = new System.Drawing.Point(213, 115);
            this.appid.Margin = new System.Windows.Forms.Padding(0);
            this.appid.MaxLength = 32767;
            this.appid.MinimumSize = new System.Drawing.Size(33, 40);
            this.appid.Name = "appid";
            this.appid.PasswordChar = '\0';
            this.appid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.appid.SelectedText = "";
            this.appid.SelectionLength = 0;
            this.appid.SelectionStart = 0;
            this.appid.ShortcutsEnabled = true;
            this.appid.Size = new System.Drawing.Size(437, 40);
            this.appid.TabIndex = 1;
            this.appid.UseSelectable = true;
            this.appid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.appid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // secretid
            // 
            // 
            // 
            // 
            this.secretid.CustomButton.Image = null;
            this.secretid.CustomButton.Location = new System.Drawing.Point(279, 2);
            this.secretid.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secretid.CustomButton.Name = "";
            this.secretid.CustomButton.Size = new System.Drawing.Size(24, 28);
            this.secretid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.secretid.CustomButton.TabIndex = 1;
            this.secretid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.secretid.CustomButton.UseSelectable = true;
            this.secretid.CustomButton.Visible = false;
            this.secretid.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.secretid.Lines = new string[0];
            this.secretid.Location = new System.Drawing.Point(213, 183);
            this.secretid.Margin = new System.Windows.Forms.Padding(0);
            this.secretid.MaxLength = 32767;
            this.secretid.MinimumSize = new System.Drawing.Size(33, 40);
            this.secretid.Name = "secretid";
            this.secretid.PasswordChar = '\0';
            this.secretid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.secretid.SelectedText = "";
            this.secretid.SelectionLength = 0;
            this.secretid.SelectionStart = 0;
            this.secretid.ShortcutsEnabled = true;
            this.secretid.Size = new System.Drawing.Size(437, 40);
            this.secretid.TabIndex = 1;
            this.secretid.UseSelectable = true;
            this.secretid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.secretid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // secretkey
            // 
            // 
            // 
            // 
            this.secretkey.CustomButton.Image = null;
            this.secretkey.CustomButton.Location = new System.Drawing.Point(279, 2);
            this.secretkey.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secretkey.CustomButton.Name = "";
            this.secretkey.CustomButton.Size = new System.Drawing.Size(24, 28);
            this.secretkey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.secretkey.CustomButton.TabIndex = 1;
            this.secretkey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.secretkey.CustomButton.UseSelectable = true;
            this.secretkey.CustomButton.Visible = false;
            this.secretkey.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.secretkey.Lines = new string[0];
            this.secretkey.Location = new System.Drawing.Point(213, 251);
            this.secretkey.Margin = new System.Windows.Forms.Padding(0);
            this.secretkey.MaxLength = 32767;
            this.secretkey.MinimumSize = new System.Drawing.Size(33, 40);
            this.secretkey.Name = "secretkey";
            this.secretkey.PasswordChar = '\0';
            this.secretkey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.secretkey.SelectedText = "";
            this.secretkey.SelectionLength = 0;
            this.secretkey.SelectionStart = 0;
            this.secretkey.ShortcutsEnabled = true;
            this.secretkey.Size = new System.Drawing.Size(437, 40);
            this.secretkey.TabIndex = 1;
            this.secretkey.UseSelectable = true;
            this.secretkey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.secretkey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bucketname
            // 
            // 
            // 
            // 
            this.bucketname.CustomButton.Image = null;
            this.bucketname.CustomButton.Location = new System.Drawing.Point(279, 2);
            this.bucketname.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bucketname.CustomButton.Name = "";
            this.bucketname.CustomButton.Size = new System.Drawing.Size(24, 28);
            this.bucketname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bucketname.CustomButton.TabIndex = 1;
            this.bucketname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bucketname.CustomButton.UseSelectable = true;
            this.bucketname.CustomButton.Visible = false;
            this.bucketname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.bucketname.Lines = new string[0];
            this.bucketname.Location = new System.Drawing.Point(213, 319);
            this.bucketname.Margin = new System.Windows.Forms.Padding(0);
            this.bucketname.MaxLength = 32767;
            this.bucketname.MinimumSize = new System.Drawing.Size(33, 40);
            this.bucketname.Name = "bucketname";
            this.bucketname.PasswordChar = '\0';
            this.bucketname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bucketname.SelectedText = "";
            this.bucketname.SelectionLength = 0;
            this.bucketname.SelectionStart = 0;
            this.bucketname.ShortcutsEnabled = true;
            this.bucketname.Size = new System.Drawing.Size(437, 40);
            this.bucketname.TabIndex = 1;
            this.bucketname.UseSelectable = true;
            this.bucketname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bucketname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.Location = new System.Drawing.Point(169, 483);
            this.skinButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.Size = new System.Drawing.Size(143, 51);
            this.skinButton1.Style = MetroFramework.MetroColorStyle.Pink;
            this.skinButton1.TabIndex = 2;
            this.skinButton1.Text = "修改";
            this.skinButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.skinButton1.UseSelectable = true;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.Location = new System.Drawing.Point(393, 483);
            this.skinButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.Size = new System.Drawing.Size(143, 51);
            this.skinButton2.Style = MetroFramework.MetroColorStyle.Pink;
            this.skinButton2.TabIndex = 2;
            this.skinButton2.Text = "关闭";
            this.skinButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.skinButton2.UseSelectable = true;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.ForeColor = System.Drawing.Color.Green;
            this.skinLabel5.Location = new System.Drawing.Point(105, 400);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(93, 19);
            this.skinLabel5.TabIndex = 3;
            this.skinLabel5.Text = "图片地址规则";
            // 
            // urlRegex
            // 
            // 
            // 
            // 
            this.urlRegex.CustomButton.Image = null;
            this.urlRegex.CustomButton.Location = new System.Drawing.Point(279, 2);
            this.urlRegex.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.urlRegex.CustomButton.Name = "";
            this.urlRegex.CustomButton.Size = new System.Drawing.Size(24, 28);
            this.urlRegex.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.urlRegex.CustomButton.TabIndex = 1;
            this.urlRegex.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.urlRegex.CustomButton.UseSelectable = true;
            this.urlRegex.CustomButton.Visible = false;
            this.urlRegex.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.urlRegex.Lines = new string[0];
            this.urlRegex.Location = new System.Drawing.Point(213, 389);
            this.urlRegex.Margin = new System.Windows.Forms.Padding(0);
            this.urlRegex.MaxLength = 32767;
            this.urlRegex.MinimumSize = new System.Drawing.Size(33, 40);
            this.urlRegex.Name = "urlRegex";
            this.urlRegex.PasswordChar = '\0';
            this.urlRegex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.urlRegex.SelectedText = "";
            this.urlRegex.SelectionLength = 0;
            this.urlRegex.SelectionStart = 0;
            this.urlRegex.ShortcutsEnabled = true;
            this.urlRegex.Size = new System.Drawing.Size(437, 40);
            this.urlRegex.TabIndex = 2;
            this.urlRegex.UseSelectable = true;
            this.urlRegex.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.urlRegex.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 605);
            this.Controls.Add(this.urlRegex);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.bucketname);
            this.Controls.Add(this.secretkey);
            this.Controls.Add(this.secretid);
            this.Controls.Add(this.appid);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(23, 85, 23, 28);
            this.Text = "万象优图配置";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroLabel skinLabel1;
        private MetroLabel skinLabel2;
        private MetroLabel skinLabel3;
        private MetroLabel skinLabel4;
        private MetroTextBox appid;
        private MetroTextBox secretid;
        private MetroTextBox secretkey;
        private MetroTextBox bucketname;
        private MetroButton skinButton1;
        private MetroButton skinButton2;
        private MetroLabel skinLabel5;
        private MetroTextBox urlRegex;
    }
}