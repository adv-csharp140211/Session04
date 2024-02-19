namespace AppCodeFirst
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
            buttonInsertSampleUser = new Button();
            dataGridViewUsers = new DataGridView();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // buttonInsertSampleUser
            // 
            buttonInsertSampleUser.Location = new Point(12, 12);
            buttonInsertSampleUser.Name = "buttonInsertSampleUser";
            buttonInsertSampleUser.Size = new Size(186, 23);
            buttonInsertSampleUser.TabIndex = 0;
            buttonInsertSampleUser.Text = "Insert Sample User";
            buttonInsertSampleUser.UseVisualStyleBackColor = true;
            buttonInsertSampleUser.Click += buttonInsertSampleUser_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(12, 41);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(776, 397);
            dataGridViewUsers.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(713, 12);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(75, 23);
            buttonRefresh.TabIndex = 2;
            buttonRefresh.Text = "Refesh";
            buttonRefresh.UseVisualStyleBackColor = true;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRefresh);
            Controls.Add(dataGridViewUsers);
            Controls.Add(buttonInsertSampleUser);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonInsertSampleUser;
        private DataGridView dataGridViewUsers;
        private Button buttonRefresh;
    }
}
