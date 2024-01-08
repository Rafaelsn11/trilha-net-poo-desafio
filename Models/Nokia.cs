using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_poo_desafio.Models
{
    // Implementado!!!
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        
        // Implementado!!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no smartphone no Nokia");
            Console.WriteLine("Carregando...");
            for (int contador = 0; contador < ContagemDaInstalacao.Length; contador++)
            {
                Console.WriteLine($"{ContagemDaInstalacao[contador]}%...");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Instalação Concluída");
        }
    }
}