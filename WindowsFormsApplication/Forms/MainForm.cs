using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicApplication.Company;

namespace WindowsFormsApplication.Forms
{
    public partial class MainForm : Form
    {
        // department
        public Department Department { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            Department = new Department(); // create department
        }

        private void CreateEmployeeButton_Click(object sender, EventArgs e)
        {
            // create & open Form to create new Employee instance
            var createEmployeeForm = new CreateEmployeeForm();
            createEmployeeForm.Show();
        }
    }
}
