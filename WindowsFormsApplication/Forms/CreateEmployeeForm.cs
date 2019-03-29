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
            
        }

        private void EmployeeTypeListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        //
        private void CreateEmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
