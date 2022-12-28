
namespace Calculater
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
            this.textBoxn1 = new System.Windows.Forms.TextBox();
            this.textBoxn2 = new System.Windows.Forms.TextBox();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.MultipBtn = new System.Windows.Forms.Button();
            this.DivideBtn = new System.Windows.Forms.Button();
            this.labelAns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(65, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter two number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.Location = new System.Drawing.Point(65, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.Location = new System.Drawing.Point(65, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number2";
            // 
            // textBoxn1
            // 
            this.textBoxn1.Font = new System.Drawing.Font("新細明體", 20F);
            this.textBoxn1.Location = new System.Drawing.Point(223, 74);
            this.textBoxn1.Name = "textBoxn1";
            this.textBoxn1.Size = new System.Drawing.Size(100, 39);
            this.textBoxn1.TabIndex = 3;
            // 
            // textBoxn2
            // 
            this.textBoxn2.Font = new System.Drawing.Font("新細明體", 20F);
            this.textBoxn2.Location = new System.Drawing.Point(223, 123);
            this.textBoxn2.Name = "textBoxn2";
            this.textBoxn2.Size = new System.Drawing.Size(100, 39);
            this.textBoxn2.TabIndex = 4;
            // 
            // PlusBtn
            // 
            this.PlusBtn.AutoSize = true;
            this.PlusBtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.PlusBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PlusBtn.Location = new System.Drawing.Point(70, 193);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(101, 37);
            this.PlusBtn.TabIndex = 5;
            this.PlusBtn.Text = "Plus";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.AutoSize = true;
            this.MinusBtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.MinusBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MinusBtn.Location = new System.Drawing.Point(196, 193);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(101, 37);
            this.MinusBtn.TabIndex = 6;
            this.MinusBtn.Text = "Minus";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // MultipBtn
            // 
            this.MultipBtn.AutoSize = true;
            this.MultipBtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.MultipBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MultipBtn.Location = new System.Drawing.Point(321, 193);
            this.MultipBtn.Name = "MultipBtn";
            this.MultipBtn.Size = new System.Drawing.Size(112, 37);
            this.MultipBtn.TabIndex = 7;
            this.MultipBtn.Text = "Multip";
            this.MultipBtn.UseVisualStyleBackColor = true;
            this.MultipBtn.Click += new System.EventHandler(this.MultipBtn_Click);
            // 
            // DivideBtn
            // 
            this.DivideBtn.AutoSize = true;
            this.DivideBtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.DivideBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DivideBtn.Location = new System.Drawing.Point(459, 193);
            this.DivideBtn.Name = "DivideBtn";
            this.DivideBtn.Size = new System.Drawing.Size(101, 37);
            this.DivideBtn.TabIndex = 8;
            this.DivideBtn.Text = "Divide";
            this.DivideBtn.UseVisualStyleBackColor = true;
            this.DivideBtn.Click += new System.EventHandler(this.DivideBtn_Click);
            // 
            // labelAns
            // 
            this.labelAns.AutoSize = true;
            this.labelAns.Font = new System.Drawing.Font("新細明體", 20F);
            this.labelAns.Location = new System.Drawing.Point(65, 291);
            this.labelAns.Name = "labelAns";
            this.labelAns.Size = new System.Drawing.Size(60, 27);
            this.labelAns.TabIndex = 9;
            this.labelAns.Text = "Ans:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAns);
            this.Controls.Add(this.DivideBtn);
            this.Controls.Add(this.MultipBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.textBoxn2);
            this.Controls.Add(this.textBoxn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxn1;
        private System.Windows.Forms.TextBox textBoxn2;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button MultipBtn;
        private System.Windows.Forms.Button DivideBtn;
        private System.Windows.Forms.Label labelAns;
    }
}

