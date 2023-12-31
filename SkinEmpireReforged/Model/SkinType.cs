﻿using System.ComponentModel.DataAnnotations;
using SkinEmpireReforged;

/*Credits:
 * Kodet af Nuriye Erdogan */

namespace SkinEmpireReforged
{
    public class SkinType
    {

        [Key]
        public int SkinTypeId { get; set; }

        public string Type { get; set; }
        public string Rarity { get; set; }

        // Navigation property for relationships/relationer
        public ICollection<Skin> Skins { get; set; } = new List<Skin>();

        public SkinType()
        {
            Type = string.Empty;
            Rarity = string.Empty; 
        }
    }
}
