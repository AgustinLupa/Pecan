namespace Pecan.Entities;

public class TransactionItem
{
    public CommodityModel Product { get; set; }
    public float QuantityOfProducts { get; set; }
    public float Subtotal => QuantityOfProducts * Product.PricePublic;

    public TransactionItem(CommodityModel product, float QuantityOfProducts) 
    {
        
    }
}
