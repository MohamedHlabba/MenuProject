

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

            //Group is a class to manage the number of people that will visit the cinema.
            Group g = new Group();


            do
            {
                //this is a method to print the menu.
                ShowMenu();

                switch (Console.ReadLine())
                {
                    case "1":
                        g.BuyTicket();

                        break;

                    case "2":
                        //this  method for repating text
                        RepeatText();
                        break;

                    case "3":
                        //this method  to print the third word in a text
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
            Console.WriteLine("Write a text here!, the text should be more than three words");
            var input = Console.ReadLine();

            // test input , must be not null or less than 3 words
            while (string.IsNullOrEmpty(input) || (input.Split().Length < 3))
            {
                Console.WriteLine("Enter a mening that contains at least 3 words try again !", Color.GreenYellow);
                input = Console.ReadLine();

            }
            string[] menning = input.Split();
           
            
            //foreach (var word in menning)
            //{
            //    Console.WriteLine($"<{word}>", Color.Beige);


            //}
            Console.WriteLine("The third word is  " + menning[2], Color.DarkMagenta);

        }

        private static void RepeatText()
        {
            Console.WriteLine("Here you can enter your text so we can print it 10 Times !!!");
            string text = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(text)) 
            {
                System.Console.WriteLine("The text cannot be empty", Color.Yellow);
                text = Console.ReadLine();

            }
            for (int i = 1; i <= 10; i++)
            {
                if (i!= 10)
                {
                    Console.Write("{0}", i + "." + text + ", ");
                }
                else
                {
                    System.Console.WriteLine("{0}", i + "." + text + ".");
                }
            }
            Console.WriteLine("\n");
        }

        private static void ShowMenu()
        {

            Console.WriteAscii("Welcome  ", Color.FromArgb(50, 50, 50));
            Console.WriteLine("---------------------------------------\n", Color.DarkCyan);
            Console.WriteLine("Choose a number from the following list:");
            Console.WriteLine("\t1 - Cinema", Color.Blue);
            Console.WriteLine("\t2 - Repeat your text", Color.Green);
            Console.WriteLine("\t3 - Split your text", Color.Yellow);
            Console.WriteLine("\t0 - Exit the app", Color.DeepSkyBlue);
            Console.WriteLine("----------------------------------------\n", Color.DarkCyan);




        }
    }
}
