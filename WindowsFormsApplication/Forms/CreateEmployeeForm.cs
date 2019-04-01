using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicApplication.Company.Employees;
using WindowsFormsApplication.Database;

namespace WindowsFormsApplication.Forms
{
    public partial class CreateEmployeeForm : Form
    {
        private int _employeeType;

        private string _firstName;
        private string _secondName;
        private decimal _salary;
        private int _experience;
        private decimal _effectiveness;

        public CreateEmployeeForm()
        {
            InitializeComponent();
        }

        private void CreateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (_employeeType != 0)
            {
                CreateEmployee();
            }
            else
            {
                MessageBox.Show("Not Valise Employee Type");
            }
        }

        private void EmployeeTypeListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(EmployeeTypeListComboBox.SelectedItem.ToString())
            {
                case "Manager":
                    _employeeType = 1;
                    break;

                case "Developer":
                    _employeeType = 2;
                    break;

                case "Designer":
                    _employeeType = 3;
                    break;
            }
        }

        private void CreateEmployeeForm_Load(object sender, EventArgs e)
        {
            _employeeType = 0;

            EmployeeTypeListComboBox.Items.Add("Manager");
            EmployeeTypeListComboBox.Items.Add("Developer");
            EmployeeTypeListComboBox.Items.Add("Designer");
        }

        private void CreateEmployee()
        {
            if(FieldsAreNotEmpty())
            {
                // create employee
            }
            else
            {
                MessageBox.Show("Empty field");
            }
        }

        private bool FieldsAreNotEmpty()
        {
            return true;
        }


    }
}
