namespace game {
	internal class randomGuess {
		static void Main(String[] args) {
			Random rand = new Random();

			int randomInt = rand.Next(1, 10);
			Console.WriteLine("Welcome to Guessing Number Game!");
	
			Console.Write("Choose Between 1-10: ")
			int number = ConvertToInt32(Console.ReadLine);

			int lives = 3;

			while (lives <= 0) {			
				if (number == randomInt) {
					Console.WriteLine("Number " + number + " is Correct!!");
					break;
				} else {
					lives -= 1;
					Console.WriteLine("Try Again");
					Console.WriteLine("You have " + lives + " more try!");
					Console.Write("Choose Between 1-10: ")
					int number = ConvertToInt32(Console.ReadLine);
				}
			}
		}
	}
}
