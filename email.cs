using System;

class Program {
    static void Main(String[] args) {
        String[] emails = { "joel", "sulit" };
        String[] passwords = { "ewan", "sayo" };

        Console.Write("Enter your Email: ");
        string email = Console.ReadLine();

        bool emailFound = false;

        for (int i = 0; i < emails.Length; i++) {
            if (email == emails[i]) {
                emailFound = true;

                Console.Write("Enter your Password: ");
                string password = Console.ReadLine();

                if (password == passwords[i]) {
                    Console.WriteLine("You Logged IN");
                } else {
                    Console.WriteLine("Incorrect Password");
                }
                break;
            }
        }

        if (!emailFound) {
            Console.WriteLine("Incorrect Email");
        }
    }
}
