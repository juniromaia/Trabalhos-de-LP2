using System.Diagnostics.Tracing;
using System;

namespace Tarefa_da_Aula_14
{
    public class Assinatura : Licensa
    {
        private int _duracao;

        public double Duracao
        {
            get { return this._duracao; }
        }

        public Assinatura(string nome, double mensalidade, int duracao, string chaveAtivacao, Fornecedor fornecedor) : base(nome, mensalidade, chaveAtivacao, fornecedor)
        {
            this._duracao = duracao;
        }

        public override double CalculaValorTotal()
        {
            return this._preco * this._duracao;
        }

        public override void Imprimir()
        {
            Console.WriteLine("Software:\t{0}", this.Nome);
            Console.WriteLine("Mensalidade:\tR$ {0:0.00}", this._preco);
            Console.WriteLine("Duração:\t{0}", this._duracao);
            Console.WriteLine("Valor:\t\tR$ {0:0.00}", this.CalculaValorTotal());
        }
    }
}