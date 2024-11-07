namespace EmployeeWinApp
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
            txtFirstname = new TextBox();
            lblFirstname = new Label();
            lblLastname = new Label();
            lblAge = new Label();
            txtLastname = new TextBox();
            txtAge = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(102, 23);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(175, 23);
            txtFirstname.TabIndex = 0;
            // 
            // lblFirstname
            // 
            lblFirstname.AutoSize = true;
            lblFirstname.Location = new Point(24, 31);
            lblFirstname.Name = "lblFirstname";
            lblFirstname.Size = new Size(59, 15);
            lblFirstname.TabIndex = 1;
            lblFirstname.Text = "Firstname";
            // 
            // lblLastname
            // 
            lblLastname.AutoSize = true;
            lblLastname.Location = new Point(24, 70);
            lblLastname.Name = "lblLastname";
            lblLastname.Size = new Size(58, 15);
            lblLastname.TabIndex = 2;
            lblLastname.Text = "Lastname";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(24, 110);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age";
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(102, 67);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(175, 23);
            txtLastname.TabIndex = 4;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(102, 107);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(175, 23);
            txtAge.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(202, 147);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 193);
            Controls.Add(btnSave);
            Controls.Add(txtAge);
            Controls.Add(txtLastname);
            Controls.Add(lblAge);
            Controls.Add(lblLastname);
            Controls.Add(lblFirstname);
            Controls.Add(txtFirstname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstname;
        private Label lblFirstname;
        private Label lblLastname;
        private Label lblAge;
        private TextBox txtLastname;
        private TextBox txtAge;
        private Button btnSave;
    }
}
