using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller2DVirtual251.Figures
{
    internal class FigureMenu
    {
        public void Execute()
        {
            ShowOptions();
        }

        private void ShowOptions()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("1. Rectángulo");
                Console.WriteLine("2. Círculo");
                Console.WriteLine("3. Triángulo");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        CalculateRectangle();
                        break;
                    case "2":
                        CalculateCircle();
                        break;
                    case "3":
                        CalculateTriangle();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("La opción no es válida");
                        break;
                }
            }

        }

        private void CalculateRectangle()
        {
            float b;
            float h;

            Console.WriteLine("Introduce la base");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura");
            h = float.Parse(Console.ReadLine());

            Rectangle r = new Rectangle(b, h);
            Console.WriteLine($"El área del rectángulo es {r.GetArea()}");

        } 

        private void CalculateCircle()
        {
            float r;

            Console.WriteLine("Introduce el radio");
            r = float.Parse(Console.ReadLine());

            Circle c = new Circle(r);
            Console.WriteLine($"El área del círculo es {c.GetArea()}");

        }

        private void CalculateTriangle()
        {
            float b;
            float h;

            Console.WriteLine("Introduce la base");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura");
            h = float.Parse(Console.ReadLine());

            Triangle t = new Triangle(b, h);
            Console.WriteLine($"El área del triángulo es {t.GetArea()}");

        }
    }
}
