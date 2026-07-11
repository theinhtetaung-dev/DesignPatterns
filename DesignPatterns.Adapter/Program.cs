using DesignPatterns.Adapter.Pyament;

IPayment systemPayment = new SystemPayment();
Console.WriteLine("Using SystemPayment:");
systemPayment.Pay("0912345678", 10000m);
Console.WriteLine();

ThirdPartyPayment thirdPartyPayment = new ThirdPartyPayment();
Console.WriteLine("Using ThirdPartyPayment directly:");
thirdPartyPayment.Pay("0912345678", 10000f, "MMK", "Debt");
Console.WriteLine();

IPayment paymentAdapter = new PaymemtAdapter(thirdPartyPayment);
Console.WriteLine("Using PaymemtAdapter:");
paymentAdapter.Pay("0912345678", 10000m);