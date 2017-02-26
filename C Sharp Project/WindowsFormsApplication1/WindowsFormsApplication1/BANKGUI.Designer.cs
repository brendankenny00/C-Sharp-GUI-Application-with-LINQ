namespace WindowsFormsApplication1
{
    partial class BANKGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BANKGUI));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.t1 = new System.Windows.Forms.TextBox();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t3 = new System.Windows.Forms.TextBox();
            this.t4 = new System.Windows.Forms.TextBox();
            this.t5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.t6 = new System.Windows.Forms.TextBox();
            this.Deposit = new System.Windows.Forms.RadioButton();
            this.Current = new System.Windows.Forms.RadioButton();
            this.Student = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutBOIAccountsAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank of Ireland Accounts Admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(310, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "First Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(167, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Next Record";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(36, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Previous Record";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(36, 404);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(167, 404);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(104, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Exit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // t1
            // 
            this.t1.Location = new System.Drawing.Point(157, 19);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(248, 20);
            this.t1.TabIndex = 8;
            this.t1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // t2
            // 
            this.t2.Location = new System.Drawing.Point(157, 62);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(248, 20);
            this.t2.TabIndex = 9;
            // 
            // t3
            // 
            this.t3.Location = new System.Drawing.Point(157, 109);
            this.t3.Name = "t3";
            this.t3.Size = new System.Drawing.Size(248, 20);
            this.t3.TabIndex = 10;
            // 
            // t4
            // 
            this.t4.Location = new System.Drawing.Point(157, 146);
            this.t4.Name = "t4";
            this.t4.Size = new System.Drawing.Size(248, 20);
            this.t4.TabIndex = 11;
            // 
            // t5
            // 
            this.t5.Location = new System.Drawing.Point(157, 186);
            this.t5.Name = "t5";
            this.t5.Size = new System.Drawing.Size(248, 20);
            this.t5.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Account Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Currency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Account Balance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Phone Number";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(36, 366);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(104, 23);
            this.Search.TabIndex = 19;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // t6
            // 
            this.t6.Location = new System.Drawing.Point(167, 369);
            this.t6.Name = "t6";
            this.t6.Size = new System.Drawing.Size(248, 20);
            this.t6.TabIndex = 20;
            // 
            // Deposit
            // 
            this.Deposit.AutoSize = true;
            this.Deposit.Location = new System.Drawing.Point(77, 214);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(61, 17);
            this.Deposit.TabIndex = 21;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.CheckedChanged += new System.EventHandler(this.Deposit_CheckedChanged);
            // 
            // Current
            // 
            this.Current.AutoSize = true;
            this.Current.Location = new System.Drawing.Point(190, 214);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(59, 17);
            this.Current.TabIndex = 22;
            this.Current.Text = "Current";
            this.Current.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(302, 214);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(62, 17);
            this.Student.TabIndex = 23;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextRecordToolStripMenuItem,
            this.previousRecordToolStripMenuItem,
            this.firstRecordToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // nextRecordToolStripMenuItem
            // 
            this.nextRecordToolStripMenuItem.Name = "nextRecordToolStripMenuItem";
            this.nextRecordToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.nextRecordToolStripMenuItem.Text = "Next Record";
            this.nextRecordToolStripMenuItem.Click += new System.EventHandler(this.nextRecordToolStripMenuItem_Click);
            // 
            // previousRecordToolStripMenuItem
            // 
            this.previousRecordToolStripMenuItem.Name = "previousRecordToolStripMenuItem";
            this.previousRecordToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.previousRecordToolStripMenuItem.Text = "Previous Record";
            this.previousRecordToolStripMenuItem.Click += new System.EventHandler(this.previousRecordToolStripMenuItem_Click);
            // 
            // firstRecordToolStripMenuItem
            // 
            this.firstRecordToolStripMenuItem.Name = "firstRecordToolStripMenuItem";
            this.firstRecordToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.firstRecordToolStripMenuItem.Text = "First Record";
            this.firstRecordToolStripMenuItem.Click += new System.EventHandler(this.firstRecordToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllFieldsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearAllFieldsToolStripMenuItem
            // 
            this.clearAllFieldsToolStripMenuItem.Name = "clearAllFieldsToolStripMenuItem";
            this.clearAllFieldsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.clearAllFieldsToolStripMenuItem.Text = "Clear All Fields";
            this.clearAllFieldsToolStripMenuItem.Click += new System.EventHandler(this.clearAllFieldsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutBOIAccountsAdminToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutBOIAccountsAdminToolStripMenuItem
            // 
            this.aboutBOIAccountsAdminToolStripMenuItem.Name = "aboutBOIAccountsAdminToolStripMenuItem";
            this.aboutBOIAccountsAdminToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.aboutBOIAccountsAdminToolStripMenuItem.Text = "About BOI Accounts Admin";
            this.aboutBOIAccountsAdminToolStripMenuItem.Click += new System.EventHandler(this.aboutBOIAccountsAdminToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMessageToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpMessageToolStripMenuItem
            // 
            this.helpMessageToolStripMenuItem.Name = "helpMessageToolStripMenuItem";
            this.helpMessageToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.helpMessageToolStripMenuItem.Text = "Help Message";
            this.helpMessageToolStripMenuItem.Click += new System.EventHandler(this.helpMessageToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(77, 238);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Loan Approved";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.t6);
            this.panel1.Controls.Add(this.Search);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 435);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 47);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.t4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.t5);
            this.panel3.Controls.Add(this.Deposit);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.t3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.Current);
            this.panel3.Controls.Add(this.t1);
            this.panel3.Controls.Add(this.t2);
            this.panel3.Controls.Add(this.Student);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(23, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(422, 260);
            this.panel3.TabIndex = 29;
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // BANKGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 483);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BANKGUI";
            this.Text = "Bank Of Ireland Accounts Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t3;
        private System.Windows.Forms.TextBox t4;
        private System.Windows.Forms.TextBox t5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox t6;
        private System.Windows.Forms.RadioButton Deposit;
        private System.Windows.Forms.RadioButton Current;
        private System.Windows.Forms.RadioButton Student;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem nextRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllFieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutBOIAccountsAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
    }
}

