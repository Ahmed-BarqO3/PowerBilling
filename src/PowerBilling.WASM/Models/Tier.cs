namespace PowerBilling.WASM.Models;

public class Tier
{
    public string Name { get; set; } = string.Empty;
    public int UpperLimit { get; set; }
    public decimal Rate { get; set; }
    
}
