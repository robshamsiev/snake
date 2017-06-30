using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            POINT p1 = new POINT();
            p1.x = 3;
            p1.y = 12;
            p1.sym = '*';
            p1.Draw();

            POINT p2 = new POINT();
            p2.x = 1;
            p2.y = 16;
            p2.sym = '#';
            p2.Draw();


            /*int x1 = 3;
            int y1 = 12;
            char sym1 = '*';
            Draw(x1, y1, sym1);


            int x2 = 1;
            int y2 = 16;
            char sym2 = '#';
            Draw(x2, y2, sym2); */

            Console.ReadLine();
        }

       
    }
}
