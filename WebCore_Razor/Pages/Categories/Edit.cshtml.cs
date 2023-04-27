using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebCore_Razor.Data;
using WebCore_Razor.Model;

namespace WebCore_Razor.Pages.Categories
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            this._db = db;
        }
        public void OnGet(int? id)
        {
            Category = _db.Categories.Find(id);

        }
        public IActionResult OnPost(Category category)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.Categories.Update(category);
            _db.SaveChanges();
            TempData["success"] = "Category updated successfully!";
            return RedirectToPage("Index");
        }

    }
}
