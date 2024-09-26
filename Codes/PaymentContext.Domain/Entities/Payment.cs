using PaymentContext.Domain.Entities.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities;

public abstract class Payment : Entity
{
    public DateTime PaidDate { get; private set; }
    public DateTime ExpireDate { get; private set; }
    public decimal Total { get; private set; }
    public decimal TotalPaid { get; private set; }
    public Document Document { get; private set; }
    public string Payer { get; private set; }
    public Address Address { get; private set; }
    public Email Email { get; private set; }    
    
    public Payment(Email email, Document document, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Address address, string payer)
    {
        Email = email;
        PaidDate = paidDate;
        ExpireDate = expireDate;
        Total = total;
        TotalPaid = totalPaid;
        Document = document;
        Address = address;
        Payer = payer;
    }
    
}
public class BoletoPayment : Payment
{
    public string BarCode { get; set; }
    public string BoletoNumber { get; set; }

    public BoletoPayment(Email email, Document document, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Address address, string payer, string barCode, string boletoNumber) : base(email, document, paidDate, expireDate, total, totalPaid, address, payer)
    {
        BarCode = barCode;
        BoletoNumber = boletoNumber;
    }
}
public class CreditPayment : Payment
{
    public string CardHolderName { get; set; }
    public string CardNumber { get; set; }
    public string LastTranscationNumber { get; set; }


    public CreditPayment(Email email, Document document, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Address address, string payer, string cardNumber, string cardHolderName, string lastTranscationNumber) : base(email, document, paidDate, expireDate, total, totalPaid, address, payer)
    {
        CardHolderName = cardHolderName;
        CardNumber = cardNumber;
        LastTranscationNumber = lastTranscationNumber;
    }
}
public class PayPalPayment : Payment
{
    public string TranscationCode { get; set; }

    public PayPalPayment(Email email, Document document, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Address address, string payer, string transcationCode) : base(email, document, paidDate, expireDate, total, totalPaid, address, payer)
        => TranscationCode = transcationCode;
    
}