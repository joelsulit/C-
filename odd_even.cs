namespace game {
    internal class Program {
        static void Main(String[] args) {
            numberType();
        }

        static void numberType() {
            while (true) {
                Console.WriteLine("Even/Odd");
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number % 2 == 0) {
                    Console.WriteLine("Number " + number + " is Even Number");
                } else {
                    Console.WriteLine("Number " + number + " is Odd Number");
                }

                Console.Write("Press 'e' to exit or any other key to continue: ");
                char choice = Console.ReadKey().KeyChar;
                if (choice == 'e' || choice == 'E') {
                    break;
                }
            }
        }
    }
}
