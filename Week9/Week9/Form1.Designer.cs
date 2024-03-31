namespace Week9
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(104, 45);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(350, 104);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(93, 205);
            button1.Name = "button1";
            button1.Size = new Size(348, 29);
            button1.TabIndex = 1;
            button1.Text = "Find employees who are older than 40";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 253);
            button2.Name = "button2";
            button2.Size = new Size(429, 29);
            button2.TabIndex = 2;
            button2.Text = "Get a list of unique departments from the data.";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(93, 306);
            button3.Name = "button3";
            button3.Size = new Size(454, 29);
            button3.TabIndex = 3;
            button3.Text = "Calculate the average salary of employees in the file.";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(101, 363);
            button4.Name = "button4";
            button4.Size = new Size(446, 29);
            button4.TabIndex = 4;
            button4.Text = "Print Employees from Indviual countries using Join";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
