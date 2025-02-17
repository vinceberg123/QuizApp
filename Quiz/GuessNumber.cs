namespace Quiz
{
    internal class GuessNumber
    {
        public static void Run()
        {
            bool isNumberGuessed = false;

            Random random = new Random();
            int randomNumber = random.Next(100);

            while (!isNumberGuessed)
            {
                int guessedNumber = Convert.ToInt32(Console.ReadLine());

                if (guessedNumber == randomNumber)
                {
                    Console.WriteLine($"[+] Succesfully guessed number {randomNumber} was indeed the number");
                    return;
                }

                if (guessedNumber > randomNumber)
                {
                    Console.WriteLine("[-] guess lower");
                }

                if (guessedNumber < randomNumber)
                {
                    Console.WriteLine("[+] guess higher");
                }
            }
        }
    }
}
