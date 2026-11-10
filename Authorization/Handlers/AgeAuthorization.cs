using AuthCore.Authorization.Requirements;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace AuthCore.Authorization.Handlers
{
    public class AgeAuthorization : AuthorizationHandler<MinimumAge>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MinimumAge requirement)
        {
            var dataNascimentoClaim = context.User.FindFirst(claim => claim.Type == ClaimTypes.DateOfBirth);

            if (dataNascimentoClaim == null) return Task.CompletedTask;

            var dataNascimento = Convert.ToDateTime(dataNascimentoClaim);

            var idadeUsuario = DateTime.Now.Year - dataNascimento.Year ;

            if (dataNascimento < DateTime.Now.AddYears(- idadeUsuario)) idadeUsuario--;

            if (idadeUsuario >= requirement.Age) context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
