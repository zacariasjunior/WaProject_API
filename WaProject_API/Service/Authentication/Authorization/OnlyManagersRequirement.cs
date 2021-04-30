using Microsoft.AspNetCore.Authorization;

namespace WaProject_API.Service.Authentication.Authorization
{
    public class OnlyManagersRequirement : IAuthorizationRequirement
    {
    }
}
