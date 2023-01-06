using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder str1, str2, str3, str4, str5;
            str1 = new StringBuilder("ID,Et%o3,st,oC,Gm yr,Dy e s,tWe;r*dBa y;.Q");
            str2 = new StringBuilder(" wSe,n t1,ds c$h,o oFlf,ww,rRi t e@,3hoo mme,w#oer.k ");
            str3 = new StringBuilder();
            str4 = new StringBuilder();
            str5 = new StringBuilder();
            for (int i = 0; i < str1.Length; i += 2)
            {
                str3.Append(str1[i]);
            }
            for (int i = 1; i < str2.Length; i += 2)
            {
                str4.Append(str2[i]);
            }


            String[] stra = str3.ToString().Split(',');
            String[] strb = str4.ToString().Split(',');

            foreach (var s in stra)
                textBox1.AppendText(s+" ");
            textBox1.AppendText("\r\n");
            foreach (var s in strb)
                textBox1.AppendText(s+" ");
            textBox1.AppendText("\r\n");
            
            for(int i = 0; i < stra.Length; i++)
            {
                str5.Append(stra[i] + " ");
                if(i<strb.Length)
                    str5.Append(strb[i] + " ");
              
                
            }
            
            
            textBox1.AppendText(str3.ToString() + "\r\n");
            textBox1.AppendText(str4.ToString() + "\r\n");
            textBox1.AppendText(str5.ToString());
        }
    }
}
