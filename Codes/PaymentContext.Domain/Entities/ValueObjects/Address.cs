using PaymentContext.Shared.Entities.ValueObjects;

namespace PaymentContext.Domain.Entities.ValueObjects;

public class Address : ValueObject
{
    public string ZipCode { get; private set; }
    public string Street  { get; private set; }
    public string Number { get; set; }
    public string Neighborhood { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }

    public Address(string zipCode, string street, string number, string neighborhood, string city, string state)
    {
        ZipCode = zipCode;
        Street = street;
        Number = number;
        Neighborhood = neighborhood;
        City = city;
        State = state;
    }
}