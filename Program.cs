using System;

namespace primeira_aula
	{
		class Program
			{
				static void Main(string[] args)
				{
					Console.WriteLine("Quantos anos você tem? ");
					var result = Console.ReadLine();

					var userAge = Int32.Parse(result);

					if (userAge > 15 && userAge < 51) {
						Console.WriteLine("Sim, você tem idade para o Entra21");
					}
					// else if (userAge == 14 || userAge == 15){
					// 	Console.WriteLine("Você n tem idade para o entra21, mas te idade para ser menor aprendiz");
					// }
					else{
						Console.WriteLine("Você não tem idade para o entra21 e nem para ser menor aprendiz");
					}

					Console.WriteLine("Só isso e mais nada");
				}
			}
	}	