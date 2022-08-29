using Augure.Shared.Model;


namespace Augure.Server
{
    public class DataContext : PaApiAuthorizationDbContext<User, UserRole, int>
    {
    }
}
