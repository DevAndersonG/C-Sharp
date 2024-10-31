using System;
using System.Threading;

namespace projeto
{
	public class Class
	{
		public quantidadePaciente qtd = new quantidadePaciente();
		public Struct[] vStruct;
		public Struct cliente;
		Random rnd = new Random();
		
		public void telaLogin()
		{
			
			string usuario, senha;
			
			
			do{
				
				
				
				Console.WriteLine("                                             |********************************************|");
				Console.WriteLine("                                             |                                            |");
				Console.WriteLine("                                             |         BEM VINDO AO NOSSO SISTEMA!        |");
				Console.WriteLine("                                             |                                            |");
				Console.WriteLine("                                             |********************************************|");
				Console.WriteLine();
				Console.WriteLine();
				Console.Write("                                                   Usuário: ");
				usuario = Console.ReadLine().ToUpper();
				Console.Write("                                                   Senha  : ");
				senha = Console.ReadLine();
				
				Console.WriteLine();
				Console.WriteLine();
				if(usuario == "USER2000" && senha == "123456"){
					Console.WriteLine("\n\n\n\n\n                                                 LOGIN FEITO COM SUCESSO");
					Console.WriteLine("\n\n                                                        AGUARDE...");
					
					Thread.Sleep(1500);
					Console.Clear();
					break;
				}
				
				Console.WriteLine("                                                USUÁRIO OU SENHA INCORRETOS...");
				Console.WriteLine("                                                       TENTE NOVAMENTE!");
				Console.ReadKey(true);
				Console.Clear();
				
			}while(usuario != "user2000" || senha != "123456");
		}
		public void menuPrincipal()
		{
			Console.WriteLine("                                             |********************************************|");
			Console.WriteLine("                                             |                                            |");
			Console.WriteLine("                                             |                 MENU PRINCIPAL             |");
			Console.WriteLine("                                             |                                            |");
			Console.WriteLine("                                             |********************************************|");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("PRESSIONE A TECLA CORRESPONDENTE A OPÇÃO QUE DESEJAR:\n\n");
			Console.WriteLine();
			Console.WriteLine(" ____________________________________ ");
			Console.WriteLine("|                                    |");
			Console.WriteLine("| 1. CADASTRO CLIENTE                |");
			Console.WriteLine("|------------------------------------|");
			Console.WriteLine("| 2. CONSULTA CLIENTES               |");
			Console.WriteLine("|------------------------------------|");
			Console.WriteLine("| 3. ORÇAMENTO                       |");
			Console.WriteLine("|------------------------------------|");
			Console.WriteLine("| 4. ENCERRAR O PROGRAMA             |");
			Console.WriteLine("|____________________________________|");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine();
		}
		public void cadastroCliente()
		{
			Console.WriteLine("                                             |********************************************|");
			Console.WriteLine("                                             |                                            |");
			Console.WriteLine("                                             |               CADASTRO CLIENTES            |");
			Console.WriteLine("                                             |                                            |");
			Console.WriteLine("                                             |********************************************|");
			Console.WriteLine();
			Console.WriteLine();
			
			Console.Write("INFORME QUANTOS CLIENTES SERÃO CADASTRADOS: ");
			qtd.quantPaciente = int.Parse(Console.ReadLine());
			vStruct = new Struct[qtd.quantPaciente];
			Console.Clear();
			
			
			
			if(qtd.quantPaciente <= 0)
			{
				Console.WriteLine("INFORME UMA QUANTIDADE MAIOR DO QUE ZERO!");
				Thread.Sleep(1500);
				Console.Clear();
			}
			
			for(int i=0; i<qtd.quantPaciente; i++)
			{
				Console.WriteLine("                                             |********************************************|");
				Console.WriteLine("                                             |                                            |");
				Console.WriteLine("                                             |               CADASTRO CLIENTES            |");
				Console.WriteLine("                                             |                                            |");
				Console.WriteLine("                                             |********************************************|");
				Console.WriteLine();
				Console.WriteLine();
				
				vStruct[i] = new Struct();
				Console.Write("ID   : ");
				vStruct[i].IDCliente = rnd.Next(1, 500);
				Console.WriteLine(vStruct[i].IDCliente);
				Console.Write("NOME : ");
				vStruct[i].Nome = Console.ReadLine().ToUpper();
				if(vStruct[i].Nome == "" || vStruct[i].Nome == String.Empty)
				{
					Console.WriteLine("NENHUM NOME DIGITADO, TENTE NOVAMENTE!");
					Thread.Sleep(1700);
					Console.Clear();
					i--;
					continue;
				}
				Console.Write("CPF  : ");
				vStruct[i].CPF = Console.ReadLine();
				if(!validadorCPF(vStruct[i].CPF))
				{
					Console.WriteLine("CPF INVÁLIDO, TENTE NOVAMENTE!");
					Thread.Sleep(1700);
					Console.Clear();
					i--;
					continue;
				}
				Console.Write("CEL  : ");
				vStruct[i].CEL = Console.ReadLine();
				if(vStruct[i].CEL == "")
				{
					Console.WriteLine("NENHUM NÚMERO DIGITADO, TENTE NOVAMENTE!");
					Thread.Sleep(1700);
					Console.Clear();
					i--;
					continue;
				}
				Console.Write("EMAIL: ");
				vStruct[i].Email = Console.ReadLine().ToUpper();
				if(vStruct[i].Email == "")
				{
					Console.WriteLine("NENHUM EMAIL DIGITADO, TENTEN NOVAMENTE!");
					Thread.Sleep(1700);
					Console.Clear();
					i--;
					continue;
				}
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine("CADASTRO(S) FEITO COM SUCESSO... PRESSIONE ENTER PARA CONTINUAR!");
				Console.ReadKey(true);
				Console.Clear();
				continue;
			}
		}
		public void consultaCadastro()
		{
			while(qtd.quantPaciente != 0)
			{
				if(qtd.quantPaciente == 0)
				{
					Console.WriteLine("CADASTRE PACIENTES ANTES DE FAZER A CONSULTA!");
					Console.WriteLine("PRESSIONE QUALQUER TECLA PARA CONTINUAR ...");
					Console.ReadKey(true);
					Console.Clear();
					break;
				}
				Console.WriteLine("                                             |********************************************|");
				Console.WriteLine("                                             |                                            |");
				Console.WriteLine("                                             |              CONSULTOR CADASTROS           |");
				Console.WriteLine("                                             |                                            |");
				Console.WriteLine("                                             |********************************************|");
				Console.WriteLine("                                                ");
				for(int i=0; i<qtd.quantPaciente; i++)
				{
					Console.WriteLine(vStruct[i]);
				}
				Console.WriteLine();
				Console.WriteLine();
				Console.WriteLine("PRESSIONE QUALQUER TECLA PARA CONTINUAR");
				Console.ReadKey(true);
				Console.Clear();
				break;
			}
		}
		
