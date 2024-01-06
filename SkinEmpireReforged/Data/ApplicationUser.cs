
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel;

namespace SkinEmpireReforged.Data
{

    public class ApplicationUser : IdentityUser
    {
        // [PersonalData]
        // public string? Name { get; set; }

        [PersonalData]
        [DisplayName("Name")]
        public string? Name { get; set; }


    }

}
