using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    class Program
    {
        public static int Add(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
        public static int Sub(int num1, int num2)
        { return num1 - num2; }

        public static int Mul(int num1, int num2, int num3)
        { return num1 * num2 * num3; }

        public static int Div(int num1, int num2)
        { return num1 / num2; }

        public static int Mod(int num1, int num2)
        { return num1 % num2; }

           
        
        
        
        static void Main(string[] args)
        {
            var addition = Add(2, 3, 5, 2, 7);
            Console.WriteLine(addition);
            var subtraction = Sub(5, 2);
            Console.WriteLine(subtraction);
            var mutilply = Mul(3, 3, 4);
            Console.WriteLine(mutilply);
            var division = Div(9, 3);
            Console.WriteLine(division);
            var modulus = Mod(25, 4);
            Console.WriteLine(modulus);



            //Exercise 1
            /*Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("What is your favorite Animal?");
            string favoriteAnimal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();
            Console.WriteLine($"{name}'s favorite color is {favoriteColor}.\nThat is their favorite color because their favorite animal is a {favoriteAnimal} and that is the color of their fur" +
                $"\nTheir favorite band, {favoriteBand} sings a song about the same animal");*/
          

         

         
            
            

            

        }
        
    }
}
