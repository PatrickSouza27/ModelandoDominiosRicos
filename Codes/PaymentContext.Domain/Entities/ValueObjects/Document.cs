using PaymentContext.Domain.Entities.Enums;
using PaymentContext.Shared.Entities.ValueObjects;

namespace PaymentContext.Domain.Entities.ValueObjects;

public class Document : ValueObject
{
    public string Number { get; private set; }
    public EDocumentType DocumentType { get; set; }
    
    public Document(string number, EDocumentType documentType)
    {
        Number = number;
        DocumentType = documentType;
    }
}