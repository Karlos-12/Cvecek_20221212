using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public int xp { get; set; }
        public const int xplvlup = 100;

        public Solider(string name)
        {
            this.name = name;
            damage = 20;

            MaxHp = 100;
            hp = 100;

            Maxshield = 5;
            shield = 5;
            levl = 1;
            xp = 0;
        }

        public void Atack(Solider enemy)
        {
            int potecial = damageget() - enemy.shield;
            if(potecial > 0)
            {
                enemy.hp -= potecial;
                xpadd(10);
                enemy.hpcheck();
            }
            else
            {
                MessageBox.Show("Ani ses ho nedokl");
            }
        }

        public void hpcheck()
        {
            if(hp <= 0)
            {
                MessageBox.Show(name + "has died. The opopnent wins!");
            }
        }

        private int damageget()
        {
            Random random = new Random();
            int finaldamage = random.Next(damage - 5, damage + 5);
            return finaldamage;
        }

        public void Heal()
        {
            hp += 10;
            if (hp > MaxHp)
            {
                hp = MaxHp;
                xpadd(10);
            }
            else
            {
                xpadd(15);
            }
        }

        public void xpadd(int add)
        {
            xp += add;
            if(xp >= xplvlup)
            {
                levelup();
            }
        }
        public void levelup()
        {
            xp = 0;
            levl++;
            MaxHp += 10;
            Maxshield += 5;
            hp = MaxHp;
            shield = Maxshield;
            damage += 5;
        }

    }
}
