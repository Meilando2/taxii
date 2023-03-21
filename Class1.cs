using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class TaxiOne
    {
        public string DriverName { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("\n Taxi Info \n");
            Console.WriteLine("Nama Driver: {0}", DriverName);

            if (OnDuty == true)
            {
                Console.WriteLine("Kerja : Iya", OnDuty);
            }
            else
            {
                Console.WriteLine("Kerja : Tidak", OnDuty);
            }
            Console.WriteLine("Nomor Pelanggan : {0}", NumPassenger);
        }
        public void PickupPassanger()
        {
            Console.WriteLine("\n {0} Sedang Menaikkan Penumpang", DriverName);
        }
        public void DropoffPassanger()
        {
            Console.WriteLine("\n {0} Sedang Menurunkan Penumpang", DriverName);
        }
    }
}
