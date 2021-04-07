using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1

            Console.WriteLine("Hi, what is your first name?");
            
            var firstName = Console.ReadLine();
            
            Console.WriteLine($"Welcome, {firstName}! Let's have some fun! What's your favorite mythical creature?");
            
            var mythicalCreature = Console.ReadLine();
            
            Console.WriteLine($"{mythicalCreature}(s) are pretty awesome! What's your favorite season?");
            
            var season = Console.ReadLine();
            
            Console.WriteLine($"Oh, {season} is a good one! Perfect time to hang around {mythicalCreature}s! Lastly, where's your dream vacation?");
            
            var dreamVacation = Console.ReadLine();
            
            Console.WriteLine($"Surprise, {firstName}! You're now stuck in {dreamVacation}, but it's not all rainbows and daisies. \n" +
              $"Are you ready for what's next?");

            //Exercise 2

            var halloweenGroup = Sum(2, 3);
            Console.WriteLine($"Happy Halloween! Looks like the {halloweenGroup} of us are ready to head out and get some candy!");

            var halloweenCandy = Multiply(4, 28);
            Console.WriteLine($"The four of us got together and put together our Halloween candy and ended up with {halloweenCandy} pieces!");

            var lessCandy = Subtract(112, 40);
            Console.WriteLine($"We ended up having to share some of our Halloween candy and are left with {lessCandy}");

            var splitCandy = Divide(72, 4);
            Console.WriteLine($"It's time to go home so we split what's left of our candy amongst the four of us and ended up with {splitCandy} ");

            var leftOverCandy = Modulus(12, 5);
            Console.WriteLine($"We had a few stragglers, {leftOverCandy} to be exact. I ate them. Shh!");

        }
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;
        }
        public static int Subtract(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;
        }
        public static int Divide(int num1, int num2)
        {
            var answer = num1 / num2;
            return answer;
        }
        public static int Modulus(int num1, int num2)
        {
            var answer = num1 % num2;
            return answer;
        }
    }
}
