using System;

class Program {
    static void Main() {
        while (true) {
                Console.WriteLine();
                Console.WriteLine("Conversion");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Binary To Decimal");
                Console.WriteLine("2. Decimal To Binary");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");

                int number = Convert.ToInt32(Console.ReadLine());

                int chance = 10;

                switch (number) {
                    case 1:
                        while (chance > 0) {
                            Console.WriteLine();
                            Console.WriteLine("Binary to Decimal");

                            Console.Write("Enter an 8 Digit Binary: ");
                            string binary = Console.ReadLine();

                            int[] arr = new int[binary.Length];

                            for (int i = 0; i < binary.Length; i++) {
                                arr[i] = binary[i] - '0';
                            }

                            Array.Reverse(arr);

                            int decimalValue = 0;
                            int power = 1;

                            for (int i = 0; i < arr.Length; i++) {
                                decimalValue += arr[i] * power;
                                power *= 2;
                            }
                            Console.WriteLine($"Decimal: {decimalValue}");
                            Console.WriteLine("Type 'e' to exit or any key to continue.");
                            string exitChoice = Console.ReadLine();
                            if (exitChoice == "e") {
                                break;
                            }
                            chance--;
                        }
                        break;

                    case 2:
                        while (chance > 0) {
                            Console.WriteLine();
                            Console.WriteLine("Decimal to Binary");

                            Console.Write("Enter a Decimal: ");
                            int decimalValue2 = Convert.ToInt32(Console.ReadLine());

                            int[] binaryArr = new int[8];
                            int index = 0;

                            while (decimalValue2 > 0) {
                                int answer = decimalValue2 % 2;

                                binaryArr[index] = answer;
                                index++;
                                decimalValue2 /= 2;
                            }
                            Console.Write("Binary: ");

                            for (int i = index - 1; i >= 0; i--){
                                Console.Write(binaryArr[i]);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Type 'e' to exit or any key to continue.");
                            string exitChoice = Console.ReadLine();
                            if (exitChoice == "e") {
                                break;
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Thank you so much!!!");
                        return;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
    }
}
