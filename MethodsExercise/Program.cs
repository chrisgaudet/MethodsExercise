namespace MethodsExercise
{

}
    public class Program
    {
        static void Main(string[] args)
        {
            //MadLib();

            int added = Addition(2, 2);
            Console.WriteLine(added);

            int Subtracted = Subtraction(10, 5);
            Console.WriteLine(Subtracted);

            int Multiplied = Multiplication(2, 5);
            Console.WriteLine(Multiplied);

            int Divided = Division(4, 2);
            Console.WriteLine(Divided);

            static void MadLib()
            {
                Console.WriteLine("What is your name?");
                string userName = Console.ReadLine();
                Console.WriteLine($"Hello, {userName}! What is your favorite color?");
                string favColor = Console.ReadLine();
                Console.WriteLine("Favorite band?");
                string favBand = Console.ReadLine();
                Console.WriteLine("Favorite animal?");
                string favAnimal = Console.ReadLine();

                Console.WriteLine($"One day, {userName} was walking through the woods while wearing a {favColor} t-shirt. {userName} saw a {favAnimal} listening to {favBand}.");
            }

            static int Addition(int numOne, int numTwo)
            {
                return numOne + numTwo;
            }

            static int Subtraction(int numOne, int numTwo)
            {
                return numOne - numTwo;
            }

            static int Multiplication(int numOne, int numTwo)
            {
                return numOne * numTwo;
            }

            static int Division(int numOne, int numTwo)
            {
                return numOne / numTwo;
            }
        }
    }

