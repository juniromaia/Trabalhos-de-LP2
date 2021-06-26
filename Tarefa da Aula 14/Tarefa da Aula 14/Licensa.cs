using System;

namespace Tarefa_da_Aula_14
{
    public class Licensa : Produto
    {

        protected string _chaveAtivacao;

        public string ChaveAtivacao
        {
            get { return this._chaveAtivacao; }
        }

        public Licensa(string nome, double preco, string chaveAtivacao, Fornecedor fornecedor)
        {
            this._nome = nome;
            this._preco = preco;
            this._chaveAtivacao = chaveAtivacao;
            this._fornecedor = fornecedor;
        }

        public override double CalculaValorTotal()
        {
            return this._preco;
        }

        public override void Imprimir()
        {
            Console.WriteLine("Software:\t{0}", this.Nome);
            Console.WriteLine("Valor:\t\tR$ {0:0.00}", this.CalculaValorTotal());
        }
    }
}