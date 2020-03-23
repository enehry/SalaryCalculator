using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class MainForm : Form
    {

        private string position;
        private double salaryPerDay;
        private double totalSalary;

        private double govDeduc = 600;
        private double ensurance = 500;
        private double totalTax = 0.05;
        private double totalDeduction = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void populatePosition()
        {
            cmbBoxPosition.Items.Add("Developer");
            cmbBoxPosition.Items.Add("Software Engineer");
            cmbBoxPosition.Items.Add("System Analyst");
            cmbBoxPosition.Items.Add("DevOps Engineer");
            cmbBoxPosition.Items.Add("Software Tester");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            populatePosition();
        }

        private void cmbBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbBoxPosition.SelectedIndex;
            position = cmbBoxPosition.Items[selectedIndex].ToString();
            if (selectedIndex == 0) salaryPerDay = 1500;
            else if (selectedIndex == 1) salaryPerDay = 2000;
            else if (selectedIndex == 2) salaryPerDay = 1000;
            else if (selectedIndex == 3) salaryPerDay = 2500;
            else if (selectedIndex == 4) salaryPerDay = 1000;

            txtTotalSalary.Text = String.Format("{0:0,0.0}", totalSalary);
            txtTotalDeduction.Text = String.Format("{0:0,0.0}", totalDeduction);
            txtNetPay.Text = String.Format("{0:0,0.0}", totalSalary - totalDeduction);
        }

        private void SpinnerWorkingDays_ValueChanged(object sender, EventArgs e)
        {
            totalSalary = salaryPerDay * (double)SpinnerWorkingDays.Value;
            if(totalSalary >= 10000)
            {
                chkBoxEnsurance.Enabled = true;
                chkBoxGovDeduc.Enabled = true;
                chkBoxTax.Enabled = true;
            }
            else
            {
                chkBoxEnsurance.Enabled = false;
                chkBoxGovDeduc.Enabled = false;
                chkBoxTax.Enabled = false;

                chkBoxEnsurance.Checked = false;
                chkBoxGovDeduc.Checked = false;
                chkBoxTax.Checked = false;

                txtTotalDeduction.Text = "0";
            }
            txtTotalSalary.Text = String.Format("{0:0,0.0}", totalSalary);
            txtTotalDeduction.Text = String.Format("{0:0,0.0}", totalDeduction);
            txtNetPay.Text = String.Format("{0:0,0.0}", totalSalary - totalDeduction);
        }

        private void chkBoxGovDeduc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxGovDeduc.Checked == true)
            {
                totalDeduction += govDeduc;
            }
            else
            {
                totalDeduction -= govDeduc;
            }

            txtTotalDeduction.Text = String.Format("{0:0,0.0}", totalDeduction);
            txtNetPay.Text = String.Format("{0:0,0.0}", totalSalary - totalDeduction);
        }

        private void chkBoxEnsurance_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxEnsurance.Checked == true)
            {
                totalDeduction += ensurance;
            }
            else
            {
                totalDeduction -= ensurance;
            }

            txtTotalDeduction.Text = String.Format("{0:0,0.0}", totalDeduction);
            txtNetPay.Text = String.Format("{0:0,0.0}", totalSalary - totalDeduction);
        }

        private void chkBoxTax_CheckedChanged(object sender, EventArgs e)
        {
            if(chkBoxTax.Checked == true)
            {
                totalTax = totalSalary * 0.05;
                totalDeduction += totalTax;
            }
            else
            {
                totalDeduction -= totalTax;
            }


            txtTotalDeduction.Text = String.Format("{0:0,0.0}", totalDeduction);
            txtNetPay.Text = String.Format("{0:0,0.0}", totalSalary - totalDeduction);
        }

        String fieldMessages = "";
        bool isvalid = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEmpNo.Text))
            {
                fieldMessages += "Emp No is Required \n";
                isvalid = false;
            }
            if (String.IsNullOrWhiteSpace(txtFname.Text))
            {
                fieldMessages += "First Name is Required \n";
                isvalid = false;
            }
            if (String.IsNullOrWhiteSpace(txtLname.Text))
            {
                fieldMessages += "Last Name is Required \n";
                isvalid = false;
            }
            if (String.IsNullOrWhiteSpace(cmbBoxPosition.Text))
            {
                fieldMessages += "Position is Required \n";
                isvalid = false;
            }
            if (isvalid)
            {
                ListViewItem item = new ListViewItem(txtEmpNo.Text);
                item.SubItems.Add(txtFname.Text + " " + txtMname.Text + " " + txtLname.Text);
                item.SubItems.Add(cmbBoxPosition.Text);
                item.SubItems.Add(totalSalary.ToString());
                item.SubItems.Add(totalDeduction.ToString());
                item.SubItems.Add(txtNetPay.Text);
                listViewSalaryEmp.Items.Add(item);

                clearFields();
    
            }
            else
            {
                fieldValidation(fieldMessages);
                isvalid = true;
                fieldMessages = "";
                return;
            }

           

  
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (listViewSalaryEmp.SelectedItems.Count > 0)
            {
              DialogResult dResult = MessageBox.Show("Are you sure you want to delete this item ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dResult == DialogResult.Yes)
                {
                    foreach (ListViewItem eachItem in listViewSalaryEmp.SelectedItems)
                    {
                       listViewSalaryEmp.Items.Remove(eachItem);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select item first! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

        }
        private void fieldValidation(String fieldMessage)
        {
            MessageBox.Show(fieldMessages, "Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void clearFields()
        {
            txtEmpNo.Text = "";
            txtFname.Text = "";
            txtMname.Text = "";
            txtLname.Text = "";
            txtNetPay.Text = "";
            txtTotalDeduction.Text = "";
            txtTotalSalary.Text = "";

            cmbBoxPosition.Text = "";

            SpinnerWorkingDays.Value = 0;

            chkBoxEnsurance.Enabled = false;
            chkBoxGovDeduc.Enabled = false;
            chkBoxTax.Enabled = false;

            chkBoxEnsurance.Checked = false;
            chkBoxGovDeduc.Checked = false;
            chkBoxTax.Checked = false;




        }
    }

   
}
