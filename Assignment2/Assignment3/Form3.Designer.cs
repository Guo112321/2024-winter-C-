namespace Lab3Student
{
    partial class Form3
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
            labelStudentInfo = new Label();
            ScoreListBox = new ListBox();
            txtScore = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            label2 = new Label();
            btnSubmit = new Button();
            btnDelete = new Button();
            label1 = new Label();
            txtID = new TextBox();
            SuspendLayout();
            // 
            // labelStudentInfo
            // 
            labelStudentInfo.AutoSize = true;
            labelStudentInfo.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            labelStudentInfo.Location = new Point(39, 26);
            labelStudentInfo.Margin = new Padding(2, 0, 2, 0);
            labelStudentInfo.Name = "labelStudentInfo";
            labelStudentInfo.Size = new Size(67, 25);
            labelStudentInfo.TabIndex = 0;
            labelStudentInfo.Text = "label1";
            // 
            // ScoreListBox
            // 
            ScoreListBox.FormattingEnabled = true;
            ScoreListBox.ItemHeight = 17;
            ScoreListBox.Location = new Point(39, 65);
            ScoreListBox.Margin = new Padding(2, 3, 2, 3);
            ScoreListBox.Name = "ScoreListBox";
            ScoreListBox.Size = new Size(363, 225);
            ScoreListBox.TabIndex = 1;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(472, 94);
            txtScore.Margin = new Padding(2, 3, 2, 3);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(74, 23);
            txtScore.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(473, 147);
            btnAdd.Margin = new Padding(2, 3, 2, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(73, 25);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(473, 197);
            btnUpdate.Margin = new Padding(2, 3, 2, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(73, 25);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 96);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 5;
            label2.Text = "Score:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(272, 318);
            btnSubmit.Margin = new Padding(2, 3, 2, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(73, 25);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(473, 254);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(73, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(425, 67);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 17);
            label1.TabIndex = 9;
            label1.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(472, 65);
            txtID.Margin = new Padding(2, 3, 2, 3);
            txtID.Name = "txtID";
            txtID.Size = new Size(74, 23);
            txtID.TabIndex = 8;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 382);
            Controls.Add(label1);
            Controls.Add(txtID);
            Controls.Add(btnDelete);
            Controls.Add(btnSubmit);
            Controls.Add(label2);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtScore);
            Controls.Add(ScoreListBox);
            Controls.Add(labelStudentInfo);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelStudentInfo;
        private ListBox ScoreListBox;
        private TextBox txtScore;
        private Button btnAdd;
        private Button btnUpdate;
        private Label label2;
        private Button btnSubmit;
        private Button btnDelete;
        private Label label1;
        private TextBox txtID;
    }
}