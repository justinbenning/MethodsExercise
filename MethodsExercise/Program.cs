namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("What is your favorite Animal?");
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();
            Console.WriteLine($"{name}'s favorite color is {favoriteColor}.\n That is their favorite color because their favorite animal is a {favoriteAnimal} and that is the color of their fur" +
                $"\nTheir favorite band, {favoriteBand} sings a song about the same animal");
        }
    }
}
