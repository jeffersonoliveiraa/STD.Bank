using System;

namespace STD.Bank
{
	public class Conta
	{
		// Atributos
		private Instituicao Instituicao { get; set; }
		private double Saldo { get; set; }
		private double Credito { get; set; }
		private string Nome { get; set; }
		private string CPF { get; set; }

		// Métodos
		public Conta(Instituicao instituicao, double saldo, double credito, string nome, string cpf)
		{
			this.Instituicao = instituicao;
			this.Saldo = saldo;
			this.Credito = credito;
			this.Nome = nome;
			this.CPF = cpf;
		}

		public bool Sacar(double valorSaque)
		{
            // Validação de saldo suficiente
            if (this.Saldo - valorSaque < (this.Credito *-1)){
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            this.Saldo -= valorSaque;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            // https://docs.microsoft.com/pt-br/dotnet/standard/base-types/composite-formatting

            return true;
		}

		public void Depositar(double valorDeposito)
		{
			this.Saldo += valorDeposito;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
		}

		public void Transferir(double valorTransferencia, Conta contaDestino)
		{
			if (this.Sacar(valorTransferencia)){
                contaDestino.Depositar(valorTransferencia);
            }
		}

        public override string ToString()
		{
            string retorno = "";
            retorno += "Instituição " + this.Instituicao + " | ";
            retorno += "Nome " + this.Nome + " | ";
			retorno += "CPF" + this.CPF + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Crédito " + this.Credito;
			return retorno;
		}
	}
}