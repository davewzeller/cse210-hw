public class Customer
{
    private string _name;
    private Address _address;

    public Customer(String nameInput, Address addressInput)
    {

        _name = nameInput;
        _address = addressInput;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetName() => _name;
    public string GetAddressLabel() => _address.GetFullAddress();




}