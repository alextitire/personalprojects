using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace accountgenerator
{


    public class Program
    {

        static void Main(string[] args)
        {
            
            string interfata = "===================================================================================";
            Console.WriteLine(interfata);
            Console.WriteLine("TREBUIE SA AI 18 ANI");
            Console.WriteLine(interfata);
            Person person = new Person();
 
            person.IntroducereDate();
  

        }

    }


    


 }





