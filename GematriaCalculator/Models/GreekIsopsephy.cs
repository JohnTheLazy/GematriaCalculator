using GematriaCalculator.Data;

namespace GematriaCalculator.Models
{
    public class GreekIsopsephy : Greek
    {
        public long Standard
        {
            get
            {
                long sum = 0;
                foreach (char letter in Lemma)
                {
                    Isopsephy isopsephy = ApplicationData.Isopsephys.FirstOrDefault(x => x.Letter.FirstOrDefault() == letter);
                    if (isopsephy != null)
                        sum += isopsephy.Standard;
                }
                return sum;
            }
        }
    }
}
