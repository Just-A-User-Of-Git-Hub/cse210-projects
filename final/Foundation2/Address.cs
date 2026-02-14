public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        if(_country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetDetails()
    {
        if(_state == "")
        {
            return $"{_streetAddress}\n{_city}\n{_country}";
        }
        else
        {
            return $"{_streetAddress}\n{_city}, {_state}\n{_country}";
        }
    }
}