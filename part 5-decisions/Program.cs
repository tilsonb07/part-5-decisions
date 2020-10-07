using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_5_decisions
{
    class Program
    {


        
        static void Main(string[] args)
        {
            //STAGES...

            Console.WriteLine("Please enter your age!");

            string age = Console.ReadLine();
            int number = Convert.ToInt32(age);


            if (number == 18)
            {
                Console.WriteLine("Adult");
            }
            if (number >= 13)
            {
                Console.WriteLine("Teen");
            }
            if (number <= 12)
            {
                Console.WriteLine("Preteen");
            }
            if (number <= 10)
            {
                Console.WriteLine("Child");
            }
            if (number <= 6)
            {
                Console.WriteLine("Toddler");
            }

            Console.ReadLine();







            //HURRICANE CATEGORYS...

            Console.WriteLine("Enter a hurricane category");

            int caseSwitch;
            Int32.TryParse(Console.ReadLine(), out caseSwitch);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Category 1: 74-95 mph 64-82 kt or 119-153 km/h ");
                    break;
                case 2:
                    Console.WriteLine("Category 2: 96-10 mph or 83-95 kt or 154=177 km/h");
                    break;
                case 3:
                    Console.WriteLine("Category 111-130 mph or 96-113 kt or 178-209 km/h");
                    break;
                case 4:
                    Console.WriteLine("Category 4 131-155 mph or 114-135 kt or 210-249 km/h");
                    break;
                case 5:
                    Console.WriteLine("Category 5 greater than 155 mph or 135 kt 249 km/h");
                    break;
                default:
                    Console.WriteLine("That is not a hurricane category. Please pick bettween 1-5");
                    break;

            }
            Console.ReadLine();





            //DIVISIBLE PROJECT...

            Random generator = new Random();

            int randomNum = generator.Next(1, 7);
            Console.WriteLine($"Please enter a number larger then,{randomNum} to see if its divisible...");

            string guess = Console.ReadLine();
            int newnumber = Convert.ToInt32(guess);

            if (randomNum % newnumber == 0)

            {

                Console.WriteLine("Divisible!");


            }

            else if (!(randomNum % newnumber == 0))
            {

                Console.WriteLine("Not Divisible!");


            }

            Console.ReadLine();




















        }




    }
}
