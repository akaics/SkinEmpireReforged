
using Microsoft.AspNetCore.Identity;

namespace SkinEmpireReforged.Data
{
    public class ApplicationUser : IdentityUser<string>
    {
        public class WebApp1User : IdentityUser<Guid>
        {
            [PersonalData]
            public string? Name { get; set; }

        }
    }
}
