using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.F1
{
   
    class MainApp
    {
        public static void Main()
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            
            Console.Read();
        }
    }


  
    class SubSystemOne
    {
        public void RedBull(int r)
        {
            if (r == 1)
                Console.WriteLine("Max Verstappen");
            else
                Console.WriteLine("Checo Perez");
        }
    }

  
    class SubSystemTwo
    {
        public void Mersedes(int m)
        {
            if(m == 1)
            Console.WriteLine("Lewis Hammilton");
            else
                Console.WriteLine("George Russel");

        }
    }


   
    class SubSystemThree
    {
        public void Ferrary(int f)
        {
            if (f == 1)
                Console.WriteLine("Charles Leclerc");
            else
                Console.WriteLine("Carlos Sainz");
        }
    }
  
    class SubSystemFour
    {
        public void McLaren(int ml)
        { if (ml == 1)
                Console.WriteLine("Lando Norris");
            else Console.WriteLine("Daniel Riccarrdo");
        }
    }
   
    class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\nPotential winner on USA GP ---- ");
            one.RedBull(1);
            two.Mersedes(1);
            four.McLaren(2);
        }

        public void MethodB()
        {
            Console.WriteLine("\nPotential winner on Monaco GP ---- ");
            two.Mersedes(2);
            three.Ferrary(1);
        }
    }
}
