﻿namespace BookMonitoringSystem
{
    partial class frmBorrower
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
            this.lblErrorSearch = new System.Windows.Forms.Label();
            this.txbSearchBox1 = new System.Windows.Forms.TextBox();
            this.grbBookRecords = new System.Windows.Forms.GroupBox();
            this.cbxSearch1 = new System.Windows.Forms.ComboBox();
            this.dataGridView11 = new System.Windows.Forms.DataGridView();
            this.lblErrorSave = new System.Windows.Forms.Label();
            this.btnClear1 = new System.Windows.Forms.Button();
            this.btnEdit1 = new System.Windows.Forms.Button();
            this.txbLastname = new System.Windows.Forms.TextBox();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete1 = new System.Windows.Forms.Button();
            this.txbFirstname = new System.Windows.Forms.TextBox();
            this.btnUpdate1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grbBookDetails = new System.Windows.Forms.GroupBox();
            this.txbContactNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbBorrowerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.grbBookRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            this.grbBookDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblErrorSearch
            // 
            this.lblErrorSearch.AutoSize = true;
            this.lblErrorSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorSearch.ForeColor = System.Drawing.Color.White;
            this.lblErrorSearch.Location = new System.Drawing.Point(106, 55);
            this.lblErrorSearch.Name = "lblErrorSearch";
            this.lblErrorSearch.Size = new System.Drawing.Size(0, 13);
            this.lblErrorSearch.TabIndex = 9;
            // 
            // txbSearchBox1
            // 
            this.txbSearchBox1.Enabled = false;
            this.txbSearchBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbSearchBox1.Location = new System.Drawing.Point(181, 24);
            this.txbSearchBox1.Name = "txbSearchBox1";
            this.txbSearchBox1.Size = new System.Drawing.Size(191, 20);
            this.txbSearchBox1.TabIndex = 11;
            this.txbSearchBox1.TextChanged += new System.EventHandler(this.txbSearchBox_TextChanged);
            // 
            // grbBookRecords
            // 
            this.grbBookRecords.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbBookRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbBookRecords.Controls.Add(this.lblErrorSearch);
            this.grbBookRecords.Controls.Add(this.cbxSearch1);
            this.grbBookRecords.Controls.Add(this.dataGridView11);
            this.grbBookRecords.Controls.Add(this.txbSearchBox1);
            this.grbBookRecords.ForeColor = System.Drawing.Color.Black;
            this.grbBookRecords.Location = new System.Drawing.Point(12, 154);
            this.grbBookRecords.Name = "grbBookRecords";
            this.grbBookRecords.Size = new System.Drawing.Size(413, 241);
            this.grbBookRecords.TabIndex = 6;
            this.grbBookRecords.TabStop = false;
            this.grbBookRecords.Text = "Borrower Records";
            // 
            // cbxSearch1
            // 
            this.cbxSearch1.FormattingEnabled = true;
            this.cbxSearch1.Items.AddRange(new object[] {
            "Borrower ID",
            "Firstname",
            "Lastname",
            "Contact No."});
            this.cbxSearch1.Location = new System.Drawing.Point(96, 23);
            this.cbxSearch1.Name = "cbxSearch1";
            this.cbxSearch1.Size = new System.Drawing.Size(79, 21);
            this.cbxSearch1.TabIndex = 10;
            this.cbxSearch1.Text = "Search by:";
            this.cbxSearch1.SelectedIndexChanged += new System.EventHandler(this.cbxSearch_SelectedIndexChanged);
            // 
            // dataGridView11
            // 
            this.dataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView11.Location = new System.Drawing.Point(9, 55);
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.Size = new System.Drawing.Size(392, 180);
            this.dataGridView11.TabIndex = 6;
            this.dataGridView11.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView11_CellContentClick);
            // 
            // lblErrorSave
            // 
            this.lblErrorSave.AutoSize = true;
            this.lblErrorSave.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSave.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSave.Location = new System.Drawing.Point(18, 137);
            this.lblErrorSave.Name = "lblErrorSave";
            this.lblErrorSave.Size = new System.Drawing.Size(0, 13);
            this.lblErrorSave.TabIndex = 5;
            // 
            // btnClear1
            // 
            this.btnClear1.BackColor = System.Drawing.Color.Silver;
            this.btnClear1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear1.ForeColor = System.Drawing.Color.Black;
            this.btnClear1.Location = new System.Drawing.Point(326, 81);
            this.btnClear1.Name = "btnClear1";
            this.btnClear1.Size = new System.Drawing.Size(75, 23);
            this.btnClear1.TabIndex = 9;
            this.btnClear1.Text = "Clear";
            this.btnClear1.UseVisualStyleBackColor = false;
            this.btnClear1.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit1
            // 
            this.btnEdit1.BackColor = System.Drawing.Color.Silver;
            this.btnEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit1.ForeColor = System.Drawing.Color.Black;
            this.btnEdit1.Location = new System.Drawing.Point(245, 51);
            this.btnEdit1.Name = "btnEdit1";
            this.btnEdit1.Size = new System.Drawing.Size(75, 23);
            this.btnEdit1.TabIndex = 6;
            this.btnEdit1.Text = "Edit";
            this.btnEdit1.UseVisualStyleBackColor = false;
            this.btnEdit1.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txbLastname
            // 
            this.txbLastname.Enabled = false;
            this.txbLastname.Location = new System.Drawing.Point(101, 77);
            this.txbLastname.Name = "txbLastname";
            this.txbLastname.Size = new System.Drawing.Size(115, 20);
            this.txbLastname.TabIndex = 3;
            // 
            // btnAdd1
            // 
            this.btnAdd1.BackColor = System.Drawing.Color.Silver;
            this.btnAdd1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd1.ForeColor = System.Drawing.Color.Black;
            this.btnAdd1.Location = new System.Drawing.Point(245, 23);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(75, 23);
            this.btnAdd1.TabIndex = 4;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = false;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // btnDelete1
            // 
            this.btnDelete1.BackColor = System.Drawing.Color.Silver;
            this.btnDelete1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete1.ForeColor = System.Drawing.Color.Black;
            this.btnDelete1.Location = new System.Drawing.Point(245, 80);
            this.btnDelete1.Name = "btnDelete1";
            this.btnDelete1.Size = new System.Drawing.Size(75, 23);
            this.btnDelete1.TabIndex = 8;
            this.btnDelete1.Text = "Delete";
            this.btnDelete1.UseVisualStyleBackColor = false;
            this.btnDelete1.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbFirstname
            // 
            this.txbFirstname.Enabled = false;
            this.txbFirstname.Location = new System.Drawing.Point(101, 51);
            this.txbFirstname.Name = "txbFirstname";
            this.txbFirstname.Size = new System.Drawing.Size(115, 20);
            this.txbFirstname.TabIndex = 2;
            this.txbFirstname.TextChanged += new System.EventHandler(this.txbFirstname_TextChanged);
            // 
            // btnUpdate1
            // 
            this.btnUpdate1.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate1.Enabled = false;
            this.btnUpdate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate1.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate1.Location = new System.Drawing.Point(326, 52);
            this.btnUpdate1.Name = "btnUpdate1";
            this.btnUpdate1.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate1.TabIndex = 7;
            this.btnUpdate1.Text = "Update";
            this.btnUpdate1.UseVisualStyleBackColor = false;
            this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // grbBookDetails
            // 
            this.grbBookDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbBookDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbBookDetails.Controls.Add(this.txbContactNo);
            this.grbBookDetails.Controls.Add(this.label4);
            this.grbBookDetails.Controls.Add(this.lblErrorSave);
            this.grbBookDetails.Controls.Add(this.btnClear1);
            this.grbBookDetails.Controls.Add(this.btnEdit1);
            this.grbBookDetails.Controls.Add(this.txbLastname);
            this.grbBookDetails.Controls.Add(this.btnAdd1);
            this.grbBookDetails.Controls.Add(this.label3);
            this.grbBookDetails.Controls.Add(this.btnDelete1);
            this.grbBookDetails.Controls.Add(this.txbFirstname);
            this.grbBookDetails.Controls.Add(this.btnUpdate1);
            this.grbBookDetails.Controls.Add(this.label2);
            this.grbBookDetails.Controls.Add(this.txbBorrowerID);
            this.grbBookDetails.Controls.Add(this.label1);
            this.grbBookDetails.Controls.Add(this.btnSave1);
            this.grbBookDetails.ForeColor = System.Drawing.Color.Black;
            this.grbBookDetails.Location = new System.Drawing.Point(12, 12);
            this.grbBookDetails.Name = "grbBookDetails";
            this.grbBookDetails.Size = new System.Drawing.Size(413, 136);
            this.grbBookDetails.TabIndex = 5;
            this.grbBookDetails.TabStop = false;
            this.grbBookDetails.Text = "Borrower Details";
            // 
            // txbContactNo
            // 
            this.txbContactNo.Enabled = false;
            this.txbContactNo.Location = new System.Drawing.Point(101, 107);
            this.txbContactNo.Name = "txbContactNo";
            this.txbContactNo.Size = new System.Drawing.Size(115, 20);
            this.txbContactNo.TabIndex = 10;
            this.txbContactNo.TextChanged += new System.EventHandler(this.txbContNum_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contact No.";
            // 
            // txbBorrowerID
            // 
            this.txbBorrowerID.Enabled = false;
            this.txbBorrowerID.Location = new System.Drawing.Point(101, 25);
            this.txbBorrowerID.Name = "txbBorrowerID";
            this.txbBorrowerID.Size = new System.Drawing.Size(115, 20);
            this.txbBorrowerID.TabIndex = 1;
            this.txbBorrowerID.TextChanged += new System.EventHandler(this.txbBorrowerID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrower ID";
            // 
            // btnSave1
            // 
            this.btnSave1.BackColor = System.Drawing.Color.Silver;
            this.btnSave1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave1.Enabled = false;
            this.btnSave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave1.ForeColor = System.Drawing.Color.Black;
            this.btnSave1.Location = new System.Drawing.Point(326, 23);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(75, 23);
            this.btnSave1.TabIndex = 5;
            this.btnSave1.Text = "Save";
            this.btnSave1.UseVisualStyleBackColor = false;
            this.btnSave1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookMonitoringSystem.Properties.Resources.inaki_del_olmo_NIJuEQw0RKg_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(436, 401);
            this.Controls.Add(this.grbBookRecords);
            this.Controls.Add(this.grbBookDetails);
            this.DoubleBuffered = true;
            this.Name = "frmBorrower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrowers";
            this.Load += new System.EventHandler(this.Borrower_Load);
            this.grbBookRecords.ResumeLayout(false);
            this.grbBookRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            this.grbBookDetails.ResumeLayout(false);
            this.grbBookDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblErrorSearch;
        private System.Windows.Forms.TextBox txbSearchBox1;
        private System.Windows.Forms.GroupBox grbBookRecords;
        private System.Windows.Forms.ComboBox cbxSearch1;
        private System.Windows.Forms.DataGridView dataGridView11;
        private System.Windows.Forms.Label lblErrorSave;
        private System.Windows.Forms.Button btnClear1;
        private System.Windows.Forms.Button btnEdit1;
        private System.Windows.Forms.TextBox txbLastname;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete1;
        private System.Windows.Forms.TextBox txbFirstname;
        private System.Windows.Forms.Button btnUpdate1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbBookDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.TextBox txbContactNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbBorrowerID;
    }
}