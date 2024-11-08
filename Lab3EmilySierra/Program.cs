internal class Program
{
    private static void Main(string[] args)
    {
        
        int answer;
        bool found = false;
        int guess;
        int counter;

        Console.WriteLine("Welcome to the guessing game!!");
        Console.WriteLine("Choose a number between 1 and 100:");
        Console.WriteLine("Enter guess");
        guess = int.Parse(Console.ReadLine());

        //random number
        Random random = new Random();
        int randomNumber = random.Next(0,101);
        answer = randomNumber;
        counter = 0;
        while (!found)
        {
            counter++;

            if(guess == randomNumber)
            {
                found = true;
            }
            else
            {
                if (guess < answer)
                {
                    Console.WriteLine("Your guess was too low...");
                }
                else if (guess > answer)
                {
                    Console.WriteLine("Your answer was too high..");
                }

            }
            Console.WriteLine("Enter guess again: ");
            guess = int.Parse(Console.ReadLine());


        }
        Console.WriteLine("Congrats! You won!");
        Console.WriteLine("It took " + counter + " number of tries!");



    }
}