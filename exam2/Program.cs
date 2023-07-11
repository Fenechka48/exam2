using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Вы – профессиональный грабитель, планирующий ограбить дома вдоль улицы. 
             В каждом доме спрятана определённая сумма денег. Единственное ограничение,
            мешающее вам ограбить каждый из них, заключается в том, что в соседних домах 
            подключены системы безопасности, которые срабатывает если два соседних дома будут 
            взломаны в одну и ту же ночь. Целочисленный массив nums – представляет сумму денег в 
            каждом доме. Необходимо вернуть максимальную сумму денег, которую вы можете ограбить сегодня вечером,
            не привлекая внимания полиции. 

            Ввод: nums = [1,2,3,1] 
            Вывод: 4 

            Ввод: nums = [2,7,9,3,1] 
            Вывод: 12 */
            // ввод исходных данных
            Console.WriteLine("Введите размер исходного массива:");
            int size;
            if (Int32.TryParse(Console.ReadLine(), out int value))
            {
                size = value;
            }
            else
            {
                throw new ApplicationException("Ошибка! Вы ввели не число!");
            }
            int[] nums = new int[size];
            Console.WriteLine("Введите массив положительных целых чисел:");
            for (int i = 0; i < size; i++)
            {
                nums[i] = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            // вычисляем сумму четных и нечетных элементов массива,
            // сравниваем и выбираем большее.
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0) sum1 += nums[i];
                else sum2 += nums[i];
            }
            int res;
            res = (sum1 > sum2) ? sum1 : sum2;
            // вывод результата
            Console.WriteLine("ответ: " + res);
        }
    }
}
