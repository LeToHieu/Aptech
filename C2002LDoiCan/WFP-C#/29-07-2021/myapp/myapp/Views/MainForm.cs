using myapp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myapp
{
    public partial class MainForm : Form
    {
        public LoginForm LoginForm { get; set; }
        private void SetupDataGridView() {
            dataGridView.Columns[0].Name = "TenLop";
            dataGridView.Columns[1].Name = "TenSv";
            dataGridView.Columns[2].Name = "UserNm";
            dataGridView.Columns[3].Name = "DiaChi";
            dataGridView.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;

        }
        public void fetchDataToGridView(List<Dictionary<String, String>> data) { 
            dataGridView.Rows.Clear(); 
            foreach (Dictionary<String, String> dictionary in data) {
                string[] eachRowData = { 
                    dictionary["TenLop"], 
                    dictionary["SiSo"], 
                    dictionary["TenSv"], 
                    dictionary["UserNm"],
                    dictionary["DiaChi"],

                };
                dataGridView.Rows.Add(eachRowData);
            }
        }
        public MainForm()
        {
            InitializeComponent();//nam o partial class khac
            Database database = new Database(); //must use Singleton Object                                  
            List<Dictionary<String, String>> data = database.GetClassStudent();
            SetupDataGridView();
            fetchDataToGridView(data);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExportXML_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Export successfully");
        }
    }
}
