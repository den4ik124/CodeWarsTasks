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
            var result = SubstractArrayQuick(array1, array2);
            var result2 = SubstractArrayQuick(new int[] { 1, 2, 3 }, new int[] { 1, 2 });
            var result3 = SubstractArrayQuick(new int[] { }, new int[] { 1, 2 });
        }

        public static int[] SubstractArrayQuick(int[] a, int[] b) => a.Where(item => b.Contains(item)).ToArray();

        /// <summary>
        /// Удаляет из массива элементы второго массива
        /// </summary>
        /// <param name="array1">Исходный массив</param>
        /// <param name="array2">Массив с элементами, которые надо удалить</param>
        /// <returns>Массив с удаленными элементами</returns>
        public static int[] SubstractArray(int[] array1, int[] array2)
        {
            if (array1.Length == 0)
                return array1; //если массив пустой - возвращается сам массив

            List<int> list = new List<int>(); //вспомогательная коллекция для удобства удаления элементов
            foreach (var item in array1)
                list.Add(item); //заполнение коллекции элементами исходного массива

            for (int i = 0; i < array2.Length; i++)
                list.RemoveAll(item => item == array2[i]); //удаление из коллекции всех элементов массива
            return list.ToArray();
        }
    }
}