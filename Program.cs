namespace test_praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("въведи цели числа, Разделени с интервал: ");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');
            int[] numbers = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                int num = 0;
                bool negative = false;
                int start = 0;

                if (parts[i][0] == '-')
                {
                    negative = true;
                    start = 1;
                    {
                        for (int j = start; j < parts.Length; j++)
                        {
                            num = num * 10 + (parts[i][j] - '0');
                        }
                        if (negative)
                            num = -num;

                        numbers[i] = num;
                    }

                    int suma = 0;
                    int naiGolyamo = numbers[0];

                    for (int j = 0; i < numbers.Length; i++)
                    {
                        suma = suma + numbers[i];

                        if (numbers[i] > naiGolyamo)
                        {
                            naiGolyamo = numbers[i];
                        }
                    }
                    double sredno = (double)suma / numbers.Length;

                    Console.WriteLine("Сума: " + suma);
                    Console.WriteLine("Най-голямо число: " + naiGolyamo);
                    Console.WriteLine("Средна стойност: " + sredno);
                }
            }

        }
    }
}