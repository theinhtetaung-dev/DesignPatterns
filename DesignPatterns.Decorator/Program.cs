using DesignPatterns.Decorator.DataPlan;
using DesignPatterns.Decorator.SpecialDataPlan;

IDataPlan dataPlan = new DataPlan
{
    PlanName = "Basic Data Plan 1 GB",
    Cost = 1000.00m
};

Console.WriteLine("Customer 1  : ");
Console.WriteLine("Buy Base Plan : ");
Console.WriteLine("Initial Plan: " + dataPlan.GetPlanName());
Console.WriteLine("Initial Cost: " + dataPlan.GetCost());
Console.WriteLine();

dataPlan = new FaceBookPlan(dataPlan);

Console.WriteLine("Update Plan : ");
Console.WriteLine("After adding Facebook Plan: " + dataPlan.GetPlanName());
Console.WriteLine("After adding Facebook Plan Cost: " + dataPlan.GetCost());
Console.WriteLine();


dataPlan = new TikTokPlan(dataPlan);

Console.WriteLine("Update Plan : ");
Console.WriteLine("After adding TikTok Plan: " + dataPlan.GetPlanName());
Console.WriteLine("After adding TikTok Plan Cost: " + dataPlan.GetCost());
Console.WriteLine("---------------------------------------------------\n");
Console.WriteLine("\n");


Console.WriteLine("Customer 2  : ");

IDataPlan dataPlan1 = new DataPlan
{
    PlanName = "Basic Data Plan 2 GB",
    Cost = 2000.00m
};

dataPlan1 = new TikTokPlan(new FaceBookPlan (new AWaThonePlan(dataPlan1)));

Console.WriteLine("After adding A Wa Thone Plan, Facebook Plan and TikTok Plan: " + dataPlan1.GetPlanName());
Console.WriteLine("After adding A Wa Thone Plan, Facebook Plan and TikTok Plan Cost: " + dataPlan1.GetCost());



