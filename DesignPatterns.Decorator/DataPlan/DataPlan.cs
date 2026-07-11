using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.DataPlan;

public class DataPlan : IDataPlan
{
    public string PlanName { get; set; } = null!;
    public decimal Cost { get; set; }
    public String GetPlanName()
    {
        return PlanName;
    }

    public decimal GetCost()
    {
        return Cost;
    }
}
