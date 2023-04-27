using Microsoft.AspNetCore.Mvc.RazorPages;
using WebCore_Razor.Data;
using WebCore_Razor.Model;

namespace WebCore_Razor.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Category> CategoryList { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            this._db = db;
        }
        public void OnGet()
        {
            CategoryList = _db.Categories.ToList();
        }
    }
}
