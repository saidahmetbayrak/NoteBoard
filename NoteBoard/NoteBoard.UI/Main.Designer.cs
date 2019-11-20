namespace NoteBoard.UI
{
    partial class Main
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
            this.lstNotes = new System.Windows.Forms.ListBox();
            this.lnkPassChange = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSavve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstNotes
            // 
            this.lstNotes.FormattingEnabled = true;
            this.lstNotes.ItemHeight = 25;
            this.lstNotes.Location = new System.Drawing.Point(18, 71);
            this.lstNotes.Name = "lstNotes";
            this.lstNotes.Size = new System.Drawing.Size(371, 654);
            this.lstNotes.TabIndex = 0;
            // 
            // lnkPassChange
            // 
            this.lnkPassChange.AutoSize = true;
            this.lnkPassChange.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkPassChange.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkPassChange.LinkColor = System.Drawing.Color.Black;
            this.lnkPassChange.Location = new System.Drawing.Point(789, 9);
            this.lnkPassChange.Name = "lnkPassChange";
            this.lnkPassChange.Size = new System.Drawing.Size(197, 39);
            this.lnkPassChange.TabIndex = 1;
            this.lnkPassChange.TabStop = true;
            this.lnkPassChange.Text = "Sifre Değiştir";
            this.lnkPassChange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPassChange_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(429, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlik:";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTitle.Location = new System.Drawing.Point(558, 66);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(428, 53);
            this.txtTitle.TabIndex = 8;
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtContent.Location = new System.Drawing.Point(558, 158);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(428, 449);
            this.txtContent.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(429, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 45);
            this.label2.TabIndex = 9;
            this.label2.Text = "İçerik:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Coral;
            this.btnDelete.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(424, 642);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(264, 83);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSavve
            // 
            this.btnSavve.BackColor = System.Drawing.Color.Coral;
            this.btnSavve.Font = new System.Drawing.Font("Candara", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSavve.ForeColor = System.Drawing.Color.White;
            this.btnSavve.Location = new System.Drawing.Point(722, 642);
            this.btnSavve.Name = "btnSavve";
            this.btnSavve.Size = new System.Drawing.Size(264, 83);
            this.btnSavve.TabIndex = 12;
            this.btnSavve.Text = "Kaydet";
            this.btnSavve.UseVisualStyleBackColor = false;
            this.btnSavve.Click += new System.EventHandler(this.btnSavve_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1013, 775);
            this.Controls.Add(this.btnSavve);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkPassChange);
            this.Controls.Add(this.lstNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNotes;
        private System.Windows.Forms.LinkLabel lnkPassChange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSavve;
    }
}