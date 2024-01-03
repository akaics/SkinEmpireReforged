using System.ComponentModel.DataAnnotations;
using SkinEmpireReforged;

namespace SkinEmpireReforged
{
        public class Skin
        {
            [Key]
            public int Id { get; set; }

            [Required(ErrorMessage = "SkinNavn is required")]
            [StringLength(50, ErrorMessage = "SkinNavn must be at most 50 characters long")]
            public string SkinNavn { get; set; }

            [StringLength(50, ErrorMessage = "Stand must be at most 50 characters long")]
            public string Stand { get; set; }

            [StringLength(50, ErrorMessage = "VåbenType must be at most 50 characters long")]
            public string VåbenType { get; set; }

            [Required(ErrorMessage = "Pris is required")]
            [Range(0.01, (double)decimal.MaxValue, ErrorMessage = "Pris must be greater than 0")]
            public decimal Pris { get; set; }

            [StringLength(200, ErrorMessage = "Beskrivelse must be at most 200 characters long")]
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


