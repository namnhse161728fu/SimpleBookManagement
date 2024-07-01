namespace BookManagement_NguyenHoaiNam
{
    partial class BookManagementForm
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
            components = new System.ComponentModel.Container();
            dgvBookManagement = new DataGridView();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtExit = new Button();
            btnSearch = new Button();
            txtName = new TextBox();
            txtDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBookManagement).BeginInit();
            SuspendLayout();
            // 
            // dgvBookManagement
            // 
            dgvBookManagement.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookManagement.Location = new Point(32, 211);
            dgvBookManagement.Name = "dgvBookManagement";
            dgvBookManagement.RowHeadersWidth = 51;
            dgvBookManagement.Size = new Size(882, 468);
            dgvBookManagement.TabIndex = 3;
            dgvBookManagement.CellContentClick += dgvBookManagement_CellContentClick;
            dgvBookManagement.SelectionChanged += dgvBookManagement_SelectionChanged;
            dgvBookManagement.DoubleClick += dgvBookManagement_DoubleClick;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(937, 211);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(136, 49);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(937, 347);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(136, 51);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(937, 477);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(136, 52);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtExit
            // 
            txtExit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtExit.Location = new Point(937, 605);
            txtExit.Name = "txtExit";
            txtExit.Size = new Size(136, 52);
            txtExit.TabIndex = 7;
            txtExit.Text = "Exit";
            txtExit.UseVisualStyleBackColor = true;
            txtExit.Click += txtExit_Click;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(937, 111);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(136, 42);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(140, 112);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 38);
            txtName.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(578, 112);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(208, 38);
            txtDescription.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 115);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(400, 115);
            label2.Name = "label2";
            label2.Size = new Size(138, 31);
            label2.TabIndex = 9;
            label2.Text = "Description";
            label2.Click += label2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 21);
            label3.Name = "label3";
            label3.Size = new Size(353, 50);
            label3.TabIndex = 11;
            label3.Text = "Book Management";
            // 
            // BookManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 705);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(btnSearch);
            Controls.Add(txtExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(dgvBookManagement);
            Name = "BookManagementForm";
            Text = "BookManagementForm";
            Load += BookManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookManagement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBookManagement;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private Button txtExit;
        private Button btnSearch;
        private TextBox txtName;
        private TextBox txtDescription;
        private Label label1;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private Label label3;
    }
}