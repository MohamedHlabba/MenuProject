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

        public void addPerson(Person p)
        {


            personers.Add(p);

        }



        public int countTotal()
        {

            foreach (Person pers in personers)
            {
                total += pers.TicketPris;

            }
            return total;

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

            

                personers = new List<Person>();
                total = 0;

                Console.WriteLine("How Many people wanna come in ");
                var input2 = Console.ReadLine();
                int antal;
                while (!int.TryParse(input2, out antal))
                {
                   System.Console.WriteLine("This is not a number ",Color.Red);
                
                   
                    input2 = Console.ReadLine();
                }


                for (int i = 1; i <= antal; i++)
                {


                    Person pers = new Person();

                    Console.WriteLine("The Age for person {0}", i);

                    var input = Console.ReadLine();

                    int age;
                    while (!int.TryParse(input, out age))
                    {
                        System.Console.WriteLine("this is invalid age format ", Color.Red);
                        input = Console.ReadLine();
                    }

                    pers.Age = age;

                    pers.TicketPris = pers.checkAge(age);


                    personers.Add(pers);


                    Console.WriteLine("Your Age " + pers.Age + " your ticket cost " + pers.TicketPris + " Kr",Color.Beige);

                }






                foreach (Person pers in personers)
                {


                    total += pers.TicketPris;



                }

                Console.WriteLine("----------------------------------------\n");
                //Console.WriteLine("Number of people is  " + personers.Count);
            //Console.WriteLine("Number of people is  " + personers.Count, Color.BlueViolet);
            Console.WriteLine("Number of people is  " + personers.Count,Color.Beige);
            Console.WriteLine("----------------------------------------\n");
                //Console.WriteLine("Total is : " + total + " Kr", Color.BlueViolet);
            Console.WriteLine("Total is : " + total + " Kr",Color.Beige);
            Console.WriteLine("----------------------------------------\n");
            }
           

        }
        

    }





        


    






    




