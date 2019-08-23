using System;

namespace Integralrechner
{
    class Program
    {
        //main
        static void Main()
        {
            int menu1;

            //erstes menu
            do
            {
                Console.WriteLine("1: Integral berechnen\n2: Programm beenden\n");
                menu1 = Convert.ToInt32(Console.ReadLine());

                if (menu1 == 2) return;

                if (menu1 != 1 && menu1 != 2) Console.WriteLine("Fehlerhafte Eingabe!");

            } while (menu1 != 1 && menu1 != 2);

            int menu2;

            //zweites menu
            do
            {
                Console.WriteLine("Welchen Funktionstyp wollen sie integrieren?\n" +
                    "1: Polynome\n2: Trigonometrische Funktionen\n3: Exponentialfunktionen");

                menu2 = Convert.ToInt32(Console.ReadLine());

                if (menu2 < 1 || menu2 > 3) Console.WriteLine("Fehlerhafte Eingabe!");

            } while (menu2 < 1 || menu2 > 3);

            double y;


            //switch case für die einzelnen Funktionstypen, bis jetzt nur polynome implementiert
            switch (menu2)
            {
                case 1:
                    Polynom polynom = new Polynom();
                    polynom.polynom();
                    y = polynom.y;
                    break;

                default: return;
            }

            Console.WriteLine("Das Integral der Funktion ergibt {0}", y);


            Main();



        }
    }
}