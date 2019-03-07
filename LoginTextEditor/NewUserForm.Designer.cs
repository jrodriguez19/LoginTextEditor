namespace LoginTextEditor
{
    partial class NewUserForm
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.reEnterPasswordTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.userTypeCB = new System.Windows.Forms.ComboBox();
            this.submitBT = new System.Windows.Forms.Button();
            this.exitBT = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Re-Enter Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name:";
            // 
            // dateTP
            // 
            this.dateTP.CustomFormat = "\"dd-MM-yyyy\"";
            this.dateTP.Location = new System.Drawing.Point(169, 272);
            this.dateTP.Name = "dateTP";
            this.dateTP.Size = new System.Drawing.Size(200, 22);
            this.dateTP.TabIndex = 6;
            this.dateTP.ValueChanged += new System.EventHandler(this.dateTP_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "User - Type:";
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(170, 92);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(199, 22);
            this.usernameTB.TabIndex = 10;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(170, 128);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(199, 22);
            this.passwordTB.TabIndex = 11;
            // 
            // reEnterPasswordTB
            // 
            this.reEnterPasswordTB.Location = new System.Drawing.Point(170, 164);
            this.reEnterPasswordTB.Name = "reEnterPasswordTB";
            this.reEnterPasswordTB.Size = new System.Drawing.Size(199, 22);
            this.reEnterPasswordTB.TabIndex = 12;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(170, 200);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(199, 22);
            this.firstNameTB.TabIndex = 13;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(170, 236);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(199, 22);
            this.lastNameTB.TabIndex = 14;
            // 
            // userTypeCB
            // 
            this.userTypeCB.FormattingEnabled = true;
            this.userTypeCB.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.userTypeCB.Location = new System.Drawing.Point(170, 308);
            this.userTypeCB.Name = "userTypeCB";
            this.userTypeCB.Size = new System.Drawing.Size(121, 24);
            this.userTypeCB.TabIndex = 15;
            // 
            // submitBT
            // 
            this.submitBT.Location = new System.Drawing.Point(170, 353);
            this.submitBT.Name = "submitBT";
            this.submitBT.Size = new System.Drawing.Size(75, 23);
            this.submitBT.TabIndex = 16;
            this.submitBT.Text = "Submit";
            this.submitBT.UseVisualStyleBackColor = true;
            this.submitBT.Click += new System.EventHandler(this.submitBT_Click);
            // 
            // exitBT
            // 
            this.exitBT.Location = new System.Drawing.Point(252, 352);
            this.exitBT.Name = "exitBT";
            this.exitBT.Size = new System.Drawing.Size(75, 23);
            this.exitBT.TabIndex = 17;
            this.exitBT.Text = "Exit";
            this.exitBT.UseVisualStyleBackColor = true;
            this.exitBT.Click += new System.EventHandler(this.exitBT_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(167, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Create New User Screen";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // NewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.exitBT);
            this.Controls.Add(this.submitBT);
            this.Controls.Add(this.userTypeCB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.reEnterPasswordTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewUserForm";
            this.Text = "New User";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button exitBT;
        private System.Windows.Forms.Button submitBT;
        private System.Windows.Forms.ComboBox userTypeCB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox reEnterPasswordTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTP;
    }
}