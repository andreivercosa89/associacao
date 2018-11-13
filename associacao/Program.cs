using System;

namespace associacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            Bairro bairro = new Bairro();

            Console.Write("Informe o nome: ");
            cliente.nome = Console.ReadLine();

            Console.Write("Informe o bairro: ");
            bairro.nome = Console.ReadLine();

            cliente.bairro = bairro;


            Console.Write(cliente.nome + " - "+ cliente.bairro.nome);
        }
    }
}
