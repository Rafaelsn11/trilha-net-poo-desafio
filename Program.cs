﻿using trilha_net_poo_desafio.Models;

// Implementado!!!

// Usuário escolhendo o smartphone
Console.WriteLine("Resposta Inválida tente novamente...");
Console.WriteLine("Escolha o celular da sua Prefêrencia: ");
Console.WriteLine("[ 1 ] - Nokia\n[ 2 ] - Iphone");
int.TryParse(Console.ReadLine(), out int respostaUsuario);
while (true)
{
    if (respostaUsuario <= 0 || respostaUsuario >= 3)
    {
        Console.WriteLine("Resposta Inválida tente novamente...");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("Escolha o celular da sua Prefêrencia: ");
        Console.WriteLine("[ 1 ] - Nokia\n[ 2 ] - Iphone");
        int.TryParse(Console.ReadLine(), out respostaUsuario); 
    }
    else
    {
        break;
    }
}

if (respostaUsuario == 1)
{
    Console.WriteLine("\nSmartphone Nokia:");

    Console.WriteLine("Cadastre seu número: ");
    string numero = Console.ReadLine();

    Console.Clear();

    Console.WriteLine("\nModelo Do Nokia: ");
    string modelo = String.Empty;
    Console.WriteLine("[ 1 ] - NOKIA G11\n[ 2 ] - NOKIA G60\n[ 3 ] - NOKIA C2\n[ 4 ] - NOKIA 5.3\n[ 5 ] - NOKIA 5.4\n\nESCOLHA O SEU MODELO: ");
    int.TryParse(Console.ReadLine(), out int respostaModelo);

    switch (respostaModelo)
    {
        case 1:
            modelo = "NOKIA G11";
            break;

        case 2:
            modelo = "NOKIA G60";
            break;

        case 3:
            modelo = "NOKIA C2";
            break;
        
        case 4:
            modelo = "NOKIA 5.3";
            break;

        case 5:
            modelo = "NOKIA 5.4";
            break;

        default:
            Console.WriteLine("OPÇÃO INVÁLIDA!");
            break;
    }
    while (true)
    {
        if (respostaModelo <= 0 || respostaModelo >= 6)
        {
            Console.WriteLine("Tente novamente...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[ 1 ] - NOKIA G11\n[ 2 ] - NOKIA G60\n[ 3 ] - NOKIA C2\n[ 4 ] - NOKIA 5.3\n[ 5 ] - NOKIA 5.4\n\nESCOLHA O SEU MODELO: ");
            int.TryParse(Console.ReadLine(), out respostaModelo);

            switch (respostaModelo)
            {
                case 1:
                    modelo = "NOKIA G11";
                    break;

                case 2:
                    modelo = "NOKIA G60";
                    break;

                case 3:
                    modelo = "NOKIA C2";
                    break;
                
                case 4:
                    modelo = "NOKIA 5.3";
                    break;

                case 5:
                    modelo = "NOKIA 5.4";
                    break;

                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA!");
                    break;
            }
         }
        else
        {
            break;
        }
        
    }
    
    Console.Clear();

    // Criando uma instância da classe Random para gerar um número aleatório para o imei
    Random random = new Random();

    // Gerando um número aleatório
    int numeroAleatorio = random.Next(100000000, 999999999);

    // Converte o número inteiro para string para ser atribuido na variável imei
    Console.WriteLine("\nImei do nokia sendo gerado: ");
    for (int contador = 1; contador <= 3; contador++)
    {
       Console.WriteLine($"{contador}...");
       Thread.Sleep(1000); 
    }
    Console.WriteLine("Concluído");
    string imei = numeroAleatorio.ToString();
    Thread.Sleep(2000);
    
    Console.Clear();

    Console.WriteLine("\nEscolha a quantidade de memória desejada");
    int memoria = 0;
    Console.WriteLine("[ 1 ] - 64GB\n[ 2 ] - 128GB\n[ 3 ] - 256GB");
    int.TryParse(Console.ReadLine(), out int respostaMemoria);

    switch (respostaMemoria)
    {
        case 1:
            memoria = 64;
            break;
        
        case 2:
            memoria = 128;
            break;

        case 3:
            memoria = 256;
            break;

        default:
            Console.WriteLine("OPÇÃO INVÁLIDA!");
            break;
    }
    while (true)
    {
        if (respostaMemoria <= 0 || respostaMemoria >= 4)
        {
            Console.WriteLine("Tente novamente...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[ 1 ] - 64GB\n[ 2 ] - 128GB\n[ 3 ] - 256GB");
            int.TryParse(Console.ReadLine(), out respostaMemoria);

            switch (respostaMemoria)
            {
                case 1:
                    memoria = 64;
                    break;
                
                case 2:
                    memoria = 128;
                    break;

                case 3:
                    memoria = 256;
                    break;

                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA!");
                    break;
            }
        }
        else
        {
            break;
        }
    }

    Smartphone nokia = new Nokia(numero, modelo, imei, memoria);

    Console.Clear();

    Console.WriteLine("\nEscolha se quer ligar ou receber uma ligação ou ligar");
    Console.WriteLine("[ 1 ] - Ligar\n[ 2 ] - Receber ligação");
    int.TryParse(Console.ReadLine(), out int respostaUsuario2);

    while (true)
    {
        if (respostaUsuario2 == 1)
        {
            nokia.Ligar();
            break;
        }
        else if (respostaUsuario2 == 2)
        {
            nokia.ReceberLigacao();
            break;
        }
        else
        {
            Console.WriteLine("Resposta inválida, tente novamente.");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("\nEscolha se quer ligar ou receber uma ligação ou ligar");
            Console.WriteLine("[ 1 ] - Ligar\n[ 2 ] - Receber ligação");
            int.TryParse(Console.ReadLine(), out respostaUsuario2);

        }
    }
    
    Console.Clear();
    
    Console.WriteLine("Digite o nome do Aplicativo que deseja instalar: ");
    string nomeApp = Console.ReadLine();
    nokia.InstalarAplicativo(nomeApp);

    Console.Clear();

    Console.WriteLine("Detalhes celular Nokia: \n");
    Console.WriteLine($"Modelo: {modelo}\nNúmero: {numero}\nIMEI: {imei}\nMemória: {memoria}");
}
else if (respostaUsuario == 2)
{
    Console.WriteLine("Smartphone Iphone: ");

    Console.WriteLine("Cadastre seu número: ");
    string numero = Console.ReadLine();
    Console.Clear();

    Console.WriteLine("Modelo Do Iphone: ");
    string modelo = String.Empty;
    Console.WriteLine("[ 1 ] - IPHONE 13\n[ 2 ] - IPHONE 14\n[ 3 ] - IPHONE 15\n[ 4 ] - IPHONE 15 PLUS\n[ 5 ] - IPHONE 15 PRO MAX\n\nESCOLHA O SEU MODELO: ");
    int.TryParse(Console.ReadLine(), out int respostaModelo);

    switch (respostaModelo)
    {
        case 1:
            modelo = "IPHONE 13";
            break;

        case 2:
            modelo = "IPHONE 14";
            break;

        case 3:
            modelo = "IPHONE 15";
            break;
        
        case 4:
            modelo = "IPHONE 15 PLUS";
            break;

        case 5:
            modelo = "IPHONE 15 PRO MAX";
            break;

        default:
            Console.WriteLine("OPÇÃO INVÁLIDA!");
            break;
    }
    while (true)
    {
        if (respostaModelo <= 0 || respostaModelo >= 6)
        {
            Console.WriteLine("Tente novamente...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[ 1 ] - IPHONE 13\n[ 2 ] - IPHONE 14\n[ 3 ] - IPHONE 15\n[ 4 ] - IPHONE 15 PLUS\n[ 5 ] - IPHONE 15 PRO MAX\n\nESCOLHA O SEU MODELO: ");
            int.TryParse(Console.ReadLine(), out respostaModelo);

            switch (respostaModelo)
            {
                case 1:
                    modelo = "IPHONE 13";
                    break;

                case 2:
                    modelo = "IPHONE 14";
                    break;

                case 3:
                    modelo = "IPHONE 15";
                    break;
                
                case 4:
                    modelo = "IPHONE 15 PLUS";
                    break;

                case 5:
                    modelo = "IPHONE 15 PRO MAX";
                    break;

                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA!");
                    break;
            }
         }
        else
        {
            break;
        }
        
    }
    Console.Clear();

    // Criando uma instância da classe Random para gerar um número aleatório para o imei
    Random random = new Random();

    // Gerando um número aleatório
    int numeroAleatorio = random.Next(100000000, 999999999);

    // Converte o número inteiro para string para ser atribuido na variável imei
    Console.WriteLine("\nImei do Iphone sendo gerado: ");
    for (int contador = 1; contador <= 3; contador++)
    {
       Console.WriteLine($"{contador}...");
       Thread.Sleep(1000); 
    }
    Console.WriteLine("Concluído");
    string imei = numeroAleatorio.ToString();
    Thread.Sleep(2000);
    
    Console.Clear();

    Console.WriteLine("\nEscolha a quantidade de memória desejada");
    int memoria = 0;
    Console.WriteLine("[ 1 ] - 64GB\n[ 2 ] - 128GB\n[ 3 ] - 256GB");
    int.TryParse(Console.ReadLine(), out int respostaMemoria);

    switch (respostaMemoria)
    {
        case 1:
            memoria = 64;
            break;
        
        case 2:
            memoria = 128;
            break;

        case 3:
            memoria = 256;
            break;

        default:
            Console.WriteLine("OPÇÃO INVÁLIDA!");
            break;
    }
    while (true)
    {
        if (respostaMemoria <= 0 || respostaMemoria >= 4)
        {
            Console.WriteLine("Tente novamente...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("[ 1 ] - 64GB\n[ 2 ] - 128GB\n[ 3 ] - 256GB");
            int.TryParse(Console.ReadLine(), out respostaMemoria);

            switch (respostaMemoria)
            {
                case 1:
                    memoria = 64;
                    break;
                
                case 2:
                    memoria = 128;
                    break;

                case 3:
                    memoria = 256;
                    break;

                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA!");
                    break;
            }
        }
        else
        {
            break;
        }
    }

    Smartphone iphone = new Iphone(numero, modelo, imei, memoria);

    Console.Clear();

    Console.WriteLine("Escolha se quer ligar ou receber uma ligação ou ligar");
    Console.WriteLine("[ 1 ] - Ligar\n[ 2 ] - Receber ligação");
    int.TryParse(Console.ReadLine(), out int respostaUsuario2);

    while (true)
    {
        if (respostaUsuario2 == 1)
        {
            iphone.Ligar();
            break;
        }
        else if (respostaUsuario2 == 2)
        {
            iphone.ReceberLigacao();
            break;
        }
        else
        {
            Console.WriteLine("Resposta inválida, tente novamente.");
            Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("\nEscolha se quer ligar ou receber uma ligação ou ligar");
            Console.WriteLine("[ 1 ] - Ligar\n[ 2 ] - Receber ligação");
            int.TryParse(Console.ReadLine(), out respostaUsuario2);
        } 
    }
    
    Console.Clear();

    Console.WriteLine("Digite o nome do Aplicativo que deseja instalar: ");
    string nomeApp = Console.ReadLine();
    iphone.InstalarAplicativo(nomeApp);

    Console.Clear();

    Console.WriteLine("Detalhes celular Iphone: \n");
    Console.WriteLine($"Modelo: {modelo}\nNúmero: {numero}\nIMEI: {imei}\nMemória: {memoria}");
}