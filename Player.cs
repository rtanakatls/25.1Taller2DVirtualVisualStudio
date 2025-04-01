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
        private List<Item> items;
        private int money;

        public string Name { get { return name; } }
        public int Life {  get { return life; } }
        public List<Item> Items { get { return items; } }
        public int Money { get { return money; } }

        public Player(string name)
        {
            this.name = name;
            life = 100;
            money = 100;
            items = new List<Item>();
        }

        public void ChangeMoney(int value)
        {
            money += value;
            if (money < 0)
            {
                money = 0;
            }
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

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }
    }
}
