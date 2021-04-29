using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaItens_Robson
{
    class Personagem
    {
        //nome, a quantidade de dinheiro e um inventário//
        public string Nome;
        public double rúpias;
        public Dictionary<string, Item> Inventario = new Dictionary<string, Item>();
        public Dictionary<string, Item> Catalogo = Item.AcrescentarItem();


        public void Criapers()
        {
            Console.WriteLine("Bem-Vindo a Loja de armas mágicas");
            Console.WriteLine("Qual é o seu nome, viajante?");
            Nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Qual é a sua quantia, viajante?");
            rúpias = Convert.ToDouble(Console.ReadLine());


        }


        public void Venda()
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






            int quero = 1;

            do
            {

                string resposta2;

                Console.WriteLine("Qual item você deseja comprar ?");
                Console.WriteLine("Caso queira comprar, escreva o nome do item e, se não quiser escreva 'nada'");
                resposta2 = Convert.ToString(Console.ReadLine());

                if (resposta2 == E1.Nome)
                {
                    int resposta3 = 0;
                    Console.WriteLine("Tem certeza que deseja comprar esse item:{0}  (1)Sim (2)Não", resposta2);
                    resposta3 = Convert.ToInt32(Console.ReadLine());
                    if (resposta3 == 1)
                    {
                        int quant1 = 0;
                        Console.WriteLine("Quantos itens você deseja?");
                        quant1 = Convert.ToInt32(Console.ReadLine());
                        if (quant1 <= E1.QntEstoque)
                        {
                            double multi = quant1 * E1.preço;

                            if (rúpias >= multi)
                            {
                                int resposta4 = 0;
                                Console.WriteLine("Você tem certeza ? (1)Sim (2)Não");
                                resposta4 = Convert.ToInt32(Console.ReadLine());
                                if (resposta4 == 1)
                                {
                                    rúpias = rúpias - multi;
                                    E1.QntEstoque = E1.QntEstoque - quant1;

                                    Console.WriteLine("Você obteve {0} de {1}", quant1, E1.Nome);

                                    if (Inventario.ContainsKey(E1.Nome))
                                    {
                                        foreach (KeyValuePair<string, Item> quantia in Inventario)
                                        {
                                            if (quantia.Value.Nome == E1.Nome)
                                            {
                                                quantia.Value.QntInv = quantia.Value.QntInv + quant1;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        E1.QntInv = quant1;
                                        Inventario.Add(E1.Nome, E1);

                                    }


                                }
                            }
                            else
                            {
                                Console.WriteLine("Dinheiro insuficiente");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Não tenho tudo isso no estoque");
                        }

                    }

                }
                if (resposta2 == E2.Nome)
                {
                    int resposta3 = 0;
                    Console.WriteLine("Tem certeza que deseja comprar esse item:{0}  (1)Sim (2)Não", resposta2);
                    resposta3 = Convert.ToInt32(Console.ReadLine());
                    if (resposta3 == 1)
                    {
                        int quant1 = 0;
                        Console.WriteLine("Quantos itens você deseja?");
                        quant1 = Convert.ToInt32(Console.ReadLine());
                        if (quant1 <= E2.QntEstoque)
                        {
                            double multi = quant1 * E2.preço;

                            if (rúpias >= multi)
                            {
                                int resposta4 = 0;
                                Console.WriteLine("Você tem certeza ? (1)Sim (2)Não");
                                resposta4 = Convert.ToInt32(Console.ReadLine());
                                if (resposta4 == 1)
                                {
                                    rúpias = rúpias - multi;
                                    E2.QntEstoque = E2.QntEstoque - quant1;
                                    Console.WriteLine("Você obteve {0} de {1}", quant1, E2.Nome);
                                    if (Inventario.ContainsKey(E2.Nome))
                                    {
                                        foreach (KeyValuePair<string, Item> quantia in Inventario)
                                        {
                                            if (quantia.Value.Nome == E2.Nome)
                                            {
                                                quantia.Value.QntInv = quantia.Value.QntInv + quant1;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        E2.QntInv = quant1;
                                        Inventario.Add(E2.Nome, E2);

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Dinheiro insuficiente");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Não tenho tudo isso no estoque");
                        }

                    }

                }
                if (resposta2 == E3.Nome)
                {
                    int resposta3 = 0;
                    Console.WriteLine("Tem certeza que deseja comprar esse item:{0}  (1)Sim (2)Não", resposta2);
                    resposta3 = Convert.ToInt32(Console.ReadLine());
                    if (resposta3 == 1)
                    {
                        int quant1 = 0;
                        Console.WriteLine("Quantos itens você deseja?");
                        quant1 = Convert.ToInt32(Console.ReadLine());
                        if (quant1 <= E3.QntEstoque)
                        {
                            double multi = quant1 * E3.preço;

                            if (rúpias >= multi)
                            {
                                int resposta4 = 0;
                                Console.WriteLine("Você tem certeza ? (1)Sim (2)Não");
                                resposta4 = Convert.ToInt32(Console.ReadLine());
                                if (resposta4 == 1)
                                {
                                    rúpias = rúpias - multi;
                                    E3.QntEstoque = E3.QntEstoque - quant1;
                                    Console.WriteLine("Você obteve {0} de {1}", quant1, E3.Nome);
                                    if (Inventario.ContainsKey(E3.Nome))
                                    {
                                        foreach (KeyValuePair<string, Item> quantia in Inventario)
                                        {
                                            if (quantia.Value.Nome == E3.Nome)
                                            {
                                                quantia.Value.QntInv = quantia.Value.QntInv + quant1;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        E3.QntInv = quant1;
                                        Inventario.Add(E3.Nome, E3);

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Dinheiro insuficiente");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Não tenho tudo isso no estoque");
                        }

                    }

                }
                if (resposta2 == E4.Nome)
                {
                    int resposta3 = 0;
                    Console.WriteLine("Tem certeza que deseja comprar esse item:{0}  (1)Sim (2)Não", resposta2);
                    resposta3 = Convert.ToInt32(Console.ReadLine());
                    if (resposta3 == 1)
                    {
                        int quant1 = 0;
                        Console.WriteLine("Quantos itens você deseja?");
                        quant1 = Convert.ToInt32(Console.ReadLine());
                        if (quant1 <= E4.QntEstoque)
                        {
                            double multi = quant1 * E4.preço;

                            if (rúpias >= multi)
                            {
                                int resposta4 = 0;
                                Console.WriteLine("Você tem certeza ? (1)Sim (2)Não");
                                resposta4 = Convert.ToInt32(Console.ReadLine());
                                if (resposta4 == 1)
                                {
                                    rúpias = rúpias - multi;
                                    E4.QntEstoque = E4.QntEstoque - quant1;
                                    Console.WriteLine("Você obteve {0} de {1}", quant1, E4.Nome);
                                    if (Inventario.ContainsKey(E4.Nome))
                                    {
                                        foreach (KeyValuePair<string, Item> quantia in Inventario)
                                        {
                                            if (quantia.Value.Nome == E4.Nome)
                                            {
                                                quantia.Value.QntInv = quantia.Value.QntInv + quant1;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        E4.QntInv = quant1;
                                        Inventario.Add(E4.Nome, E4);

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Dinheiro insuficiente");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Não tenho tudo isso no estoque");
                        }

                    }

                }
                if (resposta2 == E5.Nome)
                {
                    int resposta3 = 0;
                    Console.WriteLine("Tem certeza que deseja comprar esse item:{0}  (1)Sim (2)Não", resposta2);
                    resposta3 = Convert.ToInt32(Console.ReadLine());
                    if (resposta3 == 1)
                    {
                        int quant1 = 0;
                        Console.WriteLine("Quantos itens você deseja?");
                        quant1 = Convert.ToInt32(Console.ReadLine());
                        if (quant1 <= E5.QntEstoque)
                        {
                            double multi = quant1 * E5.preço;

                            if (rúpias >= multi)
                            {
                                int resposta4 = 0;
                                Console.WriteLine("Você tem certeza ? (1)Sim (2)Não");
                                resposta4 = Convert.ToInt32(Console.ReadLine());
                                if (resposta4 == 1)
                                {
                                    rúpias = rúpias - multi;
                                    E5.QntEstoque = E5.QntEstoque - quant1;
                                    Console.WriteLine("Você obteve {0} de {1}", quant1, E5.Nome);
                                    if (Inventario.ContainsKey(E5.Nome))
                                    {
                                        foreach (KeyValuePair<string, Item> quantia in Inventario)
                                        {
                                            if (quantia.Value.Nome == E5.Nome)
                                            {
                                                quantia.Value.QntInv = quantia.Value.QntInv + quant1;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        E5.QntInv = quant1;
                                        Inventario.Add(E5.Nome, E5);

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Dinheiro insuficiente");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Não tenho tudo isso no estoque");
                        }

                    }

                }
                if (resposta2 == E6.Nome)
                {
                    int resposta3 = 0;
                    Console.WriteLine("Tem certeza que deseja comprar esse item:{0}  (1)Sim (2)Não", resposta2);
                    resposta3 = Convert.ToInt32(Console.ReadLine());
                    if (resposta3 == 1)
                    {
                        int quant1 = 0;
                        Console.WriteLine("Quantos itens você deseja?");
                        quant1 = Convert.ToInt32(Console.ReadLine());
                        if (quant1 <= E6.QntEstoque)
                        {
                            double multi = quant1 * E6.preço;

                            if (rúpias >= multi)
                            {
                                int resposta4 = 0;
                                Console.WriteLine("Você tem certeza ? (1)Sim (2)Não");
                                resposta4 = Convert.ToInt32(Console.ReadLine());
                                if (resposta4 == 1)
                                {
                                    rúpias = rúpias - multi;
                                    E6.QntEstoque = E6.QntEstoque - quant1;
                                    Console.WriteLine("Você obteve {0} de {1}", quant1, E6.Nome);
                                    if (Inventario.ContainsKey(E6.Nome))
                                    {
                                        foreach (KeyValuePair<string, Item> quantia in Inventario)
                                        {
                                            if (quantia.Value.Nome == E6.Nome)
                                            {
                                                quantia.Value.QntInv = quantia.Value.QntInv + quant1;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        E6.QntInv = quant1;
                                        Inventario.Add(E6.Nome, E6);

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Dinheiro insuficiente");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Não tenho tudo isso no estoque");
                        }

                    }

                }
                if (resposta2 == E7.Nome)
                {
                    int resposta3 = 0;
                    Console.WriteLine("Tem certeza que deseja comprar esse item:{0}  (1)Sim (2)Não", resposta2);
                    resposta3 = Convert.ToInt32(Console.ReadLine());
                    if (resposta3 == 1)
                    {
                        int quant1 = 0;
                        Console.WriteLine("Quantos itens você deseja?");
                        quant1 = Convert.ToInt32(Console.ReadLine());
                        if (quant1 <= E7.QntEstoque)
                        {
                            double multi = quant1 * E7.preço;

                            if (rúpias >= multi)
                            {
                                int resposta4 = 0;
                                Console.WriteLine("Você tem certeza ? (1)Sim (2)Não");
                                resposta4 = Convert.ToInt32(Console.ReadLine());
                                if (resposta4 == 1)
                                {
                                    rúpias = rúpias - multi;
                                    E7.QntEstoque = E7.QntEstoque - quant1;
                                    Console.WriteLine("Você obteve {0} de {1}", quant1, E7.Nome);
                                    if (Inventario.ContainsKey(E7.Nome))
                                    {
                                        foreach (KeyValuePair<string, Item> quantia in Inventario)
                                        {
                                            if (quantia.Value.Nome == E7.Nome)
                                            {
                                                quantia.Value.QntInv = quantia.Value.QntInv + quant1;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        E7.QntInv = quant1;
                                        Inventario.Add(E7.Nome, E7);

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Dinheiro insuficiente");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Não tenho tudo isso no estoque");
                        }

                    }

                }
                if (resposta2 == E8.Nome)
                {
                    int resposta3 = 0;
                    Console.WriteLine("Tem certeza que deseja comprar esse item:{0}  (1)Sim (2)Não", resposta2);
                    resposta3 = Convert.ToInt32(Console.ReadLine());
                    if (resposta3 == 1)
                    {
                        int quant1 = 0;
                        Console.WriteLine("Quantos itens você deseja?");
                        quant1 = Convert.ToInt32(Console.ReadLine());
                        if (quant1 <= E8.QntEstoque)
                        {
                            double multi = quant1 * E8.preço;

                            if (rúpias >= multi)
                            {
                                int resposta4 = 0;
                                Console.WriteLine("Você tem certeza ? (1)Sim (2)Não");
                                resposta4 = Convert.ToInt32(Console.ReadLine());
                                if (resposta4 == 1)
                                {
                                    rúpias = rúpias - multi;
                                    E8.QntEstoque = E8.QntEstoque - quant1;
                                    Console.WriteLine("Você obteve {0} de {1}", quant1, E8.Nome);
                                    if (Inventario.ContainsKey(E8.Nome))
                                    {
                                        foreach (KeyValuePair<string, Item> quantia in Inventario)
                                        {
                                            if (quantia.Value.Nome == E8.Nome)
                                            {
                                                quantia.Value.QntInv = quantia.Value.QntInv + quant1;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        E8.QntInv = quant1;
                                        Inventario.Add(E8.Nome, E8);

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Dinheiro insuficiente");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Não tenho tudo isso no estoque");
                        }

                    }

                }
                Console.WriteLine("Quer continuar comprando Itens? (1) Sim (outro) Não");
                quero = Convert.ToInt32(Console.ReadLine());
            } while (quero == 1);
        }
        public void MostrInven()
        {
            Console.WriteLine("Seu inventário é: ");
            foreach (KeyValuePair<string, Item> Item in Inventario)
            {
                Console.WriteLine("Item: " + Item.Value.Nome);
                Console.WriteLine("Descrição: " + Item.Value.descrição);
                Console.WriteLine("Quantia: " + Item.Value.QntInv);
                Console.WriteLine("-----------------------------------");
            }
            Console.WriteLine("Seu saldo é: " + rúpias);
        }
    }
}