
namespace POSSystem
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
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.textBoxInsPrice = new System.Windows.Forms.TextBox();
            this.textBoxSodaPrice = new System.Windows.Forms.TextBox();
            this.textBoxInsQuan = new System.Windows.Forms.TextBox();
            this.textBoxSodaQuan = new System.Windows.Forms.TextBox();
            this.textBoxPay = new System.Windows.Forms.TextBox();
            this.CheckoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Instant Noodles Price/Quantity ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.Location = new System.Drawing.Point(63, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soda Price/Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.Location = new System.Drawing.Point(524, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20F);
            this.label4.Location = new System.Drawing.Point(524, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 20F);
            this.label5.Location = new System.Drawing.Point(63, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pay";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("新細明體", 20F);
            this.labelTotal.Location = new System.Drawing.Point(463, 149);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(73, 27);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total:";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("新細明體", 20F);
            this.labelChange.Location = new System.Drawing.Point(463, 186);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(97, 27);
            this.labelChange.TabIndex = 6;
            this.labelChange.Text = "Change:";
            // 
            // textBoxInsPrice
            // 
            this.textBoxInsPrice.Font = new System.Drawing.Font("新細明體", 20F);
            this.textBoxInsPrice.Location = new System.Drawing.Point(418, 28);
            this.textBoxInsPrice.Name = "textBoxInsPrice";
            this.textBoxInsPrice.Size = new System.Drawing.Size(100, 39);
            this.textBoxInsPrice.TabIndex = 7;
            // 
            // textBoxSodaPrice
            // 
            this.textBoxSodaPrice.Font = new System.Drawing.Font("新細明體", 20F);
            this.textBoxSodaPrice.Location = new System.Drawing.Point(418, 93);
            this.textBoxSodaPrice.Name = "textBoxSodaPrice";
            this.textBoxSodaPrice.Size = new System.Drawing.Size(100, 39);
            this.textBoxSodaPrice.TabIndex = 8;
            // 
            // textBoxInsQuan
            // 
            this.textBoxInsQuan.Font = new System.Drawing.Font("新細明體", 20F);
            this.textBoxInsQuan.Location = new System.Drawing.Point(549, 28);
            this.textBoxInsQuan.Name = "textBoxInsQuan";
            this.textBoxInsQuan.Size = new System.Drawing.Size(100, 39);
            this.textBoxInsQuan.TabIndex = 9;
            // 
            // textBoxSodaQuan
            // 
            this.textBoxSodaQuan.Font = new System.Drawing.Font("新細明體", 20F);
            this.textBoxSodaQuan.Location = new System.Drawing.Point(549, 93);
            this.textBoxSodaQuan.Name = "textBoxSodaQuan";
            this.textBoxSodaQuan.Size = new System.Drawing.Size(100, 39);
            this.textBoxSodaQuan.TabIndex = 10;
            // 
            // textBoxPay
            // 
            this.textBoxPay.Font = new System.Drawing.Font("新細明體", 20F);
            this.textBoxPay.Location = new System.Drawing.Point(157, 186);
            this.textBoxPay.Name = "textBoxPay";
            this.textBoxPay.Size = new System.Drawing.Size(100, 39);
            this.textBoxPay.TabIndex = 11;
            // 
            // CheckoutBtn
            // 
            this.CheckoutBtn.AutoSize = true;
            this.CheckoutBtn.Font = new System.Drawing.Font("新細明體", 20F);
            this.CheckoutBtn.Location = new System.Drawing.Point(68, 250);
            this.CheckoutBtn.Name = "CheckoutBtn";
            this.CheckoutBtn.Size = new System.Drawing.Size(125, 37);
            this.CheckoutBtn.TabIndex = 12;
            this.CheckoutBtn.Text = "Checkout";
            this.CheckoutBtn.UseVisualStyleBackColor = true;
            this.CheckoutBtn.Click += new System.EventHandler(this.CheckoutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckoutBtn);
            this.Controls.Add(this.textBoxPay);
            this.Controls.Add(this.textBoxSodaQuan);
            this.Controls.Add(this.textBoxInsQuan);
            this.Controls.Add(this.textBoxSodaPrice);
            this.Controls.Add(this.textBoxInsPrice);
            this.Controls.Add(this.labelChange);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "POS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.TextBox textBoxInsPrice;
        private System.Windows.Forms.TextBox textBoxSodaPrice;
        private System.Windows.Forms.TextBox textBoxInsQuan;
        private System.Windows.Forms.TextBox textBoxSodaQuan;
        private System.Windows.Forms.TextBox textBoxPay;
        private System.Windows.Forms.Button CheckoutBtn;
    }
}

