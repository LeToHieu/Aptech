using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;
namespace WindowsFormsApp1.Forms
{
    public partial class TravelListForm : Form
    {
        private TravelRepository travelRepository = new TravelRepository();
        public TravelListForm()
        {

            InitializeComponent();

            List<Travel> travels = travelRepository.GetTravels();
            //setup ListView
            listViewTravels.Columns.Add("Name", 100);
            listViewTravels.Columns.Add("From", 100);
            listViewTravels.Columns.Add("To", 100);
            listViewTravels.Columns.Add("Price", 100);
            listViewTravels.Columns.Add("Start Date", 100);

            //iterate a list and fetch data
            foreach (Travel travel in travels) {
                string[] eachRow = { travel.Name, travel.From, travel.To, $"{travel.Price}", $"{travel.StartDate}" };
                listViewTravels.Items.Add(new ListViewItem(eachRow));
            }
            
        }
    }
}
