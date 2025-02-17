using Quiz;

RoundThree();
// Introduction
Console.WriteLine("[?] Enter your username");
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
Console.WriteLine("\n[?] Guess a number..");
GuessNumber.Run();

// Round three
Console.WriteLine("\n");
RoundThree();

// Round Four
Console.WriteLine("\n[+] Keep in mind, the dog is going to run as much as you press the key. So please keep in mind to not hold down a key, instead just press it.");
RunningDog.ShowRunningDog();

// Round five
Console.WriteLine("\n");
int totalScoreRoundFive = RoundFive();

if (totalScoreRoundFive < 1)
{
    Console.WriteLine("[-] Failed to pass round 5");
    return;
}

Console.WriteLine("[+] Finished quiz.");

static int RoundOne()
{
    int firstQuestion = AskQuestion("[?] Who was created first windows or linux?", "windows");
    int secondQuestion = AskQuestion("[?] What code editor did microsoft create, xcode or visual studio", "visual studio");
    int thirdQuestion = AskQuestion("[?] What year was linux created? ", "1991");

    int totalScoreRound = firstQuestion + secondQuestion + thirdQuestion;

    return totalScoreRound;
}

static void RoundThree()
{
    AskQuestionWithoutAnswer("[?] Why is it important to update your computer reguraly?", "\n[ ] because else your computer doesn't get the latest security updates, and its vulnarable for hackers.");
    AskQuestionWithoutAnswer("[?] What does a cpu do in a computer?", "\n[ ] a cpu is the main part of a computer that processes instructions from programs, performing calculations and managing data flow. It acts as the computers brain executing tasks through its cores and threads to keep the system running smoothly.");
    AskQuestionWithoutAnswer("[?] What to do when your laptop battery is empty?", "\n[ ] charge the laptop");
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

static void AskQuestionWithoutAnswer(string question, string answer)
{
    Console.WriteLine(question);
    Console.ReadLine();
    Console.WriteLine($"The right answer contains, {answer}");
}
