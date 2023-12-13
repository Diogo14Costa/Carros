namespace exStandCarrosV2
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Stand Carocha!");

            Carro meuCarro = new Carro("Citroen", "C4", "Cinza", 2010);
            Console.WriteLine("Informações iniciais: ");
            Console.WriteLine(meuCarro.ToString());

            meuCarro.LigarMotor();
            Console.WriteLine("\n\nInformações após ligar o motor: ");
            Console.WriteLine(meuCarro.ToString());

            meuCarro.Acelerar(100);
            Console.WriteLine("\n\nInformações após acelerar: ");
            Console.WriteLine(meuCarro.ToString());

            Motorista motorista = new Motorista("Diogo Bandolero");
            motorista.Conduzir(meuCarro);
            motorista.Travar(meuCarro, 50);
            Console.WriteLine("\n\nInformações após travar: ");
            Console.WriteLine(meuCarro.ToString());

        }
    }
}