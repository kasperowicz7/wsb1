using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pierwszy_plik
{
    class Program
    {
        static void Main(string[] args)
        {   

           /*    Console.WriteLine("WSB");
            Console.WriteLine("nowa linia");

            Console.Write("Proszę podaj swoje imię:");
            string name = Console.ReadLine();


            //typ string
            Console.WriteLine("witaj" + name);


            Console.Write("masz na imię");
            Console.WriteLine(name);

            //typ integer
            int age = 20
            Console.WriteLine(age);

            uint number = 10;

            //typ float
            float=14.55F;
            //+ konkatenacja
            Console.WriteLine("zmienna z wynosi: " + z);    */


            Console.WriteLine("Program obliczający pole prostokąta");

            Console.WriteLine("Podaj długość figury");
            int dl = int.Parse(Console.ReadLine());
            // string Wyjscie = Console.ReadLine();
            // int dl = int.Parse(Wyjscie);



            Console.WriteLine("Podaj szerokość figury");
            int sz = int.Parse(Console.ReadLine());
            // string Wyjscie2 = Console.ReadLine();
            // int sz = int.Parse(Wyjscie2);

            int pole = (dl * sz);
            int obwod = (2 * dl + 2 * sz);

            Console.WriteLine("Pole figury wynosi " + pole);
            Console.WriteLine("Obwów figury wynosi: " + obwod);


            int x, y = 10, z;

            // int zmienna = 10;
            int zmienna = new int();




            Console.ReadKey();
        } 
    
    }
}
