using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaItens_Robson
{
    class Loja
    {
        public Dictionary<string, Item> Catalogo = Item.AcrescentarItem();

        public void MostrarCat()
        {
            Console.WriteLine("Catálogo: \t ");
            foreach (var Item in Catalogo)
            {
                Console.WriteLine("Nome do item: {0}\t", Item.Value.Nome);
                Console.WriteLine("Descrição do item: {0}\t", Item.Value.descrição);
                Console.WriteLine("Preço: {0}\t", Item.Value.preço);
                Console.WriteLine("-------------------------");
            }
        }
    }
}