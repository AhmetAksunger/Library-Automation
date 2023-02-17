namespace Library_Automation
{
    partial class MemberPanel
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
            this.dataBooksForMembers = new System.Windows.Forms.DataGridView();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYearOfPublication = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalPages = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblLoggedWith = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBooksForMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBooksForMembers
            // 
            this.dataBooksForMembers.AllowUserToDeleteRows = false;
            this.dataBooksForMembers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataBooksForMembers.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataBooksForMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBooksForMembers.Location = new System.Drawing.Point(12, 46);
            this.dataBooksForMembers.MultiSelect = false;
            this.dataBooksForMembers.Name = "dataBooksForMembers";
            this.dataBooksForMembers.ReadOnly = true;
            this.dataBooksForMembers.RowHeadersWidth = 51;
            this.dataBooksForMembers.RowTemplate.Height = 24;
            this.dataBooksForMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBooksForMembers.Size = new System.Drawing.Size(838, 231);
            this.dataBooksForMembers.TabIndex = 1;
            this.dataBooksForMembers.SelectionChanged += new System.EventHandler(this.dataBooksForMembers_SelectionChanged);
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(147, 340);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(155, 22);
            this.txtBookName.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Book Name:";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(147, 382);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.ReadOnly = true;
            this.txtAuthorName.Size = new System.Drawing.Size(155, 22);
            this.txtAuthorName.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Author Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Language:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Pages: ";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(147, 540);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.ReadOnly = true;
            this.txtGenre.Size = new System.Drawing.Size(155, 22);
            this.txtGenre.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 508);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Year of Publication:";
            // 
            // txtYearOfPublication
            // 
            this.txtYearOfPublication.Location = new System.Drawing.Point(147, 502);
            this.txtYearOfPublication.Name = "txtYearOfPublication";
            this.txtYearOfPublication.ReadOnly = true;
            this.txtYearOfPublication.Size = new System.Drawing.Size(155, 22);
            this.txtYearOfPublication.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 543);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Genre:";
            // 
            // txtTotalPages
            // 
            this.txtTotalPages.Location = new System.Drawing.Point(147, 463);
            this.txtTotalPages.Name = "txtTotalPages";
            this.txtTotalPages.ReadOnly = true;
            this.txtTotalPages.Size = new System.Drawing.Size(155, 22);
            this.txtTotalPages.TabIndex = 22;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(147, 422);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.ReadOnly = true;
            this.txtLanguage.Size = new System.Drawing.Size(155, 22);
            this.txtLanguage.TabIndex = 20;
            // 
            // btnBorrow
            // 
            this.btnBorrow.Location = new System.Drawing.Point(348, 536);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnBorrow.TabIndex = 32;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(782, 600);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 30);
            this.btnLogOut.TabIndex = 34;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblLoggedWith
            // 
            this.lblLoggedWith.AutoSize = true;
            this.lblLoggedWith.Location = new System.Drawing.Point(548, 607);
            this.lblLoggedWith.Name = "lblLoggedWith";
            this.lblLoggedWith.Size = new System.Drawing.Size(65, 16);
            this.lblLoggedWith.TabIndex = 33;
            this.lblLoggedWith.Text = "Welcome";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(134, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 22);
            this.txtSearch.TabIndex = 35;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Search Keywords:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(319, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MemberPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 642);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblLoggedWith);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtYearOfPublication);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataBooksForMembers);
            this.Controls.Add(this.txtTotalPages);
            this.Controls.Add(this.txtLanguage);
            this.Name = "MemberPanel";
            this.Text = "MemberPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MemberPanel_FormClosing);
            this.Load += new System.EventHandler(this.MemberPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBooksForMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataBooksForMembers;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYearOfPublication;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalPages;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblLoggedWith;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
    }
}