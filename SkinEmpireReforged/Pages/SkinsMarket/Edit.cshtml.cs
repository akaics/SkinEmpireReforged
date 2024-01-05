using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkinEmpireReforged.Data;

/* Credits:
 * Kodet af Nuriye og Gülsüm Erdogan
 */
namespace SkinEmpireReforged.Pages.Admin.SkinsMarket
{
    public class EditModel : PageModel
    {

        
        // Bruger også dependency injection for at få det på databasen også

        private readonly TwinsDbContext _db;
        public Skin Skin { get; set; }


        public EditModel(TwinsDbContext db)
        {
            _db = db;
        }

        public void OnGet(int id)
        {
            Skin = _db.Skin.Find(id);
        }


        //Update metode:
        public async Task<IActionResult> OnPost(Skin skin)
        {
            if (ModelState.IsValid)
            {
                _db.Skin.Update(skin);

                await _db.SaveChangesAsync();
                //Fortæller brugeren at opslaget er blevet ændret
                TempData["success"] = "Skinopslaget er nu blevet ændret";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
