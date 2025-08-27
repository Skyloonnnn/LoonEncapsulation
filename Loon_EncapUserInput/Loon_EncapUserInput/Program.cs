using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_EncapUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Main:
            //ask user to input details
            Console.Write("Enter the brand of shirt you want: ");
            string brandName = Console.ReadLine();

            Console.Write("Enter you shirt size: ");
            string shirtSize = Console.ReadLine();

            //Instantiate hte class
            Shirt shirt = new Shirt();

            //Input value 
            shirt.BrandName = brandName;
            shirt.ShirtSize = shirtSize;

            //call the method
            shirt.DisplayShirtInfo();

            //ask user if they want another shrit
            Console.Write("\nYou want to add another shirt? (y/n): ");
            char choice = Convert.ToChar(Console.ReadLine());

            if (choice == 'y')
            {
                goto Main;
            }
            else
            {
                return;
            }
        }
    }
}
