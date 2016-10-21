using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using QCloud.PicApi.Api;
using QCloud.PicApi.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace MagicImage
{
    public partial class Form1 : CCWin.Skin_Mac
    {
        public int APP_ID = 111;
        public string SECRET_ID = "SECRET_ID";
        public string SECRET_KEY = "SECRET_KEY";
        public string BUCKET_NAME = "bucketName";
        public Form1()
        {
            InitializeComponent();
            string ppath = System.Environment.CurrentDirectory;//获取当前应用程序的路径 
            string sPath = ppath + "/upload";
            if (!Directory.Exists(sPath))
            {
                Directory.CreateDirectory(sPath);
            }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("你拖拽的是图片不？");
            }
        }

        //依照比例加载图片
        public void loadImg(string filePath)
        {
                      //MessageBox.Show(filePath);
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
            try
            {
                var result = "";
                //var bucketName = "bucketName";
                var pic = new PicCloud(APP_ID, SECRET_ID, SECRET_KEY);

                var start = DateTime.Now.ToUnixTime();
                result = pic.Upload(BUCKET_NAME, filepath);
                var end = DateTime.Now.ToUnixTime();
                Console.WriteLine(result);
                var obj = (JObject)JsonConvert.DeserializeObject(result);
                var code = (int)obj["code"];
                if (code == 0)
                {
                    var data = obj["data"];
                    var fileId = data["fileid"].ToString();
                    var downloadUrl = data["download_url"].ToString();

                    Clipboard.SetDataObject("![请说明图片]("+downloadUrl+")");
                    Console.WriteLine("总用时：" + (end - start) + "毫秒");
                    toolStripStatusLabel1.Text = "总用时：" + (end - start) + "毫秒";
                    toolStripStatusLabel1.Text = "文件已经上传成功";
                }
                else
                {               
                    MessageBox.Show("发现一点小问题，图像上传失败了。。。。");
                    toolStripStatusLabel1.Text = "文件上传失败";
                }         
            }
            catch (Exception ex)
            {
                MessageBox.Show("发现一点小问题，图像上传失败了。。。。");
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
                MessageBox.Show("好像没有找到配置文件");
            }
        }

        //上传拖拽的图片
        private void skinButton2_Click(object sender, EventArgs e)
        {
            loadConfig();
            try
            {
                IDataObject iData = Clipboard.GetDataObject();
                Image img = null;
                if (iData.GetDataPresent(DataFormats.Bitmap))
                {
                    img = (Bitmap)iData.GetData(DataFormats.Bitmap);
                    string ppath = System.Environment.CurrentDirectory;//获取当前应用程序的路径 
                    var uuidN = Guid.NewGuid().ToString("N"); // e0a953c3ee6040eaa9fae2b667060e09 
                    string imgPath = ppath + "//upload//" + uuidN + ".png";
                    img.Save(imgPath);
                    loadImg(imgPath);         
                    uploadImage(imgPath);
                }
                else
                {
                    MessageBox.Show("系统剪贴板中没有图片");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("图片上传失败");
            }
        }

        private void 使用说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //调用系统默认的浏览器   
            System.Diagnostics.Process.Start("http://git.oschina.net/jsper/MagicImage");
        }

        private void 意见反馈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://git.oschina.net/jsper/MagicImage/issues");    
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://git.oschina.net/jsper/MagicImage");
        }
    }
}
