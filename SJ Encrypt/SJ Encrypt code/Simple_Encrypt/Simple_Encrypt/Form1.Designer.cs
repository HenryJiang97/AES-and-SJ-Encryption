namespace Simple_Encrypt
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rpathtext = new System.Windows.Forms.TextBox();
            this.ptext = new System.Windows.Forms.TextBox();
            this.wpathtext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Decode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(188, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "AES转SJ加密工具";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "AES密文文件路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "密钥:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "SJ加密密文导出文件夹路径:";
            // 
            // rpathtext
            // 
            this.rpathtext.Location = new System.Drawing.Point(181, 69);
            this.rpathtext.Name = "rpathtext";
            this.rpathtext.Size = new System.Drawing.Size(310, 21);
            this.rpathtext.TabIndex = 14;
            this.rpathtext.TextChanged += new System.EventHandler(this.rpathtext_TextChanged);
            // 
            // ptext
            // 
            this.ptext.Location = new System.Drawing.Point(181, 124);
            this.ptext.Name = "ptext";
            this.ptext.Size = new System.Drawing.Size(310, 21);
            this.ptext.TabIndex = 15;
            this.ptext.TextChanged += new System.EventHandler(this.ptext_TextChanged);
            // 
            // wpathtext
            // 
            this.wpathtext.Location = new System.Drawing.Point(181, 176);
            this.wpathtext.Name = "wpathtext";
            this.wpathtext.Size = new System.Drawing.Size(310, 21);
            this.wpathtext.TabIndex = 16;
            this.wpathtext.TextChanged += new System.EventHandler(this.wpathtext_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "选择文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(510, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "选择文件夹";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Decode
            // 
            this.Decode.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Decode.Location = new System.Drawing.Point(261, 234);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(75, 23);
            this.Decode.TabIndex = 19;
            this.Decode.Text = "转码";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 298);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wpathtext);
            this.Controls.Add(this.ptext);
            this.Controls.Add(this.rpathtext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "AES转SJ加密";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rpathtext;
        private System.Windows.Forms.TextBox ptext;
        private System.Windows.Forms.TextBox wpathtext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Decode;
    }
}

