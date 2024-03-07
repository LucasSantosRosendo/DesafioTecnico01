
using System;
class HelloWorld {
    
  static void Main() {
    int idademoriarty = 24;
    int peso = 65;
    float altura = 1.85f;
    double crescimentoseguidores;
    double visualizacoesmedia;
    char caracter = '#';
    string profissao = "Professor Universitário de Matemática";
    string segredo = "Moriarty tem uma agência de serviços secretos, onde realiza trabalhos para limpar a sociedade britânica corrupta";
    Console.WriteLine("Bem-vindo ao museu do Professor Moriarty!");
    Console.WriteLine("O museu contêm informações sobre esse brilhante estudioso.");
    Console.WriteLine("Vamos começar a visita! Qual informação você deseja saber sobre o professor?");
    Console.WriteLine("Setores de informações:");
    Console.WriteLine("1. Profissão");
    Console.WriteLine("2. Idade");
    Console.WriteLine("3. Altura");
    Console.WriteLine("4. Peso");
    Console.WriteLine("5. Segredo");
    int opcao = Convert.ToInt32(Console.ReadLine());
    
    if (opcao == 1){
        Console.WriteLine("Você escolheu a opção 1, profissão!");
        Console.WriteLine($"A profissão de Moriarty é: {profissao}");
    }
   else if (opcao == 2){
        Console.WriteLine("Você escolheu a opção 2, idade!");
        Console.WriteLine($"A idade de Moriarty é: {idademoriarty} ");
    }
    else if (opcao == 3){
        Console.WriteLine("Você escolheu a opção 3, altura!");
        Console.WriteLine("A altura de Moriarty é: {altura}");
    }
    else if (opcao == 4){
        Console.WriteLine("Você escolheu a opção 4, peso!");
        Console.WriteLine($"O peso de Moriarty é: {peso}");
    }
    else if (opcao == 5){
        Console.WriteLine("Você escolheu a opção 5, segredo!");
        Console.WriteLine($"O segredo de James Moriarty é... {segredo}");
    }
    else {
        Console.WriteLine("Opção inválida, por favor, digite uma opção válida");
    }
    Console.WriteLine("=== Bem-vindo ao instagram de: ===");
    Console.WriteLine("Nome: William James Moriarty");
    Console.WriteLine("BIO: Professor Universitário nas horas vagas e gênio do crime no período integral");
    Console.WriteLine("Número de seguidores: 540650 mil seguidores");
    Console.WriteLine($"Se pudesse me definir em um caracter: {caracter}");

    Console.WriteLine("Vamos agora verificar qual foi a média do crescimento dos seguidores do professor!");
    Console.WriteLine("Digite 1 para prosseguirmos!");
    int opcao2 = Convert.ToInt32(Console.ReadLine());
    if (opcao2 == 1){
        crescimentoseguidores = peso*altura;
        Console.WriteLine($"O crescimento de seguidores é de: {crescimentoseguidores}");
    }
    Console.WriteLine("Vamos conhecer a média de visualizações por vídeo dele!");
    Console.WriteLine("Digite 2 para prosseguirmos");
    int opcao3 = Convert.ToInt32(Console.ReadLine());
    if (opcao3 == 2){
        visualizacoesmedia = idademoriarty + peso;
        Console.WriteLine($"O número médio de visualizações por vídeo é de: {visualizacoesmedia}");
    }
    
  }
}