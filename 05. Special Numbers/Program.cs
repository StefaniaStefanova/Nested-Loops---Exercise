namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int number = i;
                bool isSpecial = true;

                while (number > 0)
                {
                    int digit = number % 10;
                    number /= 10;

                    if (digit == 0 || n % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }

                if (isSpecial)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}