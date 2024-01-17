using System.Collections;
namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Arrays");
            int[] numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers.Count());
            // Using the .Append() .Prepend() methods and converting it back to a string array
            numbers = numbers.Append<int>(10).ToArray();
            numbers = numbers.Prepend<int>(0).ToArray();
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write($" {numbers[x]} , ");
            }

            Console.WriteLine("Working with string array");
            string[] dayArray = new string[] { "Mon", "Tue" };
            dayArray = dayArray.Append("Wed").ToArray();
            // Display values
            foreach (var item in dayArray)
            {
                Console.Write(item + " , ");
            }
            Console.WriteLine("\nWorking with objects");
            object[] obj = new[] { "12", "2.5", "8", "monday", "tuesday" };
            double count = 0;
            foreach (var item in obj)
            {
                // Console.Write(item + " , ");
                double number;
                if (double.TryParse((string)item, out number))
                {
                    count += number;
                }
            }
            Console.WriteLine("Sum of numbers is {0}", count);
            Console.ReadLine();
            Console.Write("Enter an integer number: ");
            int inputNumber;

            // Validate input
            while (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.Write("Invalid input. Please enter a valid integer number: ");
            }

            int sum = SumOfDigits(inputNumber);
            Console.WriteLine("Sum of individual digits is: " + sum);
            Console.WriteLine("Enter string to check if it is palindrome!");
            String input = Console.ReadLine().ToLower();
            String inputReversed = "";
            for(int i = input.Length; i > 0; i--)
            {
                inputReversed +=  input[i-1];
            }
            if(inputReversed == input)
            {
                Console.WriteLine("Input was a palindrome");
            }
            else
            {
                Console.WriteLine("Input was not a palindrome");
            }

            int[] rev = new[] { 1, 2, 3, 4, 5, 6 };
            ReverseArray(rev);
            Console.WriteLine(String.Join(" ", rev));
        }

        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10; 
                number /= 10;       
            }
            return Math.Abs(sum); 
        }

        static void ReverseArray(int[] arr)
        {
            int temp;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }


        }
}
