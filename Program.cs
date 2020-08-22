using System;

namespace primeira_aula
	{
		class Program
			{
		static void Exercise1()
		 {
		    Console.WriteLine("crescente");

            for (int i = 1; i < 11; i++)
            {
			    Console.WriteLine(i);
            }

			System.Console.WriteLine("decrescente");

            for (int i = 10; i > 0; i--)
            {
				System.Console.WriteLine(i);   
            }

			System.Console.WriteLine("apenas os pares");

            for (int i = 2; i < 11; i += 2)
            {
                System.Console.WriteLine(i);
            }
		}

		static void Exercise2()
		{
			var soma = 0;

            for (int i = 1; i <= 100; i++)
            {
				soma += i;
            }

			System.Console.WriteLine($"A soma dos números inteiros entre 1 e 100 é {soma}");
		}

		static void Exercise3()
		{
            for (int i = 1; i < 200; i += 2)
            {
				System.Console.WriteLine(i);
            }
		}

		static void Exercise4()
		{
			var soma = 0;
            var idade = 0;
            var counter = 0;

            for (int i = 0; true; i++)
            {
                System.Console.WriteLine("Digite sua idade (digite 0 se quiser parar)");
                idade = Int32.Parse(Console.ReadLine());
                soma += idade;
                if (idade == 0)
                {
                    break;
                }
                counter++;
            }
            System.Console.WriteLine($"Média: {soma / counter}");
		}

		static void Exercise5()
		{
            var arraysLength = 5;
			var womenBetween18And35 = 0;
            var women = new int[arraysLength];
            var i = 0;
            
            System.Console.WriteLine("Insira sua idade: ");
            for (i = 0; i < arraysLength; i++)
            {
                while (true)
                {
                    try
                    {
                        women[i] = Int32.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Digite apenas números: ");
                    }
                }
                if (women[i] > 18 && women[i] < 35)
                {
                    womenBetween18And35++;
                }
            }
            System.Console.WriteLine($"{womenBetween18And35 * (100 / arraysLength)}%");

		}

		static void Exercise6()
		{
			const string registerMode = "1";
			const string votesMode = "2";
			const string resultMode = "3";

			var candidates = new (string name, int votes)[2];
			
			while (true)
			{
				System.Console.WriteLine("Selecione um dos modos a baixo:");
				System.Console.WriteLine($"{registerMode}) Cadastro de candidatos");
				System.Console.WriteLine($"{votesMode}) Votar");
				System.Console.WriteLine($"{resultMode}) Apuração dos votos");
				var mode = Console.ReadLine();

				if (mode == resultMode)
				{
					break;
				}

				if (mode == registerMode)
				{
					var password = "";
					while (password != "Pa$$w0rd")
					{
						System.Console.WriteLine("Digite a senha");
						password = Console.ReadLine();
					}

                    for (int i = 0; i < candidates.Length; i++)
                    {                   
                        System.Console.WriteLine($"Digite o nome do candidato nº{i + 1}");
                        candidates[i].name = Console.ReadLine();
                    }
				}

				if (mode == votesMode)
				{
					System.Console.WriteLine($"Vote 1 para o candidato: {candidates[0].name} ou 2 para o candidato: {candidates[1].name}");
					
					var vote = Int32.Parse(Console.ReadLine());
					candidates[vote - 1].votes++;
				}
			}

			if (candidates[0].votes == candidates[1].votes)
			{
				System.Console.WriteLine("Segundo turno!");
			}
			else
			{
				var winner = candidates[0];
                for (int i = 1; i < candidates.Length; i++)
                {
                    var currentCandidate = candidates[i];
                    if (currentCandidate.votes > winner.votes)
                    {
                        winner = currentCandidate;
                    }
                }

				System.Console.WriteLine($"O vencedor é: {winner.name}");
				System.Console.WriteLine($"Com o total de: {winner.votes} votos!");
			}
		}

        static void Exercise7()
        {
            System.Console.WriteLine("Há quantos anos você fuma? ");
            var years = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Quantos cigarros você fuma por dia? ");
            var cigarettes = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual o preço de uma carteira? ");
            var price = double.Parse(Console.ReadLine());

            System.Console.WriteLine($"Você ja gastou {(cigarettes * price / 20) * 30 * 12 * years}R$");
        }

        static void Exercise8()
        {
            var x = 0;
            var y = 0;

            System.Console.WriteLine("Digite o número x: ");
            x = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o número y: ");
            y = Int32.Parse(Console.ReadLine());

            if (x %y == 0)
            {
                System.Console.WriteLine("X é múltiplo de Y");
            }
            else
            {
                System.Console.WriteLine("X não é múltiplo de Y");
            }
        }
 
    	static void Exercise9()
		{
            var number1 = 0.0;
            var number2 = 0.0;
            var number3 = 0.0;

            System.Console.WriteLine("Digite um número: ");
            number1 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite um número: ");
            number2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite um número: ");
            number3 = double.Parse(Console.ReadLine());

            if (number1 > number2 + number3)
            {
                System.Console.WriteLine("O primeiro número é maior que a soma dos outros dois");
            }
            
            else
            {
                System.Console.WriteLine("A soma dos dois últimos números é maior que o primeiro");
            }
		}

        static void Exercise10()
        {
            var a = 0.0;
            var b = 0.0;

            System.Console.WriteLine("Digite o número a: ");
            a = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o número b: ");
            b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                System.Console.WriteLine("A > B");
            }
            else if (b > a)
            {
                System.Console.WriteLine("B > A");
            }
            else
            {
                System.Console.WriteLine("A = B");
            }
        }

		static void Exercise11()
		{
            var firstNumber = 0;
            Console.WriteLine("Forneça um número");
            var firstInput = Console.ReadLine();
            
            var secondNumber = 0;
            Console.WriteLine("Forneça um número");
            var secondInput = Console.ReadLine();
            
            try
            {
                firstNumber = Int32.Parse(firstInput);
                secondNumber = Int32.Parse(secondInput);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Um dos números está em formato inválido");
                System.Console.WriteLine("Tente novamente com outros números");
            }

            if (secondNumber != 0)
            {
                System.Console.WriteLine(firstNumber / secondNumber);
            }
            else
            {
                System.Console.WriteLine("DIVISÃO POR ZERO");
            }
		}

		static void Exercise13()
		{
            var biggestNumber = 0;

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Forneça um número");
                var input = Int32.Parse(Console.ReadLine());

                if (input > biggestNumber)
                {
                    biggestNumber = input;
                }
            }

            System.Console.WriteLine("O maior número é:");
            System.Console.WriteLine(biggestNumber);
		}

		static void Exercise14()
		{
            var smaller = 0.0;
            var middle = 0.0;
            var greater = 0.0;

            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine("Forneça um número");
                var input = Double.Parse(Console.ReadLine());

                if (input > greater)
                {
                    smaller = middle;
                    middle = greater;
                    greater = input;
                }
                else if (input > middle)
                {
                    smaller = middle;
                    middle = input;
                }
                else
                {
                    smaller = input;
                }
            }

            System.Console.WriteLine(smaller);
            System.Console.WriteLine(middle);
            System.Console.WriteLine(greater);
		}

		static void Exercise17()
		{
            while (true)
            {
                Console.WriteLine("Forneça um número");
                var input = Int32.Parse(Console.ReadLine());

                if (input == -1)
                {
                    break;
                }

                Console.WriteLine("Tabuada:");
                for (var i = 1; i < 11; i++)
                {
                    Console.WriteLine(input * i);
                }
            }
		}

		static void Exercise18()
		{
            var total = 12;
            System.Console.WriteLine("Quantas maçãs deseja comprar?");
            var quantity = Int32.Parse(Console.ReadLine());
            if (quantity < total)
            {
                var unitPrice = 1.30;
                var price = quantity * unitPrice;
                System.Console.WriteLine($"R$ {price.ToString("0.00")}");
            }
            if (quantity >= total)
            {
                var unitPrice = 1.00;
                var price = quantity * unitPrice;
                System.Console.WriteLine($"R$ {price.ToString("0.00")}");
            }
		}
	
        static void Main(string[] args)
        {
            Exercise8();
        }
    }
}