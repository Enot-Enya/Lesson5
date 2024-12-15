namespace HomeWork3
{
    internal class Homework3
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindIndex(
                array : [81, 22, 13, 34, 10, 34, 15, 26, 71, 68],
                index : 55                
                ));
        }

        static int FindIndex(int[] array, int index)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == index) return i;
            }
            return -1;
        }
    }
}
