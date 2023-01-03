using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeZoneInfoDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById("Taipei Standard Time");





            //該時間區域ID   

            textBox1.AppendText(timeZone.Id + "\r\n");

            //區域名稱  

            textBox1.AppendText(timeZone.StandardName + "\r\n");

            //與世界標準時間差  

            //textBox1.AppendText(timeZone.BaseUtcOffset.ToString() + "\r\n");

            textBox1.AppendText(DateTime.Now.ToString() + "\r\n");
            //該時間區域時間           

            DateTime UTCDateTime = DateTime.Now.AddHours(-timeZone.BaseUtcOffset.Hours);

            textBox1.AppendText("世界標準時間\r\n" + UTCDateTime.ToString() + "\r\n");




        }
    }
}
