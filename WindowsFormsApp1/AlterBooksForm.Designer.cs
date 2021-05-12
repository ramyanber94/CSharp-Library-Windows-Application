
namespace WindowsFormsApp1
{
    partial class AlterBooksForm
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
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbFindBook = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchBook = new System.Windows.Forms.TextBox();
            this.cmboBook = new System.Windows.Forms.ComboBox();
            this.listDisplay = new System.Windows.Forms.ListBox();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRmove = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbAddBook = new System.Windows.Forms.TabPage();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.txtDescreption = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.cmboCategory = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbFindBook.SuspendLayout();
            this.tbAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.Maroon;
            this.lblEmployeeName.Location = new System.Drawing.Point(472, 17);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(0, 32);
            this.lblEmployeeName.TabIndex = 21;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(1161, 603);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 47);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbFindBook);
            this.tabControl1.Controls.Add(this.tbAddBook);
            this.tabControl1.Location = new System.Drawing.Point(44, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1256, 545);
            this.tabControl1.TabIndex = 19;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.tabControl1_TabIndexChanged);
            // 
            // tbFindBook
            // 
            this.tbFindBook.Controls.Add(this.label1);
            this.tbFindBook.Controls.Add(this.txtSearchBook);
            this.tbFindBook.Controls.Add(this.cmboBook);
            this.tbFindBook.Controls.Add(this.listDisplay);
            this.tbFindBook.Controls.Add(this.btnDisplayAll);
            this.tbFindBook.Controls.Add(this.btnFind);
            this.tbFindBook.Controls.Add(this.btnRmove);
            this.tbFindBook.Controls.Add(this.btnPrevious);
            this.tbFindBook.Controls.Add(this.btnLast);
            this.tbFindBook.Controls.Add(this.btnFirst);
            this.tbFindBook.Controls.Add(this.btnNext);
            this.tbFindBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFindBook.Location = new System.Drawing.Point(4, 25);
            this.tbFindBook.Name = "tbFindBook";
            this.tbFindBook.Padding = new System.Windows.Forms.Padding(3);
            this.tbFindBook.Size = new System.Drawing.Size(1248, 516);
            this.tbFindBook.TabIndex = 0;
            this.tbFindBook.Text = "Find Book";
            this.tbFindBook.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "ISBN:";
            // 
            // txtSearchBook
            // 
            this.txtSearchBook.Location = new System.Drawing.Point(467, 374);
            this.txtSearchBook.Name = "txtSearchBook";
            this.txtSearchBook.Size = new System.Drawing.Size(393, 30);
            this.txtSearchBook.TabIndex = 9;
            // 
            // cmboBook
            // 
            this.cmboBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmboBook.FormattingEnabled = true;
            this.cmboBook.Location = new System.Drawing.Point(343, 25);
            this.cmboBook.Name = "cmboBook";
            this.cmboBook.Size = new System.Drawing.Size(677, 33);
            this.cmboBook.TabIndex = 8;
            this.cmboBook.SelectedIndexChanged += new System.EventHandler(this.cmboBook_SelectedIndexChanged);
            // 
            // listDisplay
            // 
            this.listDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDisplay.ForeColor = System.Drawing.Color.DarkGreen;
            this.listDisplay.FormattingEnabled = true;
            this.listDisplay.ItemHeight = 29;
            this.listDisplay.Location = new System.Drawing.Point(213, 75);
            this.listDisplay.Name = "listDisplay";
            this.listDisplay.Size = new System.Drawing.Size(970, 265);
            this.listDisplay.TabIndex = 7;
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(544, 436);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(153, 45);
            this.btnDisplayAll.TabIndex = 6;
            this.btnDisplayAll.Text = "Display All";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(885, 436);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 45);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRmove
            // 
            this.btnRmove.Location = new System.Drawing.Point(231, 436);
            this.btnRmove.Name = "btnRmove";
            this.btnRmove.Size = new System.Drawing.Size(112, 45);
            this.btnRmove.TabIndex = 4;
            this.btnRmove.Text = "Remove";
            this.btnRmove.UseVisualStyleBackColor = true;
            this.btnRmove.Click += new System.EventHandler(this.btnRmove_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(29, 371);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(172, 45);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Pervious";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(52, 267);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(112, 45);
            this.btnLast.TabIndex = 2;
            this.btnLast.Text = "Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(52, 163);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(112, 45);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(52, 53);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 45);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbAddBook
            // 
            this.tbAddBook.Controls.Add(this.btnUpdate);
            this.tbAddBook.Controls.Add(this.btnAdd);
            this.tbAddBook.Controls.Add(this.numQty);
            this.tbAddBook.Controls.Add(this.txtDescreption);
            this.tbAddBook.Controls.Add(this.txtBookName);
            this.tbAddBook.Controls.Add(this.cmboCategory);
            this.tbAddBook.Controls.Add(this.txtTitle);
            this.tbAddBook.Controls.Add(this.txtISBN);
            this.tbAddBook.Controls.Add(this.label7);
            this.tbAddBook.Controls.Add(this.label6);
            this.tbAddBook.Controls.Add(this.label5);
            this.tbAddBook.Controls.Add(this.label4);
            this.tbAddBook.Controls.Add(this.label3);
            this.tbAddBook.Controls.Add(this.label2);
            this.tbAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddBook.Location = new System.Drawing.Point(4, 25);
            this.tbAddBook.Name = "tbAddBook";
            this.tbAddBook.Padding = new System.Windows.Forms.Padding(3);
            this.tbAddBook.Size = new System.Drawing.Size(1248, 516);
            this.tbAddBook.TabIndex = 1;
            this.tbAddBook.Text = "Add Book";
            this.tbAddBook.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(760, 443);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(151, 47);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(187, 443);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 47);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(339, 371);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(120, 30);
            this.numQty.TabIndex = 11;
            // 
            // txtDescreption
            // 
            this.txtDescreption.Location = new System.Drawing.Point(339, 306);
            this.txtDescreption.Name = "txtDescreption";
            this.txtDescreption.Size = new System.Drawing.Size(722, 30);
            this.txtDescreption.TabIndex = 10;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(339, 234);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(499, 30);
            this.txtBookName.TabIndex = 9;
            // 
            // cmboCategory
            // 
            this.cmboCategory.FormattingEnabled = true;
            this.cmboCategory.Location = new System.Drawing.Point(339, 166);
            this.cmboCategory.Name = "cmboCategory";
            this.cmboCategory.Size = new System.Drawing.Size(391, 33);
            this.cmboCategory.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(339, 104);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(543, 30);
            this.txtTitle.TabIndex = 7;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(339, 37);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(374, 30);
            this.txtISBN.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Descreption:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Book Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ISBN:";
            // 
            // AlterBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 674);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControl1);
            this.Name = "AlterBooksForm";
            this.Text = "AlterBooksForm";
            this.Load += new System.EventHandler(this.AlterBooksForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbFindBook.ResumeLayout(false);
            this.tbFindBook.PerformLayout();
            this.tbAddBook.ResumeLayout(false);
            this.tbAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbFindBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchBook;
        private System.Windows.Forms.ComboBox cmboBook;
        private System.Windows.Forms.ListBox listDisplay;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnRmove;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TabPage tbAddBook;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.TextBox txtDescreption;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.ComboBox cmboCategory;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}