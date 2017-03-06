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
            this.log_text = new System.Windows.Forms.TextBox();
            this.com_in_text = new System.Windows.Forms.TextBox();
            this.com_out_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.log_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.data_text = new System.Windows.Forms.TextBox();
            this.baud_text = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.parity_text = new System.Windows.Forms.TextBox();
            this.stop_text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // run_btn
            // 
            this.run_btn.Location = new System.Drawing.Point(602, 122);
            this.run_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.run_btn.Name = "run_btn";
            this.run_btn.Size = new System.Drawing.Size(153, 61);
            this.run_btn.TabIndex = 0;
            this.run_btn.Text = "启动";
            this.run_btn.UseVisualStyleBackColor = true;
            this.run_btn.Click += new System.EventHandler(this.run_btn_Click);
            // 
            // log_text
            // 
            this.log_text.Location = new System.Drawing.Point(40, 204);
            this.log_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.log_text.Multiline = true;
            this.log_text.Name = "log_text";
            this.log_text.Size = new System.Drawing.Size(715, 480);
            this.log_text.TabIndex = 2;
            // 
            // com_in_text
            // 
            this.com_in_text.Location = new System.Drawing.Point(142, 148);
            this.com_in_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.com_in_text.Name = "com_in_text";
            this.com_in_text.Size = new System.Drawing.Size(136, 35);
            this.com_in_text.TabIndex = 3;
            // 
            // com_out_text
            // 
            this.com_out_text.Location = new System.Drawing.Point(440, 148);
            this.com_out_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.com_out_text.Name = "com_out_text";
            this.com_out_text.Size = new System.Drawing.Size(136, 35);
            this.com_out_text.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "输入COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "输出COM";
            // 
            // log_btn
            // 
            this.log_btn.Location = new System.Drawing.Point(602, 29);
            this.log_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(153, 61);
            this.log_btn.TabIndex = 9;
            this.log_btn.Text = "开启日志";
            this.log_btn.UseVisualStyleBackColor = true;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "数据位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "波特率";
            // 
            // data_text
            // 
            this.data_text.Location = new System.Drawing.Point(428, 29);
            this.data_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_text.Name = "data_text";
            this.data_text.Size = new System.Drawing.Size(148, 35);
            this.data_text.TabIndex = 11;
            this.data_text.Text = "8";
            // 
            // baud_text
            // 
            this.baud_text.Location = new System.Drawing.Point(130, 29);
            this.baud_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.baud_text.Name = "baud_text";
            this.baud_text.Size = new System.Drawing.Size(148, 35);
            this.baud_text.TabIndex = 10;
            this.baud_text.Text = "2400";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "校验位";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 94);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "停止位";
            // 
            // parity_text
            // 
            this.parity_text.Location = new System.Drawing.Point(428, 89);
            this.parity_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.parity_text.Name = "parity_text";
            this.parity_text.Size = new System.Drawing.Size(148, 35);
            this.parity_text.TabIndex = 15;
            this.parity_text.Text = "S";
            // 
            // stop_text
            // 
            this.stop_text.Location = new System.Drawing.Point(130, 89);
            this.stop_text.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stop_text.Name = "stop_text";
            this.stop_text.Size = new System.Drawing.Size(148, 35);
            this.stop_text.TabIndex = 14;
            this.stop_text.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 725);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.parity_text);
            this.Controls.Add(this.stop_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.data_text);
            this.Controls.Add(this.baud_text);
            this.Controls.Add(this.log_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.com_out_text);
            this.Controls.Add(this.com_in_text);
            this.Controls.Add(this.log_text);
            this.Controls.Add(this.run_btn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button run_btn;
        private System.Windows.Forms.TextBox log_text;
        private System.Windows.Forms.TextBox com_in_text;
        private System.Windows.Forms.TextBox com_out_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox data_text;
        private System.Windows.Forms.TextBox baud_text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox parity_text;
        private System.Windows.Forms.TextBox stop_text;
    }
}

