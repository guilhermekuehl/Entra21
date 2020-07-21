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
				string senha;
				string senha2;
				
				string name1;
				string name2;
				
				Console.WriteLine("Insira senha para você poder se cadastrar: ");
				senha = Console.ReadLine();
				if (senha == "Pa$$w0rd"){
					Console.WriteLine("Informe seu nome: ");
					name1 = Console.ReadLine();	
				}
				else{
					Console.WriteLine("SENHA INCORRETA, O PROGRAMA SERÁ REINICIADO");
				}

				Console.WriteLine("Insira senha para você poder se cadastrar: ");
				senha2 = Console.ReadLine();
				if (senha2 == "Pa$$w0rd"){
					Console.WriteLine("Informe seu nome: ");
					name2 = Console.ReadLine();	
				}
				else {
					Console.WriteLine("SENHA INCORRETA, O PROGRAMA SERÁ REINICIADO");
			}
				for(int vote = 0; vote == 1; vote++){
					Console.WriteLine("Digite seu voto: ");
					var vote = Console.ReadLine();
					if (vote == 1){
						vote++;
						vote = Int32.Parse(name1);
					}
					else if (vote == 2){
						vote++;
						vote = Int32.Parse(name2);
					if(vote != 1 && 2){
						break;
					}
				}
				
				}
			if (name1 > name2){
					Console.WriteLine("Bolsonaro teve: "+ name1);
				}

				else if (name2 > name1){
					Console.WriteLine("Haddad teve: "+ name2);
				}

				else{
					Console.WriteLine("Votação segundo turno (digite seu candidato): ");
					var vote = Console.ReadLine();
					if (vote == 1){
						vote++;
						vote = Int32.Parse(name1);
				}
					else if(vote == 2){
						vote++;
						vote = Int32.Parse(name2);
					}
					if (name1 > name2){
						Console.WriteLine("Bolsonaro teve: "+ name1);
					}
					else{
						Console.WriteLine("Haddad teve: "+ name2);
					}

					}

			}
		}
	}