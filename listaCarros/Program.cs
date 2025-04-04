using System;
class Carros
{
    static void Main()
    {
        //Criação de uma lista para armazenar as categoria de carros
        string[] categoria = {"Hatch", "Sedan", "SUV"};
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
        bool loop = true;
        string resposta;

        Console.WriteLine("Escolha uma categoria de carros: ");

        while(loop)
        {
            //Mostra os valores da lista categoria para o usuario escolher
            for (int i = 0; i < categoria.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + categoria[i]);
            }

            resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1":
                    for (int i = 0; i < hatch.GetLength(0); i++)
                    {
                        Console.WriteLine(i + 1 + ". " + hatch[i, 0]);
                    }
                    loop = false;
                    break;
                case "2":
                    for (int i = 0; i < sedan.GetLength(0); i++)
                    {
                        Console.WriteLine(i + 1 + ". " + sedan[i, 0]);
                    }
                    loop = false;
                    break;
                case "3":
                    for (int i = 0; i < suv.GetLength(0); i++)
                    {
                        Console.WriteLine(i + 1 + ". " + suv[i, 0]);
                    }
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Valor Inválido! Digite novamente!");
                    break;
            }
        }

        while(loop)
        {
            //Mostra os valores da lista categoria para o usuario escolher
            for (int i = 0; i < categoria.Length; i++)
            {
                Console.WriteLine(i + 1 + ". " + categoria[i]);
            }

            resposta = Console.ReadLine();

            switch (resposta)
            {
                case "1":
                    for (int i = 0; i < hatch.GetLength(0); i++)
                    {
                        Console.WriteLine(i + 1 + ". " + hatch[i, 0]);
                    }
                    loop = false;
                    break;
                case "2":
                    for (int i = 0; i < sedan.GetLength(0); i++)
                    {
                        Console.WriteLine(i + 1 + ". " + sedan[i, 0]);
                    }
                    loop = false;
                    break;
                case "3":
                    for (int i = 0; i < suv.GetLength(0); i++)
                    {
                        Console.WriteLine(i + 1 + ". " + suv[i, 0]);
                    }
                    loop = false;
                    break;
                default:
                    Console.WriteLine("Valor Inválido! Digite novamente!");
                    break;
            }
        }
    }
}