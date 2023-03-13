using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectobiecte
{
    class Person
    {
        public int age;
        public string name;
        public int HP = 100;

        public void EnterName()
        {

            name = Console.ReadLine();


            while (string.IsNullOrEmpty(name))
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Trebuie sa introduci un nume!");
                name = Console.ReadLine();
                Console.ResetColor();


            }

        }

        public void Eat()
        {
            HP += 5;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(name + " mananca");
            Console.WriteLine("HP: " + HP);
            Console.ResetColor();
        }
        public void Sleep()
        {
            HP += 10;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(name + " doarme");
            Console.WriteLine("HP: "+ HP );
            Console.ResetColor();
          
        }

        public void Leave()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(name + " pleaca");
            Console.ResetColor();
        }
    }
}
