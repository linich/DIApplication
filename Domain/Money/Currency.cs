namespace Domain;

public class Currency {
    public string Code { get;}
    public Currency(string code) {
        Code = code ?? throw new ArgumentNullException(nameof(code));
    }
}
