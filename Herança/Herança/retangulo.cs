using System;
using System.Collections.Generic;
using System.Text;

namespace Herança
{
    class Retangulo:Figuras
    {
        private double _altura;
        private double _largura;

        public double Altura
        {
            get
            {
                return this._altura;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Altura inválida");
                }
                else
                {
                    this._altura = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public double Largura
        {
            get
            {
                return this._largura;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Largura inválida");
                }
                else
                {
                    this._largura = value;
                    this.AtualizarArea();
                    this.AtualizarPerimetro();
                }
            }
        }
        public Retangulo(double altura, double largura)
        {
            this.Largura = largura;
            this.Altura = altura;
        }
        private void AtualizarArea()
        {
            this._area = this._altura* this._largura;
        }
        private void AtualizarPerimetro()
        {
            this._perímetro = 2*this._altura + 2*this._largura;
        }

    }
}
