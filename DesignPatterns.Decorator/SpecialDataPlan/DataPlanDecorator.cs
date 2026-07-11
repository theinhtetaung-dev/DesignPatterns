using DesignPatterns.Decorator.DataPlan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator.SpecialDataPlan;

public abstract class DataPlanDecorator : IDataPlan
{
    private readonly IDataPlan _dataPlan;

    protected DataPlanDecorator(IDataPlan dataPlan)
    {
        _dataPlan = dataPlan;
    }
    public virtual string GetPlanName()
    {
        return _dataPlan.GetPlanName();
    }

    public virtual decimal GetCost()
    {
        return _dataPlan.GetCost();
    }


}
