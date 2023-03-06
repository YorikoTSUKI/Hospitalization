namespace HospitalizationSystem
{
    partial class frm_Register
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
            this.button_enroll = new System.Windows.Forms.Button();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_No = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_No = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("华文隶书", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(176, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 50);
            this.label1.TabIndex = 35;
            this.label1.Text = "欢迎注册住院管理系统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_enroll
            // 
            this.button_enroll.Location = new System.Drawing.Point(257, 336);
            this.button_enroll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_enroll.Name = "button_enroll";
            this.button_enroll.Size = new System.Drawing.Size(100, 46);
            this.button_enroll.TabIndex = 34;
            this.button_enroll.Text = "注册";
            this.button_enroll.UseVisualStyleBackColor = true;
            this.button_enroll.Click += new System.EventHandler(this.button_enroll_Click);
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Location = new System.Drawing.Point(477, 336);
            this.btn_LogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(96, 46);
            this.btn_LogIn.TabIndex = 33;
            this.btn_LogIn.Text = "返回登录";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(330, 214);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(196, 32);
            this.txt_Password.TabIndex = 32;
            // 
            // txt_No
            // 
            this.txt_No.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_No.Location = new System.Drawing.Point(330, 143);
            this.txt_No.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_No.Multiline = true;
            this.txt_No.Name = "txt_No";
            this.txt_No.Size = new System.Drawing.Size(196, 36);
            this.txt_No.TabIndex = 31;
            this.txt_No.TextChanged += new System.EventHandler(this.txt_No_TextChanged);
            // 
            // lbl_Password
            // 
            this.lbl_Password.Location = new System.Drawing.Point(165, 215);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(122, 31);
            this.lbl_Password.TabIndex = 29;
            this.lbl_Password.Text = "密码：";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_No
            // 
            this.lbl_No.Location = new System.Drawing.Point(162, 143);
            this.lbl_No.Name = "lbl_No";
            this.lbl_No.Size = new System.Drawing.Size(124, 35);
            this.lbl_No.TabIndex = 28;
            this.lbl_No.Text = "用户名：";
            this.lbl_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_enroll);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_No);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_No);
            this.Name = "frm_Register";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.frm_Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_enroll;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_No;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_No;
    }
}