using System.Security.Claims;

namespace Web
{
    public class GraphQLUserContext
    {
        public ClaimsPrincipal User { get; set; }
    }
}
