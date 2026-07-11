using DesignPatterns.Decorator.DataPlan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.SpecialDataPlan;

public class FaceBookPlan : DataPlanDecorator
{
    public FaceBookPlan(IDataPlan dataPlan) : base(dataPlan)
    {
    }
    public override string GetPlanName()
    {
        return base.GetPlanName() + " + Unlimited Facebook (2 Days)";
    }
    public override decimal GetCost()
    {
        return base.GetCost() + 1000.00m; 
    }

}
