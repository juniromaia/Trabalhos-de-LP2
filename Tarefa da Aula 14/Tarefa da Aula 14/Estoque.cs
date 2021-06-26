using System;
using System.Collections.Generic;

namespace Tarefa_da_Aula_14
{
    public class Estoque
    {
        protected Dictionary<Produto, int> _catalogo = new Dictionary<Produto, int>();

        public Dictionary<Produto, int> Catalogo
        {
            get { return this._catalogo; }

        }

        public void Adicionar(Produto item, int quantidade)
        {
            if (this._catalogo.ContainsKey(item))
                this._catalogo[item] = this._catalogo[item] + quantidade;
            else
                this._catalogo[item] = quantidade;
        }

        public void Adicionar(Produto item)
        {
            this.Adicionar(item, 1);
        }

        public void Adicionar(List<Produto> itens)
        {
            foreach (var item in itens)
            {
                this.Adicionar(item);
            }
        }

        public void Adicionar(Dictionary<Produto, int> itens)
        {
            foreach (KeyValuePair<Produto, int> parOrdenado in itens)
            {
                this.Adicionar(parOrdenado.Key, parOrdenado.Value);
            }
        }

        public void AtualizarEstoque(Carrinho carrinho)
        {
            Dictionary<Produto, int> estoqueTemp = new Dictionary<Produto, int>();
            foreach (var item in carrinho.Itens.Keys)
            {
                if (this._catalogo.TryGetValue(item, out int produtoQuant))
                {
                    produtoQuant -= 1;
                    estoqueTemp.Add(item, produtoQuant);
                }
                else
                {
                    estoqueTemp.Add(item, produtoQuant);
                }
            }
            this._catalogo.Clear();
            foreach (var item in estoqueTemp)
            {
                _catalogo.Add(item.Key, item.Value);
            }

        }
    }


}