public class Address
{

    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetInput, string cityInput, string stateInput, string countryInput)
    {
        _street = streetInput;
        _city = cityInput;
        _state = stateInput;
        _country = countryInput;
    }

    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}
