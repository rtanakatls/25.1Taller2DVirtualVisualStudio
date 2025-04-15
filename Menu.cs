using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVirtual251
{
    internal class Menu
    {
        private int value;

        private Player player;

        public void Execute()
        {
            CreatePlayer();
            ShowOptions();
        } 

        private void CreatePlayer()
        {
            Console.WriteLine("Introduce el nombre del jugador");
            string name = Console.ReadLine();
            player = new Player(name);

            Console.WriteLine($"Se creó con éxito a {player.Name} y tiene {player.Life} de vida");
        }

        private void ShowOptions()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine($"Nombre: {player.Name} - Vida: {player.Life} - Dinero: {player.Money}");
                Console.WriteLine("1. Comprar poción");
                Console.WriteLine("2. Comprar basura");
                Console.WriteLine("3. Tomar poción");
                Console.WriteLine("4. Agarrar el cactus con la mano");
                Console.WriteLine("5. Mostrar todos los items");


                string option= Console.ReadLine();
                switch(option)
                {
                    case "1":
                        BuyItem("Poción", 10);
                        break;
                    case "2":
                        BuyItem("Basura", 50);
                        break;
                    case "3":
                        TakePotion();
                        break;
                    case "4":
                        player.TakeDamage(5);
                        Console.WriteLine($"{player.Name} recibió 5 de daño");
                        break;
                    case "5":
                        ShowItems();
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                if (player.Life <= 0)
                {
                    continueFlag = false;
                }
            }
            Console.WriteLine("Moriste");
        }

        private void ShowItems()
        {
            foreach(Item i in player.Items)
            {
                Console.WriteLine(i.Name);
            }
        }

        private void BuyItem(string name, int price)
        {
            if (player.Money >= price)
            {
                player.ChangeMoney(-price);
                player.AddItem(new Item(name));
                Console.WriteLine($"Se compró con éxito 1 {name} y se restó {price} de dinero");
            }
            else
            {
                Console.WriteLine("No tienes dinero suficiente");
            }
        }

        private void TakePotion()
        {
            Item item = null;
            foreach (Item i in player.Items)
            {
                if (item == null && i.Name == "Poción")
                {
                    item = i;
                }
            }

            if (item != null)
            {
                player.Heal(10);
                player.RemoveItem(item);
                Console.WriteLine($"{player.Name} se curó 10 de vida");
            }
            else
            {
                Console.WriteLine("No tienes pociones");
            }
        }
    }
}
