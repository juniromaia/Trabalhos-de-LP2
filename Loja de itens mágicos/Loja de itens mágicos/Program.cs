using System;

namespace lojaItens_Robson
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem personagem = new Personagem();
            Loja loja = new Loja();
            personagem.Criapers();
            Console.Clear();
            loja.MostrarCat();
            personagem.Venda();
            Console.Clear();
            personagem.MostrInven();




        }
    }
}