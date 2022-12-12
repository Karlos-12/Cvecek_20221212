using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cvecek_20221212
{
    internal class Solider
    {
        public string name { get; set; }
        public int hp { get; set; }
        public int MaxHp { get; internal set; }
        public int damage { get; set; }
        public int shield { get; set; }
        public int Maxshield { get; internal set; }
        public int levl { get; set; }

        public Solider()
        {

        }

        public void Atack(Solider enemy)
        {
            enemy.hp -= damage - enemy.shield;
        }

        private int damageget()
        {
            Random random = new Random();
            random.Next(damage - 5, damage + 5);
        }

        public void Heal()
        {

        }

        public void levelup()
        {
            levl++;
            MaxHp += 10;
            Maxshield += 5; 
        }

    }
}
