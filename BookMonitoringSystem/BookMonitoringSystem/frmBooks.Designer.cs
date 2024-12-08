namespace BookMonitoringSystem
{
    partial class frmBooks
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
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBookID = new System.Windows.Forms.TextBox();
            this.grbBookDetails = new System.Windows.Forms.GroupBox();
            this.lblErrorSave = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbTitle = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.grbBookRecords = new System.Windows.Forms.GroupBox();
            this.lblErrorSearch = new System.Windows.Forms.Label();
            this.cbxSearch = new System.Windows.Forms.ComboBox();
            this.txbSearchBox = new System.Windows.Forms.TextBox();
            this.grbBookDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.grbBookRecords.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Silver;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(290, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book ID";
            // 
            // txbBookID
            // 
            this.txbBookID.Enabled = false;
            this.txbBookID.Location = new System.Drawing.Point(54, 28);
            this.txbBookID.Name = "txbBookID";
            this.txbBookID.Size = new System.Drawing.Size(135, 20);
            this.txbBookID.TabIndex = 1;
            this.txbBookID.TextChanged += new System.EventHandler(this.txbBookID_TextChanged);
            // 
            // grbBookDetails
            // 
            this.grbBookDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbBookDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbBookDetails.Controls.Add(this.lblErrorSave);
            this.grbBookDetails.Controls.Add(this.btnClear);
            this.grbBookDetails.Controls.Add(this.btnEdit);
            this.grbBookDetails.Controls.Add(this.txbAuthor);
            this.grbBookDetails.Controls.Add(this.btnAdd);
            this.grbBookDetails.Controls.Add(this.label3);
            this.grbBookDetails.Controls.Add(this.btnDelete);
            this.grbBookDetails.Controls.Add(this.txbTitle);
            this.grbBookDetails.Controls.Add(this.btnUpdate);
            this.grbBookDetails.Controls.Add(this.label2);
            this.grbBookDetails.Controls.Add(this.txbBookID);
            this.grbBookDetails.Controls.Add(this.label1);
            this.grbBookDetails.Controls.Add(this.btnSave);
            this.grbBookDetails.ForeColor = System.Drawing.Color.Black;
            this.grbBookDetails.Location = new System.Drawing.Point(12, 12);
            this.grbBookDetails.Name = "grbBookDetails";
            this.grbBookDetails.Size = new System.Drawing.Size(373, 129);
            this.grbBookDetails.TabIndex = 3;
            this.grbBookDetails.TabStop = false;
            this.grbBookDetails.Text = "Book Details";
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
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(290, 78);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Silver;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(209, 53);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txbAuthor
            // 
            this.txbAuthor.Enabled = false;
            this.txbAuthor.Location = new System.Drawing.Point(54, 81);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(135, 20);
            this.txbAuthor.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(209, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Author";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(209, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbTitle
            // 
            this.txbTitle.Enabled = false;
            this.txbTitle.Location = new System.Drawing.Point(54, 53);
            this.txbTitle.Name = "txbTitle";
            this.txbTitle.Size = new System.Drawing.Size(135, 20);
            this.txbTitle.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(290, 53);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Title";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 55);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(361, 180);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // grbBookRecords
            // 
            this.grbBookRecords.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grbBookRecords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbBookRecords.Controls.Add(this.lblErrorSearch);
            this.grbBookRecords.Controls.Add(this.cbxSearch);
            this.grbBookRecords.Controls.Add(this.dataGridView2);
            this.grbBookRecords.Controls.Add(this.txbSearchBox);
            this.grbBookRecords.ForeColor = System.Drawing.Color.Black;
            this.grbBookRecords.Location = new System.Drawing.Point(12, 147);
            this.grbBookRecords.Name = "grbBookRecords";
            this.grbBookRecords.Size = new System.Drawing.Size(373, 241);
            this.grbBookRecords.TabIndex = 4;
            this.grbBookRecords.TabStop = false;
            this.grbBookRecords.Text = "Book Records";
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
            // cbxSearch
            // 
            this.cbxSearch.FormattingEnabled = true;
            this.cbxSearch.Items.AddRange(new object[] {
            "Book ID",
            "Title",
            "Author"});
            this.cbxSearch.Location = new System.Drawing.Point(54, 23);
            this.cbxSearch.Name = "cbxSearch";
            this.cbxSearch.Size = new System.Drawing.Size(79, 21);
            this.cbxSearch.TabIndex = 10;
            this.cbxSearch.Text = "Search by:";
            this.cbxSearch.SelectedIndexChanged += new System.EventHandler(this.cbxSearch_SelectedIndexChanged);
            // 
            // txbSearchBox
            // 
            this.txbSearchBox.Enabled = false;
            this.txbSearchBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txbSearchBox.Location = new System.Drawing.Point(139, 24);
            this.txbSearchBox.Name = "txbSearchBox";
            this.txbSearchBox.Size = new System.Drawing.Size(191, 20);
            this.txbSearchBox.TabIndex = 11;
            this.txbSearchBox.TextChanged += new System.EventHandler(this.txbSearchBox_TextChanged);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookMonitoringSystem.Properties.Resources.inaki_del_olmo_NIJuEQw0RKg_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(399, 400);
            this.Controls.Add(this.grbBookRecords);
            this.Controls.Add(this.grbBookDetails);
            this.DoubleBuffered = true;
            this.Name = "frmBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.grbBookDetails.ResumeLayout(false);
            this.grbBookDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.grbBookRecords.ResumeLayout(false);
            this.grbBookRecords.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBookID;
        private System.Windows.Forms.GroupBox grbBookDetails;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txbAuthor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbTitle;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grbBookRecords;
        private System.Windows.Forms.TextBox txbSearchBox;
        private System.Windows.Forms.Label lblErrorSave;
        private System.Windows.Forms.ComboBox cbxSearch;
        private System.Windows.Forms.Label lblErrorSearch;
    }
}