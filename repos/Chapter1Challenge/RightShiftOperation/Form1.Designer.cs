
namespace RightShiftOperation
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShiftBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(129, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "N1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.Location = new System.Drawing.Point(129, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "N2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.Location = new System.Drawing.Point(129, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ans:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 20F);
            this.textBox1.Location = new System.Drawing.Point(232, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 39);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("新細明體", 20F);
            this.textBox2.Location = new System.Drawing.Point(232, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 39);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20F);
            this.label4.Location = new System.Drawing.Point(367, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(405, 54);
            this.label4.TabIndex = 5;
            this.label4.Text = "N1 will devided by N2 \r\nusing right shift operation and plus 10";
            // 
            // ShiftBtn
            // 
            this.ShiftBtn.AutoSize = true;
            this.ShiftBtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.ShiftBtn.Location = new System.Drawing.Point(432, 114);
            this.ShiftBtn.Name = "ShiftBtn";
            this.ShiftBtn.Size = new System.Drawing.Size(79, 37);
            this.ShiftBtn.TabIndex = 6;
            this.ShiftBtn.Text = "Shift!";
            this.ShiftBtn.UseVisualStyleBackColor = true;
            this.ShiftBtn.Click += new System.EventHandler(this.ShiftBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShiftBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RightShiftOperation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ShiftBtn;
    }
}

