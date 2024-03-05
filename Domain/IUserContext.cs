namespace Domain {
    public interface IUserContext { 
        bool IsUserInRole(Role role);
        Currency Currency { get; }
    }

    public enum Role { PreferedCustomer}
}