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
            const int arraysLength = 3;

            var counterProjectYes = 0;
            var counterProjectNo = 0;
            var result = "";
            var arraysOfPerson = new char [arraysLength];
            var counterWomen = 0;
            var counterMen = 0;
            var percentMenNo = 0.0;
            var percentWomenYes = 0.0;

            for (int i = 0; i < arraysLength; i++)
            {
                System.Console.WriteLine("Digite seu sexo: (m) (f)");
                arraysOfPerson[i] = char.Parse(Console.ReadLine());
                System.Console.WriteLine("Informe sua resposta: (sim) (nao)");
                result = Console.ReadLine();
                
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
                    counterMen++;
                }
                else if (arraysOfPerson[i] == 'f' && result == "sim")
                {
                    counterWomen++;
                }
            }
                percentWomenYes = (counterWomen / arraysLength) * 100;
                System.Console.WriteLine($"{percentWomenYes}% das mulheres concordaram com o projeto");
                System.Console.WriteLine($"{counterMen}% dos homens discordaram com o projeto");
                System.Console.WriteLine($"{counterProjectYes} pessoa(s) concordaram com o projeto");
                System.Console.WriteLine($"{counterProjectNo} pessoa(s) discordaram com o projeto");
        }
        
        static void Main(string[] args)
        {
            Exercise3();
        }
    }
}