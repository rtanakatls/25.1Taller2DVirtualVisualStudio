using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVirtual251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            bool continueFlag = true;

            Console.WriteLine("Introduce tu nombre:");
            name=Console.ReadLine();

            Console.WriteLine($"Hola {name}");

            while(continueFlag)
            {
                Console.WriteLine("Introduce tu edad:");
                age = int.Parse(Console.ReadLine());
                if (age < 0)
                {
                    Console.WriteLine("No puedes tener edad negativa");
                }
                else
                {
                    continueFlag = false;
                    Console.WriteLine($"Entonces el próximo año tendrás {age + 1}");

                    if (age >= 18)
                    {
                        Console.WriteLine("Ya puedes tomar alcohol");
                    }
                    else
                    {
                        Console.WriteLine("Aún no puedes tomar alcohol");
                    }
                }
            }
            
        }
    }
}
