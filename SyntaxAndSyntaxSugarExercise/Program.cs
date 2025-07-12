namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var answer = 10;
            var response = answer < 9 ? $"{answer} is less than 9" : $"{answer} is more than or equal to 9";
            Console.WriteLine(response);

        }
    }
}
