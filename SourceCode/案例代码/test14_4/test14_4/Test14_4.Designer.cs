namespace test14_4
{
    partial class Test14_4
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ngRotate = new System.Windows.Forms.NumericUpDown();
            this.ngxScale = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ngyScale = new System.Windows.Forms.NumericUpDown();
            this.ngxMove = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ngyMove = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nlRotate = new System.Windows.Forms.NumericUpDown();
            this.nlxScale = new System.Windows.Forms.NumericUpDown();
            this.nlxMove = new System.Windows.Forms.NumericUpDown();
            this.nlyScale = new System.Windows.Forms.NumericUpDown();
            this.nlyMove = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ngRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngxScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngyScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngxMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngyMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlxScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlxMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlyScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlyMove)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "旋转：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "缩放：横向";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "平移：横向";
            // 
            // ngRotate
            // 
            this.ngRotate.Location = new System.Drawing.Point(49, 14);
            this.ngRotate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.ngRotate.Name = "ngRotate";
            this.ngRotate.Size = new System.Drawing.Size(42, 21);
            this.ngRotate.TabIndex = 3;
            this.ngRotate.ValueChanged += new System.EventHandler(this.ngRotate_ValueChanged);
            // 
            // ngxScale
            // 
            this.ngxScale.DecimalPlaces = 1;
            this.ngxScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ngxScale.Location = new System.Drawing.Point(73, 39);
            this.ngxScale.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ngxScale.Name = "ngxScale";
            this.ngxScale.Size = new System.Drawing.Size(42, 21);
            this.ngxScale.TabIndex = 3;
            this.ngxScale.ValueChanged += new System.EventHandler(this.ngxScale_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "，纵向";
            // 
            // ngyScale
            // 
            this.ngyScale.DecimalPlaces = 1;
            this.ngyScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ngyScale.Location = new System.Drawing.Point(173, 39);
            this.ngyScale.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ngyScale.Name = "ngyScale";
            this.ngyScale.Size = new System.Drawing.Size(42, 21);
            this.ngyScale.TabIndex = 3;
            this.ngyScale.ValueChanged += new System.EventHandler(this.ngyScale_ValueChanged);
            // 
            // ngxMove
            // 
            this.ngxMove.Location = new System.Drawing.Point(73, 70);
            this.ngxMove.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.ngxMove.Name = "ngxMove";
            this.ngxMove.Size = new System.Drawing.Size(42, 21);
            this.ngxMove.TabIndex = 3;
            this.ngxMove.ValueChanged += new System.EventHandler(this.ngxMove_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "，纵向";
            // 
            // ngyMove
            // 
            this.ngyMove.Location = new System.Drawing.Point(173, 72);
            this.ngyMove.Name = "ngyMove";
            this.ngyMove.Size = new System.Drawing.Size(42, 21);
            this.ngyMove.TabIndex = 3;
            this.ngyMove.ValueChanged += new System.EventHandler(this.ngyMove_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "旋转：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "缩放：横向";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "平移：横向";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(126, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "，纵向";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "，纵向";
            // 
            // nlRotate
            // 
            this.nlRotate.Location = new System.Drawing.Point(43, 14);
            this.nlRotate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nlRotate.Name = "nlRotate";
            this.nlRotate.Size = new System.Drawing.Size(42, 21);
            this.nlRotate.TabIndex = 3;
            this.nlRotate.ValueChanged += new System.EventHandler(this.nlRotate_ValueChanged);
            // 
            // nlxScale
            // 
            this.nlxScale.DecimalPlaces = 1;
            this.nlxScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nlxScale.Location = new System.Drawing.Point(71, 41);
            this.nlxScale.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nlxScale.Name = "nlxScale";
            this.nlxScale.Size = new System.Drawing.Size(42, 21);
            this.nlxScale.TabIndex = 3;
            this.nlxScale.ValueChanged += new System.EventHandler(this.nlxScale_ValueChanged);
            // 
            // nlxMove
            // 
            this.nlxMove.Location = new System.Drawing.Point(71, 68);
            this.nlxMove.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nlxMove.Name = "nlxMove";
            this.nlxMove.Size = new System.Drawing.Size(42, 21);
            this.nlxMove.TabIndex = 3;
            this.nlxMove.ValueChanged += new System.EventHandler(this.nlxMove_ValueChanged);
            // 
            // nlyScale
            // 
            this.nlyScale.DecimalPlaces = 1;
            this.nlyScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nlyScale.Location = new System.Drawing.Point(171, 41);
            this.nlyScale.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nlyScale.Name = "nlyScale";
            this.nlyScale.Size = new System.Drawing.Size(42, 21);
            this.nlyScale.TabIndex = 3;
            this.nlyScale.ValueChanged += new System.EventHandler(this.nlyScale_ValueChanged);
            // 
            // nlyMove
            // 
            this.nlyMove.Location = new System.Drawing.Point(171, 73);
            this.nlyMove.Name = "nlyMove";
            this.nlyMove.Size = new System.Drawing.Size(42, 21);
            this.nlyMove.TabIndex = 3;
            this.nlyMove.ValueChanged += new System.EventHandler(this.nlyMove_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ngxScale);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ngyMove);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ngyScale);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ngRotate);
            this.groupBox1.Controls.Add(this.ngxMove);
            this.groupBox1.Location = new System.Drawing.Point(1, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "全局变形";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nlRotate);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nlyMove);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nlyScale);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.nlxMove);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.nlxScale);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(242, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "针对椭圆的局部变形";
            // 
            // Test14_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 239);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Test14_4";
            this.Text = "Test14_4";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Test14_4_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ngRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngxScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngyScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngxMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngyMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlxScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlxMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlyScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlyMove)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ngRotate;
        private System.Windows.Forms.NumericUpDown ngxScale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ngyScale;
        private System.Windows.Forms.NumericUpDown ngxMove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ngyMove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nlRotate;
        private System.Windows.Forms.NumericUpDown nlxScale;
        private System.Windows.Forms.NumericUpDown nlxMove;
        private System.Windows.Forms.NumericUpDown nlyScale;
        private System.Windows.Forms.NumericUpDown nlyMove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

