using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UploadFileFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(sourcePath.Text) && 
                !String.IsNullOrEmpty(sourceFileName.Text) &&
                !String.IsNullOrEmpty(targetPath.Text) &&
                !String.IsNullOrEmpty(targetFileName.Text))
            {
                // 組合檔案來原位置字串
                string sourceFile = Path.Combine(sourcePath.Text, sourceFileName.Text);

                // 組合檔案目的位置字串
                string destFile = Path.Combine(targetPath.Text, targetFileName.Text);

                // 檢查是否有資料夾位置
                if (!Directory.Exists(targetPath.Text))
                {
                    // 若沒有則建立資料夾
                    Directory.CreateDirectory(targetPath.Text);

                }


                // 複製所指定檔案到檔案位置
                File.Copy(sourceFile, destFile, true);
                label6.Text = "傳送成功";
            }
            else
            {
                MessageBox.Show("請將所有TextBox填寫完畢");
                label6.Text = "傳送失敗";
            }
        }
    }
}
