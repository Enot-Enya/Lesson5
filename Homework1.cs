namespace Lesson5
{
    internal class Homework1
    {
        static void Main(string[] args)
        {           
            Console.WriteLine(EvenCounter(7, 21));
        }

        private static int EvenCounter(int min, int max)
        {
            int summ = 0;
            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0) summ += i;
            }
            return summ;
        }    
    }
}
