using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taller2DVirtual251.Figures;

namespace Taller2DVirtual251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int c;
            int value;
            int value2;
            int value3;

            value = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introdujo el número {value}");
            Console.WriteLine("Hola mundo");
            Console.WriteLine("Hola mundo 2");
            /*
            FigureMenu menu = new FigureMenu();
            menu.Execute();
            */
            /*
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
                    Console.WriteLine($"Ahora tienes {age} años y entonces el próximo año tendrás {age + 1}");

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
            */

            /*
            float a;
            float b;

            Console.WriteLine("Introduce el primer número");
            a=float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            b=float.Parse(Console.ReadLine());

            Console.WriteLine($"{a}+{b}={a + b}");
            Console.WriteLine($"{a}-{b}={a - b}");
            Console.WriteLine($"{a}*{b}={a * b}");

            if(b==0)
            {
                Console.WriteLine("No puedes dividir entre 0");
            }
            else
            {
                Console.WriteLine($"{a}/{b}={a / b}");
                Console.WriteLine($"{a}%{b}={a % b}");
            }
            */
            /*
            float days;

            Console.WriteLine("Introduce la cantidad de días");
            days=float.Parse(Console.ReadLine());

            Console.WriteLine($"En {days} días, hay {days / 365} años");
            Console.WriteLine($"En {days} días, hay {days / 7} semanas");
            */
            /*
            int year;

            Console.WriteLine("Introduce el año");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine($"El año {year} es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine($"El año {year} no es bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine($"El año {year} es bisiesto");
                }
            }
            else
            {
                Console.WriteLine($"El año {year} no es bisiesto");
            }
            */
            /*
            int a;

            Console.WriteLine("Introduce un número");
            a=int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine($"{a} es positivo");
            }
            else if (a < 0)
            {
                Console.WriteLine($"{a} es negativo");
            }
            else
            {
                Console.WriteLine($"{a} es cero");
            }
            */
            /*
            int a;
            Console.WriteLine("Introduce un número");
            a=int.Parse(Console.ReadLine());

            if (a % 7 == 0 && a % 13 == 0)
            {
                Console.WriteLine($"{a} es divisible entre 7 y 13");
            }
            else if (a % 7 == 0)
            {
                Console.WriteLine($"{a} es divisible entre 7");
            }
            else if (a % 13 == 0)
            {
                Console.WriteLine($"{a} es divisible entre 13");
            }
            else
            {
                Console.WriteLine($"{a} no es divisible entre 13 ni 7");
            }
            */
        }
    }
}
