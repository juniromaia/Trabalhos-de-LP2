using System;

namespace estudo1
{
    public class Licensa
    {
        protected double _preço;
        protected string _nome;
        protected string _chavedeativação;

        public string Nome
        {
            get
            {
                return this._nome;
            }            
        }
        public double Preço
        {
            get
            {
                return this._preço;
            }
        }
        public string ChavedeAtivação
        {
            get
            {
                return this._chavedeativação;
            }
        }
        public Licensa(double preço, string chavedeativação, string nome)
        {
            this._preço = preço;
            this._chavedeativação = chavedeativação;
            this._nome = nome;
        }
        public virtual double CalcularValor()
        {
            return _preço;
        }
    }

}