namespace Library_Automation
{
    partial class BookManagerForm
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
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.groupBoxAdminBooks = new System.Windows.Forms.GroupBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBookAmount = new System.Windows.Forms.TextBox();
            this.txtYearOfPublication = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtTotalPages = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grouBoxBookLogs = new System.Windows.Forms.GroupBox();
            this.dataBookLogs = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.groupBoxAdminBooks.SuspendLayout();
            this.grouBoxBookLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBookLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewBooks.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(1, 32);
            this.dataGridViewBooks.MultiSelect = false;
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.RowHeadersWidth = 51;
            this.dataGridViewBooks.RowTemplate.Height = 24;
            this.dataGridViewBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBooks.Size = new System.Drawing.Size(1026, 251);
            this.dataGridViewBooks.TabIndex = 0;
            this.dataGridViewBooks.SelectionChanged += new System.EventHandler(this.dataGridViewBooks_SelectionChanged);
            // 
            // groupBoxAdminBooks
            // 
            this.groupBoxAdminBooks.Controls.Add(this.txtAuthorName);
            this.groupBoxAdminBooks.Controls.Add(this.label7);
            this.groupBoxAdminBooks.Controls.Add(this.label8);
            this.groupBoxAdminBooks.Controls.Add(this.btnClear);
            this.groupBoxAdminBooks.Controls.Add(this.btnDelete);
            this.groupBoxAdminBooks.Controls.Add(this.label4);
            this.groupBoxAdminBooks.Controls.Add(this.btnUpdate);
            this.groupBoxAdminBooks.Controls.Add(this.label5);
            this.groupBoxAdminBooks.Controls.Add(this.btnAdd);
            this.groupBoxAdminBooks.Controls.Add(this.txtGenre);
            this.groupBoxAdminBooks.Controls.Add(this.label9);
            this.groupBoxAdminBooks.Controls.Add(this.txtBookAmount);
            this.groupBoxAdminBooks.Controls.Add(this.txtYearOfPublication);
            this.groupBoxAdminBooks.Controls.Add(this.txtID);
            this.groupBoxAdminBooks.Controls.Add(this.label6);
            this.groupBoxAdminBooks.Controls.Add(this.txtBookName);
            this.groupBoxAdminBooks.Controls.Add(this.txtTotalPages);
            this.groupBoxAdminBooks.Controls.Add(this.label2);
            this.groupBoxAdminBooks.Controls.Add(this.txtLanguage);
            this.groupBoxAdminBooks.Controls.Add(this.label1);
            this.groupBoxAdminBooks.Location = new System.Drawing.Point(12, 303);
            this.groupBoxAdminBooks.Name = "groupBoxAdminBooks";
            this.groupBoxAdminBooks.Size = new System.Drawing.Size(463, 435);
            this.groupBoxAdminBooks.TabIndex = 1;
            this.groupBoxAdminBooks.TabStop = false;
            this.groupBoxAdminBooks.Text = "Book Manager";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(131, 176);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(155, 22);
            this.txtAuthorName.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Author Name:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(208, 391);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(340, 274);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Language:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(340, 201);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Pages: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(340, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(131, 334);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(155, 22);
            this.txtGenre.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-3, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Year of Publication:";
            // 
            // txtBookAmount
            // 
            this.txtBookAmount.Location = new System.Drawing.Point(131, 139);
            this.txtBookAmount.Name = "txtBookAmount";
            this.txtBookAmount.Size = new System.Drawing.Size(155, 22);
            this.txtBookAmount.TabIndex = 18;
            // 
            // txtYearOfPublication
            // 
            this.txtYearOfPublication.Location = new System.Drawing.Point(131, 296);
            this.txtYearOfPublication.Name = "txtYearOfPublication";
            this.txtYearOfPublication.Size = new System.Drawing.Size(155, 22);
            this.txtYearOfPublication.TabIndex = 22;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 59);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(155, 22);
            this.txtID.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Genre:";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(131, 104);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(155, 22);
            this.txtBookName.TabIndex = 17;
            // 
            // txtTotalPages
            // 
            this.txtTotalPages.Location = new System.Drawing.Point(131, 257);
            this.txtTotalPages.Name = "txtTotalPages";
            this.txtTotalPages.Size = new System.Drawing.Size(155, 22);
            this.txtTotalPages.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Book Amount: ";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(131, 216);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(155, 22);
            this.txtLanguage.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Book Name:";
            // 
            // grouBoxBookLogs
            // 
            this.grouBoxBookLogs.Controls.Add(this.dataBookLogs);
            this.grouBoxBookLogs.Location = new System.Drawing.Point(533, 303);
            this.grouBoxBookLogs.Name = "grouBoxBookLogs";
            this.grouBoxBookLogs.Size = new System.Drawing.Size(452, 435);
            this.grouBoxBookLogs.TabIndex = 29;
            this.grouBoxBookLogs.TabStop = false;
            this.grouBoxBookLogs.Text = "Book Logs";
            // 
            // dataBookLogs
            // 
            this.dataBookLogs.AllowUserToDeleteRows = false;
            this.dataBookLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataBookLogs.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataBookLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBookLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataBookLogs.Location = new System.Drawing.Point(3, 18);
            this.dataBookLogs.MultiSelect = false;
            this.dataBookLogs.Name = "dataBookLogs";
            this.dataBookLogs.ReadOnly = true;
            this.dataBookLogs.RowHeadersWidth = 51;
            this.dataBookLogs.RowTemplate.Height = 24;
            this.dataBookLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBookLogs.Size = new System.Drawing.Size(446, 414);
            this.dataBookLogs.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(312, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 40;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Search Keywords:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(127, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 22);
            this.txtSearch.TabIndex = 38;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // BookManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 779);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.grouBoxBookLogs);
            this.Controls.Add(this.groupBoxAdminBooks);
            this.Controls.Add(this.dataGridViewBooks);
            this.Name = "BookManagerForm";
            this.Text = "Book Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookManagerForm_FormClosing);
            this.Load += new System.EventHandler(this.BookManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.groupBoxAdminBooks.ResumeLayout(false);
            this.groupBoxAdminBooks.PerformLayout();
            this.grouBoxBookLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataBookLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.GroupBox groupBoxAdminBooks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBookAmount;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grouBoxBookLogs;
        public System.Windows.Forms.DataGridView dataBookLogs;
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
    }
}