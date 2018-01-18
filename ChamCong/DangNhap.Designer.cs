namespace ChamCong
{
    partial class DangNhap
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
            this.chkPass = new System.Windows.Forms.CheckBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.lbEx = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkPass
            // 
            this.chkPass.AutoSize = true;
            this.chkPass.Location = new System.Drawing.Point(189, 160);
            this.chkPass.Name = "chkPass";
            this.chkPass.Size = new System.Drawing.Size(102, 17);
            this.chkPass.TabIndex = 13;
            this.chkPass.Text = "Show Password";
            this.chkPass.UseVisualStyleBackColor = true;
            this.chkPass.CheckedChanged += new System.EventHandler(this.chkPass_CheckedChanged);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(189, 121);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(187, 20);
            this.txtMK.TabIndex = 12;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(189, 72);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(187, 20);
            this.txtTK.TabIndex = 8;
            // 
            // lbEx
            // 
            this.lbEx.AutoSize = true;
            this.lbEx.ForeColor = System.Drawing.Color.Red;
            this.lbEx.Location = new System.Drawing.Point(186, 160);
            this.lbEx.Name = "lbEx";
            this.lbEx.Size = new System.Drawing.Size(0, 13);
            this.lbEx.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mật Khẩu";
            // 
            // btDangNhap
            // 
            this.btDangNhap.Location = new System.Drawing.Point(205, 219);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(75, 40);
            this.btDangNhap.TabIndex = 14;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tài Khoản";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 291);
            this.Controls.Add(this.chkPass);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.lbEx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.label2);
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPass;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label lbEx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Label label2;
    }
}