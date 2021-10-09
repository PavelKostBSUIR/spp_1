using System;
using MyLib_1;
namespace SPP_1_console_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу:");
            String path = Console.ReadLine();
            Sort.MergeSort(path);
            Console.WriteLine("Файл отсортирован");
        }
    }
}
