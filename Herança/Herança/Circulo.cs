using System;
using System.Collections.Generic;
using System.Text;

namespace Herança
{
        public class Circulo : Figuras
        {
            private double _raio; 
            public double Raio 
            {
               
                get
                {
                    return this._raio;
                }

                
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("Raio inválido");
                    }
                    else
                    {
                        this._raio = value;
                        this.AtualizarArea();
                        this.AtualizarPerimetro();
                    }
                }
            }
            public Circulo(double raio)
            {               
                this.Raio = raio;
            }
            private void AtualizarArea()
            {
                this._area = Math.PI * this._raio * this._raio;
            }
            private void AtualizarPerimetro()
            {
                this._perímetro = 2 * Math.PI * this._raio;
            }
        }
    
}
