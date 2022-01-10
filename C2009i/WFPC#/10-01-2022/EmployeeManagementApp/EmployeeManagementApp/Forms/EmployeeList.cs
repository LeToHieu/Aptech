using EmployeeManagementApp.Models;
using EmployeeManagementApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementApp.Forms
{
    public partial class EmployeeList : Form
    {
        private Department selectedDepartment;
        private DepartmentRepository departmentRepository = new DepartmentRepository();
        public EmployeeList()
        {
            InitializeComponent();
            SetupTreeView();            
        }
        private void SetupTreeView() {
            //treeview with fake data
            treeView.Nodes.Clear();
            List<Department> departments = departmentRepository.GetAllDepartments();             
            foreach (Department department in departments) {
                TreeNode treeNode = new TreeNode(department.DeparmentName);
                treeNode.Tag = department;
                treeView.Nodes.Add(treeNode);
            }            
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            selectedDepartment = (Department)treeView.SelectedNode.Tag;
            //MessageBox.Show(selectedDepartment.DeparmentName);
            ReloadListView();
        }
        private void ReloadListView() {
            if (selectedDepartment != null) {
                List<Dictionary<string, string>> dictionaries = departmentRepository
                    .getEmployees(selectedDepartment.DeparmentId);
                //fill data to ListView
                ListViewItem item1 = new ListViewItem("item1", 0);
                // Place a check mark next to the item.
                item1.Checked = true;
                item1.SubItems.Add("1");
                item1.SubItems.Add("2");
                item1.SubItems.Add("3");
                ListViewItem item2 = new ListViewItem("item2", 1);
                item2.SubItems.Add("4");
                item2.SubItems.Add("5");
                item2.SubItems.Add("6");
                listView.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
                listView.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
                listView.Items.AddRange(new ListViewItem[] { item1, item2 });
                foreach (Dictionary<string, string> dictionary in dictionaries) {
                    Console.WriteLine("haha");
                }
            }
        }
    }
}
