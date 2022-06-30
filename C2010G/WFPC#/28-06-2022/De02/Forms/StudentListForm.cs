using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De02.Forms
{
    public partial class StudentListForm : Form
    {
        //public LoginForm loginForm; //field        
        //property
        public LoginForm LoginForm { get; set; }
        public StudentListForm()
        {
            InitializeComponent();
            reloadDataGridView();
        }
        private void reloadDataGridView()
        {
            dataGridView.AutoGenerateColumns = true;
            //dataGridView.MultiSelect = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataSet dataSet = Database.Database.Instance.GetStudents();
            
            dataGridView.DataSource = dataSet.Tables[0];
        }
        protected override void Dispose(bool disposing)
        {
            LoginForm.Enabled = true;
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
