using System;

namespace estudo1
{
	public class Assinatura: Licensa
	{
        protected double _duração;
        
        public double Duração
        {
            get
            {
                return this._duração;
            }
        }
        public Assinatura(string nome, double mensalidade,double duração, string chavedeativação): base(mensalidade,chavedeativação,nome)
        {
            this._duração = duração;
        }
        public override double CalcularValor()
        {
            return this._preço * this._duração;
        }
    }
}
