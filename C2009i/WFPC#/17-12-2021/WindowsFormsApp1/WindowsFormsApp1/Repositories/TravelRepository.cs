using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Repositories
{
    public class TravelRepository
    {
        public List<Travel> GetTravels() {
            //get data somewhere....
            return new List<Travel>
            {
                new Travel() { 
                    TravelId = 1,
                    Name = "di choi xx11", 
                    From = "Hanoi",
                    To = "HCM City",
                    Price = 1234.55,
                    StartDate = new DateTime(2021, 12, 30)
                },
                new Travel() {
                    TravelId = 2,
                    Name = "di choi xx22",
                    From = "Hanoi",
                    To = "HCM City",
                    Price = 4444.55,
                    StartDate = new DateTime(2021, 12, 30)
                },
                new Travel() {
                    TravelId = 3,
                    Name = "di choi xx44",
                    From = "Hanoi",
                    To = "HCM City",
                    Price = 2222.55,
                    StartDate = new DateTime(2021, 12, 30)
                },
                new Travel() {
                    TravelId = 4,
                    Name = "di choi xx33",
                    From = "Hanoi",
                    To = "HCM City",
                    Price = 1111.55,
                    StartDate = new DateTime(2021, 12, 30)
                },

            };
        }
    }
}
