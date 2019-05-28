namespace Decoder
{
    partial class Decoder
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
            this.Decode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rpathtext = new System.Windows.Forms.TextBox();
            this.ptext = new System.Windows.Forms.TextBox();
            this.wpathtext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rpathtext_e = new System.Windows.Forms.TextBox();
            this.ptext_e = new System.Windows.Forms.TextBox();
            this.wpathtext_e = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Decode
            // 
            this.Decode.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Decode.Location = new System.Drawing.Point(249, 187);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(75, 23);
            this.Decode.TabIndex = 0;
            this.Decode.Text = "解码";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "密文文件路径：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密钥:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "明文导出文件夹路径:";
            // 
            // rpathtext
            // 
            this.rpathtext.Location = new System.Drawing.Point(183, 64);
            this.rpathtext.Name = "rpathtext";
            this.rpathtext.Size = new System.Drawing.Size(310, 21);
            this.rpathtext.TabIndex = 4;
            this.rpathtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ptext
            // 
            this.ptext.Location = new System.Drawing.Point(183, 103);
            this.ptext.Name = "ptext";
            this.ptext.Size = new System.Drawing.Size(310, 21);
            this.ptext.TabIndex = 5;
            this.ptext.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // wpathtext
            // 
            this.wpathtext.Location = new System.Drawing.Point(183, 144);
            this.wpathtext.Name = "wpathtext";
            this.wpathtext.Size = new System.Drawing.Size(310, 21);
            this.wpathtext.TabIndex = 6;
            this.wpathtext.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "选择文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "选择文件夹";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(244, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "解码器";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(226, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "加密工具";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "明文文件路径：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "密钥:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "密文导出文件夹路径:";
            // 
            // rpathtext_e
            // 
            this.rpathtext_e.Location = new System.Drawing.Point(183, 316);
            this.rpathtext_e.Name = "rpathtext_e";
            this.rpathtext_e.Size = new System.Drawing.Size(310, 21);
            this.rpathtext_e.TabIndex = 14;
            this.rpathtext_e.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // ptext_e
            // 
            this.ptext_e.Location = new System.Drawing.Point(183, 363);
            this.ptext_e.Name = "ptext_e";
            this.ptext_e.Size = new System.Drawing.Size(310, 21);
            this.ptext_e.TabIndex = 15;
            this.ptext_e.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // wpathtext_e
            // 
            this.wpathtext_e.Location = new System.Drawing.Point(183, 409);
            this.wpathtext_e.Name = "wpathtext_e";
            this.wpathtext_e.Size = new System.Drawing.Size(310, 21);
            this.wpathtext_e.TabIndex = 16;
            this.wpathtext_e.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(502, 314);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "选择文件";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(502, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "选择文件夹";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(249, 447);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "加密";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Decoder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 482);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.wpathtext_e);
            this.Controls.Add(this.ptext_e);
            this.Controls.Add(this.rpathtext_e);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wpathtext);
            this.Controls.Add(this.ptext);
            this.Controls.Add(this.rpathtext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Decode);
            this.Name = "Decoder";
            this.Text = "解码，加密工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Decode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rpathtext;
        private System.Windows.Forms.TextBox ptext;
        private System.Windows.Forms.TextBox wpathtext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox rpathtext_e;
        private System.Windows.Forms.TextBox ptext_e;
        private System.Windows.Forms.TextBox wpathtext_e;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

