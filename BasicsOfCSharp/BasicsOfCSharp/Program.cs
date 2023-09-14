using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace BasicsOfCSharp
{
    internal class Program
    {
        static void Main(string[] args)

        {  /*// ________With out Additional Tasks________
            //Task One: Creating Variables

            int lowNumber; 
            int highNumber;

            while (true)
            {
                Console.WriteLine("Please enter a positive low number:");
                string lowInput = Console.ReadLine();
                int lowNumber = int.Parse(lowInput);
                if lowNumber < 0) 
                {
                    Console.WriteLine("Input error.Positive numbers only, please.Try Again");
                }
                else
                {
                    Console.WriteLine($"Low Number Stored as: {lowNumber}");
                    break;

                }
            }

            while (true)
            {
                Console.WriteLine($"Please enter a high number greater than {lowNumber}:");
                string highInput = Console.ReadLine();
                string highNumber=int.parse(highInput);
                if highNumber <= lowNumber)
                {
                    Console.WriteLine("Input error. The high number must be greater than the low number. Try Again");
                }
                else
                {
                    Console.WriteLine($"High Number Stored as: {highNumber}");
                    break;

                }

            }
            int difference = highNumber - lowNumber;
            Console.WriteLine($"The difference between the high and low number is:{difference}");



            int[] numberArray = new int[highNumber - lowNumber + 1]; //+1 to have both the highNumber and lowNumber in the array
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = lowNumber + i;
            }

            Console.WriteLine($"The array of numbers between {highNumber} and {lowNumber} are: " +"\n" + string.Join(",", numberArray));
            Console.ReadLine();

            string filePath = "numbers.txt";        
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(string.Join(",", numberArray.Reverse()));
            }
            
           


            Console.WriteLine("The numbers have been written to numbers.txt in reverse order.");
            Console.ReadLine();
            */


            // ________With  Additional Tasks________


            Console.WriteLine("Please enter a positive low number:");
            double lowNumber = input();
            Console.WriteLine($"Please enter a high number greater than {lowNumber}:");
            double highNumber = input();
            compare(lowNumber, highNumber);

            double difference = highNumber - lowNumber;
            Console.WriteLine($"The difference between the high and low number is:{difference}");
            

            List<double> numbersList = new List<double>();
            for(double i = lowNumber; i <= highNumber; i++)
            {
                numbersList.Add(i);
            }
            Console.WriteLine($"The list of numbers between {lowNumber} and {highNumber} are: \n" + string.Join(",", numbersList));

            string filePath = "numbers.txt";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(string.Join(",", numbersList.AsEnumerable().Reverse()));
            }

            Console.WriteLine("The numbers have been written to numbers.txt in reverse order.");
            SumOfNumFromFile();
            Console.ReadLine();
        }





       static double input()
        {
            string input= Console.ReadLine();
            double inputnum = double.Parse(input);

            if (inputnum < 0)
            {
                Console.WriteLine("Input error.Positive numbers only, please.Try Again");
                return 0;
            }
            else
            {
                return inputnum;
            }

        }


        

   
        static double compare(double a, double b)
        {
            if (a < b)
            {
                return b;

            }
            else
            {
                Console.WriteLine("Input error. The high number must be greater than the low number. Try Again");
                return 0;
            }
        }
        
    


        static void SumOfNumFromFile()
        {
            string fileName = "numbers.txt";
            string[] numberStrings = File.ReadAllText(fileName).Split(',');
            double sum = 0;
            foreach (string numberString in numberStrings)
            {
                if (double.TryParse(numberString, out double number))
                {
                    sum += number;
                }
            }
            Console.WriteLine($"The sum of the numbers in the file is: {sum}");
        }





    }
}