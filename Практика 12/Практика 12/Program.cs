using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_12
{
    class Program
    {

        public static int bubbleSort(int[] a,  int size, out int[] a1,out int count)
        {
            count = 0;
            int tmp;
            for (int i = 1; i < size; i++)
            {
                for (int j = 1; j < size; j++)
                {
                    if (a[j] > a[j - 1])
                    {
                        count++;
                        tmp = a[j];
                        a[j] = a[j - 1];
                        a[j - 1] = tmp;
                    }
                }
            }
            a1 = a;
            return count;
        }
        public static int Ussualy_Sort(int size,int[] mas,out int count, out int [] result)
        {
            count = 0;
             result = new int[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                int j = i;
                while (j > 0 && result[j - 1] > mas[i])
                {
                    result[j] = result[j - 1];
                    j--;
                    count++;
                }
                result[j] = mas[i];
            }
            mas = result;
            return count;
        }
        public static int create(int size, int [] a)
        {

            Console.WriteLine("ВВедите элементы массива");
            for(int i=0;i<size;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            return size;
        }
        static void show(int size, int [] a)
        {
            for (int i= 0; i<size; i++)
            {
                Console.Write(a[i]+" ");
            }
        }
        static void Main(string[] args)
        {
            int Count_Buble = 0;
            Console.WriteLine("Сортировка пузырьком");
            Console.WriteLine("Введите ращмер массива");
            int  size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            create(size,a);
            show(size, a);
            bubbleSort(a, size,out int[] a1,out Count_Buble);
            Console.WriteLine();
            show(size, a1); Console.Write("количество пересылок " + Count_Buble);
            Console.WriteLine();
            Console.WriteLine("Сортиртировка простиыми вставками");
            Console.WriteLine("Введите ращмер массива");
            int size1 = int.Parse(Console.ReadLine());
            int[] a2 = new int[size1];
            create(size1, a2);
            show(size1, a2);
            Ussualy_Sort(size1, a2,out  int count3, out a2);
            Console.WriteLine();
            show(size1, a2);
            Console.WriteLine("Количесвтво пересылок="+count3);
            Console.Read();
        }
    }
}
