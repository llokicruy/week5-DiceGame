﻿using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada kasutajatunnus ja salasona;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasona on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul konsoolis kuvatakse "Vale kasutajatunnus voi salasona. Proovi uuesti.";
            //kasutajal on kolm katset;

            int i = 0;

            while (i < 3)
            { 
            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasona:");
            String userPassword = Console.ReadLine();



                if (userName == "admin" && userPassword == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Vale kasutajatunnus voi salasona. {3 - i} katset jäänud. Proovi uuesti.");
                }
            }
        }
    }
}
