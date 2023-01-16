using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ7_7
{
    public class ArrayWorker
    {
        /// <summary>
        /// Функция определения длины элемента
        /// </summary>
        /// <param name="array">Массив, в котором определяется длина элементов</param>
        /// <param name="length">Значение длины, заданное переменной</param>
        /// <returns></returns>
        public int CheckArray(string[] array, int length) // Функция определения длины элемента
        {
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= length)
                    result++;
            }
            return result;
        }
        /// <summary>
        /// Функция заполнения нового массива значениями
        /// </summary>
        /// <param name="Array">Массив с данными, из которого они переносятся в новый</param>
        /// <param name="newArray">Новый массив</param>
        /// <param name="lengthLimit">Значение лимита длины</param>
        public void NewArray(string[] Array, string[] newArray, int lengthLimit)// функция заполнения нового массива значениями
        {
            int temp = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i].Length <= lengthLimit)
                {
                    newArray[temp] = Array[i];
                    temp++;
                }
            }
        }
        /// <summary>
        /// Функция вывода массива
        /// </summary>
        /// <param name="array">Массив для вывода</param>
        /// <returns>Элементы массива </returns>
        public string PrintArray(string[] array)
        {
            string result = string.Empty;
            result = "[ ";
            for (int i = 0; i < array.Length; i++)
            {
                result += $"{array[i],1}";
                if (i < array.Length - 1) result += ", ";
            }
            result += " ]";
            return result;
        }
    }
}
