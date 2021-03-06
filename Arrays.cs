using System;

namespace primeira_aula
{
	class Arrays
	{
        static void Exercise1()
        {
            const int arraysLenght = 15;
            
            var a = new double[arraysLenght];
            var b = new double[arraysLenght];
            var c = new double[arraysLenght];

            System.Console.WriteLine($"Digite os {arraysLenght} primeiros valores");

            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor:");
                a[i] = Double.Parse(Console.ReadLine());
            }

            System.Console.WriteLine($"Digite os próximos {arraysLenght} valores");

            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor:");
                var result = Double.Parse(Console.ReadLine());
                b[i] = result;
                c[i] = a[i] - result;
            }
		}

		static void Exercise2()
		{
            var numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine("Digite um número:");
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Ordem direta de cadastro:");

            foreach (var item in numbers)
            {
               System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Ordem inversa de cadastro:");

            for (int i = numbers.Length - 1; i > -1; i--)
            {
                System.Console.WriteLine(numbers[i]);
            }
		}

		static void Exercise3()
		{
            var numbers = new double[3];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                System.Console.WriteLine("Digite um número:");
                numbers[i] = Double.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Pesquise um número:");
            var search = Double.Parse(Console.ReadLine());

            var founded = false;

            foreach (var item in numbers)
            {
                if (item == search)
                {
                    founded = true;
                    break;
                }
            }

            if (founded)
            {
               System.Console.WriteLine("O número existe no array"); 
            }
            else
            {
               System.Console.WriteLine("Número inexistente");
            }
		}

		static void Exercise4()
		{
            const int arraysLenght = 3;
            
            var a = new double?[arraysLenght];
            var b = new double[arraysLenght];

            System.Console.WriteLine($"Digite os {arraysLenght} primeiros valores");

            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor:");
                a[i] = Double.Parse(Console.ReadLine());
            }

            System.Console.WriteLine($"Digite os próximos {arraysLenght} valores");

            var arraysAreEquals = true;

            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor:");
                var result = Double.Parse(Console.ReadLine());
                b[i] = result;

                var hasEquals = false;

                for (int j = 0; j < a.Length; j++)
                {
                    if(a[j] == result)
                    {
                        hasEquals = true;
                        a[j] = null;
                        break;
                    }   
                }

                if (!hasEquals)
                {
                    arraysAreEquals = false;
                }
            }

            var message = arraysAreEquals ? "Os arrays são iguais" : "Os arrays são diferentes";
            System.Console.WriteLine(message);
		}

		static void Exercise5()
		{
            const int arraysLength = 15;

            var belowAverage = 0;
            var aboveAverage = 0;
            var onAverage = 0;

            var soma = 0.0;
            var average = 0.0;

            var arrayOfNumbers = new double[arraysLength];
            
            System.Console.WriteLine("Digite os valores:");

            for (int i = 0; i < arraysLength; i++)
            {
                arrayOfNumbers[i] = Double.Parse(Console.ReadLine());
                soma += arrayOfNumbers[i];
            }
            average = soma / arraysLength;
            System.Console.WriteLine($"Média: {average}");

            foreach (var item in arrayOfNumbers)
            {
                if(item < soma)
                {
                    belowAverage++;
                }
                else if(item > soma)
                {
                    aboveAverage++;
                }
                else
                {
                    onAverage++;
                }
            }            
                System.Console.WriteLine($"Abaixo: {belowAverage}, acima: {aboveAverage}, na média {onAverage}");
            
        }

		static void Exercise6()
		{
            const int arraysLength = 12;

            var a = new int[arraysLength];
            var b = new int[arraysLength];
            var c = new int[arraysLength];

            System.Console.WriteLine("Digite os valores do array 'a': ");
            for (int i = 0; i < arraysLength; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(a);
            System.Console.WriteLine(string.Join(",", a));

            System.Console.WriteLine("Digite os valore do array 'b': ");
            for (int i = 0; i < arraysLength; i++)
            {
                b[i] = Int32.Parse(Console.ReadLine());
            }
            Array.Sort(b);
            Array.Reverse(b);
            System.Console.WriteLine(string.Join(",", b));

            for (int i = 0; i < arraysLength; i++)
            {
                c[i] = a[i] + b[i];
            }
            Array.Sort(c);
            System.Console.WriteLine(string.Join(",", c));
        }
            
		static void off(string[] args)
		{
            Exercise6();
		} 
    }
}