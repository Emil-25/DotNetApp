using DotNetAppRazor.Data;
using DotNetAppRazor.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DotNetAppRazor.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
            
        }
    }
}
