using System;

namespace primeira_aula
	{
		class Program
			{
				static void Main(string[] args)
				{
						// 1:
					// System.Console.WriteLine("Digite a letra correspondente a questão: ");
					// var opcao = Console.ReadLine();
					// if (opcao == "a"){
					// 	for (int i = 1; i <= 10; i++){ 
					// 		System.Console.WriteLine(i);
					// 	}
					// }
					// if (opcao == "b"){
					// 	for (int i = 10; i >= 1; i--){
					// 		System.Console.WriteLine(i);
					// 	}
					// }
					// if (opcao == "c"){
					// 	for (int i = 1; i < 11; i++){
					// 		if (i % 2 == 0){
					// 		System.Console.WriteLine(i);
					// 		}
					// 	}
					// }
					
					// - - - - - - - - - - - - - - - -

						// 2:

					// var conta = 0;
					// for (int i = 1; i <= 100; i++){
					// 	conta += i;
					// }
					// System.Console.WriteLine(conta);
					
					// - - - - - - - - - -
					
						// 3: 
					// for (int i = 1; i < 200; i++){
					// 	if(i % 2 == 1){
					// 		System.Console.WriteLine(i);
					// 	}
					// }

				// --------------

					// 4:

				// var counter = 0.0;
				// var idade = 0.0;

				// while(true){
				// 	System.Console.WriteLine("Digite uma idade: ");
				// 	var result = Console.ReadLine();
				// 	if (result == "0"){
				// 		break;
				// 	}
				// 	idade += double.Parse(result);
				// 	counter++;
				// }
				// System.Console.WriteLine(idade / counter);

				// - - - - - - - - - -

					// 5:
				// var idade = new int[5];
				// for(int cont = 0; cont < 5; cont++){
				// 	System.Console.WriteLine("Digite sua idade: ");
				//	var result = Console.ReadLine();
				// 	idade[cont] = Int32.Parse(result);
				// }
				// var counter = 0;
				// for (int i = 0; i < 5; i++){
				// 	if (idade[i] <= 35 && idade[i] >= 18){
				// 		counter++;
				// 	}
					
				// }
				// System.Console.WriteLine($"{counter * 20}% das mulheres estão na faixa entre 18 e 35 anos");

				// --------------------------

					// 6:
			// 	string senha;
			// 	string name1;
			// 	string name2;

			// 	Console.WriteLine("Qual modo você quer? ");
			// 	var menu = Console.ReadLine();

			// 	if (menu == "1"){
			// 	Console.WriteLine("Insira senha para você poder se cadastrar: ");
			// 	senha = Console.ReadLine();
			// 	if (senha == "Pa$$w0rd"){
			// 		Console.WriteLine("Informe seu nome: ");
			// 		name1 = Console.ReadLine();	
			// 	}
			// 	else{
			// 		Console.WriteLine("SENHA INCORRETA, próximo candidato");
			// 	}

			// 	Console.WriteLine("Insira senha para você poder se cadastrar: ");
			// 	senha = Console.ReadLine();
			// 	if (senha == "Pa$$w0rd"){
			// 		Console.WriteLine("Informe seu nome: ");
			// 		name2 = Console.ReadLine();
			// 	}
			// 	else {
			// 		Console.WriteLine("SENHA INCORRETA, PRÓXIMO MODO");
			// }
			// 	}
			// 	if (menu == "2"){
			// 		while(true){
			// 			System.Console.WriteLine("Qual candidato você quer votar? ");
			// 			var vote = Console.ReadLine();
			// 			int vote1 = 0;
			// 			int vote2 = 0;
			// 			if (vote == "1"){
            // 	vote1++;
			// 			}
			// 			else if (vote == "2"){
			// 				vote2++;
			// 			}
			// 			else{
			// 				continue;
			// 			}
			// 			if (vote1 > vote2){
			// 				System.Console.WriteLine("O candidato 1 ganhou, com o total de ",vote1, "votos");
			// 			}
			// 			else if (vote2 > vote1){
			// 				System.Console.WriteLine("O candidato 2 ganhou, com o total de ", vote2, "votos");
			// 			}
			// 			else{
			// 				System.Console.WriteLine("SEGUNDO TURNO");
			// 				if (vote == "1"){
            //     			vote1++;
			// 			}
			// 				else if (vote == "2"){
			// 					vote2++;
			// 			}
			// 				else{
			// 					continue;
			// 			}
			// 				if (vote1 > vote2){
			// 					System.Console.WriteLine("O candidato 1 ganhou, com o total de ", vote1, "votos");
			// 		}
			// 				else if (vote2 > vote1){
			// 					System.Console.WriteLine("O candidato 2 ganhou, com o total de ", vote2, "votos");
			// 				}
			// 			}
			// 	}
			// }
			
			// ----------------------------------------

			// 7:
			System.Console.WriteLine("Há quantos anos você fuma?");
			var anos = Convert.ToInt32(Console.ReadLine());
			System.Console.WriteLine("Quantos cigarros você fuma por dia?");
			var nCigarros = Convert.ToInt32(Console.ReadLine());
			System.Console.WriteLine("Qual o preço de uma carteira?");
			var preco = Convert.ToDouble(Console.ReadLine());
			var cigarro = preco / 20;
			var tempo = anos * 365;
			var result = cigarro * tempo;
			System.Console.WriteLine(result);
		}
	}
}