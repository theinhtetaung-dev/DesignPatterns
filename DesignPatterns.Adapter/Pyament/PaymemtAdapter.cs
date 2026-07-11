using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Pyament;

public class PaymemtAdapter : IPayment
{
    private readonly ThirdPartyPayment _thirdPartyPayment;

    public PaymemtAdapter(ThirdPartyPayment thirdPartyPayment)
    {
        _thirdPartyPayment = thirdPartyPayment;
    }

    public void Pay(string phoneNo, decimal amount)
    {
        float amountInFloat = (float)amount;
        string currency = "MMK";
        string note = "Payment";

        _thirdPartyPayment.Pay(phoneNo, amountInFloat, currency, note);
    }
}
