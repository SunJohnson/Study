using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heroes3
{
    internal class Spearman
    {
        private int attack = 1;
        private int defends = 5;
        private int damage = 1 ;
        private int health = 10;
        private int speed = 4;
        /// <summary>
        /// Атаковать
        /// </summary>
        /// <returns>Сила атаки</returns>
        public int Storming()
        {
            return attack;
        }
        public void LossOfHealth(int damage)
        {
            health = health - damage;
        }
        public bool IsDead()
        {
            bool isDead;
            if(health > 0)
            {
                isDead = false;
            }
            else
            {
                isDead = true;
            }
            return isDead;
        }
    }
}
