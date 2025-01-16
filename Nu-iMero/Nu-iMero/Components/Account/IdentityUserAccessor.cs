using Microsoft.AspNetCore.Identity;
using Nu_iMero.Data;

namespace Nu_iMero.Components.Account
{
    public sealed class IdentityUserAccessor
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IdentityRedirectManager _redirectManager;

        public IdentityUserAccessor(UserManager<ApplicationUser> userManager, IdentityRedirectManager redirectManager)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            _redirectManager = redirectManager ?? throw new ArgumentNullException(nameof(redirectManager));
        }

        public async Task<ApplicationUser> GetRequiredUserAsync(HttpContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            var user = await _userManager.GetUserAsync(context.User);

            if (user is null)
            {
                var userId = _userManager.GetUserId(context.User);
                _redirectManager.RedirectToWithStatus(
                    "Account/InvalidUser",
                    $"Error: Unable to load user with ID '{userId}'.",
                    context
                );
                return null; // Sau gestioneaz? eroarea cum consideri necesar
            }

            return user;
        }
    }
}
