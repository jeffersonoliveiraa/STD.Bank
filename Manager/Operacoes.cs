using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace STD.Bank.Manager
{
    public class Operacoes
    {
		public static void AlterCredt()
		{
			Console.Write("Digite o número da conta: ");
			int indiceConta = int.Parse(Console.ReadLine());

			Console.Write("Digite o valor a ser depositado: ");
			double valorAumento = double.Parse(Console.ReadLine());

			Program.listContas[indiceConta].AlmentarSaldo(valorAumento);
		}

		public static void Comprar()
		{
			Console.Write("Digite o número da conta: ");
			string NumeroConta = (Console.ReadLine());

			if (Program.listContas.Where(x => x.NumConta == NumeroConta).FirstOrDefault() == null)
			{
				Console.WriteLine("Conta inexistente");
			}
			else
			{
				Console.Write("Digite o valor da compra: ");
				double valorCompra = double.Parse(Console.ReadLine());

			Program.listContas.Where(x => x.NumConta == NumeroConta).FirstOrDefault().InserirCompra(valorCompra);
			}

		}

		public static void SaldoDevedor()
		{
			Console.Write("Digite o número da conta: ");
			string NumeroConta = (Console.ReadLine());

			var conta = Program.listContas.Where(x => x.NumConta == NumeroConta).FirstOrDefault();

			if(conta == null)
            {
				Console.WriteLine("Conta inexistente");
            }
            else
            {
                foreach (var item in conta.Extrato)
                {
					Console.WriteLine($"Saldo devedor total é de: R$ {item}");
				}
            }
		}

		public static void InserirConta()
		{
			Console.WriteLine("Inserir nova conta");

			Console.WriteLine("Escolha a instituição onde a cantina está localizada");
			Console.WriteLine("UFC = 1 | Estacio = 2 | Unichristus = 3 | UECE = 4 ");
			Console.WriteLine("Qual seria a instituição de ensino do aluno: ");
			int NomeInstituicao = int.Parse(Console.ReadLine());

			Console.Write("Digite o Nome do aluno: ");
			string entradaNome = Console.ReadLine();

			Console.Write("Digite o CPF do aluno: ");
			string entradaCPF = Console.ReadLine();

			Console.Write("Digite o crédito inicial do aluno: ");
			double entradaCredito = double.Parse(Console.ReadLine());


			Conta novaConta = new Conta(instituicao: (Instituicao)NomeInstituicao,
										credito: entradaCredito,
										nome: entradaNome,
										cpf: entradaCPF,
										(Program.listContas.Count +1).ToString());

			Program.listContas.Add(novaConta);
		}

		public static void ListarContas()
		{
			Console.WriteLine("Listar contas");

			if (Program.listContas.Count == 0)
			{
				Console.WriteLine("Nenhuma conta cadastrada.");
				return;
			}

            foreach (var item in Program.listContas)
            {
				Console.WriteLine($"Numero da conta: {item.NumConta} | Nome: {item.Nome} | CPF: {item.CPF} | Credito Disponível: R${item.Credito}");
            }

		}
			
	}
}
