namespace Lab3Student
{
    partial class Form2
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
            label1 = new Label();
            txtStudentName = new TextBox();
            labelstudentscore = new Label();
            txtStudentScore = new TextBox();
            btnAddScore = new Button();
            labelStudentInfo = new Label();
            btnSubmit = new Button();
            txtsStudentScoreID = new TextBox();
            label3 = new Label();
            txtStudentID = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label1.Location = new Point(48, 47);
            label1.Name = "label1";
            label1.Size = new Size(154, 27);
            label1.TabIndex = 0;
            label1.Text = "Student Name:";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(208, 47);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(125, 27);
            txtStudentName.TabIndex = 1;
            // 
            // labelstudentscore
            // 
            labelstudentscore.AutoSize = true;
            labelstudentscore.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            labelstudentscore.Location = new Point(481, 176);
            labelstudentscore.Name = "labelstudentscore";
            labelstudentscore.Size = new Size(71, 27);
            labelstudentscore.TabIndex = 2;
            labelstudentscore.Text = "Score:";
            // 
            // txtStudentScore
            // 
            txtStudentScore.Location = new Point(558, 178);
            txtStudentScore.Name = "txtStudentScore";
            txtStudentScore.Size = new Size(125, 27);
            txtStudentScore.TabIndex = 3;
            // 
            // btnAddScore
            // 
            btnAddScore.Location = new Point(373, 262);
            btnAddScore.Name = "btnAddScore";
            btnAddScore.Size = new Size(70, 27);
            btnAddScore.TabIndex = 4;
            btnAddScore.Text = "Add";
            btnAddScore.UseVisualStyleBackColor = true;
            btnAddScore.Click += btnAddScore_Click;
            // 
            // labelStudentInfo
            // 
            labelStudentInfo.AutoSize = true;
            labelStudentInfo.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            labelStudentInfo.Location = new Point(354, 310);
            labelStudentInfo.Name = "labelStudentInfo";
            labelStudentInfo.Size = new Size(0, 27);
            labelStudentInfo.TabIndex = 5;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(373, 387);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtsStudentScoreID
            // 
            txtsStudentScoreID.Location = new Point(208, 176);
            txtsStudentScoreID.Name = "txtsStudentScoreID";
            txtsStudentScoreID.Size = new Size(125, 27);
            txtsStudentScoreID.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label3.Location = new Point(53, 174);
            label3.Name = "label3";
            label3.Size = new Size(149, 27);
            label3.TabIndex = 8;
            label3.Text = "AssignmentID:";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(558, 47);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(125, 27);
            txtStudentID.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            label2.Location = new Point(434, 47);
            label2.Name = "label2";
            label2.Size = new Size(118, 27);
            label2.TabIndex = 10;
            label2.Text = "Student ID:";
            // 
            // Form2
            // 
            AcceptButton = btnAddScore;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStudentID);
            Controls.Add(label2);
            Controls.Add(txtsStudentScoreID);
            Controls.Add(label3);
            Controls.Add(btnSubmit);
            Controls.Add(labelStudentInfo);
            Controls.Add(btnAddScore);
            Controls.Add(txtStudentScore);
            Controls.Add(labelstudentscore);
            Controls.Add(txtStudentName);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Add New";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentName;
        private Label labelstudentscore;
        private TextBox txtStudentScore;
        private Button btnAddScore;
        private Label labelStudentInfo;
        private Button btnSubmit;
        private TextBox txtsStudentScoreID;
        private Label label3;
        private TextBox txtStudentID;
        private Label label2;
    }
}