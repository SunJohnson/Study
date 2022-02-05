using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Spearman spearman1 = new Spearman();
            Spearman spearman2 = new Spearman();

            int attackSpearman1 = spearman1.Storming();
            int attackSpearman2 = spearman2.Storming();

            while(!spearman1.IsDead() || !spearman2.IsDead())
            {
                spearman2.LossOfHealth(attackSpearman1);
                spearman1.LossOfHealth(attackSpearman2);
            }
            Console.WriteLine("Копейщик 1 мертв: {0}",spearman1.IsDead());
            Console.WriteLine("Копейщик 2 мертв: {0}",spearman2.IsDead());
            Console.ReadLine();
        }
    }
}
