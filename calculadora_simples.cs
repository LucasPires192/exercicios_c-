using System;

class Program {
    static void Main() {
    
        double numero1;
        double numero2;
        string operacao;
        
        Console.WriteLine ("Digite um numero:");
        numero1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine ("Digite um numero:");
        numero2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine ("Escolha a operação:\n 1. Adição \n 2. Subtração \n 3. Multiplicação \n 4. Divisão");
        operacao = Console.ReadLine();
        
        if(operacao == "4" && (numero1 == 0 || numero2 == 0)){
            Console.WriteLine("Não é possivel fazer divisão por 0");
        } else{
            switch(operacao){
                case("1"):
                    Console.WriteLine(numero1 + " + " + numero2 + " = " + (numero1 + numero2));
                    break;
                case("2"):
                    Console.WriteLine(numero1 + " - " + numero2 + " = " + (numero1 - numero2));
                    break;
                case("3"):
                    Console.WriteLine(numero1 + " * " + numero2 + " = " + (numero1 * numero2));
                    break;
                case("4"):
                    Console.WriteLine(numero1 + " / " + numero2 + " = " + (numero1 / numero2));
                    break;
                default:
                    Console.WriteLine("Operação Invalida");
                    break;
            }
        }
    }
}