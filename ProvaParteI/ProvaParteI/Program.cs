using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaParteI
{
	class Program
	{
		static void Main(string[] args)
		{

			while (true)
			{
				string key = Menu(); //Chama Menu inicial instanciando a variavel de return dentro da variavel key
				
				if (key.Equals("1")) //If fibonacci
				{
					Fibonacci();
				}
				else if (key.Equals("2")) //if Numeros primos
				{
					Primos();
				}
				else if (key.Equals("0")) //if Sair do programa
				{
					Environment.Exit(1);
				}
				else //Digitou algo que não entra nos padrões anteriores
				{
					Console.Clear();
					Console.WriteLine("   ");
					Console.WriteLine("   ");
					Console.WriteLine("Digito errado, tente novamente.");
					Console.WriteLine("   ");
					Console.WriteLine("   ");
				}

			}
		}
		public static string Menu()
		{
			string key;
			Console.WriteLine("-------Prova Calculadora---------");
			Console.WriteLine(" 1 - Fibonacci ");
			Console.WriteLine(" 2 - Números Primos ");
			Console.WriteLine(" 0 - Sair ");
			key = Console.ReadLine();
			return key; //retorna o valor digitado
		}
		public static void Continuar()
		{
			Console.WriteLine("                                 ");
			Console.WriteLine("                                 ");
			Console.WriteLine("Aperte qualquer tecla para continuar...");
			Console.ReadKey();
			Console.Clear();
		}
		public static void Fibonacci()
		{
			
			
			Console.Clear();
			Console.WriteLine(" - Fibonacci -");
			Console.WriteLine(" - Até quanto? - ");
			string strqnt = Console.ReadLine();//String da quantidade de números
			Int64 qnt = Convert.ToInt32(strqnt); //Converção da string para Int
			Int64 a = 0;
			Int64 b = 1;
			for (int i = 0; i <= qnt; i++)
			{

				Console.WriteLine(a);

				Int64 temp = a;
				a = b;
				b = temp + a;

			}
			Continuar();
		}
		public static void Primos()
		{
			string strqnt;
			int qnt;
			Console.Clear();
			Console.WriteLine(" - Números Primos -");
			Console.WriteLine(" - Até quanto? - ");
			strqnt = Console.ReadLine(); //String da quantidade de números
			qnt = Convert.ToInt32(strqnt); //Converção da string para Int
			int j = 1;
			for (int i = 0; j <= qnt; i++) //Até o J porque é a quantidade de números e não o teto maximo
			{
				int verif = i; //verif e também é o número que será printado
				if ((i % 2) != 0 || i==2) //se o resto da divisão entre i e 2 for diferente de 0 ou i for igual a 2 entra no if
				{
					
					for (int l = 2; l <= (i/2); l++ ) //Até a metade de i pois depois disso o valor fica menor que 2 de resultado
				{
						
						
						if ((i%l) == 0) //Se o resto entre i e l for igual a 0 seta o verif como 1 e sai do for
						{
							
							verif = 1;
							break;
						}
						else //senão seta o verif com o valor de i pra no final do for sair como o valor que precisa ser printado
						{

							verif = i;
							continue;
						}
					}
				if(verif != 1) //se o verif for diferente do 1 setado no if de erro lá em cima, printa o valor de verif e aumenta o j
					{
						
						Console.WriteLine(verif);
						j++;
					}
				}
				else
				{
					continue;
				}

				

			}
			Continuar();
		}
		

		}
	}

