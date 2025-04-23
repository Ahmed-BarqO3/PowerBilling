namespace PowerBilling.WASM.Models;

public static class BillingCalculater
{
    public static Bill CalculateResidentialBill(
        int Consumption , DateOnly StartDate, DateOnly EndDate)
    {
        if(StartDate > EndDate)
            throw new ArgumentException("Start date must be before end date");
        
        if(Consumption < 0)
            throw new ArgumentException("Consumption cannot be negative");
        
        if(Consumption == 0)
            return new Bill(BillType.Residential, StartDate, EndDate,[]);
        
        List<BillDetail> breakDown = [];
        
        int previousUpperLimit = 0;
        int remainingConsumption = Consumption;

        foreach (var tier in BillingConfiguration.ResidentialTiers)
        {
            
            int tierCapacity = tier.UpperLimit - previousUpperLimit;
            int tierConsumption = Math.Min(remainingConsumption, tierCapacity);
            
            if(tierConsumption < 0 )
                break;
            
            breakDown.Add(new(tier.Name, Consumption, tier.Rate,tierConsumption * tier.Rate));
            
            remainingConsumption -= tierConsumption;
            previousUpperLimit = tier.UpperLimit;
        }
        
        return new(BillType.Residential, StartDate, EndDate,breakDown);
    }

    
    public static Bill CalculateCommercialBill(
        int Consumption , DateOnly StartDate, DateOnly EndDate)
    {
        if(StartDate > EndDate)
            throw new ArgumentException("Start date must be before end date");
        
        if(Consumption < 0)
            throw new ArgumentException("Consumption cannot be negative");
        
        if(Consumption == 0)
            return new Bill(BillType.Commercial, StartDate, EndDate,[]);
        
        List<BillDetail> breakDown = [];
        
        int previousUpperLimit = 0;
        int remainingConsumption = Consumption;

        foreach (var tier in BillingConfiguration.CommercialTiers)
        {
            
            int tierCapacity = tier.UpperLimit - previousUpperLimit;
            int tierConsumption = Math.Min(remainingConsumption, tierCapacity);
            
            if(tierConsumption < 0 )
                break;
            
            breakDown.Add(new(tier.Name, Consumption, tier.Rate,tierConsumption * tier.Rate));
            
            remainingConsumption -= tierConsumption;
            previousUpperLimit = tier.UpperLimit;
        }
        
        return new(BillType.Commercial, StartDate, EndDate,breakDown);
    }
}
