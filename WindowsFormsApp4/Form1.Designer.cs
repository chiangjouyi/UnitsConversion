namespace WindowsFormsApp4
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
            this.label6 = new System.Windows.Forms.Label();
            this.tb公分 = new System.Windows.Forms.TextBox();
            this.tb坪數 = new System.Windows.Forms.TextBox();
            this.tb英吋 = new System.Windows.Forms.TextBox();
            this.tb平方公尺 = new System.Windows.Forms.TextBox();
            this.tb公斤 = new System.Windows.Forms.TextBox();
            this.tb磅 = new System.Windows.Forms.TextBox();
            this.btn公分轉英寸 = new System.Windows.Forms.Button();
            this.btn坪數轉平方公尺 = new System.Windows.Forms.Button();
            this.btn公斤轉磅 = new System.Windows.Forms.Button();
            this.tb尺 = new System.Windows.Forms.TextBox();
            this.tb吋 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(87, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "公分";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(87, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "坪數";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(343, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "英吋";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(343, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "磅";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(87, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "公斤";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Firebrick;
            this.label6.Location = new System.Drawing.Point(343, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "平方公尺";
            // 
            // tb公分
            // 
            this.tb公分.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb公分.Location = new System.Drawing.Point(93, 71);
            this.tb公分.Name = "tb公分";
            this.tb公分.Size = new System.Drawing.Size(133, 36);
            this.tb公分.TabIndex = 6;
            // 
            // tb坪數
            // 
            this.tb坪數.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb坪數.Location = new System.Drawing.Point(93, 221);
            this.tb坪數.Name = "tb坪數";
            this.tb坪數.Size = new System.Drawing.Size(133, 36);
            this.tb坪數.TabIndex = 7;
            // 
            // tb英吋
            // 
            this.tb英吋.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb英吋.Location = new System.Drawing.Point(349, 71);
            this.tb英吋.Name = "tb英吋";
            this.tb英吋.Size = new System.Drawing.Size(133, 36);
            this.tb英吋.TabIndex = 8;
            // 
            // tb平方公尺
            // 
            this.tb平方公尺.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb平方公尺.Location = new System.Drawing.Point(353, 221);
            this.tb平方公尺.Name = "tb平方公尺";
            this.tb平方公尺.Size = new System.Drawing.Size(133, 36);
            this.tb平方公尺.TabIndex = 9;
            // 
            // tb公斤
            // 
            this.tb公斤.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb公斤.Location = new System.Drawing.Point(93, 320);
            this.tb公斤.Name = "tb公斤";
            this.tb公斤.Size = new System.Drawing.Size(133, 36);
            this.tb公斤.TabIndex = 10;
            // 
            // tb磅
            // 
            this.tb磅.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb磅.Location = new System.Drawing.Point(349, 320);
            this.tb磅.Name = "tb磅";
            this.tb磅.Size = new System.Drawing.Size(133, 36);
            this.tb磅.TabIndex = 11;
            // 
            // btn公分轉英寸
            // 
            this.btn公分轉英寸.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn公分轉英寸.BackColor = System.Drawing.Color.IndianRed;
            this.btn公分轉英寸.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn公分轉英寸.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn公分轉英寸.Location = new System.Drawing.Point(245, 71);
            this.btn公分轉英寸.Name = "btn公分轉英寸";
            this.btn公分轉英寸.Size = new System.Drawing.Size(84, 42);
            this.btn公分轉英寸.TabIndex = 12;
            this.btn公分轉英寸.Text = "-->";
            this.btn公分轉英寸.UseVisualStyleBackColor = false;
            this.btn公分轉英寸.Click += new System.EventHandler(this.btn公分轉英寸_Click);
            // 
            // btn坪數轉平方公尺
            // 
            this.btn坪數轉平方公尺.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn坪數轉平方公尺.BackColor = System.Drawing.Color.IndianRed;
            this.btn坪數轉平方公尺.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn坪數轉平方公尺.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn坪數轉平方公尺.Location = new System.Drawing.Point(245, 221);
            this.btn坪數轉平方公尺.Name = "btn坪數轉平方公尺";
            this.btn坪數轉平方公尺.Size = new System.Drawing.Size(84, 42);
            this.btn坪數轉平方公尺.TabIndex = 13;
            this.btn坪數轉平方公尺.Text = "-->";
            this.btn坪數轉平方公尺.UseVisualStyleBackColor = false;
            this.btn坪數轉平方公尺.Click += new System.EventHandler(this.btn坪數轉平方公尺_Click);
            // 
            // btn公斤轉磅
            // 
            this.btn公斤轉磅.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn公斤轉磅.BackColor = System.Drawing.Color.IndianRed;
            this.btn公斤轉磅.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn公斤轉磅.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn公斤轉磅.Location = new System.Drawing.Point(245, 320);
            this.btn公斤轉磅.Name = "btn公斤轉磅";
            this.btn公斤轉磅.Size = new System.Drawing.Size(84, 42);
            this.btn公斤轉磅.TabIndex = 14;
            this.btn公斤轉磅.Text = "-->";
            this.btn公斤轉磅.UseVisualStyleBackColor = false;
            this.btn公斤轉磅.Click += new System.EventHandler(this.btn公斤轉磅_Click);
            // 
            // tb尺
            // 
            this.tb尺.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb尺.Location = new System.Drawing.Point(349, 118);
            this.tb尺.Name = "tb尺";
            this.tb尺.Size = new System.Drawing.Size(47, 36);
            this.tb尺.TabIndex = 15;
            // 
            // tb吋
            // 
            this.tb吋.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tb吋.Location = new System.Drawing.Point(448, 118);
            this.tb吋.Name = "tb吋";
            this.tb吋.Size = new System.Drawing.Size(47, 36);
            this.tb吋.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(397, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 31);
            this.label7.TabIndex = 17;
            this.label7.Text = "呎";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Firebrick;
            this.label8.Location = new System.Drawing.Point(498, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 31);
            this.label8.TabIndex = 18;
            this.label8.Text = "吋";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(579, 435);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb吋);
            this.Controls.Add(this.tb尺);
            this.Controls.Add(this.btn公斤轉磅);
            this.Controls.Add(this.btn坪數轉平方公尺);
            this.Controls.Add(this.btn公分轉英寸);
            this.Controls.Add(this.tb磅);
            this.Controls.Add(this.tb公斤);
            this.Controls.Add(this.tb平方公尺);
            this.Controls.Add(this.tb英吋);
            this.Controls.Add(this.tb坪數);
            this.Controls.Add(this.tb公分);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb公分;
        private System.Windows.Forms.TextBox tb坪數;
        private System.Windows.Forms.TextBox tb英吋;
        private System.Windows.Forms.TextBox tb平方公尺;
        private System.Windows.Forms.TextBox tb公斤;
        private System.Windows.Forms.TextBox tb磅;
        private System.Windows.Forms.Button btn公分轉英寸;
        private System.Windows.Forms.Button btn坪數轉平方公尺;
        private System.Windows.Forms.Button btn公斤轉磅;
        private System.Windows.Forms.TextBox tb尺;
        private System.Windows.Forms.TextBox tb吋;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

