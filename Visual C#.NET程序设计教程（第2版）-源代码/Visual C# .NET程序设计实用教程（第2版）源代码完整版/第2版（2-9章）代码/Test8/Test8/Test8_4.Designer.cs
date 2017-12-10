namespace Test8_4
{
    partial class Test8_4
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入：";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(49, 9);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(168, 21);
            this.txtSource.TabIndex = 1;
            this.txtSource.Text = "在此，请输入任意文字！";
            this.txtSource.Enter += new System.EventHandler(this.txtSource_Enter);
            this.txtSource.Leave += new System.EventHandler(this.txtSource_Leave);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(12, 36);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(53, 12);
            this.lblShow.TabIndex = 2;
            this.lblShow.Text = "末输入：";
            // 
            // lblTarget
            // 
            this.lblTarget.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTarget.Location = new System.Drawing.Point(12, 59);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(205, 22);
            this.lblTarget.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            
            // 
            // Test8_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 126);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.Name = "Test8_4";
            this.Text = "Test8_4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Button button1;
    }
}