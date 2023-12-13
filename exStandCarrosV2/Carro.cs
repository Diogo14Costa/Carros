using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exStandCarrosV2
{
    internal class Carro
    {
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string Cor { get; set; }

        public short Ano { get; set; }

        private bool _motorLigado;

        public int Velocidade { get; private set; }

        public void LigarMotor()
        {
            if (!_motorLigado)
            {
                _motorLigado = true;
                Console.WriteLine("Motor Ligado!");
            }
            else
                Console.WriteLine("O motor ja se encontra ligado!");
        }

        public void DesligarMotor()
        {
            if (_motorLigado)
            {
                _motorLigado = false;
                Console.WriteLine("Motor Desligado!");
            }
            else
                Console.WriteLine("O motor ja se encontra desligado!");
        }

        public void Acelerar(int valor)
        {
            if (_motorLigado) Velocidade += valor;
        }

        public void Travar(int valor)
        {
            Velocidade -= valor;
            if (Velocidade <= 0) DesligarMotor();
        }

        public override string ToString()
        {
            return $"Dados do automovel
        }
    }
}
