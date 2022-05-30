using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mangus osaleb kaks mangijat - arvuti (cpu) ja kasutaja (user);
            //molemad mangijad viskavad taringuid;
            //programm kontrollib, kumb mangija viskas rohkem;
            //mangija, kes viskab rohkem, see ongi mangu voitja;
            //*taringuid visatakse 3 korda;
            //programm kuulutab voitjat.

            Random rnd = new Random();


            int cpuScore = 0;
            int userScore = 0;



            for (int i = 0; i < 3; i++)
            {

                //arvuti vise
                int cpuRandom = rnd.Next(1, 7);
                //kasutaja vise
                int userRandom = rnd.Next(1, 7);



                Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");


                if (cpuRandom < userRandom)
                {
                    Console.WriteLine("Kasutaja viskas rohkem!");
                    userScore = userScore + 1;
                }
                else if (cpuRandom > userRandom)
                {
                    Console.WriteLine("Arvuti viskas rohkem.");
                    cpuScore = cpuScore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");
                }

                
            
            }


                {
                if (cpuScore < userScore)
                {
                    Console.WriteLine("Kasutaja on mängu võitnud. Palju õnne!");
                    
                }
                else if (cpuScore > userScore)
                {
                    Console.WriteLine("Arvuti on mangu voitnud.");
                    
                }
                else
                {
                    Console.WriteLine("Viik!");
                }
            }
        }
    }
}
