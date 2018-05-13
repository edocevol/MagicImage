using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using MetroFramework.Forms;

namespace MagicImage
{
    public partial class Settings : MetroForm
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
      
        private void Settings_Load(object sender, EventArgs e)
        {

            try
            {
                string ppath = System.Environment.CurrentDirectory;//获取当前应用程序的路径             
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(ppath+"\\config.xml");

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
                            //xe2.InnerText = appid.Text.Trim();//则修改        
                            appid.Text = xn2.InnerText;
                        }
                        else if (xn2.Name == "SECRET_ID")
                        {
                            //xn2.InnerText = secretid.Text.Trim();//则修改
                            secretid.Text = xn2.InnerText;
                        }
                        else if (xn2.Name == "SECRET_KEY")
                        {
                            //xn2.InnerText = secretkey.Text.Trim();//则修改
                            secretkey.Text = xn2.InnerText;
                        }
                        else if (xn2.Name == "BUCKET_NAME")
                        {
                            //xn2.InnerText = bucketname.Text.Trim();//则修改 
                            bucketname.Text = xn2.InnerText;
                        }
                        else if (xn2.Name == "URL_REGEX")
                        {
                            //xn2.InnerText = bucketname.Text.Trim();//则修改 
                            urlRegex.Text = xn2.InnerText;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("好像没有找到配置文件");
            }

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (appid.Text.Trim() == "" || secretid.Text.Trim() == "" || secretkey.Text.Trim() == "" || bucketname.Text.Trim() == "")
            {
                MessageBox.Show("请检查配置");
                return;
            }

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("config.xml");

            //获取system节点的所有子节点
            XmlNodeList nodeList = xmlDoc.SelectSingleNode("system").ChildNodes;

            //遍历所有子节点
            foreach (XmlNode xn in nodeList)
            {
                XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型


                XmlNodeList nls = xe.ChildNodes;//继续获取xe子节点的所有子节点
                foreach (XmlNode xn1 in nls)//遍历
                {
                    XmlElement xe2 = (XmlElement)xn1;//转换类型                       
                    if (xe2.Name == "APP_ID")//如果找到
                    {
                        xe2.InnerText = appid.Text.Trim();//则修改                      
                    }
                    else if (xe2.Name == "SECRET_ID")
                    {
                        xe2.InnerText = secretid.Text.Trim();//则修改   
                    }
                    else if (xe2.Name == "SECRET_KEY")
                    {
                        xe2.InnerText = secretkey.Text.Trim();//则修改   
                    }
                    else if (xe2.Name == "BUCKET_NAME")
                    {
                        xe2.InnerText = bucketname.Text.Trim();//则修改   
                    }
                    else if (xe2.Name == "URL_REGEX")
                    {
                        xe2.InnerText = urlRegex.Text.Trim();//则修改   
                    }
                }

            }
            MessageBox.Show("配置已经修改，请关闭");
            xmlDoc.Save("config.xml");//保存。  
        }
    }
}
