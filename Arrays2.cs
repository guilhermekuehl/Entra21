using System;

namespace primeira_aula
	{
		class Arrays2
		    {
        static void Exercise1()
        {
            const int arraysLength = 10;

            var array1 = new int[arraysLength];
            var array2 = new int[arraysLength];
            var temporary = new int[arraysLength];

            System.Console.WriteLine("Digite os números do array1: ");

            for (int i = 0; i < arraysLength; i++)
            {
                array1[i] = Int32.Parse(Console.ReadLine());
            }
            System.Console.WriteLine("Digite ps números do array2");

            for (int i = 0; i < arraysLength; i++)
            {
                array2[i] = Int32.Parse(Console.ReadLine());
            }
            System.Console.WriteLine(string.Join(",", array1, array2));
        }
        static void Main(string[] args)
        {
            Exercise1();
        }
    }
}