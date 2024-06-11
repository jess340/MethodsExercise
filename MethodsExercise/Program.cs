namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //MadLib();
            int added = Add(2, 2);
            Console.WriteLine(added);

            int minus = Minus(10, 5);
            Console.WriteLine(minus);

            int mult = Multiply(5, 5);
            Console.WriteLine(mult);

            int div = Divide(4, 2);
            Console.WriteLine(div);

            int result = Sum(5, 5, 5, 5, 5, 5, 5);
            Console.WriteLine(result); 

        }

        public static void MadLib()
        {

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"One day {userName}, was walking in the woods while wearing a {favColor} t-shirt. {userName} saw a {favAnimal} while listening to {favBand}.");
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public static int Minus(int numThree, int numFour)
        {
            return numThree - numFour; 
        }

        public static int Multiply(int numFive, int numSix)
        {
            return numFive * numSix; 
        }

        public static int Divide(int numSeven, int numEight)
        {
            return numSeven / numEight; 
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number; 
            }

            return sum; 
        }
    }
}
