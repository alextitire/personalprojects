using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accountgenerator
{
    public class Person
    {

        string password = GetRandomPassword(5);

        public int age;
        public string firstName;
        public string lastName;
        public string alegere;
        public char symbol = '@';


        public static string GetRandomPassword(int length)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }

        public void GenerareUsername()
        {
            Random RandName = new Random();
            int RandomUsername;
            for (int i = 0; i < 1; i++)
            {
                RandomUsername = RandName.Next(50, 99999);
                Console.WriteLine("Username-ul tau este: " + symbol + firstName + "." + lastName + RandomUsername);
                Console.WriteLine("Parola contului este: " + password);
            }
        }
        public void GenerareCard()
        {
            Random RandNum = new Random();
            int RandomNumber;
            for (int i = 0; i < 1; i++)
            {
                RandomNumber = RandNum.Next(10000000, 99999999);
                Console.WriteLine("Contul tau este: RO" + RandomNumber + RandomNumber);
                Console.WriteLine("Numele detinatorului: " + firstName + " " + lastName);

            }

        }


        public void IntroducerePrenume()
        {
            Console.Write("Introdu prenumele tau: ");
            firstName = Console.ReadLine();

        }

        public void IntroducereNume()
        {
            Console.Write("Introdu numele de familie: ");
            lastName = Console.ReadLine();
        }


        public void IntroducereDate()
        {
            IntroducereNume();
            IntroducerePrenume();
            Varsta();
            FinalDate();


        }
        public void Varsta()
        {
            DateTime bday = new DateTime();
            Console.Write("Introdu data ta de nastere(DD/MM/YYYY),(DD.MM.YYYY),(DD,MM,YYYY): ");
            bday = Convert.ToDateTime(Console.ReadLine());
            DateTime now = DateTime.Today;
            age = now.Year - bday.Year;
            if (bday > now.AddYears(-age))
            {
                age--;

            }

        }

        public void FinalDate()
        {



            Console.WriteLine("Numele tau complet este " + lastName + " " + firstName + " si ai  " + age + " ani");

            Console.WriteLine("Datele sunt corecte? (DA/NU)");

            alegere = Console.ReadLine();


            if (alegere.ToUpper() == "DA" && age >= 18)
            {

                Console.WriteLine("Felicitari! Esti eligibil pentru card!");
                GenerareUsername();
                GenerareCard();
                Console.WriteLine("Multumim ca ne-ai ales!");
                Console.ReadKey();

            }

            else if (alegere.ToUpper() == "NU")
            {
                Console.WriteLine("Se reia procesul de introducere a datelor!");
                IntroducereDate();

            }
            else if (alegere == "DA" || age < 18)
            {
                Console.WriteLine("Ne pare rau, nu esti eligibil pentru card!");
                Console.WriteLine("Doresti sa reiei procesul? (DA/NU)");
                string realege = Console.ReadLine();
                if (realege.ToUpper() == "DA")
                {
                    IntroducereDate();

                }

                else if (realege.ToUpper() == "NU")
                {
                    Console.WriteLine("Multumim pentru vizita!");
                    Console.ReadKey();
                }

            }

        }

    }
}
