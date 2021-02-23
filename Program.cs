﻿using System;


namespace randoom_number
{
    //main class 
    class Program
    {
        //entry point  
        static void Main(string[] args)
        {
            Appinfo();

            greetUser();


           

            while(true)
            { 
            Random random = new Random();
            int correctnum = random.Next(1,10);
            int guess = 0;
            
            Console.WriteLine("Guess a number between 1 and 10");

            while(guess != correctnum)

            {
                string inputnum = Console.ReadLine();
               
                if (!int.TryParse(inputnum, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.Red;


                    Console.WriteLine("PLEASE ENTER AN ACTUAL NUMBER");

                    Console.ResetColor();
                    continue;

                }
                
                guess = Int32.Parse(inputnum);


                //match guess to correct number

                if (guess != correctnum)
                {
                    
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    

                    Console.WriteLine("Wrong number, please try again");

                    Console.ResetColor();

                   
                }

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Right number");

            Console.ResetColor();

                Console.WriteLine("DO YOU WANT TO PLAY AGAIN? [Y/N]");

                string answer = Console.ReadLine().ToUpper();

                if(answer=="Y")
                {
                    continue;
                }
                else if(answer=="N")
                {
                    return;
                }
                else
                {
                  //  Console.WriteLine("Press Y or N to exit the game");
                    return;
                    
                }
        }
    }

        static void Appinfo()
        {
            string appName = "Guess The Number";
            string appAuthor = "Faraz Ahmed Abir";
            string version = "1.0";

            //change console color 
            Console.ForegroundColor = ConsoleColor.White;

            //app info
            Console.WriteLine("{0}: by {1} Version: {2}", appName, appAuthor, version);

            Console.ResetColor();
          

            
        }

        static void greetUser()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, Lets play a game..... ", inputName);
            Console.ResetColor();
        }
}
}
