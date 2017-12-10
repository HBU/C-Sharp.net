namespace Test6_4
{
    partial class Test6_4
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
            this.lblShow = new System.Windows.Forms.Label();
            this.btnPupil = new System.Windows.Forms.Button();
            this.btnUndergraduate = new System.Windows.Forms.Button();
            this.btnPostgraduate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnStudy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(12, 12);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(168, 148);
            this.lblShow.TabIndex = 1;
            // 
            // btnPupil
            // 
            this.btnPupil.Location = new System.Drawing.Point(224, 40);
            this.btnPupil.Name = "btnPupil";
            this.btnPupil.Size = new System.Drawing.Size(75, 23);
            this.btnPupil.TabIndex = 2;
            this.btnPupil.Text = "添加小学生";
            this.btnPupil.UseVisualStyleBackColor = true;
            this.btnPupil.Click += new System.EventHandler(this.btnPupil_Click);
            // 
            // btnUndergraduate
            // 
            this.btnUndergraduate.Location = new System.Drawing.Point(224, 70);
            this.btnUndergraduate.Name = "btnUndergraduate";
            this.btnUndergraduate.Size = new System.Drawing.Size(75, 23);
            this.btnUndergraduate.TabIndex = 2;
            this.btnUndergraduate.Text = "添加大学生";
            this.btnUndergraduate.UseVisualStyleBackColor = true;
            this.btnUndergraduate.Click += new System.EventHandler(this.btnUndergraduate_Click);
            // 
            // btnPostgraduate
            // 
            this.btnPostgraduate.Location = new System.Drawing.Point(224, 100);
            this.btnPostgraduate.Name = "btnPostgraduate";
            this.btnPostgraduate.Size = new System.Drawing.Size(75, 23);
            this.btnPostgraduate.TabIndex = 2;
            this.btnPostgraduate.Text = "添加研究生";
            this.btnPostgraduate.UseVisualStyleBackColor = true;
            this.btnPostgraduate.Click += new System.EventHandler(this.btnPostgraduate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(234, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(65, 21);
            this.txtName.TabIndex = 4;
            // 
            // btnStudy
            // 
            this.btnStudy.Location = new System.Drawing.Point(224, 130);
            this.btnStudy.Name = "btnStudy";
            this.btnStudy.Size = new System.Drawing.Size(75, 23);
            this.btnStudy.TabIndex = 2;
            this.btnStudy.Text = "学习";
            this.btnStudy.UseVisualStyleBackColor = true;
            this.btnStudy.Click += new System.EventHandler(this.btnStudy_Click);
            // 
            // Test6_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 166);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStudy);
            this.Controls.Add(this.btnPostgraduate);
            this.Controls.Add(this.btnUndergraduate);
            this.Controls.Add(this.btnPupil);
            this.Controls.Add(this.lblShow);
            this.Name = "Test6_4";
            this.Text = "Test6_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnPupil;
        private System.Windows.Forms.Button btnUndergraduate;
        private System.Windows.Forms.Button btnPostgraduate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnStudy;
    }
}