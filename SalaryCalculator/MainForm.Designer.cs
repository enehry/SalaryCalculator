namespace SalaryCalculator
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalDeduction = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.SpinnerWorkingDays = new System.Windows.Forms.NumericUpDown();
            this.cmbBoxPosition = new System.Windows.Forms.ComboBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtMname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBoxTax = new System.Windows.Forms.CheckBox();
            this.chkBoxEnsurance = new System.Windows.Forms.CheckBox();
            this.chkBoxGovDeduc = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewSalaryEmp = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerWorkingDays)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtTotalSalary);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTotalDeduction);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtNetPay);
            this.panel1.Controls.Add(this.SpinnerWorkingDays);
            this.panel1.Controls.Add(this.cmbBoxPosition);
            this.panel1.Controls.Add(this.txtLname);
            this.panel1.Controls.Add(this.txtMname);
            this.panel1.Controls.Add(this.txtFname);
            this.panel1.Controls.Add(this.txtEmpNo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 431);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label9.Location = new System.Drawing.Point(8, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total Salary";
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTotalSalary.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSalary.ForeColor = System.Drawing.SystemColors.Info;
            this.txtTotalSalary.Location = new System.Drawing.Point(96, 205);
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.ReadOnly = true;
            this.txtTotalSalary.Size = new System.Drawing.Size(220, 23);
            this.txtTotalSalary.TabIndex = 19;
            this.txtTotalSalary.Text = "00.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label8.Location = new System.Drawing.Point(8, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total Deduction";
            // 
            // txtTotalDeduction
            // 
            this.txtTotalDeduction.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtTotalDeduction.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDeduction.ForeColor = System.Drawing.SystemColors.Info;
            this.txtTotalDeduction.Location = new System.Drawing.Point(117, 361);
            this.txtTotalDeduction.Name = "txtTotalDeduction";
            this.txtTotalDeduction.ReadOnly = true;
            this.txtTotalDeduction.Size = new System.Drawing.Size(201, 23);
            this.txtTotalDeduction.TabIndex = 17;
            this.txtTotalDeduction.Text = "00.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label7.Location = new System.Drawing.Point(8, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Net Pay";
            // 
            // txtNetPay
            // 
            this.txtNetPay.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtNetPay.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetPay.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNetPay.Location = new System.Drawing.Point(117, 391);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.Size = new System.Drawing.Size(201, 23);
            this.txtNetPay.TabIndex = 15;
            this.txtNetPay.Text = "00.00";
            // 
            // SpinnerWorkingDays
            // 
            this.SpinnerWorkingDays.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpinnerWorkingDays.Location = new System.Drawing.Point(137, 170);
            this.SpinnerWorkingDays.Name = "SpinnerWorkingDays";
            this.SpinnerWorkingDays.Size = new System.Drawing.Size(181, 25);
            this.SpinnerWorkingDays.TabIndex = 6;
            this.SpinnerWorkingDays.ValueChanged += new System.EventHandler(this.SpinnerWorkingDays_ValueChanged);
            // 
            // cmbBoxPosition
            // 
            this.cmbBoxPosition.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxPosition.FormattingEnabled = true;
            this.cmbBoxPosition.Location = new System.Drawing.Point(96, 139);
            this.cmbBoxPosition.Name = "cmbBoxPosition";
            this.cmbBoxPosition.Size = new System.Drawing.Size(222, 21);
            this.cmbBoxPosition.TabIndex = 5;
            this.cmbBoxPosition.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPosition_SelectedIndexChanged);
            // 
            // txtLname
            // 
            this.txtLname.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.Location = new System.Drawing.Point(96, 110);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(222, 22);
            this.txtLname.TabIndex = 4;
            // 
            // txtMname
            // 
            this.txtMname.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMname.Location = new System.Drawing.Point(96, 81);
            this.txtMname.Name = "txtMname";
            this.txtMname.Size = new System.Drawing.Size(222, 22);
            this.txtMname.TabIndex = 3;
            // 
            // txtFname
            // 
            this.txtFname.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.Location = new System.Drawing.Point(96, 52);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(222, 22);
            this.txtFname.TabIndex = 2;
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpNo.Location = new System.Drawing.Point(96, 23);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(222, 22);
            this.txtEmpNo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkBoxTax);
            this.groupBox1.Controls.Add(this.chkBoxEnsurance);
            this.groupBox1.Controls.Add(this.chkBoxGovDeduc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 111);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deduction";
            // 
            // chkBoxTax
            // 
            this.chkBoxTax.AutoSize = true;
            this.chkBoxTax.Enabled = false;
            this.chkBoxTax.Location = new System.Drawing.Point(7, 79);
            this.chkBoxTax.Name = "chkBoxTax";
            this.chkBoxTax.Size = new System.Drawing.Size(49, 23);
            this.chkBoxTax.TabIndex = 9;
            this.chkBoxTax.Text = "Tax";
            this.chkBoxTax.UseVisualStyleBackColor = true;
            this.chkBoxTax.CheckedChanged += new System.EventHandler(this.chkBoxTax_CheckedChanged);
            // 
            // chkBoxEnsurance
            // 
            this.chkBoxEnsurance.AutoSize = true;
            this.chkBoxEnsurance.Enabled = false;
            this.chkBoxEnsurance.Location = new System.Drawing.Point(7, 50);
            this.chkBoxEnsurance.Name = "chkBoxEnsurance";
            this.chkBoxEnsurance.Size = new System.Drawing.Size(91, 23);
            this.chkBoxEnsurance.TabIndex = 8;
            this.chkBoxEnsurance.Text = "Ensurance";
            this.chkBoxEnsurance.UseVisualStyleBackColor = true;
            this.chkBoxEnsurance.CheckedChanged += new System.EventHandler(this.chkBoxEnsurance_CheckedChanged);
            // 
            // chkBoxGovDeduc
            // 
            this.chkBoxGovDeduc.AutoSize = true;
            this.chkBoxGovDeduc.Enabled = false;
            this.chkBoxGovDeduc.Location = new System.Drawing.Point(7, 23);
            this.chkBoxGovDeduc.Name = "chkBoxGovDeduc";
            this.chkBoxGovDeduc.Size = new System.Drawing.Size(205, 23);
            this.chkBoxGovDeduc.TabIndex = 7;
            this.chkBoxGovDeduc.Text = "SSS, PAGIBIG, PHIL. HEALTH";
            this.chkBoxGovDeduc.UseVisualStyleBackColor = true;
            this.chkBoxGovDeduc.CheckedChanged += new System.EventHandler(this.chkBoxGovDeduc_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label6.Location = new System.Drawing.Point(8, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Working Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label5.Location = new System.Drawing.Point(8, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Middle Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp. No.";
            // 
            // listViewSalaryEmp
            // 
            this.listViewSalaryEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewSalaryEmp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewSalaryEmp.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewSalaryEmp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listViewSalaryEmp.FullRowSelect = true;
            this.listViewSalaryEmp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewSalaryEmp.Location = new System.Drawing.Point(359, 13);
            this.listViewSalaryEmp.MultiSelect = false;
            this.listViewSalaryEmp.Name = "listViewSalaryEmp";
            this.listViewSalaryEmp.Size = new System.Drawing.Size(525, 431);
            this.listViewSalaryEmp.TabIndex = 1;
            this.listViewSalaryEmp.UseCompatibleStateImageBehavior = false;
            this.listViewSalaryEmp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Emp. No.";
            this.columnHeader1.Width = 69;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Full Name";
            this.columnHeader2.Width = 127;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Position";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Salary";
            this.columnHeader4.Width = 73;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total Deduction";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Net Pay";
            this.columnHeader7.Width = 93;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAdd.Location = new System.Drawing.Point(233, 450);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 39);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD TO LIST";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.Location = new System.Drawing.Point(775, 450);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 39);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(896, 501);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listViewSalaryEmp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerWorkingDays)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listViewSalaryEmp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalDeduction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.NumericUpDown SpinnerWorkingDays;
        private System.Windows.Forms.ComboBox cmbBoxPosition;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtMname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkBoxTax;
        private System.Windows.Forms.CheckBox chkBoxEnsurance;
        private System.Windows.Forms.CheckBox chkBoxGovDeduc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}

