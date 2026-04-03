namespace InPractice
{
    class Program
    {
        public static void Main()
        {
            int current_year;
            int birth_year;

            Console.WriteLine("Em que ano estamo?");
            current_year = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Em que ano você nasceu?");
            birth_year = int.Parse(Console.ReadLine()!);

            int age = current_year - birth_year;

            Console.WriteLine($"Você tem {age} anos!");

        }
    }
}

