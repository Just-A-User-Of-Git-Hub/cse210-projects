using System.Numerics;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public float GetTotalPrice()
    {
        float total = 0;
        foreach(Product product in _products)
        {
            total += product.GetTotalCost();
        }
        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach(Product product in _products)
        {
            packingLabel += $"{product.GetName()} {product.GetID()}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddressDetails()}";
    }
}