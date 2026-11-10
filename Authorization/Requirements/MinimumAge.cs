using Microsoft.AspNetCore.Authorization;

namespace AuthCore.Authorization.Requirements
{
    public class MinimumAge : IAuthorizationRequirement
    {
        public int Age { get; set; }

        public MinimumAge(int age)
        {
            Age = age;
        }
    }
}
