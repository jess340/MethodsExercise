namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            MadLib(); 
        }

        public static void MadLib()
        {

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine ($"Hello, {userName}! What is your favorite color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"One day {userName}, was walking in the woods while wearing a {favColor} t-shirt. {userName} saw a {favAnimal} while listening to {favBand}.");
        }
    }
}
