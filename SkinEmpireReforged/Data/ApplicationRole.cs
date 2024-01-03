// Models/ApplicationRole.cs
using Microsoft.AspNetCore.Identity;

namespace SkinEmpireReforged.Data
{

    public class ApplicationRole : IdentityRole<Guid>
    {
        public string Description { get; set; }

    }
}
