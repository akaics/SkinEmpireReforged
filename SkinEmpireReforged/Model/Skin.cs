using System.ComponentModel.DataAnnotations;
using SkinEmpireReforged;

/*Credits:
 * Kodet af Gülsüm Erdogan */
namespace SkinEmpireReforged
{
    
    // Vi tilføjer error messages da der er nogle krav for, hvor lav prisen må være og hvor mange tegn der i alt bruges.
        public class Skin
        {
            [Key]
            public int Id { get; set; }

            [Required(ErrorMessage = "SkinNavn er påkrævet")]
            [StringLength(50, ErrorMessage = "SkinNavn må højst være på 50 tegn.")]
            public string SkinNavn { get; set; }

            [StringLength(50, ErrorMessage = "Stand må højst være på 50 tegn.")]
            public string Stand { get; set; }

            [StringLength(50, ErrorMessage = "VåbenType må højst være på 50 tegn.\")]")]
            public string VåbenType { get; set; }

            [Required(ErrorMessage = "Pris is required")]
            [Range(0.01, (double)decimal.MaxValue, ErrorMessage = "Prisen skal være højere end 0.")]
            public decimal Pris { get; set; }

            [StringLength(200, ErrorMessage = "Beskrivelse må højst være på 200 tegn.")]
            public string Beskrivelse { get; set; }

          

            public Skin()
            {
                SkinNavn = string.Empty;
                Stand = string.Empty;
                VåbenType = string.Empty;
                Beskrivelse = string.Empty;
            }
        }
}


