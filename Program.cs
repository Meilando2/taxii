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

            TaxiOne taxi = new TaxiOne();

            taxi.DriverName = "Ipul";
            taxi.OnDuty = false;
            taxi.NumPassenger = 82739182;

            taxi.TaxiInfo();
            taxi.PickupPassanger();
            taxi.DropoffPassanger();
        }
    }
}
