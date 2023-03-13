using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace proiectobiecte
{



    
    

    internal class Program
    {
        static void Main(string[] args)

        {
            string creator = "Titire Alexandru";
            string version = "0.0.0.1";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==============================================");
            Console.WriteLine($"Version {version} by {creator}");
            Console.WriteLine("==============================================");
            Console.ResetColor();
           

            while (true)
            {

                Person person = new Person();
                Person person2 = new Person();
                Person person3 = new Person();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Introdu numele primului jucator");
                person.EnterName();

                Console.WriteLine("Introdu numele celui de al doilea jucator: ");
                person2.EnterName();
                Console.WriteLine("Introdu numele celui de al treilea jucator: ");
                person3.EnterName();

                Console.WriteLine("Jucatorii sunt: " + person.name + ", " + person2.name + ", " + person3.name);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sunt corecte numele? (DA/NU)");
                Console.ResetColor();
                string corect = Console.ReadLine();
                corect = corect.ToUpper();
                while (corect != "DA" && corect != "NU")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep();
                    Console.WriteLine("Trebuie sa alegi DA sau NU!");
                    Console.ResetColor();
                    corect = Console.ReadLine();
                    corect = corect.ToUpper();


                }

                if (corect != "DA")
                {
                    Console.WriteLine("Vrei sa incerci din nou? (DA/NU)");
                    string alegere2 = Console.ReadLine();
                    alegere2 = alegere2.ToUpper();
                    while (alegere2 != "DA" && alegere2 != "NU")
                    {
                        Console.WriteLine("Trebuie sa alegi DA sau NU!");
                        alegere2 = Console.ReadLine();
                        alegere2 = alegere2.ToUpper();
                    }

                    if (alegere2 == "DA")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Multumesc pentru vizita");
                        Console.WriteLine("Apasa orice tasta pentru a parasi aplicatia: ");
                        Console.ReadKey();
                        break;
                    }



                }


                Console.WriteLine("Ce vrei sa faca " + person.name + "?" + "\n1.Sa manance(+5HP) \n2.Sa doarma(+10HP) \n3.Sa plece");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Introdu un numar echivalent cu alegerea");
                Console.ResetColor();

                var alegerePersonInt = Convert.ToInt32(Console.ReadLine());








                while ( alegerePersonInt != 1 && alegerePersonInt != 2 && alegerePersonInt != 3)
                {

                   

                    Console.WriteLine("Trebuie sa introduci un numar din cele afisate");
                    alegerePersonInt = int.Parse(Console.ReadLine());
                    continue;
                }
                


                switch (alegerePersonInt)
                {
                    case 1: person.Eat();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("HP-ul a crescut cu 5!");
                        Console.ResetColor();
                        break;
                    case 2: person.Sleep();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("HP-ul a crescut cu 10!");
                        Console.ResetColor();
                        
                        break;
                    case 3: person.Leave(); break;
      

                }





                Console.WriteLine("Ce vrei sa faca " + person2.name + "?" + "\n1.Sa manance(+5HP) \n2.Sa doarma(+10HP) \n3.Sa plece");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Introdu un numar echivalent cu alegerea");
                Console.ResetColor();
                string alegerePerson2 = Console.ReadLine();
                int alegerePersonInt2;
                alegerePersonInt2 = Convert.ToInt32(alegerePerson2);


                while (alegerePersonInt2 != 1 && alegerePersonInt2 != 2 && alegerePersonInt2 !=3)
                {

                    Console.WriteLine("Trebuie sa introduci un numar din cele afisate");
                    alegerePersonInt2 = int.Parse(Console.ReadLine());
                    continue;
                }
                switch (alegerePersonInt2)
                {
                    case 1: person2.Eat();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("HP-ul a crescut cu 5!");
                        Console.ResetColor();
                        break;
                    case 2: person2.Sleep();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("HP-ul a crecut cu 10!");
                        Console.ResetColor();
                        break;
                    case 3: person2.Leave(); break;
                }

                Console.WriteLine("Ce vrei sa faca " + person3.name + "?" + "\n1.Sa manance (+5HP) \n2.Sa doarma(+10HP) \n3.Sa pleace");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Introdu un numar echivalent cu alegerea");
                Console.ResetColor();

                int alegerePerson3 = int.Parse(Console.ReadLine());
                while ( alegerePerson3 != 1 && alegerePerson3 != 2 && alegerePerson3 != 3)
                {

                    Console.WriteLine("Trebuie sa introduci un numar din cele afisate");
                    alegerePerson3 = int.Parse(Console.ReadLine());
                    continue;
                }
                switch (alegerePerson3)
                {
                    case 1: person3.Eat(); 
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("HP-ul a crescut cu 5!");
                        Console.ResetColor();
                        break;
                       ;
                    case 2: person3.Sleep();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("HP-ul a crescut cu 10!");
                        Console.ResetColor();
                        break;
                    case 3: person3.Leave(); break;
                }

                Console.WriteLine("Doresti sa mai incerci?(DA/NU)");
                string alegere = Console.ReadLine();
                alegere = alegere.ToUpper();

                if (alegere == "DA")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Multumesc pentru vizita");
                    Console.WriteLine("Apasa orice tasta pentru a parasi aplicatia: ");
                    Console.ReadKey();
                    break;
                }


            }

        }

        }
    }
  

