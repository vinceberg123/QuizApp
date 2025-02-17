using Quiz;

/*Console.WriteLine("[?] Enter your username");
string userName = Console.ReadLine();

if (string.IsNullOrEmpty(userName))
{
    Console.WriteLine("[-] Hmmm, You don't have a name? Lets use Guest then.");
    userName = "Guest";
}

Console.WriteLine($"[+] Hello, {userName}");
Console.WriteLine("[+] Lets play a quiz, round one starts");

// Round one
Console.WriteLine("\n");
int totalScoreRoundOne = RoundOne();

if (totalScoreRoundOne < 2)
{
    Console.WriteLine("[-] Failed to pass round 1");
    return;
}

Console.WriteLine("[+] Succesfully passed round 1");

// Round two
Console.WriteLine("\n");
Console.WriteLine("[?] Guess a number..");
GuessNumber.Run();

// Round three
Console.WriteLine("\n");
RoundThree();*/

// Round Four
Console.WriteLine("\n[+] Keep in mind, the dog is going to run as much as you press the key. So please keep in mind to not hold down a key, instead just press it.");
RunningDog.ShowRunningDog();


// Round five
Console.WriteLine("\n");
int totalScoreRoundFive = RoundFive();

if (totalScoreRoundFive < 2)
{
    Console.WriteLine("[-] Failed to pass round 1");
    return;
}

Console.WriteLine("[+] Finished quiz. (Yeey)");

static int RoundOne()
{
    int firstQuestion = AskQuestion("[?] windows or linux?", "linux");
    int secondQuestion = AskQuestion("[?] What code editor did microsoft create, xcode or visual studio", "visual studio");
    int thirdQuestion = AskQuestion("[?] What year is linux found? ", "1991");

    int totalScoreRound = firstQuestion + secondQuestion + thirdQuestion;

    return totalScoreRound;
}

static void RoundThree()
{
    AskQuestionWithoutAnswer("[?] Why is it important to update your computer reguraly?");
    AskQuestionWithoutAnswer("[?] What does a cpu do in a computer?");
    AskQuestionWithoutAnswer("[?] What to do when your computer is empty?");
}

static int RoundFive()
{
    // Round Two
    int firstQuestion = AskQuestion("[?] in which country is nvidia developed? america / russia / cuba", "america");
    int secondQuestion = AskQuestion("[?] How many countries are in Europe?", "51");
    int thirdQuestion = AskQuestion("[?] How many countries are in European Union", "27");

    int totalScoreRound = firstQuestion + secondQuestion + thirdQuestion;

    return totalScoreRound;
}

static int AskQuestion(string question, string answer)
{
    Console.WriteLine(question);
    
    string inputAnswer = Console.ReadLine();

    if (inputAnswer == answer)
    {
        Console.WriteLine("[+] Thats indeed the right answer");
        return 1;
    }

    Console.WriteLine("[-] Ugh... that was not the right answer");
    return 0;
}

static void AskQuestionWithoutAnswer(string question)
{
    Console.WriteLine(question);
    Console.ReadLine();
}