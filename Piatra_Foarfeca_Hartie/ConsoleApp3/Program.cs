using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PiatraFoarfecaHartie
{
    internal class Program
    {

        static void Main()
        {

            Random random = new Random();
            bool playAgain = true;
            string alegere;
            string computer;
            string raspuns;


            while (playAgain == true) //atata timp cat
            {
                alegere = "";
                computer = "";
                

                while (alegere != "PIATRA" && alegere != "HARTIE" && alegere != "FOARFECA" && alegere != "SHOTGUN")  // atata timp cat alegere diferit de "PIATRA", "HARTIE", "FOARFECA si "SHOTGUN", repeta codul pana la user input(loop)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Trebuie sa alegi una dintre cele prezentate: ");
                    Console.Write("Introdu PIATRA, FOARFECA sau HARTIE: ");
                    alegere = Console.ReadLine();
                    alegere = alegere.ToUpper();
                    Console.ResetColor();

                    if (alegere == "SHOTGUN")  //daca alegere == "Shotgun" afiseaza "Felicitari ai deblocat arma secreta"
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Felicitari, ai deblocat arma secreta!");
                        Console.ResetColor();
                    }


                }

                switch (random.Next(1, 4)) // switch pentru obiectul random sa aleaga aleatoriu de la 1 la 4 + cazurile in functie de alegere
                {
                    case 1:
                        computer = "PIATRA";
                        break;
                    case 2:
                        computer = "HARTIE";
                        break;
                    case 3:
                        computer = "FOARFECA";
                        break;

                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Jucator: " + alegere);
                Console.WriteLine("Computer : " + computer);
                Console.ResetColor();


                switch (alegere)
                {
                    case "PIATRA":
                        if (computer == "PIATRA")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Este egalitate");
                            Console.ResetColor();
                        }
                        else if (computer == "HARTIE")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ai pierdut!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ai castigat");
                            Console.ResetColor();
                        }
                        break;
                    case "HARTIE":

                        if (computer == "PIATRA")
                        {
                            Console.WriteLine("Ai castigat!");
                        }
                        else if (computer == "HARTIE")
                        {
                            Console.WriteLine("Este egalitate!");
                        }
                        else
                        {
                            Console.WriteLine("Ai pierdut!");
                        }
                        break;
                    case "FOARFECA":
                        if (computer == "PIATRA")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ai pierdut");
                            Console.ResetColor();
                        }
                        else if (computer == "HARTIE")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ai castigat");
                            Console.ResetColor();
                        }

                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Este egalitate!");
                            Console.ResetColor();
                        }

                        break;
                    case "SHOTGUN":
                        if (computer == "PIATRA") 
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ai castigat!");
                            Console.ResetColor();
                        }
                        else if (computer == "FOARFECA")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ai castigat!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ai castigat!");
                            Console.ResetColor();
                        }
                        break;



                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Vrei sa te joci din nou? (DA/NU)");
                Console.ResetColor();
                raspuns = Console.ReadLine();
                raspuns = raspuns.ToUpper();

                if (raspuns == "DA") 
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                    
                }



            }



            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Multumesc pentru vizita!");
            Console.ResetColor();
            Console.WriteLine("Apasa orice tasta pentru a iesi!");
            Console.ReadKey();





        }

    }

        

    
}
