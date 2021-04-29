using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaItens_Robson
{
    class Item
    {
        public string Nome;
        public double preço;
        public int QntEstoque;
        public string categoria;
        public string descrição;
        public int QntInv;


        public Item(string Nome, double preço, string tipo, int QntEstoque, string descrição)
        {
            this.Nome = Nome;
            this.preço = preço;
            this.QntEstoque = QntEstoque;
            this.descrição = descrição;
        }
        public static Dictionary<string, Item> AcrescentarItem()
        {
            Dictionary<string, Item> itens = new Dictionary<string, Item>();
            Item E1 = new Item("Surtur Sword", 400, "Fogo", 10, "É a espada que um titã nórdico que gerará o Ragnarok");
            itens.Add(E1.Nome, E1);
            Item E2 = new Item("Gelu Glatio", 350, "Gelo", 35, "O reino africano do Mali foi subjulgado por essa espada sublime");
            itens.Add(E2.Nome, E2);
            Item E3 = new Item("Axium Blaze", 400, "Fogo", 54, "Trata - se do machado roubado por Constantine de Mefisto");
            itens.Add(E3.Nome, E3);
            Item E4 = new Item("Isete Oks", 310, "Gelo", 8, "É o grande machado empunhado por Laufey, rei dos gigantes de gelo, na luta contra Odin");
            itens.Add(E4.Nome, E4);
            Item E5 = new Item("Arcum Flame", 410, "Fogo", 23, "Foi a última arma construída no núcleo de Nidavelir");
            itens.Add(E5.Nome, E5);
            Item E6 = new Item("Yeti's bow", 300, "Gelo", 34, "Foi feita a partir do sangue do último Yeti detectado ");
            itens.Add(E6.Nome, E6);
            Item E7 = new Item("Clypeus inflamado", 400, "Fogo", 21, "É escudo empunhado por Apolo em todas as suas raras guerras");
            itens.Add(E7.Nome, E7);
            Item E8 = new Item("Claudio", 300, "Gelo", 7, "É a arma que gerou todo o povo russo e a parte glacial do mundo");
            itens.Add(E8.Nome, E8);

            return (itens);
        }
    }
}
