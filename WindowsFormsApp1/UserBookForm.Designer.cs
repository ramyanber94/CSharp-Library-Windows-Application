
namespace WindowsFormsApp1
{
    partial class UserBookForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabWelcome = new System.Windows.Forms.TabPage();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.dateOfOreder = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.btnFindBook = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabInformation = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOrderQty = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listDisplayBooks = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabWelcome.SuspendLayout();
            this.tabBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.tabInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabWelcome);
            this.tabControl1.Controls.Add(this.tabBooking);
            this.tabControl1.Controls.Add(this.tabInformation);
            this.tabControl1.Location = new System.Drawing.Point(55, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 478);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabWelcome
            // 
            this.tabWelcome.Controls.Add(this.lblWelcome);
            this.tabWelcome.Location = new System.Drawing.Point(4, 25);
            this.tabWelcome.Name = "tabWelcome";
            this.tabWelcome.Size = new System.Drawing.Size(839, 449);
            this.tabWelcome.TabIndex = 2;
            this.tabWelcome.Text = "Welcome";
            this.tabWelcome.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblWelcome.Location = new System.Drawing.Point(152, 196);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 36);
            this.lblWelcome.TabIndex = 0;
            // 
            // tabBooking
            // 
            this.tabBooking.Controls.Add(this.btnDisplayAll);
            this.tabBooking.Controls.Add(this.listDisplayBooks);
            this.tabBooking.Controls.Add(this.label11);
            this.tabBooking.Controls.Add(this.dateOfOreder);
            this.tabBooking.Controls.Add(this.label9);
            this.tabBooking.Controls.Add(this.numQty);
            this.tabBooking.Controls.Add(this.btnFindBook);
            this.tabBooking.Controls.Add(this.btnBooking);
            this.tabBooking.Controls.Add(this.txtISBN);
            this.tabBooking.Controls.Add(this.label10);
            this.tabBooking.Location = new System.Drawing.Point(4, 25);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooking.Size = new System.Drawing.Size(839, 449);
            this.tabBooking.TabIndex = 0;
            this.tabBooking.Text = "Book";
            this.tabBooking.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Date";
            // 
            // dateOfOreder
            // 
            this.dateOfOreder.Location = new System.Drawing.Point(182, 175);
            this.dateOfOreder.Name = "dateOfOreder";
            this.dateOfOreder.Size = new System.Drawing.Size(168, 22);
            this.dateOfOreder.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "qty";
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(182, 113);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(120, 22);
            this.numQty.TabIndex = 15;
            // 
            // btnFindBook
            // 
            this.btnFindBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindBook.Location = new System.Drawing.Point(35, 383);
            this.btnFindBook.Name = "btnFindBook";
            this.btnFindBook.Size = new System.Drawing.Size(156, 39);
            this.btnFindBook.TabIndex = 14;
            this.btnFindBook.Text = "Find";
            this.btnFindBook.UseVisualStyleBackColor = true;
            this.btnFindBook.Click += new System.EventHandler(this.btnFindBook_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.Location = new System.Drawing.Point(533, 383);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(156, 39);
            this.btnBooking.TabIndex = 10;
            this.btnBooking.Text = "Book";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(128, 50);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(244, 22);
            this.txtISBN.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 29);
            this.label10.TabIndex = 11;
            this.label10.Text = "ISBN:";
            // 
            // tabInformation
            // 
            this.tabInformation.Controls.Add(this.label12);
            this.tabInformation.Controls.Add(this.txtOrderQty);
            this.tabInformation.Controls.Add(this.txtEmail);
            this.tabInformation.Controls.Add(this.txtZip);
            this.tabInformation.Controls.Add(this.txtState);
            this.tabInformation.Controls.Add(this.txtCity);
            this.tabInformation.Controls.Add(this.txtAddress);
            this.tabInformation.Controls.Add(this.txtUserName);
            this.tabInformation.Controls.Add(this.txtLastName);
            this.tabInformation.Controls.Add(this.txtFirstName);
            this.tabInformation.Controls.Add(this.label8);
            this.tabInformation.Controls.Add(this.label7);
            this.tabInformation.Controls.Add(this.label6);
            this.tabInformation.Controls.Add(this.label5);
            this.tabInformation.Controls.Add(this.label4);
            this.tabInformation.Controls.Add(this.label3);
            this.tabInformation.Controls.Add(this.label2);
            this.tabInformation.Controls.Add(this.label1);
            this.tabInformation.Location = new System.Drawing.Point(4, 25);
            this.tabInformation.Name = "tabInformation";
            this.tabInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tabInformation.Size = new System.Drawing.Size(839, 449);
            this.tabInformation.TabIndex = 1;
            this.tabInformation.Text = "User Information";
            this.tabInformation.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(535, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Order qty:";
            // 
            // txtOrderQty
            // 
            this.txtOrderQty.Location = new System.Drawing.Point(653, 32);
            this.txtOrderQty.Name = "txtOrderQty";
            this.txtOrderQty.ReadOnly = true;
            this.txtOrderQty.Size = new System.Drawing.Size(156, 22);
            this.txtOrderQty.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(257, 393);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(295, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(257, 342);
            this.txtZip.Name = "txtZip";
            this.txtZip.ReadOnly = true;
            this.txtZip.Size = new System.Drawing.Size(150, 22);
            this.txtZip.TabIndex = 14;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(257, 294);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(150, 22);
            this.txtState.TabIndex = 13;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(257, 239);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(150, 22);
            this.txtCity.TabIndex = 12;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(257, 186);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(376, 22);
            this.txtAddress.TabIndex = 11;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(257, 133);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(150, 22);
            this.txtUserName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(257, 83);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(150, 22);
            this.txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(257, 32);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(150, 22);
            this.txtFirstName.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Zip:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "State:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "City:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // listDisplayBooks
            // 
            this.listDisplayBooks.FormattingEnabled = true;
            this.listDisplayBooks.ItemHeight = 16;
            this.listDisplayBooks.Location = new System.Drawing.Point(422, 28);
            this.listDisplayBooks.Name = "listDisplayBooks";
            this.listDisplayBooks.Size = new System.Drawing.Size(403, 340);
            this.listDisplayBooks.TabIndex = 19;
            this.listDisplayBooks.SelectedIndexChanged += new System.EventHandler(this.listDisplayBooks_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(773, 520);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(156, 39);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAll.Location = new System.Drawing.Point(253, 383);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(224, 39);
            this.btnDisplayAll.TabIndex = 20;
            this.btnDisplayAll.Text = "Display All Books";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // UserBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 564);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserBookForm";
            this.Text = "UserBook";
            this.Load += new System.EventHandler(this.UserBook_Load);
            this.Shown += new System.EventHandler(this.UserBook_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabWelcome.ResumeLayout(false);
            this.tabWelcome.PerformLayout();
            this.tabBooking.ResumeLayout(false);
            this.tabBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.tabInformation.ResumeLayout(false);
            this.tabInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.TabPage tabInformation;
        private System.Windows.Forms.Button btnFindBook;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabWelcome;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateOfOreder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOrderQty;
        private System.Windows.Forms.ListBox listDisplayBooks;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDisplayAll;
    }
}