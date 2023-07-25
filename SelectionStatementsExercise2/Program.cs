namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var favSubject = (Console.ReadLine());
            
            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("What a nerd!");
                    break;
                case "english":
                    Console.WriteLine("You must love reading!");
                    break;
                case "science":
                    Console.WriteLine("Carl Sagan is my hero.");
                    break;
                case "gym":
                    Console.WriteLine("You must be good at sports!");
                    break;
                default:
                    Console.WriteLine("What a slacker!");
                    break;

            }
        }
    }
}