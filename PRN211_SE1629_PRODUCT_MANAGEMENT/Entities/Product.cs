namespace PRN.SE1629;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string Desc { get; set; }
    public double UnitPrice { get; set; }
    public int Quantity { get; set; }

    public Product() { }

    public Product(int id, string productName, string desc, double unitPrice, int quantity)
    {
        Id = id;
        ProductName = productName;
        Desc = desc;
        UnitPrice = unitPrice;
        Quantity = quantity;
    }
    public override string ToString() => $"[ID = {Id}, Product Name = {ProductName}, Desc = {Desc}, Unit Price = {UnitPrice}, Quantity = {Quantity}";

    /*Increase percent unit_price*/
    public void IncreaseUnitPrice(double unitPrice) => UnitPrice = UnitPrice * unitPrice/100;
}
