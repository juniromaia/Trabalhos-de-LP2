
namespace Tarefa_da_Aula_14
{
    public abstract class Produto : IImprimivel
    {

        protected Fornecedor _fornecedor;
        protected string _nome;
        protected double _preco;

        public double Preco
        {
            get { return this._preco; }
        }

        public string Nome
        {
            get { return this._nome; }
        }

        public Fornecedor Fornecedor
        {
            get { return this._fornecedor; }
        }
        public abstract double CalculaValorTotal();
        public abstract void Imprimir();

    }
}
