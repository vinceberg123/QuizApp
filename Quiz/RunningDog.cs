namespace Quiz
{
    internal class RunningDog
    {
        public static void ShowRunningDog()
        {
            string baseDog = @"   
                  ;~~,__
   :-....,-------'`-'._.'
    `-,,,  ,       ,'~~'
        ; ,'~.__; /
        :|      :|
        `-'     `-'";

            string firstRunningDog = @"
                  ;~~,__
   :-....,-------'`-'._.'
    `-,,,  ,       ,'~~'
        ; ,'~.__; /--.
        :| :|   :|``(;
        `-'`-'  `-'";

            string secondRunningDog = @"
                  ;~~,__
   :-....,-------'`-'._.'
    `-,,,  ,       ;'~~'
       ,'_,'~.__; '--.
      //'       ````(;
     `-'";

            string thirdRunningDog = @"
                .--~~,__
   :-....,-------`~~'._.'
    `-,,,  ,_      ;'~U'
     _,-' ,'`-__; '--.
    (_/'~~      ''''(;";


            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                AnimateDog(baseDog);
                AnimateDog(firstRunningDog);
                AnimateDog(secondRunningDog);
                AnimateDog(thirdRunningDog);

                Console.WriteLine("[ ] Press enter to quit. Or any other key to let de dog run.");
            }

            Console.Clear();
        }

        public static void AnimateDog(string animation)
        {
            Console.Clear();
            Thread.Sleep(200);
            Console.WriteLine(animation);
        }
    }
}
