public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;


    public Product(string nameInput, string productIdInput, double priceInput, int quantityInput)
    {
        _name = nameInput;
        _productId = productIdInput;
        _price = priceInput;
        _quantity = quantityInput;
    }

    public double GetTotalCost() => _price * _quantity;

    public string GetPackingInto() => $"{_name} (ID: {_productId})";

}