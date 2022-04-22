using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace NguyenQuocTruong.Pages;

public class IndexModel : PageModel
{
    private readonly DataContext _context;
    public IndexModel(DataContext context)
    {
        _context = context;
    }

    public IList<NguyenQuocTruong.Models.News> News { get; set; }
    public async Task OnGetAsync()
    {
        News = await _context.News.ToListAsync();
    }
}
