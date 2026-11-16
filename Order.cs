using System.Text.Json.Nodes;

public class Order
{
    public int OrderNumber {get; set;}
    public string ProductName {get; set;}
    public int Quantity {get; set;}
    public decimal TotalAmount {get; set;}

    public Order(int On1,string Pn, int q, decimal Ta)
    {
        OrderNumber = On1;
        ProductName = Pn;
        Quantity = q;
        TotalAmount = Ta;
    }
    public void DisplayInfo()
    {
        System.Console.WriteLine($"Информация о заказах: {OrderNumber}, {ProductName}, {Quantity}, {TotalAmount}");   
    }
}