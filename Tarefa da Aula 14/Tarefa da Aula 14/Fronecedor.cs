using System;

namespace Tarefa_da_Aula_14
{
    public class Fornecedor : IImprimivel
    {
        private string _nome;
        private string _endereco;
        private string _cnpj;
        private string _contato;

        public string Nome
        {
            get { return this._nome; }
        }
        public string Endereco
        {
            get { return this._endereco; }
        }
        public string Cnpj
        {
            get { return this._cnpj; }
        }
        public string Contato
        {
            get { return this._contato; }
        }

        public Fornecedor(string nome, string endereco, string cnpj, string contato)
        {
            this._nome = nome;
            this._endereco = endereco;
            this._cnpj = cnpj;
            this._contato = contato;
        }

        public void Imprimir()
        {
            Console.WriteLine("Fornecedor:\t{0}", this.Nome);
            Console.WriteLine("endereco:\t{0}", this.Endereco);
            Console.WriteLine("cnpj:\t{0}", this.Cnpj);
            Console.WriteLine("contato:\t{0}", this.Contato);
        }
    }
}