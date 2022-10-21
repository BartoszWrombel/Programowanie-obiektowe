//1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double F, C;
            Console.WriteLine("Podaj temp. w stopniach Celsjusza");
            C=double.Parse(Console.ReadLine());
            F = 32 + 9 / 5.0 * C;
            Console.WriteLine(F);
            Console.ReadKey();
        }
    }
}

//2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta;
            Console.WriteLine("Obliczanie delty dla rownania kwadratowego a*x^2+bx+c");
            Console.WriteLine("Podaj wspolczynnik a: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik b: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik c: ");
            C = double.Parse(Console.ReadLine());
            delta = (B * B) - (4 * A * C);
            Console.WriteLine(delta);
            Console.ReadKey();
        }
    }
}

//3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double masa, wzrost, BMI;
            Console.WriteLine("Obliczanie wskaznika masy ciala BMI: BMI=masa/wzrost^2");
            Console.WriteLine("Podaj wagę w kilogramach");
            masa = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w metrach");
            wzrost = double.Parse(Console.ReadLine());
            BMI = masa / (wzrost * wzrost);
            Console.WriteLine("BMI wynosi " + BMI);
            Console.ReadKey();
        }
    }
}

//4
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 100;
            Console.WriteLine(++x*2);
            Console.ReadKey();
        }
    }
}
//a

//5
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2, y = 3;
            x *= y * 2;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
//d

//6
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x , y = 4;
            x = (y -= 2);
            x = y++;
            x = y--;
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
//x = 3

//7
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x , y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
			//x = 7  y = 6
            Console.WriteLine(++y);
			//y = 7
            Console.ReadKey();
        }
    }
}

//8
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
//a

//9

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a)
            /*int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
            //wynik=false x=2 y=4 z=2
            */
            //b)
            /*int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
            //wynik=false x=2 y=5 z=2
            */
            //c)
            /*int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
            Console.Write("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
            //wynik=false x=2 y=5 z=1
            */
            //d)
            /*int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 || y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
            //wynik=true x=1 y=3 z=4
            */
            //e)
            /*int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
            //wynik=true x=1 y=4 z=4
            */
            //f)
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            Console.ReadKey();
            //wynik=true x=1 y=4 z=5
        }
    }
}

//10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = (double)osoby / powierzchnia;
            Console.WriteLine(gestoscZaludnienia);
            Console.ReadKey();
        }
    }
}
