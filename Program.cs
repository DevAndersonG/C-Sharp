using System;
using System.Threading;

namespace projeto
{
	class Program
	{
		public static void Main(string[] args)
		{
			Class CL = new Class();
			
			CL.telaLogin();
			ConsoleKeyInfo keyinfoPR;
			do{
				Console.Clear();
				CL.menuPrincipal();
				keyinfoPR = Console.ReadKey(true);
				switch(keyinfoPR.Key)
				{
					case ConsoleKey.D1:
					case ConsoleKey.NumPad1:
						Console.Clear();
						CL.cadastroCliente();
						Console.Clear();
						break;
						
					case ConsoleKey.D2:
					case ConsoleKey.NumPad2:
						Console.Clear();
						CL.consultaCadastro();
						Console.Clear();
						break;
				}
				
			}while(keyinfoPR.Key != ConsoleKey.NumPad9);
		}
		
	}
}