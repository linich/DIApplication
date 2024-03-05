namespace Domain {
    public interface IUserContext { 
        bool IsUserInRole(Role role);
    }

    public enum Role { PreferedCustomer}
}