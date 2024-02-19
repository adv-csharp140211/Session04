namespace App04
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
            btnEven = new Button();
            listBox1 = new ListBox();
            btnOdd = new Button();
            buttonGT5 = new Button();
            SuspendLayout();
            // 
            // btnEven
            // 
            btnEven.Location = new Point(12, 12);
            btnEven.Name = "btnEven";
            btnEven.Size = new Size(187, 23);
            btnEven.TabIndex = 0;
            btnEven.Text = "Even";
            btnEven.UseVisualStyleBackColor = true;
            btnEven.Click += btnEven_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 162);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(187, 274);
            listBox1.TabIndex = 1;
            // 
            // btnOdd
            // 
            btnOdd.Location = new Point(12, 41);
            btnOdd.Name = "btnOdd";
            btnOdd.Size = new Size(187, 23);
            btnOdd.TabIndex = 2;
            btnOdd.Text = "Odd";
            btnOdd.UseVisualStyleBackColor = true;
            btnOdd.Click += btnOdd_Click;
            // 
            // buttonGT5
            // 
            buttonGT5.Location = new Point(12, 70);
            buttonGT5.Name = "buttonGT5";
            buttonGT5.Size = new Size(187, 23);
            buttonGT5.TabIndex = 3;
            buttonGT5.Text = "GT 5";
            buttonGT5.UseVisualStyleBackColor = true;
            buttonGT5.Click += buttonGT5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGT5);
            Controls.Add(btnOdd);
            Controls.Add(listBox1);
            Controls.Add(btnEven);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEven;
        private ListBox listBox1;
        private Button btnOdd;
        private Button buttonGT5;
    }
}
