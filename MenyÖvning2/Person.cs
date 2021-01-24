using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Console = Colorful.Console;


namespace MenyÖvning2
{
   public  class Person
    {

        public Person()
        {

        }

     
        private int ticketPris;
  
       
        public int TicketPris{ get; set; }

        public int totalkostand { get; set; }
        public int Age { get; set; }

      
        public int  checkAge(int age)
        {
           if (age < 5 || age > 100)
            {
                ticketPris = 0;
               
                Console.WriteLine("Gratis", Color.GreenYellow);

            }
            else if (age > 64)
            {

                ticketPris = 90;
               
                Console.WriteLine("pensioner price",Color.Yellow);


            }

            else if (age>=20 && age <=64)
            {
                ticketPris = 120;
                
                Console.WriteLine("Standard price",Color.Blue);
               
            }
         
            else if(age <20)
                 {

                ticketPris = 80;
                

                Console.WriteLine("Teenager price",Color.Magenta);

            }

            return ticketPris;
        
        }
        


    }
}
