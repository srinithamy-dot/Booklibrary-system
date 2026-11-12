namespace Booklibrary_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpBookDetails = new GroupBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtYear = new TextBox();
            label3 = new Label();
            txtAuthor = new TextBox();
            label2 = new Label();
            txtTitle = new TextBox();
            label1 = new Label();
            txtBookId = new TextBox();
            BookTitle = new Label();
            groupBox1 = new GroupBox();
            btnReturn = new Button();
            btnBorrow = new Button();
            btnAddMember = new Button();
            txtPhone = new TextBox();
            label6 = new Label();
            txtMemberName = new TextBox();
            label5 = new Label();
            txtMemberId = new TextBox();
            label4 = new Label();
            dgvBooks = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label7 = new Label();
            btnShowAll = new Button();
            grpBookDetails.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // grpBookDetails
            // 
            grpBookDetails.Controls.Add(btnClear);
            grpBookDetails.Controls.Add(btnDelete);
            grpBookDetails.Controls.Add(btnAdd);
            grpBookDetails.Controls.Add(txtYear);
            grpBookDetails.Controls.Add(label3);
            grpBookDetails.Controls.Add(txtAuthor);
            grpBookDetails.Controls.Add(label2);
            grpBookDetails.Controls.Add(txtTitle);
            grpBookDetails.Controls.Add(label1);
            grpBookDetails.Controls.Add(txtBookId);
            grpBookDetails.Controls.Add(BookTitle);
            grpBookDetails.Location = new Point(14, 16);
            grpBookDetails.Margin = new Padding(3, 4, 3, 4);
            grpBookDetails.Name = "grpBookDetails";
            grpBookDetails.Padding = new Padding(3, 4, 3, 4);
            grpBookDetails.Size = new Size(343, 350);
            grpBookDetails.TabIndex = 0;
            grpBookDetails.TabStop = false;
            grpBookDetails.Text = "Book Details";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(230, 297);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(138, 297);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(46, 297);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 31);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(34, 248);
            txtYear.Margin = new Padding(3, 4, 3, 4);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(114, 27);
            txtYear.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 224);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 5;
            label3.Text = "Year :";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(34, 184);
            txtAuthor.Margin = new Padding(3, 4, 3, 4);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(114, 27);
            txtAuthor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 160);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 4;
            label2.Text = "Author :";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(37, 116);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(114, 27);
            txtTitle.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 97);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 2;
            label1.Text = "Title :";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(37, 60);
            txtBookId.Margin = new Padding(3, 4, 3, 4);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(114, 27);
            txtBookId.TabIndex = 1;
            txtBookId.TextChanged += txtBookId_TextChanged;
            // 
            // BookTitle
            // 
            BookTitle.AutoSize = true;
            BookTitle.Location = new Point(34, 35);
            BookTitle.Name = "BookTitle";
            BookTitle.Size = new Size(65, 20);
            BookTitle.TabIndex = 0;
            BookTitle.Text = "Book ID:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReturn);
            groupBox1.Controls.Add(btnBorrow);
            groupBox1.Controls.Add(btnAddMember);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtMemberName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtMemberId);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(14, 374);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(343, 297);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Members and Loans";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(188, 207);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(86, 31);
            btnReturn.TabIndex = 8;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnBorrow
            // 
            btnBorrow.Location = new Point(188, 157);
            btnBorrow.Margin = new Padding(3, 4, 3, 4);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(86, 31);
            btnBorrow.TabIndex = 7;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = true;
            // 
            // btnAddMember
            // 
            btnAddMember.Location = new Point(188, 90);
            btnAddMember.Margin = new Padding(3, 4, 3, 4);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(102, 51);
            btnAddMember.TabIndex = 6;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(30, 212);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(114, 27);
            txtPhone.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 188);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 4;
            label6.Text = "Phone";
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(30, 157);
            txtMemberName.Margin = new Padding(3, 4, 3, 4);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(114, 27);
            txtMemberName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 133);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 2;
            label5.Text = "Name";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(30, 102);
            txtMemberId.Margin = new Padding(3, 4, 3, 4);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(114, 27);
            txtMemberId.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 78);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 0;
            label4.Text = "Member ID:";
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(388, 176);
            dgvBooks.Margin = new Padding(3, 4, 3, 4);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(800, 495);
            dgvBooks.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.ImageAlign = ContentAlignment.TopCenter;
            btnSearch.Location = new Point(438, 102);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(438, 57);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(114, 27);
            txtSearch.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(438, 33);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 13;
            label7.Text = "Search";
            // 
            // btnShowAll
            // 
            btnShowAll.ImageAlign = ContentAlignment.TopCenter;
            btnShowAll.Location = new Point(554, 102);
            btnShowAll.Margin = new Padding(3, 4, 3, 4);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(86, 31);
            btnShowAll.TabIndex = 17;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 691);
            Controls.Add(btnShowAll);
            Controls.Add(dgvBooks);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(grpBookDetails);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Library system";
            Load += Form1_Load;
            grpBookDetails.ResumeLayout(false);
            grpBookDetails.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpBookDetails;
        private Label BookTitle;
        private Label label1;
        private TextBox txtBookId;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Label label2;
       
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtYear;
        private Label label3;
        private Button btnClear;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtMemberId;
        private Label label5;
        private TextBox txtMemberName;
        private Button btnAddMember;
        private TextBox txtPhone;
        private Label label6;
        private Button btnBorrow;
        private Button btnReturn;
        private DataGridView dgvBooks;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label7;
        private Button btnShowAll;
    }
}
