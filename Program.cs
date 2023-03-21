using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {

            Taxialip taxi = new Taxialip();

            taxi.DriverName = "Alip";
            taxi.OnDuty = true;
            taxi.NumPassenger = 500;

            taxi.TaxiInfo();
            taxi.TaxiPickUp();
            taxi.TaxiDropOut();
        }
    }
}
