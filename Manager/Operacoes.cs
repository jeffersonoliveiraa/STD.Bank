using System;
using System.Collections.Generic;
using System.Text;


namespace STD.Bank.Manager
{
    class Operacoes
    {
		static List<Conta> listContas = new List<Conta>();
		public static void Depositar()
		{
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser depositado: ");
			double valorDeposito = double.Parse(Console.ReadLine());

			listContas[indiceConta].Depositar(valorDeposito);
		}

		public static void Sacar()
		{
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser sacado: ");
			double valorSaque = double.Parse(Console.ReadLine());

			listContas[indiceConta].Sacar(valorSaque);
		}

		public static void Transferir()
		{
			Console.Write("Digite o número da conta de origem: ");
			int indiceContaOrigem = int.Parse(Console.ReadLine());

			Console.Write("Digite o número da conta de destino: ");
			int indiceContaDestino = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser transferido: ");
			double valorTransferencia = double.Parse(Console.ReadLine());

			listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
		}

		public static void InserirConta()
		{
			Console.WriteLine("Inserir nova conta");

			Console.WriteLine("Qual seria sua instituição de ensino: ");
			Console.WriteLine("Escolha entre nossas instituições parceiras!!");
			Console.WriteLine("UFC = 1 | Estacio = 2 | Unichristus = 3 | UECE = 4 ");
			int NomeInstituicao = int.Parse(Console.ReadLine());

			Console.Write("Digite o Nome do Cliente: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite o saldo inicial: ");
			double entradaSaldo = double.Parse(Console.ReadLine());

			Console.Write("Digite o crédito: ");
			double entradaCredito = double.Parse(Console.ReadLine());

			Console.Write("Digite o CPF do cliente: ");
			string entradaCPF = Console.ReadLine();

			Conta novaConta = new Conta(instituicao: (Instituicao)NomeInstituicao,
										saldo: entradaSaldo,
										credito: entradaCredito,
										nome: entradaNome,
										cpf: entradaCPF);

			listContas.Add(novaConta);
		}

		public static void ListarContas()
		{
			Console.WriteLine("Listar contas");

			if (listContas.Count == 0)
			{
				Console.WriteLine("Nenhuma conta cadastrada.");
				return;
			}

			for (int i = 0; i < listContas.Count; i++)
			{
				Conta conta = listContas[i];
				Console.Write("#{0} - ", i);
				Console.WriteLine(conta);
			}
		}
			
	}
}
