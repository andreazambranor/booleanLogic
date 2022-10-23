using System;


namespace booleanLogic.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Question number 1
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            int ageInt = Convert.ToInt32(age);

            //question number 2
            Console.WriteLine("Have you ever had DUI? Answer true or false");
            string dui = Console.ReadLine();
            bool duiBool = Convert.ToBoolean(dui);

            //question number 3
            Console.WriteLine("Hoe many speeding tickets do you have?");
            string noOfTickets = Console.ReadLine();
            int noOfTicketsInt = Convert.ToInt32(noOfTickets);


            bool qualified = (ageInt > 18 && duiBool == false && noOfTicketsInt < 3);
            Console.WriteLine("You are qualified for insurance: " + qualified);
            Console.ReadLine();


        }
    }
}
