using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkinEmpireReforged.Data;

namespace SkinEmpireReforged.Pages.Admin.SkinsMarket
{
    public class DeleteModel : PageModel
    {

        private readonly TwinsDbContext _db;
        public Skin Skin { get; set; }


        public DeleteModel(TwinsDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            Skin = _db.Skin.Find(id);
        }

        // Delete metode:
        public async Task<IActionResult> OnPost(Skin skin)
        {

            _db.Skin.Remove(skin);
            await _db.SaveChangesAsync();

            TempData["success"] = "Skinopslaget er nu blevet slettet";
            return RedirectToPage("Index");

        }
    }
}
