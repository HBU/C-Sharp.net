namespace test4_1
{
    partial class Test4_X
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtLy = new System.Windows.Forms.TextBox();
            this.txtLx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRy = new System.Windows.Forms.TextBox();
            this.txtRx = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "左上角(X):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "左上角(Y):";
            // 
            // txtLy
            // 
            this.txtLy.Location = new System.Drawing.Point(84, 45);
            this.txtLy.Name = "txtLy";
            this.txtLy.Size = new System.Drawing.Size(57, 21);
            this.txtLy.TabIndex = 1;
            // 
            // txtLx
            // 
            this.txtLx.Location = new System.Drawing.Point(84, 13);
            this.txtLx.Name = "txtLx";
            this.txtLx.Size = new System.Drawing.Size(57, 21);
            this.txtLx.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "右下角(X):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "右下角(Y):";
            // 
            // txtRy
            // 
            this.txtRy.Location = new System.Drawing.Point(230, 45);
            this.txtRy.Name = "txtRy";
            this.txtRy.Size = new System.Drawing.Size(57, 21);
            this.txtRy.TabIndex = 1;
            // 
            // txtRx
            // 
            this.txtRx.Location = new System.Drawing.Point(230, 13);
            this.txtRx.Name = "txtRx";
            this.txtRx.Size = new System.Drawing.Size(57, 21);
            this.txtRx.TabIndex = 1;
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(15, 87);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(41, 12);
            this.lblShow.TabIndex = 2;
            this.lblShow.Text = "label5";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(111, 117);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "计算面积";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Test4_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 152);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtRx);
            this.Controls.Add(this.txtLx);
            this.Controls.Add(this.txtRy);
            this.Controls.Add(this.txtLy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Test4_3";
            this.Text = "Test4_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLy;
        private System.Windows.Forms.TextBox txtLx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRy;
        private System.Windows.Forms.TextBox txtRx;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnCalculate;
    }
}