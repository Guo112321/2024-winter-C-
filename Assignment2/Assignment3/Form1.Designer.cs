namespace Lab3Student
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            groupBox = new GroupBox();
            rdbExit = new RadioButton();
            rdbDelete = new RadioButton();
            rdbUpdate = new RadioButton();
            rdbAdd = new RadioButton();
            labelStudents = new Label();
            labelTotal = new Label();
            labelCount = new Label();
            labelAverage = new Label();
            txtTotal = new TextBox();
            txtCount = new TextBox();
            txtAverage = new TextBox();
            buttonPerform = new Button();
            toolTip1 = new ToolTip(components);
            menuStrip1 = new MenuStrip();
            exitToolStripMenuItem = new ToolStripMenuItem();
            operationToolStripMenuItem = new ToolStripMenuItem();
            addNewStudentToolStripMenuItem = new ToolStripMenuItem();
            updateStudentToolStripMenuItem = new ToolStripMenuItem();
            deleteStudentToolStripMenuItem = new ToolStripMenuItem();
            groupBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(41, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(355, 144);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(rdbExit);
            groupBox.Controls.Add(rdbDelete);
            groupBox.Controls.Add(rdbUpdate);
            groupBox.Controls.Add(rdbAdd);
            groupBox.Location = new Point(567, 51);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(171, 272);
            groupBox.TabIndex = 1;
            groupBox.TabStop = false;
            groupBox.Text = "Options";
            // 
            // rdbExit
            // 
            rdbExit.AutoSize = true;
            rdbExit.Location = new Point(25, 221);
            rdbExit.Name = "rdbExit";
            rdbExit.Size = new Size(56, 24);
            rdbExit.TabIndex = 3;
            rdbExit.TabStop = true;
            rdbExit.Text = "E&xit";
            rdbExit.UseVisualStyleBackColor = true;
            // 
            // rdbDelete
            // 
            rdbDelete.AutoSize = true;
            rdbDelete.Location = new Point(25, 160);
            rdbDelete.Name = "rdbDelete";
            rdbDelete.Size = new Size(78, 24);
            rdbDelete.TabIndex = 2;
            rdbDelete.TabStop = true;
            rdbDelete.Text = "&Delete";
            rdbDelete.UseVisualStyleBackColor = true;
            // 
            // rdbUpdate
            // 
            rdbUpdate.AutoSize = true;
            rdbUpdate.Location = new Point(25, 101);
            rdbUpdate.Name = "rdbUpdate";
            rdbUpdate.Size = new Size(84, 24);
            rdbUpdate.TabIndex = 1;
            rdbUpdate.TabStop = true;
            rdbUpdate.Text = "&Update";
            rdbUpdate.UseVisualStyleBackColor = true;
            // 
            // rdbAdd
            // 
            rdbAdd.AutoSize = true;
            rdbAdd.Location = new Point(25, 48);
            rdbAdd.Name = "rdbAdd";
            rdbAdd.Size = new Size(98, 24);
            rdbAdd.TabIndex = 0;
            rdbAdd.TabStop = true;
            rdbAdd.Text = "&Add New";
            rdbAdd.UseVisualStyleBackColor = true;
            // 
            // labelStudents
            // 
            labelStudents.AutoSize = true;
            labelStudents.Location = new Point(41, 47);
            labelStudents.Name = "labelStudents";
            labelStudents.Size = new Size(74, 20);
            labelStudents.TabIndex = 2;
            labelStudents.Text = "Students";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(86, 258);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(92, 20);
            labelTotal.TabIndex = 3;
            labelTotal.Text = "Score Total";
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(79, 303);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(99, 20);
            labelCount.TabIndex = 4;
            labelCount.Text = "Score Count";
            // 
            // labelAverage
            // 
            labelAverage.AutoSize = true;
            labelAverage.Location = new Point(86, 349);
            labelAverage.Name = "labelAverage";
            labelAverage.Size = new Size(70, 20);
            labelAverage.TabIndex = 5;
            labelAverage.Text = "Average";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(192, 255);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(93, 27);
            txtTotal.TabIndex = 6;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(191, 303);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(94, 27);
            txtCount.TabIndex = 7;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(192, 349);
            txtAverage.Name = "txtAverage";
            txtAverage.Size = new Size(93, 27);
            txtAverage.TabIndex = 8;
            // 
            // buttonPerform
            // 
            buttonPerform.Location = new Point(639, 365);
            buttonPerform.Name = "buttonPerform";
            buttonPerform.Size = new Size(94, 29);
            buttonPerform.TabIndex = 9;
            buttonPerform.Text = "&Perform";
            buttonPerform.UseVisualStyleBackColor = true;
            buttonPerform.Click += buttonPerform_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem, operationToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(49, 24);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // operationToolStripMenuItem
            // 
            operationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewStudentToolStripMenuItem, updateStudentToolStripMenuItem, deleteStudentToolStripMenuItem });
            operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            operationToolStripMenuItem.Size = new Size(97, 24);
            operationToolStripMenuItem.Text = "&Operation";
            // 
            // addNewStudentToolStripMenuItem
            // 
            addNewStudentToolStripMenuItem.Name = "addNewStudentToolStripMenuItem";
            addNewStudentToolStripMenuItem.Size = new Size(217, 26);
            addNewStudentToolStripMenuItem.Text = "Add new student";
            addNewStudentToolStripMenuItem.Click += addNewStudentToolStripMenuItem_Click;
            // 
            // updateStudentToolStripMenuItem
            // 
            updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            updateStudentToolStripMenuItem.Size = new Size(217, 26);
            updateStudentToolStripMenuItem.Text = "Update student";
            updateStudentToolStripMenuItem.Click += updateStudentToolStripMenuItem_Click;
            // 
            // deleteStudentToolStripMenuItem
            // 
            deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            deleteStudentToolStripMenuItem.Size = new Size(217, 26);
            deleteStudentToolStripMenuItem.Text = "Delete student";
            deleteStudentToolStripMenuItem.Click += deleteStudentToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AcceptButton = buttonPerform;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPerform);
            Controls.Add(txtAverage);
            Controls.Add(txtCount);
            Controls.Add(txtTotal);
            Controls.Add(labelAverage);
            Controls.Add(labelCount);
            Controls.Add(labelTotal);
            Controls.Add(labelStudents);
            Controls.Add(groupBox);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Student Scores";
            Load += Form1_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private GroupBox groupBox;
        private RadioButton rdbDelete;
        private RadioButton rdbUpdate;
        private RadioButton rdbAdd;
        private Label labelStudents;
        private Label labelTotal;
        private Label labelCount;
        private Label labelAverage;
        private TextBox txtTotal;
        private TextBox txtCount;
        private TextBox txtAverage;
        private Button buttonPerform;
        private RadioButton rdbExit;
        private ToolTip toolTip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem operationToolStripMenuItem;
        private ToolStripMenuItem addNewStudentToolStripMenuItem;
        private ToolStripMenuItem updateStudentToolStripMenuItem;
        private ToolStripMenuItem deleteStudentToolStripMenuItem;
    }
}
