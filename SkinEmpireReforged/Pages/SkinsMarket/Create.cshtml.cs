using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkinEmpireReforged.Data;

/*Credits:
 * Kodet af Nuriye Erdogan */
namespace SkinEmpireReforged.Pages.Admin.SkinsMarket
{
    public class CreateModel : PageModel
    {
        private readonly TwinsDbContext _db;
        public Skin Skin { get; set; }

        public CreateModel(TwinsDbContext db)
        {
            _db = db;
            Skin = new Skin();
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost(Skin skin)
        {
            _db.Skin.Add(skin);
            await _db.SaveChangesAsync();
            TempData["success"] = "Skinopslaget er nu blevet oprettet";
            return RedirectToPage("Index");
        }
    }
}
