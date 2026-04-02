/*
Address.cs

This class is just for storing address info like street, city, state, and country. 
It has a method to get the full address as one string so other classes can easily use it. 
It keeps all the address stuff in one place so the code is cleaner.

THIS IS NOT AI. I AM TRYING TO DEVELOP GOOD PROGRAMMING SKILLS LIKE COMMENTING IN YOUR CODE.
*/public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}