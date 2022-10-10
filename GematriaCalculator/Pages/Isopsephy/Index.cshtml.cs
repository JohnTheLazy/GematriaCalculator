using GematriaCalculator.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GematriaCalculator.Pages.Isopsephy
{
    public class IndexModel : PageModel
    {
        private readonly StrongsDbContext _context;

        public IndexModel(StrongsDbContext context)
        {
            _context = context;
        }

        public IList<Models.Isopsephy> Isopsephys { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Isopsephys != null)
            {
                Isopsephys = await _context.Isopsephys.OrderBy(x => x.Standard).ToListAsync();
            }
        }
    }
}
