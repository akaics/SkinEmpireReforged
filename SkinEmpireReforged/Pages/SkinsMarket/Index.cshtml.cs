using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkinEmpireReforged.Data;
using SkinEmpireReforged.Model;



namespace SkinEmpireReforged.Pages.Admin.SkinsMarket
{
    public class IndexModel : PageModel
    {

        private readonly TwinsDbContext _db;

        [BindProperty]
        public IEnumerable<Skin> Skins { get; set; } = new List<Skin>();

        // Bruger dependency injection til at implementere klassen

        public IndexModel(TwinsDbContext db)
        {
            _db = db;
        }

        // Henter listen af skins 
        public void OnGet()
        {
            Skins = _db.Skin;
        }
    }
}
