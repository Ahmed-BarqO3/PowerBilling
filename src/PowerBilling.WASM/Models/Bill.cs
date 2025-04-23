namespace PowerBilling.WASM.Models;

public record Bill(BillType Type, DateOnly StartDate, DateOnly EndDate, List<BillDetail> Details);

public record BillDetail(string TierName, int Consumption, decimal Rate, decimal Total);


public enum BillType
{
    Residential,
    Commercial
}
