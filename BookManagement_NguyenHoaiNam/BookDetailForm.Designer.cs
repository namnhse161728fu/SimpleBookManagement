namespace BookManagement_NguyenHoaiNam
{
    partial class BookDetailForm
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
            label2 = new Label();
            label1 = new Label();
            txtBookName = new TextBox();
            txtBookId = new TextBox();
            btnSave = new Button();
            txtBookDescription = new TextBox();
            txtAuthor = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            dtPublicationDate = new DateTimePicker();
            cboCategory = new ComboBox();
            btnCancel = new Button();
            lblBookDetail = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 183);
            label2.Name = "label2";
            label2.Size = new Size(139, 31);
            label2.TabIndex = 14;
            label2.Text = "Book Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 118);
            label1.Name = "label1";
            label1.Size = new Size(97, 31);
            label1.TabIndex = 13;
            label1.Text = "Book Id";
            label1.Click += label1_Click;
            // 
            // txtBookName
            // 
            txtBookName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookName.Location = new Point(258, 183);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(645, 38);
            txtBookName.TabIndex = 1;
            txtBookName.TextChanged += txtBookName_TextChanged;
            txtBookName.Validating += txtBookName_Validating;
            // 
            // txtBookId
            // 
            txtBookId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookId.Location = new Point(258, 111);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(645, 38);
            txtBookId.TabIndex = 0;
            txtBookId.TextChanged += txtBookId_TextChanged;
            txtBookId.Validating += txtBookId_Validating;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(976, 111);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(136, 42);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtBookDescription
            // 
            txtBookDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookDescription.Location = new Point(258, 252);
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.Size = new Size(645, 38);
            txtBookDescription.TabIndex = 2;
            txtBookDescription.TextChanged += txtBookDescription_TextChanged;
            txtBookDescription.Validating += txtBookDescription_Validating;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAuthor.Location = new Point(258, 332);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(645, 38);
            txtAuthor.TabIndex = 3;
            txtAuthor.TextChanged += txtAuthor_TextChanged;
            txtAuthor.Validating += txtAuthor_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 259);
            label3.Name = "label3";
            label3.Size = new Size(200, 31);
            label3.TabIndex = 19;
            label3.Text = "Book Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 371);
            label4.Name = "label4";
            label4.Size = new Size(0, 31);
            label4.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(44, 335);
            label5.Name = "label5";
            label5.Size = new Size(90, 31);
            label5.TabIndex = 21;
            label5.Text = "Author";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(43, 417);
            label6.Name = "label6";
            label6.Size = new Size(193, 31);
            label6.TabIndex = 22;
            label6.Text = "Publication Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(43, 503);
            label7.Name = "label7";
            label7.Size = new Size(108, 31);
            label7.TabIndex = 23;
            label7.Text = "Quantity";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(558, 503);
            label8.Name = "label8";
            label8.Size = new Size(67, 31);
            label8.TabIndex = 24;
            label8.Text = "Price";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(44, 586);
            label9.Name = "label9";
            label9.Size = new Size(111, 31);
            label9.TabIndex = 25;
            label9.Text = "Category";
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtQuantity.Location = new Point(258, 496);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(262, 38);
            txtQuantity.TabIndex = 5;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            txtQuantity.Validating += txtQuantity_Validating;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new Point(656, 496);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(247, 38);
            txtPrice.TabIndex = 6;
            txtPrice.TextChanged += txtPrice_TextChanged;
            txtPrice.Validating += txtPrice_Validating;
            // 
            // dtPublicationDate
            // 
            dtPublicationDate.CustomFormat = "";
            dtPublicationDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtPublicationDate.Location = new Point(258, 421);
            dtPublicationDate.Name = "dtPublicationDate";
            dtPublicationDate.Size = new Size(389, 38);
            dtPublicationDate.TabIndex = 4;
            // 
            // cboCategory
            // 
            cboCategory.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(258, 586);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(262, 39);
            cboCategory.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(976, 249);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(136, 42);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblBookDetail
            // 
            lblBookDetail.AutoSize = true;
            lblBookDetail.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookDetail.Location = new Point(43, 22);
            lblBookDetail.Name = "lblBookDetail";
            lblBookDetail.Size = new Size(226, 50);
            lblBookDetail.TabIndex = 30;
            lblBookDetail.Text = "Book Detail";
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 714);
            Controls.Add(lblBookDetail);
            Controls.Add(btnCancel);
            Controls.Add(cboCategory);
            Controls.Add(dtPublicationDate);
            Controls.Add(txtPrice);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(txtAuthor);
            Controls.Add(txtBookDescription);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBookName);
            Controls.Add(txtBookId);
            Controls.Add(btnSave);
            Name = "BookDetailForm";
            Text = "Book Detail";
            Load += BookDetailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txtBookName;
        private TextBox txtBookId;
        private Button btnSave;
        private TextBox txtBookDescription;
        private TextBox txtAuthor;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private DateTimePicker dtPublicationDate;
        private ComboBox cboCategory;
        private Button btnCancel;
        private Label lblBookDetail;
    }
}