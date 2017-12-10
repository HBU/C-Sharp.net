namespace test4_1
{
    partial class Test4_8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtOp1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOp2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOp3 = new System.Windows.Forms.TextBox();
            this.btnTwoInt = new System.Windows.Forms.Button();
            this.bntDouble = new System.Windows.Forms.Button();
            this.bntThreeInt = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据1：";
            // 
            // txtOp1
            // 
            this.txtOp1.Location = new System.Drawing.Point(74, 13);
            this.txtOp1.Name = "txtOp1";
            this.txtOp1.Size = new System.Drawing.Size(68, 21);
            this.txtOp1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "数据2：";
            // 
            // txtOp2
            // 
            this.txtOp2.Location = new System.Drawing.Point(215, 13);
            this.txtOp2.Name = "txtOp2";
            this.txtOp2.Size = new System.Drawing.Size(68, 21);
            this.txtOp2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "数据3：";
            // 
            // txtOp3
            // 
            this.txtOp3.Location = new System.Drawing.Point(356, 13);
            this.txtOp3.Name = "txtOp3";
            this.txtOp3.Size = new System.Drawing.Size(68, 21);
            this.txtOp3.TabIndex = 1;
            // 
            // btnTwoInt
            // 
            this.btnTwoInt.Location = new System.Drawing.Point(36, 57);
            this.btnTwoInt.Name = "btnTwoInt";
            this.btnTwoInt.Size = new System.Drawing.Size(75, 23);
            this.btnTwoInt.TabIndex = 2;
            this.btnTwoInt.Text = "两个整数";
            this.btnTwoInt.UseVisualStyleBackColor = true;
            this.btnTwoInt.Click += new System.EventHandler(this.btnTwoInt_Click);
            // 
            // bntDouble
            // 
            this.bntDouble.Location = new System.Drawing.Point(156, 57);
            this.bntDouble.Name = "bntDouble";
            this.bntDouble.Size = new System.Drawing.Size(116, 23);
            this.bntDouble.TabIndex = 2;
            this.bntDouble.Text = "两个双精度浮点数";
            this.bntDouble.UseVisualStyleBackColor = true;
            this.bntDouble.Click += new System.EventHandler(this.bntDouble_Click);
            // 
            // bntThreeInt
            // 
            this.bntThreeInt.Location = new System.Drawing.Point(317, 57);
            this.bntThreeInt.Name = "bntThreeInt";
            this.bntThreeInt.Size = new System.Drawing.Size(75, 23);
            this.bntThreeInt.TabIndex = 2;
            this.bntThreeInt.Text = "三个整数";
            this.bntThreeInt.UseVisualStyleBackColor = true;
            this.bntThreeInt.Click += new System.EventHandler(this.bntThreeInt_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(16, 100);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(0, 12);
            this.lblShow.TabIndex = 3;
            // 
            // Test4_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 130);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.bntDouble);
            this.Controls.Add(this.bntThreeInt);
            this.Controls.Add(this.btnTwoInt);
            this.Controls.Add(this.txtOp3);
            this.Controls.Add(this.txtOp2);
            this.Controls.Add(this.txtOp1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Test4_8";
            this.Text = "Test4_8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOp1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOp2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOp3;
        private System.Windows.Forms.Button btnTwoInt;
        private System.Windows.Forms.Button bntDouble;
        private System.Windows.Forms.Button bntThreeInt;
        private System.Windows.Forms.Label lblShow;
    }
}