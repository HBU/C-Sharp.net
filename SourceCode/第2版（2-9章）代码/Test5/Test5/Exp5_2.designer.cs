namespace Exp5_2
{
    partial class Exp5_2
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
            this.btnCrtSavingAc = new System.Windows.Forms.Button();
            this.btnWithDraw = new System.Windows.Forms.Button();
            this.txtWithDraw = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.btnShowBalance = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnCrtVipAc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrtSavingAc
            // 
            this.btnCrtSavingAc.Location = new System.Drawing.Point(11, 33);
            this.btnCrtSavingAc.Name = "btnCrtSavingAc";
            this.btnCrtSavingAc.Size = new System.Drawing.Size(92, 23);
            this.btnCrtSavingAc.TabIndex = 0;
            this.btnCrtSavingAc.Text = "创建账户";
            this.btnCrtSavingAc.UseVisualStyleBackColor = true;
            this.btnCrtSavingAc.Click += new System.EventHandler(this.btnCrtSavingAc_Click);
            // 
            // btnWithDraw
            // 
            this.btnWithDraw.Location = new System.Drawing.Point(11, 62);
            this.btnWithDraw.Name = "btnWithDraw";
            this.btnWithDraw.Size = new System.Drawing.Size(43, 23);
            this.btnWithDraw.TabIndex = 0;
            this.btnWithDraw.Text = "取款";
            this.btnWithDraw.UseVisualStyleBackColor = true;
            this.btnWithDraw.Click += new System.EventHandler(this.btnWithDraw_Click);
            // 
            // txtWithDraw
            // 
            this.txtWithDraw.Location = new System.Drawing.Point(61, 63);
            this.txtWithDraw.Name = "txtWithDraw";
            this.txtWithDraw.Size = new System.Drawing.Size(42, 21);
            this.txtWithDraw.TabIndex = 1;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(11, 91);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(43, 23);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "存款";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(61, 92);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(42, 21);
            this.txtDeposit.TabIndex = 1;
            // 
            // btnShowBalance
            // 
            this.btnShowBalance.Location = new System.Drawing.Point(11, 120);
            this.btnShowBalance.Name = "btnShowBalance";
            this.btnShowBalance.Size = new System.Drawing.Size(92, 23);
            this.btnShowBalance.TabIndex = 0;
            this.btnShowBalance.Text = "查询余额";
            this.btnShowBalance.UseVisualStyleBackColor = true;
            this.btnShowBalance.Click += new System.EventHandler(this.btnShowBalance_Click);
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(109, 4);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(104, 138);
            this.lblShow.TabIndex = 2;
            this.lblShow.Text = "label1";
            // 
            // btnCrtVipAc
            // 
            this.btnCrtVipAc.Location = new System.Drawing.Point(11, 4);
            this.btnCrtVipAc.Name = "btnCrtVipAc";
            this.btnCrtVipAc.Size = new System.Drawing.Size(92, 23);
            this.btnCrtVipAc.TabIndex = 0;
            this.btnCrtVipAc.Text = "创建VIP账户";
            this.btnCrtVipAc.UseVisualStyleBackColor = true;
            this.btnCrtVipAc.Click += new System.EventHandler(this.btnCrtVipAc_Click);
            // 
            // Exp5_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 151);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.txtWithDraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithDraw);
            this.Controls.Add(this.btnShowBalance);
            this.Controls.Add(this.btnCrtVipAc);
            this.Controls.Add(this.btnCrtSavingAc);
            this.Name = "Exp5_2";
            this.Text = "实训5_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrtSavingAc;
        private System.Windows.Forms.Button btnWithDraw;
        private System.Windows.Forms.TextBox txtWithDraw;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Button btnShowBalance;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnCrtVipAc;
    }
}