using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de03
{
    public partial class EmployeeProfile : Form
    {
        private ExamWinFormEntities db = new ExamWinFormEntities();
        public EmployeeProfile()
        {
            InitializeComponent();
            InitializeTreeView();
        }
        private void InitializeTreeView()
        {            
            treeView.BeginUpdate();
            foreach(Department department in db.Departments.ToList()){
                String departmentName = department.DeptName;
                treeView.Nodes.Add(departmentName);
            }
            
            treeView.EndUpdate();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
