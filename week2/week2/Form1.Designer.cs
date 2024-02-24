namespace week2
{
    partial class form1
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtSubtotal = new TextBox();
            txtDiscountPercent = new TextBox();
            discountAmount = new TextBox();
            total = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(186, 355);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "&Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(442, 356);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "E&xit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 86);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 2;
            label1.Text = "&Subtotal";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 138);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 3;
            label2.Text = "Discount Percent";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 198);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 4;
            label3.Text = "Discount Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(148, 264);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 5;
            label4.Text = "Total";
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(337, 81);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(125, 27);
            txtSubtotal.TabIndex = 6;
            txtSubtotal.TextChanged += textBox1_TextChanged;
            // 
            // txtDiscountPercent
            // 
            txtDiscountPercent.Location = new Point(358, 144);
            txtDiscountPercent.Name = "txtDiscountPercent";
            txtDiscountPercent.ReadOnly = true;
            txtDiscountPercent.Size = new Size(125, 27);
            txtDiscountPercent.TabIndex = 7;
            txtDiscountPercent.TextChanged += textBox2_TextChanged;
            // 
            // discountAmount
            // 
            discountAmount.Location = new Point(359, 205);
            discountAmount.Name = "discountAmount";
            discountAmount.ReadOnly = true;
            discountAmount.Size = new Size(125, 27);
            discountAmount.TabIndex = 8;
            // 
            // total
            // 
            total.Location = new Point(351, 268);
            total.Name = "total";
            total.ReadOnly = true;
            total.Size = new Size(125, 27);
            total.TabIndex = 9;
            // 
            // form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size(800, 450);
            Controls.Add(total);
            Controls.Add(discountAmount);
            Controls.Add(txtDiscountPercent);
            Controls.Add(txtSubtotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "form1";
            Text = "Invoice Total";
            Load += form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSubtotal;
        private TextBox txtDiscountPercent;
        private TextBox discountAmount;
        private TextBox total;
    }
}
