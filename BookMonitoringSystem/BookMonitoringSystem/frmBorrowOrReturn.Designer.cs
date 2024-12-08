namespace BookMonitoringSystem
{
    partial class frmBorrowOrReturn
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
            this.grbBorrowerRecords = new System.Windows.Forms.GroupBox();
            this.cbxSearchBorrower = new System.Windows.Forms.ComboBox();
            this.txbSearchBorrower = new System.Windows.Forms.TextBox();
            this.gridBorrower = new System.Windows.Forms.DataGridView();
            this.grbBookRecords = new System.Windows.Forms.GroupBox();
            this.cbxSearchBook = new System.Windows.Forms.ComboBox();
            this.gridBooks = new System.Windows.Forms.DataGridView();
            this.txbSearchBook = new System.Windows.Forms.TextBox();
            this.grbBookDetails = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.gridBorrowedbooks = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblErrorSave = new System.Windows.Forms.Label();
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbBookID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbContact = new System.Windows.Forms.TextBox();
            this.label1234 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbLastname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbFirstname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbBorrowerID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grbBorrowerRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBorrower)).BeginInit();
            this.grbBookRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
            this.grbBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBorrowedbooks)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBorrowerRecords
            // 
            this.grbBorrowerRecords.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbBorrowerRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbBorrowerRecords.Controls.Add(this.cbxSearchBorrower);
            this.grbBorrowerRecords.Controls.Add(this.txbSearchBorrower);
            this.grbBorrowerRecords.Controls.Add(this.gridBorrower);
            this.grbBorrowerRecords.ForeColor = System.Drawing.Color.Black;
            this.grbBorrowerRecords.Location = new System.Drawing.Point(328, 209);
            this.grbBorrowerRecords.Name = "grbBorrowerRecords";
            this.grbBorrowerRecords.Size = new System.Drawing.Size(296, 281);
            this.grbBorrowerRecords.TabIndex = 7;
            this.grbBorrowerRecords.TabStop = false;
            this.grbBorrowerRecords.Text = "Borrower Records";
            // 
            // cbxSearchBorrower
            // 
            this.cbxSearchBorrower.FormattingEnabled = true;
            this.cbxSearchBorrower.Items.AddRange(new object[] {
            "Borrower ID",
            "Firstname",
            "Lastname",
            "Contact No"});
            this.cbxSearchBorrower.Location = new System.Drawing.Point(6, 25);
            this.cbxSearchBorrower.Name = "cbxSearchBorrower";
            this.cbxSearchBorrower.Size = new System.Drawing.Size(79, 21);
            this.cbxSearchBorrower.TabIndex = 18;
            this.cbxSearchBorrower.Text = "Search by:";
            this.cbxSearchBorrower.SelectedIndexChanged += new System.EventHandler(this.cbxSearchBorrower_SelectedIndexChanged);
            // 
            // txbSearchBorrower
            // 
            this.txbSearchBorrower.Enabled = false;
            this.txbSearchBorrower.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbSearchBorrower.Location = new System.Drawing.Point(91, 26);
            this.txbSearchBorrower.Name = "txbSearchBorrower";
            this.txbSearchBorrower.Size = new System.Drawing.Size(196, 20);
            this.txbSearchBorrower.TabIndex = 17;
            this.txbSearchBorrower.TextChanged += new System.EventHandler(this.txbSearchBorrower_TextChanged_1);
            // 
            // gridBorrower
            // 
            this.gridBorrower.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridBorrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBorrower.Location = new System.Drawing.Point(6, 55);
            this.gridBorrower.Name = "gridBorrower";
            this.gridBorrower.Size = new System.Drawing.Size(281, 200);
            this.gridBorrower.TabIndex = 6;
            this.gridBorrower.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBorrower_CellClick_1);
            // 
            // grbBookRecords
            // 
            this.grbBookRecords.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbBookRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbBookRecords.Controls.Add(this.cbxSearchBook);
            this.grbBookRecords.Controls.Add(this.gridBooks);
            this.grbBookRecords.Controls.Add(this.txbSearchBook);
            this.grbBookRecords.ForeColor = System.Drawing.Color.Black;
            this.grbBookRecords.Location = new System.Drawing.Point(328, 3);
            this.grbBookRecords.Name = "grbBookRecords";
            this.grbBookRecords.Size = new System.Drawing.Size(296, 196);
            this.grbBookRecords.TabIndex = 8;
            this.grbBookRecords.TabStop = false;
            this.grbBookRecords.Text = "Book Records";
            // 
            // cbxSearchBook
            // 
            this.cbxSearchBook.FormattingEnabled = true;
            this.cbxSearchBook.Items.AddRange(new object[] {
            "Book ID",
            "Title",
            "Author"});
            this.cbxSearchBook.Location = new System.Drawing.Point(6, 19);
            this.cbxSearchBook.Name = "cbxSearchBook";
            this.cbxSearchBook.Size = new System.Drawing.Size(79, 21);
            this.cbxSearchBook.TabIndex = 14;
            this.cbxSearchBook.Text = "Search by:";
            this.cbxSearchBook.SelectedIndexChanged += new System.EventHandler(this.cbxSearchBook_SelectedIndexChanged);
            // 
            // gridBooks
            // 
            this.gridBooks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBooks.Enabled = false;
            this.gridBooks.Location = new System.Drawing.Point(6, 46);
            this.gridBooks.Name = "gridBooks";
            this.gridBooks.Size = new System.Drawing.Size(281, 133);
            this.gridBooks.TabIndex = 6;
            this.gridBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBooks_CellClick);
            // 
            // txbSearchBook
            // 
            this.txbSearchBook.Enabled = false;
            this.txbSearchBook.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbSearchBook.Location = new System.Drawing.Point(91, 20);
            this.txbSearchBook.Name = "txbSearchBook";
            this.txbSearchBook.Size = new System.Drawing.Size(196, 20);
            this.txbSearchBook.TabIndex = 11;
            this.txbSearchBook.TextChanged += new System.EventHandler(this.txbSearchBook_TextChanged_2);
            // 
            // grbBookDetails
            // 
            this.grbBookDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbBookDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbBookDetails.Controls.Add(this.btnReturn);
            this.grbBookDetails.Controls.Add(this.lblDate);
            this.grbBookDetails.Controls.Add(this.gridBorrowedbooks);
            this.grbBookDetails.Controls.Add(this.btnClear);
            this.grbBookDetails.Controls.Add(this.txbStatus);
            this.grbBookDetails.Controls.Add(this.label10);
            this.grbBookDetails.Controls.Add(this.lblErrorSave);
            this.grbBookDetails.Controls.Add(this.txbAuthor);
            this.grbBookDetails.Controls.Add(this.btnBorrow);
            this.grbBookDetails.Controls.Add(this.label3);
            this.grbBookDetails.Controls.Add(this.txbTitle);
            this.grbBookDetails.Controls.Add(this.label2);
            this.grbBookDetails.Controls.Add(this.txbBookID);
            this.grbBookDetails.Controls.Add(this.label4);
            this.grbBookDetails.ForeColor = System.Drawing.Color.White;
            this.grbBookDetails.Location = new System.Drawing.Point(10, 142);
            this.grbBookDetails.Name = "grbBookDetails";
            this.grbBookDetails.Size = new System.Drawing.Size(295, 333);
            this.grbBookDetails.TabIndex = 9;
            this.grbBookDetails.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Silver;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReturn.Enabled = false;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(200, 43);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(82, 23);
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Location = new System.Drawing.Point(662, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 13);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "<<date>>";
            // 
            // gridBorrowedbooks
            // 
            this.gridBorrowedbooks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridBorrowedbooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBorrowedbooks.Enabled = false;
            this.gridBorrowedbooks.Location = new System.Drawing.Point(6, 116);
            this.gridBorrowedbooks.Name = "gridBorrowedbooks";
            this.gridBorrowedbooks.Size = new System.Drawing.Size(276, 203);
            this.gridBorrowedbooks.TabIndex = 12;
            this.gridBorrowedbooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBorrowedbooks_CellClick);
            this.gridBorrowedbooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBorrowedbooks_CellContentClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(200, 72);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 23);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txbStatus
            // 
            this.txbStatus.Enabled = false;
            this.txbStatus.Location = new System.Drawing.Point(83, 90);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(99, 20);
            this.txbStatus.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Status";
            // 
            // lblErrorSave
            // 
            this.lblErrorSave.AutoSize = true;
            this.lblErrorSave.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSave.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSave.Location = new System.Drawing.Point(18, 108);
            this.lblErrorSave.Name = "lblErrorSave";
            this.lblErrorSave.Size = new System.Drawing.Size(0, 13);
            this.lblErrorSave.TabIndex = 5;
            // 
            // txbAuthor
            // 
            this.txbAuthor.Enabled = false;
            this.txbAuthor.Location = new System.Drawing.Point(83, 64);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(99, 20);
            this.txbAuthor.TabIndex = 3;
            // 
            // btnBorrow
            // 
            this.btnBorrow.BackColor = System.Drawing.Color.Silver;
            this.btnBorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBorrow.Enabled = false;
            this.btnBorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrow.ForeColor = System.Drawing.Color.Black;
            this.btnBorrow.Location = new System.Drawing.Point(200, 14);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(82, 23);
            this.btnBorrow.TabIndex = 4;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author";
            // 
            // txbTitle
            // 
            this.txbTitle.Enabled = false;
            this.txbTitle.Location = new System.Drawing.Point(83, 38);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(99, 20);
            this.txbTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title";
            // 
            // txbBookID
            // 
            this.txbBookID.Enabled = false;
            this.txbBookID.Location = new System.Drawing.Point(83, 13);
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.Size = new System.Drawing.Size(99, 20);
            this.txbBookID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.txbContact);
            this.groupBox2.Controls.Add(this.label1234);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbLastname);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txbFirstname);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txbBorrowerID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(10, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 117);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txbContact
            // 
            this.txbContact.Enabled = false;
            this.txbContact.Location = new System.Drawing.Point(83, 85);
            this.txbContact.Name = "txbContact";
            this.txbContact.Size = new System.Drawing.Size(199, 20);
            this.txbContact.TabIndex = 10;
            // 
            // label1234
            // 
            this.label1234.AutoSize = true;
            this.label1234.BackColor = System.Drawing.Color.Transparent;
            this.label1234.ForeColor = System.Drawing.Color.Black;
            this.label1234.Location = new System.Drawing.Point(6, 88);
            this.label1234.Name = "label1234";
            this.label1234.Size = new System.Drawing.Size(64, 13);
            this.label1234.TabIndex = 11;
            this.label1234.Text = "Contact No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(18, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 5;
            // 
            // txbLastname
            // 
            this.txbLastname.Enabled = false;
            this.txbLastname.Location = new System.Drawing.Point(83, 59);
            this.txbLastname.Name = "txbLastname";
            this.txbLastname.Size = new System.Drawing.Size(199, 20);
            this.txbLastname.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Last Name";
            // 
            // txbFirstname
            // 
            this.txbFirstname.Enabled = false;
            this.txbFirstname.Location = new System.Drawing.Point(83, 36);
            this.txbFirstname.Name = "txbFirstname";
            this.txbFirstname.Size = new System.Drawing.Size(199, 20);
            this.txbFirstname.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "First Name";
            // 
            // txbBorrowerID
            // 
            this.txbBorrowerID.Enabled = false;
            this.txbBorrowerID.Location = new System.Drawing.Point(83, 12);
            this.txbBorrowerID.Name = "txbBorrowerID";
            this.txbBorrowerID.Size = new System.Drawing.Size(199, 20);
            this.txbBorrowerID.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Borrower ID";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.grbBookDetails);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 487);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borrower Details";
            // 
            // frmBorrowOrReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BookMonitoringSystem.Properties.Resources.inaki_del_olmo_NIJuEQw0RKg_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(635, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbBookRecords);
            this.Controls.Add(this.grbBorrowerRecords);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmBorrowOrReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Or Return Books";
            this.Load += new System.EventHandler(this.frmBorrow_Load);
            this.grbBorrowerRecords.ResumeLayout(false);
            this.grbBorrowerRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBorrower)).EndInit();
            this.grbBookRecords.ResumeLayout(false);
            this.grbBookRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            this.grbBookDetails.ResumeLayout(false);
            this.grbBookDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBorrowedbooks)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBorrowerRecords;
        private System.Windows.Forms.DataGridView gridBorrower;
        private System.Windows.Forms.GroupBox grbBookRecords;
        private System.Windows.Forms.DataGridView gridBooks;
        private System.Windows.Forms.TextBox txbSearchBook;
        private System.Windows.Forms.GroupBox grbBookDetails;
        private System.Windows.Forms.DataGridView gridBorrowedbooks;
        private System.Windows.Forms.Label lblErrorSave;
        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbBookID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbContact;
        private System.Windows.Forms.Label label1234;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbLastname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbFirstname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbBorrowerID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cbxSearchBook;
        private System.Windows.Forms.ComboBox cbxSearchBorrower;
        private System.Windows.Forms.TextBox txbSearchBorrower;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}