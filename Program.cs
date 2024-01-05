using trilha_net_poo_desafio.Models;

// Implementado!!!
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"67887666", modelo:"Modelo 0909", imei:"123456789", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:"45451313", modelo:"Modelo 9090", imei:"987654321", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");