using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;

namespace NumberGuesser // namespace
{
    class Program // main class 
    {
        static void Main(string[] args) //entry point method 
        {

            while (true) { 
            
            string numeAplicatie = "Ghiceste numarul";
            string versiuneAplicatie = "0.0.0.1";
            string autorAplicatie = "Titire Alexandru";



            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("==============================");
            Console.WriteLine($"{numeAplicatie} Versiunea {versiuneAplicatie} de {autorAplicatie}");
            Console.WriteLine("==============================");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Introdu numele: ");
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Bine ai venit {name}, vom juca un joc, este de acord? (DA/NU)");

            Console.ForegroundColor = ConsoleColor.Magenta;

            string alegere = Console.ReadLine();
            Console.ResetColor();          // apelare metoda ResetColor() pentru a reseta culoarea scrisului din consola
            alegere = alegere.ToUpper();
               
                if (alegere == "NU")    // daca raspunsul este nu, opreste din rulare.
                {
                    Console.WriteLine("Multumesc pentru joc");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("==============================");
                    Console.WriteLine("Apasa orice tasta pentru a parasi jocul!");
                    Console.WriteLine("==============================");
                    Console.ResetColor();
                    Console.ReadKey();
                    break;
                }

                while (alegere != "DA" && alegere != "NU")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Trebuie sa alegi DA sau NU!");
                Console.ForegroundColor = ConsoleColor.Magenta;
                alegere = Console.ReadLine();
                alegere = alegere.ToUpper();
                Console.ResetColor();
            }

          
            

                Console.ForegroundColor = ConsoleColor.White;


                //int correctNumber = 7;
                int guess = 0;
                //Initializare variabila guess

              


                Random random = new Random();   // creez un random obiect

                int correctNumber = random.Next(1, 100);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ghiceste un numar intre 1 si 100");






                while (guess != correctNumber)   // atata timp cat guess nu e corect 
                {

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    string input = Console.ReadLine(); // input user
                    if (!int.TryParse(input, out guess)) //verific ca input sa fie integer
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Te rog introdu un numar");
                        Console.ResetColor();
                        continue;   // programul reia while loop si verifica ca input sa fie integer, se reia pana cand input e integer

                    }
                    guess = Int32.Parse(input); //transform in integer si guess ia valoarea lui input





                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Nu ai ghicit, mai incearca!");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.ResetColor();

                    }
                    if (guess < correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"Hint: Numarul este mai mare decat: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(guess);

                        Console.ResetColor();
                    }

                    else if (guess > correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write($"Hint: Numarul este mai mic decat ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(guess);
                        Console.ResetColor();
                    }

                    else if (guess == correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Felicitari, ai ghicit!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
               
                Console.WriteLine("Vrei sa joci din nou? (DA/NU)");
                string raspuns = Console.ReadLine();
                Console.ResetColor();
                raspuns = raspuns.ToUpper();

                if (raspuns == "DA")
                {
                    continue;
                }

                else
                {
                    Console.WriteLine("Multumesc pentru joc");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("==============================");
                    Console.WriteLine("Apasa orice tasta pentru a parasi jocul!");
                    Console.WriteLine("==============================");
                   
                    Console.ReadKey(); // pentru a nu inchide consola singura
                    break;
                }


                
             






            }


        }
    }
}
