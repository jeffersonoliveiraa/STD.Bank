using System;
using System.Collections.Generic;
using STD.Bank.Manager;

namespace STD.Bank
{
	class Program
	{
		public static List<Conta> listContas = new List<Conta>();
		static void Main(string[] args)
		{
			string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
						Operacoes.InserirConta();
						break;
					case "2":
						Operacoes.ListarContas();
						break;
					case "3":
						Operacoes.Comprar();
						break;
					case "4":
						Operacoes.SaldoDevedor();
						break;
					case "5":
						Operacoes.AlterCredt();
						break;
                    case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}
			
			Console.WriteLine("Obrigado por utilizar nossos serviços.");
			Console.ReadLine();
		}

		
		private static string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Student Bank a seu dispor!!!");
			Console.WriteLine("Informe a opção desejada:");

			Console.WriteLine("1- Inserir novo aluno");
			Console.WriteLine("2- Listar Alunos");
			Console.WriteLine("3- Inserir compra");
			Console.WriteLine("4- Verificar saldo devedor do aluno");
			Console.WriteLine("5- Alterar credito");
            Console.WriteLine("C- Limpar Tela");
			Console.WriteLine("X- Sair");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}
	}
}
