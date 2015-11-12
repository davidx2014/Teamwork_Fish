namespace FishMD
{
    partial class FishMD
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFishName1 = new System.Windows.Forms.Label();
            this.ptbFishimg1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFishimg1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFishName1);
            this.panel1.Controls.Add(this.ptbFishimg1);
            this.panel1.Location = new System.Drawing.Point(91, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(805, 616);
            this.panel1.TabIndex = 0;
            // 
            // lblFishName1
            // 
            this.lblFishName1.AutoSize = true;
            this.lblFishName1.Location = new System.Drawing.Point(104, 176);
            this.lblFishName1.Name = "lblFishName1";
            this.lblFishName1.Size = new System.Drawing.Size(35, 13);
            this.lblFishName1.TabIndex = 15;
            this.lblFishName1.Text = "label1";
            // 
            // ptbFishimg1
            // 
            this.ptbFishimg1.Location = new System.Drawing.Point(62, 35);
            this.ptbFishimg1.Name = "ptbFishimg1";
            this.ptbFishimg1.Size = new System.Drawing.Size(125, 130);
            this.ptbFishimg1.TabIndex = 7;
            this.ptbFishimg1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(407, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "搜索";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(2, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 85);
            this.button2.TabIndex = 3;
            this.button2.Text = "请设计";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 85);
            this.button3.TabIndex = 4;
            this.button3.Text = "分类";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 57);
            this.panel2.TabIndex = 27;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(94, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(83, 57);
            this.panel3.TabIndex = 0;
            // 
            // FishMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 771);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FishMD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " CE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFishimg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ptbFishimg1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFishName1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

