namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello, what is your favorite subject in school?");

            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "Math":
                    Console.WriteLine($"Math is very interesting");
                    break;
                case "Science":
                    Console.WriteLine($"That is out of this world!");
                    break;
                case "Spanish":
                    Console.WriteLine($"Tu Hables Espanol");
                    break;
                case "English":
                    Console.WriteLine($"Wow, you read a lot");
                    break;
                default:
                    Console.WriteLine($"That must be new");
                    break;

            }
        }
    }
}