using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loon_EncapUserInput
{
    internal class Shirt
    {
        //declare fields
        public string BrandName { get; set; }
        public string ShirtSize { get; set; }

        //mathod to dispaly
        public void DisplayShirtInfo()
        {
            Console.Clear();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Here are the shirt details you want!");
            Console.WriteLine("Shirt Brand: " + BrandName);
            Console.WriteLine("Shirt size: " + ShirtSize);
        }
    }
}
