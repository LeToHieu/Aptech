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
      
    }
}
