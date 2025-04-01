using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVirtual251
{
    internal class Menu
    {
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
                Console.WriteLine($"Nombre: {player.Name} - Vida: {player.Life}");
                Console.WriteLine("1. Tomar poción");
                Console.WriteLine("2. Agarrar el cactus con la mano");

                string option= Console.ReadLine();
                switch(option)
                {
                    case "1":
                        player.Heal(10);
                        Console.WriteLine($"{player.Name} se curó 10 de vida");
                        break;
                    case "2":
                        player.TakeDamage(5);
                        Console.WriteLine($"{player.Name} recibió 5 de daño");
                        break;
                }
                if (player.Life <= 0)
                {
                    continueFlag = false;
                }
            }
            Console.WriteLine("Moriste");
        }
    }
}
