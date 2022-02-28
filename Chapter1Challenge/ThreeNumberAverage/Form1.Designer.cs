
namespace ThreeNumberAverage
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
            this.textBoxN1 = new System.Windows.Forms.TextBox();
            this.textBoxN2 = new System.Windows.Forms.TextBox();
            this.textBoxN3 = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(82, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "N1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.Location = new System.Drawing.Point(82, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "N2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.Location = new System.Drawing.Point(82, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "N3";
            // 
            // textBoxN1
            // 
            this.textBoxN1.Font = new System.Drawing.Font("新細明體", 20F);
            this.textBoxN1.Location = new System.Drawing.Point(190, 27);
            this.textBoxN1.Name = "textBoxN1";
            this.textBoxN1.Size = new System.Drawing.Size(100, 39);
            this.textBoxN1.TabIndex = 3;
            // 
            // textBoxN2
            // 
            this.textBoxN2.Font = new System.Drawing.Font("新細明體", 20F);
            this.textBoxN2.Location = new System.Drawing.Point(190, 109);
            this.textBoxN2.Name = "textBoxN2";
            this.textBoxN2.Size = new System.Drawing.Size(100, 39);
            this.textBoxN2.TabIndex = 4;
            // 
            // textBoxN3
            // 
            this.textBoxN3.Font = new System.Drawing.Font("新細明體", 20F);
            this.textBoxN3.Location = new System.Drawing.Point(190, 186);
            this.textBoxN3.Name = "textBoxN3";
            this.textBoxN3.Size = new System.Drawing.Size(100, 39);
            this.textBoxN3.TabIndex = 5;
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Font = new System.Drawing.Font("新細明體", 20F);
            this.Output.Location = new System.Drawing.Point(82, 306);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(60, 27);
            this.Output.TabIndex = 6;
            this.Output.Text = "Ans:";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.AutoSize = true;
            this.CalculateBtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.CalculateBtn.Location = new System.Drawing.Point(320, 188);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(117, 37);
            this.CalculateBtn.TabIndex = 7;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.textBoxN3);
            this.Controls.Add(this.textBoxN2);
            this.Controls.Add(this.textBoxN1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ThreeNumberAvg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxN1;
        private System.Windows.Forms.TextBox textBoxN2;
        private System.Windows.Forms.TextBox textBoxN3;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Button CalculateBtn;
    }
}

