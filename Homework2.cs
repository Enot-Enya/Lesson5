namespace HomeWork2
{
    internal class Homework2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EvenCounter([81, 22, 13, 54, 10, 34, 15, 26, 71, 68]));
        }

        private static int EvenCounter(int[] array)
        {
            int summ = 0;
            foreach (int i in array) 
            {
                if (i % 2 == 0) summ += i;
            }
            return summ;
        }
    }
}
