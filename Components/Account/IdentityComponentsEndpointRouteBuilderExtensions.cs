using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using AcademicYearCalendar.Components.Account.Pages;
using AcademicYearCalendar.Components.Account.Pages.Manage;
using AcademicYearCalendar.Data;

namespace Microsoft.AspNetCore.Routing;

internal static class IdentityComponentsEndpointRouteBuilderExtensions
{
    // These endpoints are required by the Identity Razor components defined in the /Components/Account/Pages directory of this project.
    public static IEndpointConventionBuilder MapAdditionalIdentityEndpoints(this IEndpointRouteBuilder endpoints)
    {
        ArgumentNullException.ThrowIfNull(endpoints);

        var accountGroup = endpoints.MapGroup("/Account");

        accountGroup.MapPost("/Logout", async (
            ClaimsPrincipal user,
            [FromServices] SignInManager<ApplicationUser> signInManager,
            [FromForm] string returnUrl) =>
        {
            await signInManager.SignOutAsync();
            //return TypedResults.LocalRedirect($"~/{returnUrl}");
            return TypedResults.LocalRedirect($"/");
        });

        accountGroup.MapGet("/Logout", async (
            ClaimsPrincipal user,
            [FromServices] SignInManager<ApplicationUser> signInManager) =>
        {
            await signInManager.SignOutAsync();            
            return TypedResults.LocalRedirect($"~/");
        });

        return accountGroup;
    }

    private static string TemporaryFluentButtonFix(string provider)
    {
        // Temporary workaround for FluentButton returning a provider value twice
        // Split the comma-separated list of strings
        var providers = provider.Split(',');

        // Find the value that appears twice in the list
        provider = providers.GroupBy(p => p)
                            .Where(g => g.Count() == 2)
                            .Select(g => g.Key)
                            .First();
        return provider;
    }
}
