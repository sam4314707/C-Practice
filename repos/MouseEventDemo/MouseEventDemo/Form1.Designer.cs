
namespace MouseEventDemo
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(112, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.Location = new System.Drawing.Point(415, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label2_MouseClick);
            this.label2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDoubleClick);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.Location = new System.Drawing.Point(112, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.MouseEnter += new System.EventHandler(this.label3_MouseEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20F);
            this.label4.Location = new System.Drawing.Point(415, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            this.label4.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MouseEvent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

