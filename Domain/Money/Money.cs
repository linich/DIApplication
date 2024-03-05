namespace Domain;

public class Money {
    public decimal Amount { get;}
    public Currency Currency { get;}
    public Money(decimal amount, Currency currency) {
        Amount = amount;
        Currency = currency ?? throw new ArgumentNullException(nameof(currency));
    }

    public static Money operator *(Money w1, decimal value)
    {
        return new Money(w1.Amount * value, w1.Currency);
    }

    public static Money operator *(decimal value, Money w1)
    {
        return w1*value;
    }
}
