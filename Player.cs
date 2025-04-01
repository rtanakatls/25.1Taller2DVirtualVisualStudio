using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVirtual251
{
    internal class Player
    {
        private string name;
        private int life;

        public string Name { get { return name; } }
        public int Life {  get { return life; } }

        public Player(string name)
        {
            this.name = name;
            life = 100;
        }

        private void ChangeLife(int value)
        {
            life += value;
            if (life < 0)
            {
                life = 0;
            }
        }

        public void TakeDamage(int value)
        {
            ChangeLife(-value);
        }

        public void Heal(int value)
        {
            ChangeLife(value);
        }

    }
}
