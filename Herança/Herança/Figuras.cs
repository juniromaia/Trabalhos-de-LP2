using System;
using System.Collections.Generic;
using System.Text;

namespace Herança
{
    public class Figuras
    {       
        protected double _perímetro;
        protected double _area;
        public List<Figuras> fig=new List<Figuras>();
            
            
        public double Area
        {
            get
            {
                return this._area;
            }
        }
        public double Perimetro
        {
            get
            {
                return this._perímetro; 
            }
        }
        public void CriarFigura()
        {
            Circulo c1;
            Retangulo r1;

            int continuar;
            int opcao;

            do
            {
                Console.WriteLine("Insira a a figura que deseja trabalhar(1)Círculo(2)Retângulo");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    
                    Console.WriteLine("Você está na parte de criação de um círculo");
                    Console.WriteLine("Qual é o raio do seu círculo?");
                    double raio = Convert.ToDouble(Console.ReadLine());

                    c1 = new Circulo(raio);
                    fig.Add(c1);
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Você está na parte de criação de um retângulo");
                    Console.WriteLine("Qual é a base do seu retângulo?");
                    double largura = Convert.ToDouble(Console.ReadLine());
                   
                    Console.WriteLine("Qual é a altura do seu retângulo?");
                    double altura = Convert.ToDouble(Console.ReadLine());

                    r1 = new Retangulo(altura,largura);
                    fig.Add(r1);
                }
                else
                {
                    Console.WriteLine("Opção inválida");

                }
                Console.WriteLine("Quer continuar adicionando figuras?(1)Sim(2)Não");
                continuar = Convert.ToInt32(Console.ReadLine());

            } while (continuar == 1);
           
             
        }
        public void mostrar()
        {
            Console.WriteLine("Aqui estão as figuras:");
            int numero = 1;
            foreach(var Figuras in fig)
            {
                Console.WriteLine("Figura {0}", numero);
                Console.WriteLine("Área:{0}", Figuras.Area);
                Console.WriteLine("Perímetro:{0}", Figuras.Perimetro);
                Console.WriteLine("--------------------------");
                numero++;
            }
        }
    }
}
