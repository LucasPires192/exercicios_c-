using System;
class Carros
{
    static void Main()
    {
        //Criação de uma lista para armazenar as categoria de carros
        string[] categoria = {"Hatch", "Sedan", "SUV"};
        //Criação de uma lista com os modelos de cada categoria        
        string[,] hatch = {
            {"Fit", "50.000", "1.5", "Flex"},
            {"Corsa", "35.000", "1.6", "Flex"},
            {"Palio", "25.000", "1.0", "Gasolina"}
        };
        string[,] sedan = {
            {"Civic", "80.000", "1.5", "Flex"},
            {"Corolla", "90.000", "1.5", "Flex"},
            {"Siena", "50.000", "1.8", "Flex"}
        };
        string[,] suv = {
            {"Creta", "110.000", "2.0", "Flex"},
            {"ix35", "68.000", "2.0", "Flex"},
            {"SantaFe", "85.000", "2.5", "Gasolina"}
        };
        
        string resposta;

        while(true)
        {
            Console.WriteLine("Escolha uma categoria de carros: ");
            
            //Mostra os valores da lista categoria para o usuario escolher
            for (int i = 0; i < categoria.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + categoria[i]);
            }

            resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Hatch: ");
                    for (int i = 0; i < hatch.GetLength(0); i++)
                    {
                        Console.WriteLine(i + 1 + ". " + hatch[i, 0]);
                    }
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Sedan: ");
                    for (int i = 0; i < sedan.GetLength(0); i++)
                    {
                        Console.WriteLine(i + 1 + ". " + sedan[i, 0]);
                    }
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("SUV: ");
                    for (int i = 0; i < suv.GetLength(0); i++)
                    {
                        Console.WriteLine(i + 1 + ". " + suv[i, 0]);
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Valor Inválido! Digite novamente!");
                    continue;
            }
            while(true)
            {
                resposta = Console.ReadLine();

                switch (resposta)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine($"Modelo: {hatch[0 , 0]}\n Km: {hatch[0, 1]}\n Motor: {hatch[0, 2]}\n Combustivel: {hatch[0, 3]}");
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"Modelo: {sedan[0 , 0]}\n Km: {sedan[0, 1]}\n Motor: {sedan[0, 2]}\n Combustivel: {sedan[0, 3]}");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine($"Modelo: {suv[0 , 0]}\n Km: {suv[0, 1]}\n Motor: {suv[0, 2]}\n Combustivel: {suv[0, 3]}");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Valor Inválido! Digite novamente!");
                        continue;
                }
                break;
            }
            break;
        }
    }
}