using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SkinEmpireReforged.Data;

/* Credits:
 * Kodet af Nuriye og G�ls�m Erdogan
 */
namespace SkinEmpireReforged.Pages.Admin.SkinsMarket
{
    public class EditModel : PageModel
    {

        
        // Bruger ogs� dependency injection for at f� det p� databasen ogs�

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
                //Fort�ller brugeren at opslaget er blevet �ndret
                TempData["success"] = "Skinopslaget er nu blevet �ndret";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
