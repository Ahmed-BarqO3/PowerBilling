using System.ComponentModel.DataAnnotations;

namespace PowerBilling.WASM.Models;

public class BillReqset
{
    [Range(0,Int32.MaxValue,
        ErrorMessage = "Consumption must be a positive number")]
    public int Consumption { get; set; }
    public DateOnly StartDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    public DateOnly EndDate { get; set; } = DateOnly.FromDateTime(DateTime.Now).AddMonths(1);
    public BillType BillType { get; set; }
}
