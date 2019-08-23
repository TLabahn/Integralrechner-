using System;
using System.Collections.Generic;
using System.Text;

namespace Integralrechner
{
    class Polynom
    {
        private double[] parameter = new double[7];
        private string[] text = new string[7]   {"a", "ax+b", "ax^2+bx+c", "ax^3+bx^2+cx+d",
                                                "ax^4+bx^3+cx^2+dx+e", "ax^5+bx^4+cx^3+dx^2+ex+f", 
                                                "ax^6+bx^5+cx^4+dx^3+ex^2+fx+g"};
        private int grad;
        private double u, o;
        public double y;
    
        public void polynom()
        {
            do
            {
                Console.WriteLine("Welchen Grad soll ihr Polynom haben (max. Grad 6)?");
                grad = Convert.ToInt32(Console.ReadLine());

                if (grad < 0 || grad > 6) Console.WriteLine("Fehlerhafte Eingabe!");

            } while (grad < 0 || grad > 6);

            char koeffizient = 'a';

            Console.WriteLine("Ihre Funktion hat die Form {0}. " +
                        "Geben sie bitte die Parameter der gewünschten Funktion ein.", text[grad]);

            for (int i = 6; i >= 0; i--)
            {
                if(i > grad)
                {
                    parameter[i] = 0;
                }
                else
                {
                    Console.WriteLine("{0} = ", koeffizient);
                    parameter[i] = Convert.ToDouble(Console.ReadLine());
                    koeffizient++;
                }
            }

            Console.WriteLine("Geben Sie jetzt eine untere und eine obere Schranke ein.\nUntere Schranke: ");
            u = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Obere Schranke: ");
            o = Convert.ToDouble(Console.ReadLine());

            for(double i = u; i < o; i += (o - u)/((o - u) * 1000000))
            {
                y += (parameter[6] * i * i * i * i * i * i + parameter[5] * i * i * i * i * i + parameter[4] * i * i * i * i + parameter[3] * i * i * i + parameter[2] * i * i + parameter[1] * i + parameter[0]) * (o - u) / ((o - u) * 1000000);
            }

        }
    }
}
