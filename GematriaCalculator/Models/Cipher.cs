using System.ComponentModel.DataAnnotations;

namespace GematriaCalculator.Models
{
    public class Cipher
    {
        [Key]
        public string Letter { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Transliteration { get; set; }
        public long Standard { get; set; }
    }
}