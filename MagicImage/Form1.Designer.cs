using System.Windows.Forms;

namespace MagicImage
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.skinMenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.获取签名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.使用说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.意见反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.关闭通知ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadImg = new System.Windows.Forms.PictureBox();
            this.home = new System.Windows.Forms.ToolStripMenuItem();
            this.listen = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.skinMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uploadImg)).BeginInit();
            this.SuspendLayout();
            // 
            // skinMenuStrip1
            // 
            this.skinMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置ToolStripMenuItem,
            this.获取签名ToolStripMenuItem,
            this.使用说明ToolStripMenuItem,
            this.意见反馈ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.skinMenuStrip1.Location = new System.Drawing.Point(20, 60);
            this.skinMenuStrip1.Name = "skinMenuStrip1";
            this.skinMenuStrip1.Size = new System.Drawing.Size(778, 25);
            this.skinMenuStrip1.TabIndex = 0;
            this.skinMenuStrip1.Text = "skinMenuStrip1";
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.配置ToolStripMenuItem.Text = "配置";
            this.配置ToolStripMenuItem.Click += new System.EventHandler(this.配置ToolStripMenuItem_Click);
            // 
            // 获取签名ToolStripMenuItem
            // 
            this.获取签名ToolStripMenuItem.Name = "获取签名ToolStripMenuItem";
            this.获取签名ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.获取签名ToolStripMenuItem.Text = "获取签名";
            this.获取签名ToolStripMenuItem.Click += new System.EventHandler(this.获取签名ToolStripMenuItem_Click);
            // 
            // 使用说明ToolStripMenuItem
            // 
            this.使用说明ToolStripMenuItem.Name = "使用说明ToolStripMenuItem";
            this.使用说明ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.使用说明ToolStripMenuItem.Text = "使用说明";
            this.使用说明ToolStripMenuItem.Click += new System.EventHandler(this.使用说明ToolStripMenuItem_Click);
            // 
            // 意见反馈ToolStripMenuItem
            // 
            this.意见反馈ToolStripMenuItem.Name = "意见反馈ToolStripMenuItem";
            this.意见反馈ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.意见反馈ToolStripMenuItem.Text = "意见反馈";
            this.意见反馈ToolStripMenuItem.Click += new System.EventHandler(this.意见反馈ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(20, 493);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(778, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(32, 17);
            this.toolStripStatusLabel1.Text = "tips:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "图床工具";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.home,
            this.listen,
            this.关闭通知ToolStripMenuItem,
            this.exit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 92);
            // 
            // 关闭通知ToolStripMenuItem
            // 
            this.关闭通知ToolStripMenuItem.Image = global::MagicImage.Properties.Resources.jingyin;
            this.关闭通知ToolStripMenuItem.Name = "关闭通知ToolStripMenuItem";
            this.关闭通知ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.关闭通知ToolStripMenuItem.Text = "关闭通知";
            this.关闭通知ToolStripMenuItem.Click += new System.EventHandler(this.关闭通知ToolStripMenuItem_Click);
            // 
            // uploadImg
            // 
            this.uploadImg.BackColor = System.Drawing.Color.Transparent;
            this.uploadImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uploadImg.Location = new System.Drawing.Point(20, 85);
            this.uploadImg.Name = "uploadImg";
            this.uploadImg.Size = new System.Drawing.Size(778, 430);
            this.uploadImg.TabIndex = 1;
            this.uploadImg.TabStop = false;
            // 
            // home
            // 
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(136, 22);
            this.home.Text = "打开主界面";
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // listen
            // 
            this.listen.Image = global::MagicImage.Properties.Resources.unlisten;
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(136, 22);
            this.listen.Text = "取消监听";
            this.listen.Click += new System.EventHandler(this.listen_Click);
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(136, 22);
            this.exit.Text = "退出";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 535);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.uploadImg);
            this.Controls.Add(this.skinMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.skinMenuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.99D;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "腾讯云图床工具";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.skinMenuStrip1.ResumeLayout(false);
            this.skinMenuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uploadImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip skinMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 使用说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 意见反馈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 获取签名ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem home;
        private System.Windows.Forms.ToolStripMenuItem listen;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.PictureBox uploadImg;
        private ToolStripMenuItem 关闭通知ToolStripMenuItem;
    }
}

