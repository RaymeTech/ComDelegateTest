namespace ComDelegateTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.run_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.com_in_text = new System.Windows.Forms.TextBox();
            this.com_out_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // run_btn
            // 
            this.run_btn.Location = new System.Drawing.Point(403, 16);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(102, 38);
            this.run_btn.TabIndex = 0;
            this.run_btn.Text = "启动";
            this.run_btn.UseVisualStyleBackColor = true;
            this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 71);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 358);
            this.textBox1.TabIndex = 2;
            // 
            // com_in_text
            // 
            this.com_in_text.Location = new System.Drawing.Point(61, 25);
            this.com_in_text.Name = "com_in_text";
            this.com_in_text.Size = new System.Drawing.Size(100, 25);
            this.com_in_text.TabIndex = 3;
            // 
            // com_out_text
            // 
            this.com_out_text.Location = new System.Drawing.Point(260, 25);
            this.com_out_text.Name = "com_out_text";
            this.com_out_text.Size = new System.Drawing.Size(100, 25);
            this.com_out_text.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "COM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.com_out_text);
            this.Controls.Add(this.com_in_text);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.run_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox com_in_text;
        private System.Windows.Forms.TextBox com_out_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

