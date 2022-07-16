//using System.Collections.Generic;

namespace Seminar7
{
    class Notes
    {
        /// <summary>This method main</summary>
        /// <param name="sender"></param>
        public static void Main(string[] args)
        {
            int[] points = new int[3] { 22, 11, 33 };
            List<int> list = new List<int>() { 1, 2, 3, 4, 5 };
            list.Add(7);
            list.AddRange(points);

            foreach (int number in list)
            {
                Console.Write($"{number} ");
            }

            FillList(list, 5);
            int num = list.Find(x => x % 2 == 0);
            List<int> evenNumbers = list.FindAll(x => x % 2 == 0);

            foreach (int x in evenNumbers)
            {
                Console.WriteLine(x);
            }
        }

        public static void FillList(List<int> list, int count)
        {
            for (int i = 0; i < count; i++)
            {
                list.Add(new Random().Next(0, 11));
            }
        }
    }
}
