using System;
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
            //STAGES 
            //Console.WriteLine("Please enter your age!");

            //string age = Console.ReadLine();
            //int number = Convert.ToInt32(age);


            //if (number == 18)
            //{
            //    Console.WriteLine("Adult");
            //}
            //if (number >= 13)
            //{
            //    Console.WriteLine("Teen");
            //}
            //if (number <= 12)
            //{
            //    Console.WriteLine("Preteen");
            //}
            //if (number <= 10)
            //{
            //    Console.WriteLine("Child");
            //}
            //if (number <= 6)
            //{
            //    Console.WriteLine("Toddler");
            //}

            //Console.ReadLine();

            Console.WriteLine("Enter a hurricane category");
            
            int caseSwitch;
            Int32.TryParse(Console.ReadLine(), out caseSwitch);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Category 1 ");
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                case 3:
                    Console.WriteLine("Case 2");
                    break;
                case 4:
                    Console.WriteLine("Case 2");
                    break;
                case 5:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;


            }





        
        
        
        
        
        
        
        
        
        
        
        
        }




    }
}
