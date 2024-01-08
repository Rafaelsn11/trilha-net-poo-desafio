using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public abstract class Smartphone
{
        // Implementado!!!
        public string Numero { get; set; }
        private string Modelo;
        private string IMEI;
        private int Memoria;
        protected int[] ContagemDaInstalacao = {20, 40, 60, 80, 100};

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // Implementado!!!
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
            
            for (int contador = 1; contador <= 3; contador++)
            {
                Console.WriteLine("...");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\nLigação Atendida");
            Thread.Sleep(1000);
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
            
            for (int contador = 1; contador <= 3; contador++)
            {
                Console.WriteLine("...");
                Thread.Sleep(1000);
            }
            Console.WriteLine("\nLigação Recebida");
            Thread.Sleep(1000);
        }

        public abstract void InstalarAplicativo(string nomeApp);
}
