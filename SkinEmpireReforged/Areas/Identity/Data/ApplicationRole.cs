
using Microsoft.AspNetCore.Identity;
using System;

namespace SkinEmpireReforged.Areas.Identity.Data
{

    public class ApplicationRole : IdentityRole<Guid>
    {
        public string? Description { get; set; }

    }
}
