using Domain;

public class AspNetUserContextAdapter: IUserContext {
    private static readonly HttpContextAccessor Accessor = new();
    public bool IsUserInRole(Role role)
    {
        var context = Accessor.HttpContext;
        if (context == null) {
            throw new ArgumentNullException(nameof(context));
        }
        
        return context.User.IsInRole(role.ToString());
    }
}
