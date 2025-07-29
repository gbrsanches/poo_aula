using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace poo_aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro() { cor = "Preto", placa = "ABC-123", velocidade = 120 };
            Carro carro2 = new Carro() { cor = "Branco", placa = "ABC-456", velocidade = 60 };
            Carro carro3 = new Carro() { cor = "Prata", placa = "ABC-789", velocidade = 100 };

            carro1.Exibir(); carro1.Acelerar();
            carro2.Exibir(); carro2.Acelerar();
            carro3.Exibir(); carro3.Freiar();
        }

        public class Carro
        {
            public string cor;
            public string placa;
            public int velocidade;

            public void Acelerar() { Console.WriteLine("Está acelerando!"); }
            public void Freiar() { Console.WriteLine("Está freiando!"); }

            public void Exibir()
            {
                Console.WriteLine($"Cor: {cor} - Placa: {placa} - Velocidade: {velocidade}");
            }
        }
    }
}
