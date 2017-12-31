namespace Exp7_1
{
    partial class Exp7_1
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
            this.btnSort = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入一系列整数，中间用,（逗号）隔开：";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(13, 36);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(229, 21);
            this.txtSource.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(259, 35);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(49, 23);
            this.btnSort.TabIndex = 2;
            this.btnSort.Text = "排序";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(13, 68);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(65, 12);
            this.lblShow.TabIndex = 3;
            this.lblShow.Text = "排序结果：";
            // 
            // Exp7_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 92);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.Name = "Exp7_1";
            this.Text = "实训7_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblShow;
    }
}