using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveFileFunction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void SaveFile(string windowFilter, string windowTitle, string defaultFileName, string targetFileName)
        {
            SaveFileDialog saveFileDialogFunction = new SaveFileDialog();
            saveFileDialogFunction.Filter = windowFilter;
            saveFileDialogFunction.Title = windowTitle;
            saveFileDialogFunction.FileName = defaultFileName;
            if(saveFileDialogFunction.ShowDialog() == DialogResult.OK)
            {




            }




        }
    }
}
