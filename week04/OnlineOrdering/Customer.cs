public class Customer
{
    private string _name;
    private Address _address;

    public Customer(String nameInput, Address addressInput)
    {

        _name = nameInput;
        _address = addressInput;

    }

    /*  public int LivesInUSA(string usaInput)
      {
          if (usaInput == "usa")
          {
              return 5;
          }

          else {
              return 35;
          }

      }*/

    public string GetName() => _name;
    public string GetAddressLabel() => _address.GetFullAddress();
    public Address GetAddress() => _address;




}