		public void orcamento()
		{
			Console.WriteLine("                                             |********************************************|");
			Console.WriteLine("                                             |                                            |");
			Console.WriteLine("                                             |           ORÇAMENTO DE PACOTES \n\n        |");
			Console.WriteLine("                                             |                                            |");
			Console.WriteLine("                                             |********************************************|");
			Console.WriteLine();
			Console.Write("INFORME O ID DO CLIENTE PARA CONTINUAR: ");
			int idPaciente = int.Parse(Console.ReadLine());
			cliente = Array.Find(vStruct, p => p.IDCliente == idPaciente);
			if(cliente.IDCliente != 0)
			{
				Console.WriteLine("INFORME SE JÁ UTILIZOU UM DE NOSSOS SERVIÇOS: ");
				string resposta = Console.ReadLine().ToUpper();
				if(resposta == "SIM" || resposta == "S")
				{
					Console.WriteLine("COMO JÁ UTILIZOU NOSSOS SERVIÇOS RECEBE X% DE DESCONTO!!");
					Console.WriteLine("PRESSIONE ENTER PARA CONTINUAR O ORÇAMENTO ... ");
					Console.ReadKey(true);
					
				}
				if(resposta == "NAO" || resposta == "N")
				{
					Console.WriteLine("DESEJA CONTRATAR ALGUM DOS NOSSOS SERVIÇOS? <SIM/NAO>");
					string resposta2 = Console.ReadLine().ToUpper();
					if(resposta2 == "SIM" || resposta2 == "S")
					{
						
					}
				}
			}
		}
		
		public static bool validadorCPF(string cpf)//Responsável pela verificação do CPF, de acordo com o cálculo nacional
		{
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int i;

			cpf = cpf.Trim().Replace(".", "").Replace("-", "");//Retira pontos, traços e espaços do cpf digitado
			if (cpf.Length != 11)
				return false;

			for (int j = 0; j < 10; j++)
				if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)//Verifica se dos 11 digitos todos foram iguais ou não
					return false;

			string tempCpf = cpf.Substring(0, 9);//Separa os 9 primeiros digitos do CPF para realizar o cálculo dos digitos verificadores
			int soma = 0;

			for (i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

			int resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;

			string digito = resto.ToString();
			tempCpf = tempCpf + digito;
			soma = 0;
			for (i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;

			digito = digito + resto.ToString();
			return cpf.EndsWith(digito);
			
		}
	}
}
public class quantidadePaciente
{
	public int quantPaciente {get; set;}
}
