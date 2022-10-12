
namespace SaveFileFunction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.windowFilter = new System.Windows.Forms.TextBox();
            this.windowTitle = new System.Windows.Forms.TextBox();
            this.defaultFileName = new System.Windows.Forms.TextBox();
            this.targetFileName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "限定搜尋附檔名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "視窗標題：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "預設檔名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "目標檔名：";
            // 
            // windowFilter
            // 
            this.windowFilter.Location = new System.Drawing.Point(145, 12);
            this.windowFilter.Name = "windowFilter";
            this.windowFilter.Size = new System.Drawing.Size(100, 22);
            this.windowFilter.TabIndex = 4;
            // 
            // windowTitle
            // 
            this.windowTitle.Location = new System.Drawing.Point(145, 50);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(100, 22);
            this.windowTitle.TabIndex = 5;
            // 
            // defaultFileName
            // 
            this.defaultFileName.Location = new System.Drawing.Point(145, 87);
            this.defaultFileName.Name = "defaultFileName";
            this.defaultFileName.Size = new System.Drawing.Size(100, 22);
            this.defaultFileName.TabIndex = 6;
            // 
            // targetFileName
            // 
            this.targetFileName.Location = new System.Drawing.Point(145, 128);
            this.targetFileName.Name = "targetFileName";
            this.targetFileName.Size = new System.Drawing.Size(100, 22);
            this.targetFileName.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "檔案下載";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.targetFileName);
            this.Controls.Add(this.defaultFileName);
            this.Controls.Add(this.windowTitle);
            this.Controls.Add(this.windowFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "指定檔案給予下載";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox windowFilter;
        private System.Windows.Forms.TextBox windowTitle;
        private System.Windows.Forms.TextBox defaultFileName;
        private System.Windows.Forms.TextBox targetFileName;
        private System.Windows.Forms.Button button1;
    }
}

