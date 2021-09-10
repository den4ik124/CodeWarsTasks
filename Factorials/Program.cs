using System;
using System.Text;

namespace Factorials
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var result = Factorial(150);
        }

        /// <summary>
        /// Реализация умножения "в столбик" для чисел > int.MaxValue
        /// </summary>
        /// <param name="value1">строковое значение числа1</param>
        /// <param name="value2">строковое значение числа2</param>
        /// <returns>Результат умножения числа1 на число2</returns>
        public static string Multiply(string value1, string value2)
        {
            if (value1.Length < value2.Length)
                (value1, value2) = (value2, value1);
            string[] sums = new string[value2.Length];
            for (int i = value2.Length - 1; i >= 0; i--)
            {
                int additional = 0;
                StringBuilder sb = new StringBuilder("");
                for (int j = value1.Length - 1; j >= 0; j--)
                {
                    int result = int.Parse(value2[i].ToString()) * int.Parse(value1[j].ToString()) + additional;
                    int memory = result % 10;
                    additional = result / 10;
                    if (j == 0)
                    {
                        if (result < 10)
                            sb.Insert(0, memory);
                        else
                        {
                            sb.Insert(0, memory);
                            sb.Insert(0, additional);
                        }
                    }
                    else
                        sb.Insert(0, memory);
                }
                sb.Append('0', value2.Length - 1 - i);
                sums[value2.Length - i - 1] = sb.ToString();
            }
            bool isNeedToAddZeros = false;
            int max = sums[0].Length;
            foreach (var item in sums)
                if (item.Length > max)
                {
                    isNeedToAddZeros = true;
                    max = item.Length;
                }

            if (isNeedToAddZeros)
                for (int i = sums.Length - 2; i >= 0; i--)
                    sums[i] = sums[i].Insert(0, new string('0', max - sums[i].Length));

            return Summ(sums);
        }

        /// <summary>
        /// Реализация суммирования "в стобик" для чисел > int.MaxValue
        /// </summary>
        /// <param name="sums">Массив чисел в строковом формате</param>
        /// <returns>Сумму чисел в массиве</returns>
        private static string Summ(string[] sums)
        {
            int length = sums[0].Length;
            int additionalLoc = 0;
            StringBuilder sbSum = new StringBuilder("");
            for (int i = length - 1; i >= 0; i--)
            {
                int result = 0;
                for (int j = 0; j < sums.Length; j++)
                    result += int.Parse(sums[j][i].ToString());
                result += additionalLoc;
                int memoryLoc = result % 10;
                additionalLoc = result / 10;
                if (i == 0)
                    sbSum.Insert(0, result);
                else
                {
                    if (result < 10)
                        sbSum.Insert(0, result);
                    else
                        sbSum.Insert(0, memoryLoc);
                }
            }
            return sbSum.ToString();
        }

        /// <summary>
        /// Расчет факториала
        /// </summary>
        /// <param name="n">Число, факториал которого нужно вычислить</param>
        /// <returns>Факториал числа n</returns>
        public static string Factorial(int n)
        {
            if (n < 0)
                return string.Empty;
            if (n == 1 || n == 0)
                return "1";
            return Multiply(n.ToString(), Factorial(n - 1));
        }
    }
}