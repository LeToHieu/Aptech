using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormDetailsOfEmployee : Form
    {
        public FormDetailsOfEmployee()
        {
            InitializeComponent();
            comboBoxCurrentDepartmentName.DataSource = new List<string> {
                "IT", "Account", "HR"
            };
            checkedListBoxDepartmentWorked.Items.Add("IT", CheckState.Checked);
            checkedListBoxDepartmentWorked.Items.Add("Account", CheckState.Unchecked);
            checkedListBoxDepartmentWorked.Items.Add("HR", CheckState.Checked);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
