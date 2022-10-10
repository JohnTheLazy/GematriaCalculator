using GematriaCalculator.Data;
using GematriaCalculator.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GematriaCalculator.Pages.Greek
{
    public class IndexModel : PageModel
    {
        public IList<GreekIsopsephy> GreekIsopsephys { get; set; } = default!;

        public void OnGet()
        {
            if (ApplicationData.Greeks != null && ApplicationData.Greeks.Any())
            {
                GreekIsopsephys = ApplicationData.Greeks
                .Select(x => new GreekIsopsephy()
                {
                    Xlit = x.Xlit,
                    Description = x.Description,
                    Lemma = x.Lemma,
                    Number = x.Number,
                    Pronounce = x.Pronounce
                }).ToList();
            }
        }
    }
}
