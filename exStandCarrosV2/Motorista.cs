using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exStandCarrosV2
{
    internal class Motorista
    {
        public string Nome { get; set; }

        public Motorista(string nome)
        {
            Nome = nome;
        }

        public void Conduzir(Carro carro)
        {
            Console.WriteLine($"O motorista {Nome} está a conduzir o carro" +
                $"{carro.Marca}, {carro.Modelo}");
        }

        public void Acelerar(Carro carro, int valor)
        {
            carro.Acelerar(valor);
        }

        public void Travar(Carro carro, int valor)
        {
            carro.Travar(valor);
        }

        public void LigarMotor(Carro carro)
        {
            carro.LigarMotor();
        }

        public void DesligarMotor(Carro carro)
        {
            carro.DesligarMotor();
        }

    }
}
