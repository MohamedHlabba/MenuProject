using System;
using System.Collections.Generic;
using System.Text;
using Console = Colorful.Console;
using System.Drawing;

namespace MenyÖvning2
{
    public class Group

    {

        public Person pers = new Person();

        List<Person> personers { get; set; }




        public List<String> resultat = new List<string>();
        public int total { get; set; }
        public Group()
        {
            personers = new List<Person>();


        }
        // this is method for creating new person and add it to the list of persons
        public void addPerson(Person p)
        {


            personers.Add(p);   

        }

        public List<String> affichpeople()
        {
            List<String> result = new List<String>();
            foreach (Person em in personers)
            {
                result.Add("person age " + em.Age + "person ticket price: " + em.TicketPris);
            }
            return result;
        }

        public void BuyTicket()
        {
            Console.WriteLine(" Welcome to the Cinema", Color.Beige);


            personers = new List<Person>();
            total = 0;

            Console.WriteLine("How Many people want to visit the cinema ?", Color.Beige);
            var input2 = Console.ReadLine();
            int antal;
            while (!int.TryParse(input2, out antal)) //this is a test if the input is not a number we force the user to enter a number
            {
                Console.WriteLine("This is not a number", Color.Red);


                input2 = Console.ReadLine();
            }


            for (int i = 1; i <= antal; i++)
            {


                Person pers = new Person();

                Console.WriteLine("The Age for person {0}", i, Color.Beige);

                var input = Console.ReadLine();

                int age;
                while (!int.TryParse(input, out age))//test for input, the input must be a number 
                {
                    Console.WriteLine("this is invalid age format", Color.DarkSalmon);
                    input = Console.ReadLine();
                }

                pers.Age = age;

                pers.TicketPris = pers.checkAge(age);


                personers.Add(pers);


                Console.WriteLine("Your Age " + pers.Age + " your ticket cost " + pers.TicketPris + " Kr", Color.Beige);

            }


            foreach (Person pers in personers)
            {


                total += pers.TicketPris; //here we count the total 
                                          //we get all the person on the list personers and get the person.ticket and add it to the total


            }

            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine("Number of people is  " + personers.Count, Color.Beige);
            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine("Total is : " + total + " Kr", Color.Beige);
            Console.WriteLine("----------------------------------------\n");
        }


    }


}




















