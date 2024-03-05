namespace Domain;
public interface ICurrencyConverter {
    Money Exchange(Money money, Currency currentCurrency);
}