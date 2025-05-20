namespace DevPrinciples.Models;

public class Address
{
    public Street Street { get; set; }

    public Address(Street street)
    {
        Street = street;
    }
}