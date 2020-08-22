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
            var hasRepeat = false;
            for (int i = 0; i < arrayLength; i++)
            {
                for (int j = 0; j < arrayLength; j++)
                {
                    if (arrayOfNumbers[i] == arrayOfNumbers[j] && i != j)
                    {
                        hasRepeat = true;
                        break;
                    }
                }
                if (hasRepeat)
                {
                    break;
                }
            }
            System.Console.WriteLine(hasRepeat ? "Contém repetição" : "Não contém repetição");
        }
        
        static void Exercise3()
        {
            const int arraysLength = 10;

            var counterProjectYes = 0;
            var counterProjectNo = 0;
            var result = "";
            var arraysOfPerson = new char [arraysLength];
            var counterWomenYes = 0;
            var counterMenNo = 0;
            var percentMenNo = 0.0;
            var percentWomenYes = 0.0;
            var counterMen = 0;
            var counterWomen = 0;

            for (int i = 0; i < arraysLength; i++)
            {
                System.Console.WriteLine("Digite seu sexo: (m) (f)");
                arraysOfPerson[i] = char.Parse(Console.ReadLine());
                System.Console.WriteLine("Informe sua resposta: (sim) (nao)");
                result = Console.ReadLine();

                if (arraysOfPerson[i] == 'm')
                {
                    counterMen++;
                }
                else if (arraysOfPerson[i] == 'f')
                {
                    counterWomen++;
                }

                if (result == "sim")
                {
                    counterProjectYes++;
                }
                else
                {
                    counterProjectNo++;
                }
                
                if(arraysOfPerson[i] == 'm' && result == "nao")
                {
                    counterMenNo++;
                }
                else if (arraysOfPerson[i] == 'f' && result == "sim")
                {
                    counterWomenYes++;
                }
            }

            percentWomenYes = counterWomenYes * (100 / counterWomen);
            percentMenNo = counterMenNo * (100 / counterMen);

            System.Console.WriteLine($"{percentWomenYes}% das mulheres concordaram com o projeto");
            System.Console.WriteLine($"{percentMenNo}% dos homens discordaram com o projeto");
            System.Console.WriteLine($"{counterProjectYes} pessoa(s) concordaram com o projeto");                
            System.Console.WriteLine($"{counterProjectNo} pessoa(s) discordaram com o projeto");
        }
        
        static void Exercise4()
        {
            const int arrayLength = 5;

            var arrayElements = new double[arrayLength];
            var soma = 0.0;

            System.Console.WriteLine("Insira os valores: ");

            for (int i = 0; i < arrayLength; i++)
            {
                arrayElements[i] = double.Parse(Console.ReadLine());
                if(arrayElements[i] %2 != 0)
                {
                    soma += arrayElements[i];
                }
            }
            System.Console.WriteLine($"Soma: {soma}");
        }

        static void Exercise5()
        {
            const int arrayLength = 10;

            var arrayOfValue = new double[arrayLength];
            var counter = 0;

            System.Console.WriteLine("Insira os valores: ");

            for (int i = 0; i < arrayLength; i++)
            {
                arrayOfValue[i] = double.Parse(Console.ReadLine());
                if (arrayOfValue[i] > 0)
                {
                    counter++;
                }
            }
            System.Console.WriteLine($"Há {counter} valor(es) positivos.");
        }

        static void Exercise6()
        {
            const int arrayLength = 10;

            var arrayElements = new double[arrayLength];
            var bigger = 0.0;
            var position = 0;

            System.Console.WriteLine("Insira os valores: ");
            for (int i = 0; i < arrayLength; i++)
            {
                arrayElements[i] = double.Parse(Console.ReadLine());
                if (arrayElements[i] < 0)
                {
                    arrayElements[i] = 0;
                }

                if (arrayElements[i] > bigger)
                {
                    bigger = arrayElements[i];
                    position = i;
                }
            }
            System.Console.WriteLine($"Maior: {bigger} na posição: {position}");

        }

        static void Exercise7()

        {
            const int arrayLength = 3;

            var a = new int[arrayLength];
            var counter = 0;

            System.Console.WriteLine("Insira os números: ");
            for (int i = 0; i < arrayLength; i++)
            {
                while(true)
                {
                    try
                    {
                        a[i] = Int32.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Digita um número inteiro");
                    }
                }
                if (a[i] == i)
                {
                    counter++;
                }
            }
            if (counter == 0)
            {
                System.Console.WriteLine("Nenhum dos números é igual a sua posição");
            }
            else
            {
                System.Console.WriteLine($"{counter} vez(es)");
            }
            
        }

        static void Exercise8()
        {
            const int arrayLength = 10;

            var arrayOfLetters = new string[arrayLength];
            var counterVogals = 0;

            System.Console.WriteLine("Insira suas letras: ");

            for (int i = 0; i < arrayLength; i++)
            {
                arrayOfLetters[i] = Console.ReadLine();
                if (arrayOfLetters[i] == "a" || arrayOfLetters[i] == "e" || arrayOfLetters[i] == "i" || arrayOfLetters[i] == "o" || arrayOfLetters[i] == "u")
                {
                    counterVogals++;
                }
            }
            if (counterVogals == 0)
            {
                System.Console.WriteLine("Nenhuma vogal foi inserida");
            }
            else
            {
                System.Console.WriteLine($"Foram informadas {counterVogals} vogais");
            }
            
            
        }
   
        static void Exercise9()
        {
            const int arrayLength = 10;

            var arrayOfLettersInIndex = new string[arrayLength];
            var arrayOfLetters = new string[arrayLength];

            System.Console.WriteLine("Insira suas letras: ");

            for (int i = 0; i < arrayLength; i++)
            {
                arrayOfLetters[i] = Console.ReadLine();
                if (i %2 == 0)
                {
                    arrayOfLettersInIndex[i] = arrayOfLetters[i];
                }
            }
            System.Console.WriteLine("Resultado: ");
            System.Console.WriteLine(string.Join(",", arrayOfLettersInIndex));
        }
        static void off(string[] args)
        {
            Exercise9();
        }
    }
}