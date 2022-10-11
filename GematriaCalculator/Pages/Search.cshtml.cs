using GematriaCalculator.Data;
using GematriaCalculator.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GematriaCalculator.Pages
{
    public class SearchModel : PageModel
    {
        public IList<Cipher> Ciphers { get; set; } = default!;

        public void OnGet(string q)
        {
            if (!string.IsNullOrWhiteSpace(q))
            {
                q = q.Trim();
                Ciphers = new List<Cipher>();

                foreach (char letter in q)
                {
                    var gematria = ApplicationData.Gematrias
                        .FirstOrDefault(x => x.Letter.FirstOrDefault() == letter);
                    if (gematria != null)
                    {
                        Ciphers.Add(gematria);
                    }

                    var isopsephy = ApplicationData.Isopsephys
                        .FirstOrDefault(x => x.Letter.FirstOrDefault() == letter);
                    if (isopsephy != null)
                    {
                        Ciphers.Add(isopsephy);
                    }
                }
            }
        }
    }
}
