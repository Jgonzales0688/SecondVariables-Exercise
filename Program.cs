namespace SecondVariables_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Jessica";
            int age = 21;
            char intial = 'J';
            bool answer = false;
            double num1 = 21.5;
            decimal num2 = 22.5m;

            Console.WriteLine($"Her name is {name}, and she is {age} years old" +
                $" and its {answer} that she is {num1} but looks forward to turing {num2}");
        }
    }
}