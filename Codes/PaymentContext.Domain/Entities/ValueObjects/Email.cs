using PaymentContext.Shared.Entities.ValueObjects;

namespace PaymentContext.Domain.Entities.ValueObjects;

public class Email(string address) : ValueObject
{
    public string Address { get; private set; } = address;
}