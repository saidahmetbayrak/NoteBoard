namespace NoteBoard.UI
{
    partial class Login
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(108, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUserName.Location = new System.Drawing.Point(245, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(428, 53);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(245, 130);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(428, 53);
            this.txtPassword.TabIndex = 3;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Coral;
            this.btnlogin.Font = new System.Drawing.Font("Candara", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(116, 215);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(557, 89);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Giriş Yap";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lnkRegister
            // 
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkRegister.LinkColor = System.Drawing.Color.Black;
            this.lnkRegister.Location = new System.Drawing.Point(307, 356);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(366, 39);
            this.lnkRegister.TabIndex = 5;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "Kayıt olmak için tıklayınız";
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(695, 414);
            this.Controls.Add(this.lnkRegister);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Login";
            this.VisibleChanged += new System.EventHandler(this.Login_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel lnkRegister;
    }
}