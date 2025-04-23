namespace PowerBilling.WASM.Models;

public static class BillingConfiguration
{
    public static readonly  List<Tier> ResidentialTiers =
    [
        new Tier { Name = "Up to 160 kWh", UpperLimit = 160, Rate = 0.05m },
        new Tier { Name = "Up to 300 kWh", UpperLimit = 300, Rate = 0.10m },
        new Tier { Name = "Up to 500 kWh", UpperLimit = 500, Rate = 0.12m },
        new Tier { Name = "Up to 600 kWh", UpperLimit = 600, Rate = 0.16m },
        new Tier { Name = "Up to 750 kWh", UpperLimit = 750, Rate = 0.22m },
        new Tier { Name = "Up to 1000 kWh", UpperLimit = 1000, Rate = 0.27m },
        new Tier { Name = "Above 1000 kWh", UpperLimit = int.MaxValue, Rate = 0.37m }
    ];

    public static readonly  List<Tier> CommercialTiers =
    [
        new Tier { Name = "Up to 200 kWh", UpperLimit = 260, Rate = 0.08m },
        new Tier { Name = "Up to 500 kWh", UpperLimit = 500, Rate = 0.15m },
        new Tier { Name = "Above 500 kWh", UpperLimit = 500, Rate = 0.25m },
    ];

}
