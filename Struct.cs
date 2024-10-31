using System;

namespace projeto
{
	public struct Struct
	{
		public int IDCliente {get; set;}
		public string Nome   {get; set;}
		public string Email  {get; set;}
		public string CPF    {get; set;}
		public string CEL    {get; set;}
		
		public override string ToString()
		{
			
			Console.WriteLine();
			return string.Format("IDCliente: {0} \nNome: {1} \nCPF: {2} \nEMAIL: {3} \nCEL: {4}", IDCliente , Nome, CPF, Email, CEL);
			
		}
		

	}
	
}
