namespace DitecLibrarySystem
{
    partial class FrmIssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIssueBooks));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblRefCode = new System.Windows.Forms.Label();
            this.btnIssueBooks = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpBarrow = new System.Windows.Forms.DateTimePicker();
            this.btnRefCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ref Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ISBN Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Member ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Barrow Date";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Return Date";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(89, 77);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(120, 20);
            this.txtMemberID.TabIndex = 3;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(89, 48);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(120, 20);
            this.txtISBN.TabIndex = 3;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            // 
            // lblRefCode
            // 
            this.lblRefCode.AutoSize = true;
            this.lblRefCode.Location = new System.Drawing.Point(89, 112);
            this.lblRefCode.Name = "lblRefCode";
            this.lblRefCode.Size = new System.Drawing.Size(52, 13);
            this.lblRefCode.TabIndex = 1;
            this.lblRefCode.Text = "Ref Code";
            // 
            // btnIssueBooks
            // 
            this.btnIssueBooks.Location = new System.Drawing.Point(14, 201);
            this.btnIssueBooks.Name = "btnIssueBooks";
            this.btnIssueBooks.Size = new System.Drawing.Size(332, 27);
            this.btnIssueBooks.TabIndex = 8;
            this.btnIssueBooks.Text = "Issue Book";
            this.btnIssueBooks.UseVisualStyleBackColor = true;
            this.btnIssueBooks.Click += new System.EventHandler(this.btnIssueBooks_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Issue Books";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpReturn
            // 
            this.dtpReturn.Location = new System.Drawing.Point(89, 173);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(200, 20);
            this.dtpReturn.TabIndex = 2;
            // 
            // dtpBarrow
            // 
            this.dtpBarrow.Location = new System.Drawing.Point(89, 141);
            this.dtpBarrow.Name = "dtpBarrow";
            this.dtpBarrow.Size = new System.Drawing.Size(200, 20);
            this.dtpBarrow.TabIndex = 2;
            this.dtpBarrow.ValueChanged += new System.EventHandler(this.dtpBarrow_ValueChanged);
            // 
            // btnRefCode
            // 
            this.btnRefCode.Location = new System.Drawing.Point(230, 106);
            this.btnRefCode.Name = "btnRefCode";
            this.btnRefCode.Size = new System.Drawing.Size(116, 25);
            this.btnRefCode.TabIndex = 4;
            this.btnRefCode.Text = "Generate Ref Code";
            this.btnRefCode.UseVisualStyleBackColor = true;
            this.btnRefCode.Click += new System.EventHandler(this.btnRefCode_Click);
            // 
            // FrmIssueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(361, 238);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIssueBooks);
            this.Controls.Add(this.btnRefCode);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.dtpReturn);
            this.Controls.Add(this.dtpBarrow);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRefCode);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIssueBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Books";
            this.Load += new System.EventHandler(this.FrmIssueBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblRefCode;
        private System.Windows.Forms.Button btnIssueBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.DateTimePicker dtpBarrow;
        private System.Windows.Forms.Button btnRefCode;
    }
}