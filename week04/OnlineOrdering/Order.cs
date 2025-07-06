using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customerInput)
    {
        _customer = customerInput;
    }

    public void AddProduct(Product productInput)
    {
        _products.Add(productInput);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }
        total += _customer.LivesInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()

    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Packing Label:");
        foreach (var product in _products)
        {
            sb.AppendLine(product.GetPackingInto());

        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {

        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddressLabel()}";
    }

}