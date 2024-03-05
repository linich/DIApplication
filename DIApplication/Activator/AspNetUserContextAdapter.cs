using Domain;

public class AspNetUserContextAdapter: IUserContext {
    public bool IsUserInRole(Role role) {
        return false;
    }
}
