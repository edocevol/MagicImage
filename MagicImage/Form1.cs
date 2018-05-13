using MetroFramework;
using MetroFramework.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QCloud.CosApi.Api;
using QCloud.CosApi.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace MagicImage
{
    public partial class Form1 : MetroForm
    {
        public int APP_ID = 111;
        public string SECRET_ID = "SECRET_ID";
        public string SECRET_KEY = "SECRET_KEY";
        public string BUCKET_NAME = "bucketName";
        public string URL_REGEX = "![请输入图片描述](url)";
        public Image imagessss = null;
        //Constants for API Calls...  
        private const int WM_DRAWCLIPBOARD = 0x308;
        private const int WM_CHANGECBCHAIN = 0x30D;

        //Handle for next clipboard viewer...  
        private IntPtr mNextClipBoardViewerHWnd;

        //API declarations...  
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static public extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static public extern bool ChangeClipboardChain(IntPtr HWnd, IntPtr HWndNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        IntPtr nextClipboardViewer;
        private bool keepListen = true;
        private bool keepNotification = true;
        public Form1()
        {
            InitializeComponent();
            string ppath = System.Environment.CurrentDirectory;//获取当前应用程序的路径 
            string sPath = ppath + "/upload";
            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }
            imagessss = this.uploadImg.Image;
            nextClipboardViewer = (IntPtr)SetClipboardViewer(this.Handle);
        }



        private void 配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                //定义一个string用于存储路径名
                string filePath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
                loadImg(filePath);
                uploadImage(filePath);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "你拖拽的是图片不？");
            }
        }

        //依照比例加载图片
        public void loadImg(string filePath)
        {

            this.uploadImg.Image = imagessss;
            Bitmap bmPic = new Bitmap(filePath);
            Point ptLoction = new Point(bmPic.Size);
            if (ptLoction.X > uploadImg.Size.Width || ptLoction.Y > uploadImg.Size.Height)
            {
                //图像框的停靠方式  
                //pcbPic.Dock = DockStyle.Fill;  
                //图像充滿图像框，並且图像維持比例  
                uploadImg.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                //图像在图像框置中  
                uploadImg.SizeMode = PictureBoxSizeMode.CenterImage;
            }

            //LoadAsync：非同步转入图像  
            uploadImg.LoadAsync(filePath);
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            loadConfig();
            string filepath = uploadImg.ImageLocation;
            uploadImage(filepath);
        }

        /**
         * 
         * @param filepath 图片路径        
         */
        public void uploadImage(string filepath)
        {
            loadConfig();
            try
            {
                var result = "";
                //var bucketName = "bucketName";
                var cos = new CosCloud(APP_ID, SECRET_ID, SECRET_KEY);

                var start = DateTime.Now.ToUniversalTime();

                string remotePath = Path.GetFileName(filepath);
                //上传文件（不论文件是否分片，均使用本接口）
                var uploadParasDic = new Dictionary<string, string>();
                uploadParasDic.Add(CosParameters.PARA_BIZ_ATTR, "");
                uploadParasDic.Add(CosParameters.PARA_INSERT_ONLY, "0");
                //uploadParasDic.Add(CosParameters.PARA_SLICE_SIZE,SLICE_SIZE.SLIZE_SIZE_3M.ToString());
                result = cos.UploadFile(BUCKET_NAME, remotePath, filepath, uploadParasDic);
                Console.WriteLine("上传文件:" + result);


                var end = DateTime.Now.ToUniversalTime();
                Console.WriteLine(result);
                var obj = (JObject)JsonConvert.DeserializeObject(result);
                var code = (int)obj["code"];
                if (code == 0)
                {
                    var data = obj["data"];
                    var downloadUrl = data["source_url"].ToString();
                    Clipboard.SetDataObject(URL_REGEX.Replace("url", downloadUrl).Replace("http:", "https:"));
                    Console.WriteLine("总用时：" + (end - start) + "毫秒");
                    toolStripStatusLabel1.Text = "总用时：" + (end - start) + "毫秒";
                    toolStripStatusLabel1.Text = "文件已经上传成功";
                    if(keepNotification)
                    {
                        notifyIcon1.ShowBalloonTip(2000, "图床工具提示", "图片上传成功", ToolTipIcon.Info);
                    }
                   
                }
                else
                {
                    MetroMessageBox.Show(this, "发现一点小问题，图像上传失败了。。。。");
                    toolStripStatusLabel1.Text = "文件上传失败";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "发现一点小问题，图像上传失败了。。。。");
                toolStripStatusLabel1.Text = "文件上传失败";
            }
        }

        //加载万象优图的配置文件
        public void loadConfig()
        {
            try
            {
                string ppath = System.Environment.CurrentDirectory;//获取当前应用程序的路径             
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(ppath + "\\config.xml");

                XmlNode xn = xmlDoc.SelectSingleNode("system");

                XmlNodeList xnl = xn.ChildNodes;

                foreach (XmlNode xnf in xnl)
                {
                    XmlElement xe = (XmlElement)xnf;

                    XmlNodeList xnf1 = xe.ChildNodes;
                    foreach (XmlNode xn2 in xnf1)
                    {
                        if (xn2.Name == "APP_ID")//如果找到
                        {
                            APP_ID = Convert.ToInt32(xn2.InnerText);
                        }
                        else if (xn2.Name == "SECRET_ID")
                        {
                            SECRET_ID = xn2.InnerText;
                        }
                        else if (xn2.Name == "SECRET_KEY")
                        {
                            SECRET_KEY = xn2.InnerText;
                        }
                        else if (xn2.Name == "BUCKET_NAME")
                        {
                            BUCKET_NAME = xn2.InnerText;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "好像没有找到配置文件");
            }
        }

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //调用系统默认的浏览器   
            System.Diagnostics.Process.Start("https://github.com/sixtrees/MagicImage");
        }

        private void 意见反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/sixtrees/MagicImage/issues/");
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/sixtrees/MagicImage/releases/");
        }

        private void 获取签名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gd = Sign.Signature(APP_ID, SECRET_ID, SECRET_KEY, 12 * 24 * 3600 * 1000, BUCKET_NAME);
            toolStripStatusLabel1.Text = "获取签名成功";
        }

        #region Message Process  
        //Override WndProc to get messages...  
        protected override void WndProc(ref Message m)
        {
            if (!keepListen) return;
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    {
                        SendMessage(mNextClipBoardViewerHWnd, m.Msg, m.WParam.ToInt32(), m.LParam.ToInt32());
                        //显示剪贴板中的图片信息  
                        if (Clipboard.ContainsImage())
                        {
                            IDataObject iData = Clipboard.GetDataObject();
                            Image img = (Bitmap)iData.GetData(DataFormats.Bitmap);
                            string ppath = System.Environment.CurrentDirectory;//获取当前应用程序的路径 
                            var uuidN = Guid.NewGuid().ToString("N"); // e0a953c3ee6040eaa9fae2b667060e09 
                            string imgPath = ppath + "//upload//" + uuidN + ".png";
                            img.Save(imgPath);
                            loadImg(imgPath);
                            uploadImage(imgPath);
                            uploadImg.Update();
                        }
                        break;
                    }
                case WM_CHANGECBCHAIN:
                    {
                        //Another clipboard viewer has removed itself...  
                        if (m.WParam == (IntPtr)mNextClipBoardViewerHWnd)
                        {
                            mNextClipBoardViewerHWnd = m.LParam;
                        }
                        else
                        {
                            SendMessage(mNextClipBoardViewerHWnd, m.Msg, m.WParam.ToInt32(), m.LParam.ToInt32());
                        }
                        break;
                    }
            }
            base.WndProc(ref m);
        }
        #endregion

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            try
            {

                //显示剪贴板中的图片信息  
                if (Clipboard.ContainsImage())
                {
                    IDataObject iData = Clipboard.GetDataObject();
                    Image img = (Bitmap)iData.GetData(DataFormats.Bitmap);
                    string ppath = System.Environment.CurrentDirectory;//获取当前应用程序的路径 
                    var uuidN = Guid.NewGuid().ToString("N"); // e0a953c3ee6040eaa9fae2b667060e09 
                    string imgPath = ppath + "//upload//" + uuidN + ".png";
                    img.Save(imgPath);
                    loadImg(imgPath);
                    uploadImage(imgPath);
                    uploadImg.Update();
                    //uploadImg.Image = Clipboard.GetImage();
                    //uploadImg.Update();
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "图片上传失败");
            }
        }

        private void home_Click(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                this.Hide();
                this.contextMenuStrip1.Items[0].Text = "显示主界面";
            }
            else
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.contextMenuStrip1.Items[0].Text = "隐藏主界面";
            }
        }

        private void listen_Click(object sender, EventArgs e)
        {
            if (!keepListen)
            {
                keepListen = true;
                this.contextMenuStrip1.Items[1].Text = "取消监听粘贴板";
                this.contextMenuStrip1.Items[1].Image = global::MagicImage.Properties.Resources.unlisten;
            }
            else
            {
                keepListen = false;
                this.contextMenuStrip1.Items[1].Text = "监听粘贴板";
                this.contextMenuStrip1.Items[1].Image = global::MagicImage.Properties.Resources.listen;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 关闭通知ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (!keepNotification)
            {
                keepNotification = true;
                this.contextMenuStrip1.Items[2].Text = "取消系统通知";
                this.contextMenuStrip1.Items[2].Image = global::MagicImage.Properties.Resources.jingyin;
            }
            else
            {
                keepNotification = false;
                this.contextMenuStrip1.Items[2].Text = "开启系统通知";
                this.contextMenuStrip1.Items[2].Image = global::MagicImage.Properties.Resources.shengyin;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.contextMenuStrip1.Items[0].Text = "显示主界面";
            }
        }

    }
}
