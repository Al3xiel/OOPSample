using System.Diagnostics.Contracts;

namespace OOPSample.Sales.Domain.Model.Aggregates;

public class SalesOrderItem
{
    public SalesOrderItem(Guid salesOrderId, int productId, int quantity, double unitPrice)
    {
        if (salesOrderId == Guid.Empty)
        {
            throw new ArgumentException("SalesOrderId cannot be empty");
        }
        if (productId <= 0)
        {
            throw new ArgumentException("Product ID is required");
        }

        if (quantity <= 0)
        {
            throw new ArgumentException("Quantity must be grater than zero");
        }
        if (unitPrice <= 0)
        {
            throw new ArgumentException("Quantity must be grater than zero");
        }
        SalesOrderId = salesOrderId;
        ProductId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }

    public double CalculateItemPrice() => Quantity * UnitPrice;
    
    public Guid Id { get; private set; } = GenerateOrderItemId();
    public Guid SalesOrderId { get;}
    public int ProductId { get;}
    public int Quantity { get;}
    public double UnitPrice { get;}

    private static Guid GenerateOrderItemId()
    {
        return Guid.NewGuid();
    }
}