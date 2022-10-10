using GematriaCalculator.Data;
using System.ComponentModel;

namespace GematriaCalculator.Models
{
    public class HebrewGematria : Hebrew
    {
        public HebrewGematria()
        {
          
        }

        [DisplayName("Mispar Hechrachi")]
        public long Standard
        {
            get
            {
                long sum = 0;
                foreach (char letter in Lemma)
                {
                    Gematria gematria = ApplicationData.Gematrias.FirstOrDefault(x => x.Letter.FirstOrDefault() == letter);
                    if (gematria != null)
                        sum += gematria.Standard;
                }
                return sum;
            }
        }

        [DisplayName("Mispar Gadol")]
        public long Large
        {
            get
            {
                long sum = 0;
                foreach (char letter in Lemma)
                {
                    Gematria gematria = ApplicationData.Gematrias.FirstOrDefault(x => x.Letter.FirstOrDefault() == letter);
                    if (gematria != null)
                        sum += gematria.Large;
                }
                return sum;
            }
        }

        [DisplayName("Mispar Katan")]
        public long Small
        {
            get
            {
                long sum = 0;
                foreach (char letter in Lemma)
                {
                    Gematria gematria = ApplicationData.Gematrias.FirstOrDefault(x => x.Letter.FirstOrDefault() == letter);
                    if (gematria != null)
                        sum += gematria.Small;
                }
                return sum;
            }
        }

        [DisplayName("Mispar Siduri")]
        public long Ordinal
        {
            get
            {
                long sum = 0;
                foreach (char letter in Lemma)
                {
                    Gematria gematria = ApplicationData.Gematrias.FirstOrDefault(x => x.Letter.FirstOrDefault() == letter);
                    if (gematria != null)
                        sum += gematria.Ordinal;
                }
                return sum;
            }
        }

        //Atbash
        public long ReverseStandard
        {
            get
            {
                long sum = 0;
                foreach (char letter in Lemma)
                {
                    Gematria gematria = ApplicationData.Gematrias.FirstOrDefault(x => x.Letter.FirstOrDefault() == letter);
                    if (gematria != null)
                        sum += gematria.ReverseStandard;
                }
                return sum;
            }
        }

        //Avgad

        //Albam

        //Mispar HaKadmi
        public long Sum
        {
            get
            {
                long sum = 0;
                foreach (char letter in Lemma)
                {
                    Gematria gematria = ApplicationData.Gematrias.FirstOrDefault(x => x.Letter.FirstOrDefault() == letter);
                    if (gematria != null)
                        sum += gematria.Sum;
                }
                return sum;
            }
        }

        //Mispar HaPerati
        public long Square
        {
            get
            {
                long sum = 0;
                foreach (char letter in Lemma)
                {
                    Gematria gematria = ApplicationData.Gematrias.FirstOrDefault(x => x.Letter.FirstOrDefault() == letter);
                    if (gematria != null)
                        sum += gematria.Square;
                }
                return sum;
            }
        }

        //Mispar Shemi
        public long Letters
        {
            get
            {
                long sum = 0;
                foreach (char letter in Lemma)
                {
                    Gematria gematria = ApplicationData.Gematrias.FirstOrDefault(x => x.Letter.FirstOrDefault() == letter);
                    if (gematria != null)
                        sum += gematria.Letters;
                }
                return sum;
            }
        }
    }
}
