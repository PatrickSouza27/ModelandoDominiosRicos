﻿namespace PaymentContext.Domain.Entities;

public class Subscription
{
    private IList<Payment> _payments;
    public DateTime CreateDate { get; private set; }
    public DateTime LastUpdateDate { get; private set; }
    public DateTime ExpireDate { get; private set; }
    public bool Active { get; private set; }

    public IReadOnlyCollection<Payment> Payments
    {
        get { return _payments.ToList(); }
    }

    public Subscription()
    {
        
    }

    public Subscription(DateTime expireDate)
    {
        CreateDate = DateTime.Now;
        LastUpdateDate = DateTime.Now;
        ExpireDate = expireDate;
        Active = true;
        _payments = new List<Payment>();
    }

    public void AddPayment(Payment payment)
    {
        _payments.Add(payment);
    }

    public void ActiveSubscription()
    {
        Active = true;
        LastUpdateDate = DateTime.Now;
    }
        

    public void DesactiveSubscription()
    {
        Active = false;
        LastUpdateDate = DateTime.Now;
    } 
    
    
}