using DesignPatterns.Decorator.DataPlan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.SpecialDataPlan;

public class AWaThonePlan : DataPlanDecorator
{
    public AWaThonePlan(IDataPlan dataPlan) : base(dataPlan)
    {
    }
    public override string GetPlanName()
    {
        return base.GetPlanName() + " +  A Wa Thone (2 Days)";
    }
    public override decimal GetCost()
    {
        return base.GetCost() + 3000.00m;
    }

}
