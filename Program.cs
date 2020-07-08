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
					}else{
						Console.WriteLine("Não, você não tem idade para o Entra21");
						}
				}
			}
	}