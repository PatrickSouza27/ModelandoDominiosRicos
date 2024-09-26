using System.Collections.ObjectModel;
using PaymentContext.Domain.Entities.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities;

public class Student : Entity
{
    private IList<Subscription> _subscriptions;
    public Name Name { get; set; }
    public Document Document { get; private set; }
    public Email Email { get; private set; }
    public string Address { get; private set; }
    public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToList(); } }

    public Student()
    {
        
    }
    public Student(Name name, Document document, Email email)
    {
        Name = name;
        Document = document;
        Email = email;
        _subscriptions = new List<Subscription>();
    }

    public void AddSubscription(Subscription subscription)
    {
        // se já tiver uma assinatura ativa, cancela
        
        //cancela todas as outras assinaturas e coloca está como principal

        foreach (var subscriptionRegister in Subscriptions)
        {
            subscriptionRegister.DesactiveSubscription();
        }
        
        _subscriptions.Add(subscription);
    }
}