namespace WindowsFormsApplication1
{
    partial class Test5_4
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCtBase = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnCtChild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "品种：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "年龄：";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(357, 12);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(70, 21);
            this.txtType.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(212, 12);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(70, 21);
            this.txtAge.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(70, 21);
            this.txtName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "姓名：";
            // 
            // btnCtBase
            // 
            this.btnCtBase.Location = new System.Drawing.Point(34, 94);
            this.btnCtBase.Name = "btnCtBase";
            this.btnCtBase.Size = new System.Drawing.Size(161, 23);
            this.btnCtBase.TabIndex = 10;
            this.btnCtBase.Text = "创建基类对象并调用方法";
            this.btnCtBase.UseVisualStyleBackColor = true;
            this.btnCtBase.Click += new System.EventHandler(this.btnCtBase_Click);
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(12, 45);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(416, 33);
            this.lblShow.TabIndex = 9;
            // 
            // btnCtChild
            // 
            this.btnCtChild.Location = new System.Drawing.Point(237, 94);
            this.btnCtChild.Name = "btnCtChild";
            this.btnCtChild.Size = new System.Drawing.Size(161, 23);
            this.btnCtChild.TabIndex = 10;
            this.btnCtChild.Text = "创建子类对象并调用方法";
            this.btnCtChild.UseVisualStyleBackColor = true;
            this.btnCtChild.Click += new System.EventHandler(this.btnCtChild_Click);
            // 
            // Test5_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 132);
            this.Controls.Add(this.btnCtChild);
            this.Controls.Add(this.btnCtBase);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Test5_4";
            this.Text = "Test5_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCtBase;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnCtChild;
    }
}