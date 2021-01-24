

using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using Console = Colorful.Console;


namespace MenyÖvning2
{
    class Program
    {
        static void Main(string[] args)
        {

            Group g = new Group();
           
 
            do
            {
                ShowMenu();
               
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine(" Welcome to the Cinema");
                       
                            g.BuyTicket();
                        break;


                    case "2":
                        RepeatText();
                        break;


                    case "3":
                        PickUpWord();

                        break;

                    case "0":

                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("This is an info message! Choose a number between the following list", Color.Red);
                        break;


                }
                
            }
            while (true);
            
        }

        private static void PickUpWord()
        {
            Console.WriteLine("Write you mening here !");
            var input = Console.ReadLine();

            string[] menning = input.Split();
            if (menning.Length >= 3)
            {

                foreach (var word in menning)
                {
                    Console.WriteLine($"<{word}>", Color.Beige);
                    

                }
                Console.WriteLine(" the third word is  " + menning[2], Color.DarkMagenta);
            }
            else
            {

                Console.WriteLine("enter a mening that contains at least 3 words try again !", Color.Orange);
                //Console.ReadKey();
            }
        }

        private static void RepeatText()
        {
            Console.WriteLine("Here you can enter your text so we can print it 10 Times !!!");
            string text = Console.ReadLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("{0}", i + "." + text + ", ");
            }
            Console.WriteLine("\n");
        }

        private static void ShowMenu()
        {
            
            Console.WriteAscii("Welcome  ", Color.FromArgb(50, 50, 50));
            Console.WriteLine("---------------------------------------\n",Color.DarkCyan);
            Console.WriteLine("Choose a number from the following list:");
            Console.WriteLine("\t1 - Cinema",Color.Blue);
            Console.WriteLine("\t2 - Repeat your text",Color.Green);
            Console.WriteLine("\t3 - Split your text",Color.Yellow);
            Console.WriteLine("\t0 - Exit the app",Color.DeepSkyBlue);
            Console.WriteLine("----------------------------------------\n",Color.DarkCyan);
            
            

            
        }
    }
}
