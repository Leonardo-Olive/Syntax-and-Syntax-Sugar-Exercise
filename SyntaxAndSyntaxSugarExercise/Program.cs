namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a number");
            var answer = int.Parse(Console.ReadLine());
            var response = (answer < 9)? $"{ answer} is less than nine" : $"{answer} is greater than or equal to nine";
            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}
