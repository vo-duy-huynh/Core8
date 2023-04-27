using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebCore_Razor.Data;
using WebCore_Razor.Model;

namespace WebCore_Razor.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            this._db = db;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Category category)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _db.Categories.Add(category);
            _db.SaveChanges();
            TempData["success"] = "Category created successfully!";
            return RedirectToPage("Index");
        }
    }
}
