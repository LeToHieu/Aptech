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
            dataGridView.AutoGenerateColumns = false;
            dataGridView.RowHeadersVisible = false;
            //dataGridView.ColumnHeadersVisible = false;
            dataGridView.ReadOnly = true;
            //dataGridView.MultiSelect = false;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataSet dataSet = Database.Database.Instance.GetStudents();
            //className, studentName,userName,address             
            //Set Columns Count
            dataGridView.ColumnCount = 4;
            //Add Columns
            dataGridView.Columns[0].Name = "TenLop";
            dataGridView.Columns[0].HeaderText = "Ten lop";
            dataGridView.Columns[0].DataPropertyName = "ClassName";

            dataGridView.Columns[1].Name = "TenSV";
            dataGridView.Columns[1].HeaderText = "Ten SV";
            dataGridView.Columns[1].DataPropertyName = "StudentName";

            dataGridView.Columns[2].Name = "UserNm";
            dataGridView.Columns[2].HeaderText = "UserNm";
            dataGridView.Columns[2].DataPropertyName = "UserName";

            dataGridView.Columns[3].Name = "DiaChi";
            dataGridView.Columns[3].HeaderText = "Dia chi";
            dataGridView.Columns[3].DataPropertyName = "Address";

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

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
