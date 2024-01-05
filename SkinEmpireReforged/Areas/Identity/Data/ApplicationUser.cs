
using Microsoft.AspNetCore.Identity;
using System;

namespace SkinEmpireReforged.Areas.Identity.Data
{

    public class ApplicationUser : IdentityUser<Guid>
    {
        [PersonalData]
        public string? Name { get; set; }

    }

}
