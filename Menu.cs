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
        } 

        private void CreatePlayer()
        {
            Console.WriteLine("Introduce el nombre del jugador");
            string name = Console.ReadLine();
            player = new Player(name);

            Console.WriteLine($"Se creó con éxito a {player.Name}");
        }
    }
}
