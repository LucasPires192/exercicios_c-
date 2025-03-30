using System;

class Program{
    static void Main(){
        string[] alunos = {
            "Lucas Almeida", 
            "Marina Souza", 
            "João Pereira", 
            "Fernanda Oliveira", 
            "Rafael Santos", 
            "Camila Costa", 
            "Gustavo Lima", 
            "Larissa Martins", 
            "Pedro Carvalho", 
            "Juliana Ribeiro", 
            "Bruno Ferreira", 
            "Ana Clara Mendes", 
            "Thiago Nunes", 
            "Isabela Rocha", 
            "Eduardo Vasconcelos", 
            "Sofia Lima", 
            "Carlos Henrique Silva", 
            "Beatriz Figueiredo", 
            "Matheus Azevedo", 
            "Carolina Antunes"
        };

        double[,] notas = {
            {8.6, 7.9, 9},
            {9.2, 9.5, 8.8},
            {7.8, 8, 7.5},
            {8.9, 9.1, 8.7},
            {7.5, 6.9, 7.8},
            {9, 9.2, 8.9},
            {8.1, 7.7, 8.3},
            {9.5, 9.7, 9.4},
            {7, 6.8, 7.3},
            {8.4, 8.6, 8.2},
            {7.9, 8.1, 7.5},
            {9.3, 9, 9.4},
            {7.2, 7.6, 7.1},
            {9.8, 10, 9.6},
            {6.9, 6.5, 7},
            {8.7, 8.9, 8.5},
            {8, 7.8, 8.2},
            {9.1, 9.3, 8.9},
            {7.4, 7.6, 7.2},
            {8.6, 8.4, 8.7}
        };

        double[] medias = new double[alunos.Length];
        double maiorMedia = 0;
        double menorMedia = 0;

        for(int i = 0; i < alunos.Length; i++){
            double media = Math.Round((notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3, 2);
            medias[i] = media;
            
            if(maiorMedia < media){
                maiorMedia = media;
            }
            if(menorMedia > media || menorMedia == 0){
                menorMedia = media;
            }

            Console.WriteLine(i + 1 + ". " + alunos[i] + "- Média: " + media);
        }

        int indexMaiorMedia = Array.IndexOf(medias, maiorMedia);
        int indexMenorMedia = Array.IndexOf(medias, menorMedia);

        Console.WriteLine("A maior média: " + alunos[indexMaiorMedia] + "- " + maiorMedia);
        Console.WriteLine("A menor média: " + alunos[indexMenorMedia] + "- " + menorMedia);
    }
}