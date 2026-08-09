namespace game
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("WELCOME TO SIMPLE CALCULATOR");

            Console.Write("Enter 1st Number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Operation { + | - | * | / }: ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter 2nd Number: ");
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
            {
                int answer = numberOne + numberTwo;
                Console.WriteLine(numberOne + " + " + numberTwo + " = " + answer);
            }
            else if (operation == '-')
            {
                int answer = numberOne - numberTwo;
                Console.WriteLine(numberOne + " - " + numberTwo + " = " + answer);
            }
            else if (operation == '*')
            {
                int answer = numberOne * numberTwo;
                Console.WriteLine(numberOne + " * " + numberTwo + " = " + answer);
            }
            else if (operation == '/')
            {
                double answer = numberOne / numberTwo;
                Console.WriteLine(numberOne + " / " + numberTwo + " = " + answer);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            

        }
    }
}
