using System.ComponentModel.DataAnnotations;

namespace SkinEmpireReforged.Model
{
    public class Bruger
    {

        [Key]
        public int BrugerId { get; set; }

        [Required]
        [StringLength(20)]
        public string Rolle { get; set; }

        // Navigation property for relationships
        public ICollection<Skin> Skins { get; set; } = new List<Skin>();

        public Bruger()
        {
            Rolle = string.Empty;
        }
    }
}
