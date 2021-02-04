using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int numb1;
            int numb2;
            int numb3;
            int temp;
            //Einlesen
            Console.WriteLine("Geben Sie drei Zahlen ein!");
            Console.Write("Ihre erste Zahl lautet:");
            input = Console.ReadLine();
            numb1 = Convert.ToInt32(input);

            Console.Write("Ihre erste Zahl lautet:");
            input = Console.ReadLine();
            numb2 = Convert.ToInt32(input);

            Console.Write("Ihre erste Zahl lautet:");
            input = Console.ReadLine();
            numb3 = Convert.ToInt32(input);

            if (numb1 > numb2)
            {
                //Tausche Zahl 1 und 2
                temp = numb1;
                numb1 = numb2;
                numb2 = temp;
            } 
            //Ab hier ist numb2 sicher größer als numb1
            if (numb2 > numb3)
            {
                //Tausche Zahl 2 und 3
                temp = numb2;
                numb2 = numb3;
                numb3 = temp;
            }
            //Ab hier ist numb3 sicher die größte der drei Zahlen
            //D.h. es müssen nur noch die anderen beiden verglichen werden
            if (numb1 > numb2)
            {
                //Tausche Zahl 1 und 2
                temp = numb1;
                numb1 = numb2;
                numb2 = temp;
            }
            Console.WriteLine("Kleinste Zahl:"+numb1);
            Console.WriteLine("Mittlere Zahl:" + numb2);
            Console.WriteLine("Groesste Zahl:" + numb3);
        }
    }
}
