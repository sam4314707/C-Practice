
namespace CSharpLearning
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelheight = new System.Windows.Forms.Label();
            this.labelweight = new System.Windows.Forms.Label();
            this.labelAns = new System.Windows.Forms.Label();
            this.buttoncal = new System.Windows.Forms.Button();
            this.textBoxheight = new System.Windows.Forms.TextBox();
            this.textBoxweight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelheight
            // 
            this.labelheight.AutoSize = true;
            this.labelheight.Location = new System.Drawing.Point(99, 37);
            this.labelheight.Name = "labelheight";
            this.labelheight.Size = new System.Drawing.Size(29, 12);
            this.labelheight.TabIndex = 0;
            this.labelheight.Text = "身高";
            // 
            // labelweight
            // 
            this.labelweight.AutoSize = true;
            this.labelweight.Location = new System.Drawing.Point(99, 73);
            this.labelweight.Name = "labelweight";
            this.labelweight.Size = new System.Drawing.Size(29, 12);
            this.labelweight.TabIndex = 1;
            this.labelweight.Text = "體重";
            // 
            // labelAns
            // 
            this.labelAns.AutoSize = true;
            this.labelAns.Location = new System.Drawing.Point(99, 145);
            this.labelAns.Name = "labelAns";
            this.labelAns.Size = new System.Drawing.Size(33, 12);
            this.labelAns.TabIndex = 2;
            this.labelAns.Text = "label3";
            this.labelAns.Visible = false;
            // 
            // buttoncal
            // 
            this.buttoncal.Location = new System.Drawing.Point(362, 63);
            this.buttoncal.Name = "buttoncal";
            this.buttoncal.Size = new System.Drawing.Size(75, 23);
            this.buttoncal.TabIndex = 3;
            this.buttoncal.Text = "計算";
            this.buttoncal.UseVisualStyleBackColor = true;
            this.buttoncal.Click += new System.EventHandler(this.buttoncal_Click);
            // 
            // textBoxheight
            // 
            this.textBoxheight.Location = new System.Drawing.Point(170, 26);
            this.textBoxheight.Name = "textBoxheight";
            this.textBoxheight.Size = new System.Drawing.Size(100, 22);
            this.textBoxheight.TabIndex = 4;
            // 
            // textBoxweight
            // 
            this.textBoxweight.Location = new System.Drawing.Point(170, 63);
            this.textBoxweight.Name = "textBoxweight";
            this.textBoxweight.Size = new System.Drawing.Size(100, 22);
            this.textBoxweight.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxweight);
            this.Controls.Add(this.textBoxheight);
            this.Controls.Add(this.buttoncal);
            this.Controls.Add(this.labelAns);
            this.Controls.Add(this.labelweight);
            this.Controls.Add(this.labelheight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelheight;
        private System.Windows.Forms.Label labelweight;
        private System.Windows.Forms.Label labelAns;
        private System.Windows.Forms.Button buttoncal;
        private System.Windows.Forms.TextBox textBoxheight;
        private System.Windows.Forms.TextBox textBoxweight;
    }
}

