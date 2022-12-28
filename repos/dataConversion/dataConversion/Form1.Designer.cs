
namespace dataConversion
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
            this.colculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.noodles = new System.Windows.Forms.TextBox();
            this.soda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // colculate
            // 
            this.colculate.Location = new System.Drawing.Point(313, 102);
            this.colculate.Name = "colculate";
            this.colculate.Size = new System.Drawing.Size(85, 24);
            this.colculate.TabIndex = 0;
            this.colculate.Text = "Colculate";
            this.colculate.UseVisualStyleBackColor = true;
            this.colculate.Click += new System.EventHandler(this.colculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "購買泡麵的數量：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "購買汽水的數量：";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(85, 241);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(53, 12);
            this.output.TabIndex = 3;
            this.output.Text = "總金額：";
            // 
            // noodles
            // 
            this.noodles.Location = new System.Drawing.Point(190, 37);
            this.noodles.Name = "noodles";
            this.noodles.Size = new System.Drawing.Size(100, 22);
            this.noodles.TabIndex = 4;
            // 
            // soda
            // 
            this.soda.Location = new System.Drawing.Point(190, 104);
            this.soda.Name = "soda";
            this.soda.Size = new System.Drawing.Size(100, 22);
            this.soda.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.soda);
            this.Controls.Add(this.noodles);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colculate);
            this.Name = "Form1";
            this.Text = "購物車";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button colculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.TextBox noodles;
        private System.Windows.Forms.TextBox soda;
    }
}

