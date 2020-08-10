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
                try{
                array1[i] = Int32.Parse(Console.ReadLine());
                }
                catch(System.Exception){
                    System.Console.WriteLine("Não é possível inserir um valor deste tipo");
                }
            }
            System.Console.WriteLine("Digite os números do array2: ");

            for (int i = 0; i < arraysLength; i++)
            {
                try{
                array2[i] = Int32.Parse(Console.ReadLine());
                }
                catch(System.Exception){
                    System.Console.WriteLine("Não é possível inserir um valor deste tipo");
                }
            }
            System.Console.WriteLine("Arrays como o usuário informou: ");
            for (int i = 0; i < arraysLength; i++)
            {
                System.Console.WriteLine($"Array1: {array1[i]}");
            }

            System.Console.WriteLine("");
            
            for (int i = 0; i < arraysLength; i++)
            {
                System.Console.WriteLine($"Array2: {array2[i]}");
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("Arrays trocados: ");
            System.Console.WriteLine("");
            for (int i = 0; i < arraysLength; i++)
            {
                temporary[i] = array1[i];
                array1[i] = array2[i];
                array2[i] = temporary[i];           
            }

            for (int i = 0; i < arraysLength; i++)
            {
                System.Console.WriteLine($"Array1: {array1[i]}");
            }

            System.Console.WriteLine("");
            
            for (int i = 0; i < arraysLength; i++)
            {
                System.Console.WriteLine($"Array2: {array2[i]}");
            }

        }
        
        static void Exercise2()
        {
            const int arrayLength = 3;
            
            var arrayOfNumbers = new double[arrayLength];

            System.Console.WriteLine("Informe os números: ");

            for (int i = 0; i < arrayLength; i++)
            {
                try
                {
                    arrayOfNumbers[i] = double.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Insira apenas números, tente novamente!");
                }                
            }
            foreach (var item in arrayOfNumbers)
            {
                if (item == item)
                {
                    System.Console.WriteLine("equals");
                }
                else
                {
                    System.Console.WriteLine("not equals");
                }
            }
        }
        static void Main(string[] args)
        {
            Exercise2();
        }
    }
}