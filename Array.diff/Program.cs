using System.Linq;
using System.Collections.Generic;

namespace Array.diff
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2 };
            int[] array2 = new int[] { 1 };

            //var result = SubstractArray(array1, array2);
            //var result2 = SubstractArray(new int[] { 1, 2, 3 }, new int[] { 1, 2 });
            //var result3 = SubstractArray(new int[] { }, new int[] { 1, 2 });
            var result = SubstractArrayQuick(array1, array2);
            var result2 = SubstractArrayQuick(new int[] { 1, 2, 3 }, new int[] { 1, 2 });
            var result3 = SubstractArrayQuick(new int[] { }, new int[] { 1, 2 });
        }

        public static int[] SubstractArrayQuick(int[] a, int[] b) => a.Where(item => b.Contains(item)).ToArray();

        public static int[] SubstractArray(int[] array1, int[] array2)
        {
            if (array1.Length == 0)
            {
                return array1;
            }
            List<int> list = new List<int>();
            foreach (var item in array1)
                list.Add(item);

            for (int i = 0; i < array2.Length; i++)
                list.RemoveAll(item => item == array2[i]);
            return list.ToArray();
        }
    }
}