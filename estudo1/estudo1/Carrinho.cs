using System;
using System.Collections.Generic;

namespace estudo1
{
    public class Carrinho
    {
        private Dictionary<Licensa, int> _itens;
        public Dictionary<Licensa, int> Itens
        {
            get
            {
                return this._itens;
            }
        }
        public double Total()
        {
            double somatório = 0;
            foreach (KeyValuePair<Licensa, int> parOrdenado in this._itens)
            {
                somatório += parOrdenado.Key.CalcularValor() * parOrdenado.Value;
            }
            return somatório;
        }
        public void Carinho()
        {
            this._itens = new Dictionary<Licensa, int>();
        }
        public void Adicionar(Licensa item, int quantidade)
        {
            if (this._itens.ContainsKey(item))
                this._itens[item] = this._itens[item] +
               quantidade;
            else
                this._itens[item] = quantidade;
        }
        public void Adicionar(Licensa item)
        {
            this.Adicionar(item, 1);
        }
        public void Adicionar(List<Licensa> itens)
        {
            foreach (var item in itens)
            {
                this.Adicionar(item);
            }
        }
        public void Adicionar(Dictionary<Licensa, int>itens)
        {
            foreach (KeyValuePair<Licensa, int> parOrdenado
           in itens)
            {
                this.Adicionar(parOrdenado.Key,
               parOrdenado.Value);
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("======== CARRINHO========");
            foreach (KeyValuePair<Licensa, int> parOrdenado in this._itens)
            {
                Console.WriteLine("Software:\t{0}", parOrdenado.Key.Nome);
                Console.WriteLine("Valor:\t\tR$ {0:0.00}", parOrdenado.Key.CalcularValor());
                Console.WriteLine("Quantidade:\t{0}", parOrdenado.Value);
                Console.WriteLine("Subtotal:\tR$ {0:0.00}", parOrdenado.Value * parOrdenado.Key.CalcularValor());
                Console.WriteLine("==========================");

            }
            Console.WriteLine("Total do carrinho:\tR${ 0:0.00}"); this.Total();
            Console.WriteLine("==========================");
        }

    }
}
