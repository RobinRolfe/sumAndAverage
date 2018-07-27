using System;

namespace sumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] numberArray = new int[10];

            int count = 0;
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter a  number");
                numberArray.SetValue(Convert.ToInt32(Console.ReadLine()), i);
            }
            for (int i = 0; i < numberArray.Length; i++)
            {
                count++;
                Console.WriteLine("number " + count + " is " + numberArray[i]  );
            }
            for (int i = 0; i < numberArray.Length; i++)
            {
                sum = sum + numberArray[i];
            }


            Console.WriteLine("The sum of the numbers input is " + sum);

            Console.WriteLine("The average of the numbers input is " + sum / numberArray.Length);


            Console.ReadLine();
        }

        
    }
}
