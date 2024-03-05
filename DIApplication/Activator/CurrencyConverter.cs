using Domain;

public class CurrencyConverter: ICurrencyConverter {
    Money ICurrencyConverter.Exchange(Money money, Currency currentCurrency)
    {
        return new Money(money.Amount*2, currentCurrency);
    }
}