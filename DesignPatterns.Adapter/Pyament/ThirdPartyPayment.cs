using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Pyament
{
    public class ThirdPartyPayment
    {
        public void Pay(string phoneNo, float amount,string crrency,string note)
        {
            Console.WriteLine($"Payment of {amount:N2} {crrency} made to {phoneNo} using ThirdPartyPayment. Note: {note}");
        }
    }
}
