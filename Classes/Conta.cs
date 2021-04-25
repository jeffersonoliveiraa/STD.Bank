using System;
using System.Collections.Generic;

namespace STD.Bank
{
	public class Conta
	{
		// Atributos
		public Instituicao Instituicao { get; set; }
		public double Credito { get; set; }
		public string Nome { get; set; }
		public string CPF { get; set; }
		public string NumConta { get; set; }
		public List<double> Extrato { get; set; }

		// Métodos
		public Conta(Instituicao instituicao, double credito, string nome, string cpf, string numConta)
		{
			this.Instituicao = instituicao;
			this.Credito = credito;
			this.Nome = nome;
			this.CPF = cpf;
			this.NumConta = numConta;
			this.Extrato = new List<double> ();
			Console.WriteLine($"Conta criada com o numero: {numConta}");
		}

		public bool InserirCompra(double valorCompra)
		{
            // Validação de saldo suficiente
            if (this.Credito - valorCompra < (this.Credito *-1)){
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            this.Credito -= valorCompra;
			this.Extrato.Add(valorCompra);

            Console.WriteLine("Credito atual do aluno {0} é {1}", this.Nome, this.Credito);
            // https://docs.microsoft.com/pt-br/dotnet/standard/base-types/composite-formatting

            return true;
		}

		public void AlmentarSaldo(double almentoLimite)
		{
			this.Credito += almentoLimite;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Credito);
		}

		//public Debito()

		public override string ToString()
		{
            string retorno = "";
            retorno += "Instituição " + this.Instituicao + " | ";
            retorno += "Nome " + this.Nome + " | ";
			retorno += "CPF" + this.CPF + " | ";
            retorno += "Crédito " + this.Credito + " | ";
			//retorno += "Saldo devedor" this.;
			return retorno;
		}
	}
}