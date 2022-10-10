using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GematriaCalculator.Pages.Greek
{
    public class IndexModel : PageModel
    {
        private readonly GematriaCalculator.Data.StrongsDbContext _context;

        public IndexModel(GematriaCalculator.Data.StrongsDbContext context)
        {
            _context = context;
        }

        public IList<Models.Greek> Greeks { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Greeks != null)
            {
                Greeks = await _context.Greeks.ToListAsync();
            }
        }
    }
}
