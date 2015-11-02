using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using SearchApplication;
using EncrypterUtils;
using System.IO;

namespace KeywordForm
{
    public partial class ActivateForm : CCSkinMain
    {
        private Form1 parent;
        public ActivateForm(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void activateBtn_Click(object sender, EventArgs e)
        {
            //校验mail
            if (this.mailInput.Text == null || this.mailInput.Text.Trim().Length == 0)
            {
                MyMessageBoxEx.show("Please enter your License mail and Serial number.");
                return;
            }

            //校验Serial Number
            if (this.numberInput.Text == null || this.numberInput.Text.Trim().Length == 0)
            {
                MyMessageBoxEx.show("Please enter your License mail and Serial number.");
                return;
            }
            //验证激活码
            bool result = Encrypter.ValidateSerialNumber(this.numberInput.Text.Trim());
            if (result)
            {
                //激活成功 写文件
                writeSerialNumberToFile(this.numberInput.Text.Trim(), this.mailInput.Text.Trim());
                this.parent.updateActivateStatus(true);
                MyMessageBoxEx.show("Activate successfully!");
                this.Close();
            }
            else
            {
                //激活失败
                MyMessageBoxEx.show("Invalid serial number, please try again or contact the Viavert support team.");
            }
        }

        private void writeSerialNumberToFile(string serialNumber, string mail)
        {
            try
            {
                //获取安装目录
                String installDir = Application.StartupPath;
                string dataFile = installDir + "\\data.bin";
                if (File.Exists(dataFile))
                {
                    File.Delete(dataFile);
                }
                //写入key文件
                FileStream fs = new FileStream(dataFile, FileMode.Append);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.WriteLine(serialNumber);
                sw.WriteLine(mail);
                sw.Flush();
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
        }

        private void buyNow_Click(object sender, EventArgs e)
        {
            //调用系统默认的浏览
            try
            {
                System.Diagnostics.Process.Start("https://order.shareit.com/product?vendorid=200252623&productid=300696975");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Process.Start("IEXPLORE.EXE", "https://order.shareit.com/product?vendorid=200252623&productid=300696975");
            }
            
        }

        private void ActivateForm_Load(object sender, EventArgs e)
        {
            this.AcceptButton = this.activateBtn;
        }

    }
}
