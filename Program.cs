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
            F = 32+((9/5d)*C);
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
            Console.WriteLine("Obliczanie delty rownania kwadratowego ax^2+bx+c=0");
            Console.WriteLine("Podaj a");
            A=double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c");
            C = double.Parse(Console.ReadLine());
            delta = ((B * B) - (4 * A * C));
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
            Console.WriteLine("Podaj mase");
            masa=double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost");
            wzrost = double.Parse(Console.ReadLine());
            BMI = (masa / (wzrost * wzrost));
            Console.WriteLine(BMI);
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
            Console.WriteLine(++y);
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
            int x , y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
            Console.WriteLine(++y);
            Console.ReadKey();
        }
    }
}

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
            /*int x = 1, y = 4, z = 2;
			bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
			Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
			//b)
			int x = 1, y = 4, z = 2;
			bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
			Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
			//c)
			int x = 1, y = 4, z = 2;
			bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
			Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
			//d)
			int x = 1, y = 3, z = 4;
			bool wynik = (x == 1 || y++ > 2 || ++z > 0);
			Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
			//e)
			int x = 1, y = 3, z = 4;
			bool wynik = (x == 1 | y++ > 2 || ++z > 0);
			Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);*/
			//f)
			int x = 1, y = 3, z = 4;
			bool wynik = (x == 1 | y++ > 2 | ++z > 0);
			Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
			Console.ReadKey();
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
