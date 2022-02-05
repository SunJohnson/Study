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
            int damage1, damage2;
            while (!spearman1.IsDead() && !spearman2.IsDead())
            {
                damage1 = spearman1.Storming();
                spearman2.LossOfHealth(damage1);
                if (!spearman2.IsDead())
                {
                    damage2 = spearman2.Storming();
                    spearman1.LossOfHealth(damage2);
                }
            }
            Console.WriteLine("Копейщик 1 мертв: {0}",spearman1.IsDead());
            Console.WriteLine("Копейщик 2 мертв: {0}",spearman2.IsDead());
            Console.ReadLine();
        }
    }
}
