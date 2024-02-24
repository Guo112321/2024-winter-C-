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
            SuspendLayout();
            // 
            // labelStudentInfo
            // 
            labelStudentInfo.AutoSize = true;
            labelStudentInfo.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 134);
            labelStudentInfo.Location = new Point(50, 31);
            labelStudentInfo.Name = "labelStudentInfo";
            labelStudentInfo.Size = new Size(79, 30);
            labelStudentInfo.TabIndex = 0;
            labelStudentInfo.Text = "label1";
            // 
            // ScoreListBox
            // 
            ScoreListBox.FormattingEnabled = true;
            ScoreListBox.Location = new Point(50, 76);
            ScoreListBox.Name = "ScoreListBox";
            ScoreListBox.Size = new Size(465, 264);
            ScoreListBox.TabIndex = 1;
            ScoreListBox.SelectedIndexChanged += ScoreListBox_SelectedIndexChanged;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(607, 110);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(94, 27);
            txtScore.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(607, 196);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(607, 280);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(546, 113);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 5;
            label2.Text = "Score:";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(350, 374);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubmit);
            Controls.Add(label2);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtScore);
            Controls.Add(ScoreListBox);
            Controls.Add(labelStudentInfo);
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
    }
}