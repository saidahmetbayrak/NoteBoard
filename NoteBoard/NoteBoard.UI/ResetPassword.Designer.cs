namespace NoteBoard.UI
{
    partial class ResetPassword
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
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewPassA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewPass
            // 
            this.txtNewPass.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewPass.Location = new System.Drawing.Point(340, 139);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(428, 53);
            this.txtNewPass.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(121, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 45);
            this.label5.TabIndex = 21;
            this.label5.Text = "Yeni Parola:";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOldPass.Location = new System.Drawing.Point(340, 45);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(428, 53);
            this.txtOldPass.TabIndex = 20;
            // 
            // txtNewPassA
            // 
            this.txtNewPassA.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewPassA.Location = new System.Drawing.Point(340, 233);
            this.txtNewPassA.Name = "txtNewPassA";
            this.txtNewPassA.Size = new System.Drawing.Size(428, 53);
            this.txtNewPassA.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(19, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 45);
            this.label3.TabIndex = 18;
            this.label3.Text = "Yeni Parola Tekrar:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Coral;
            this.btnReset.Font = new System.Drawing.Font("Candara", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(211, 319);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(557, 89);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Sifre Değiştir";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(124, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Eski Parola:";
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.txtNewPassA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ResetPassword";
            this.Text = "ResetPassword";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResetPassword_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNewPassA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
    }
}