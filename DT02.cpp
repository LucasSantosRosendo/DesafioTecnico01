using namespace std;
#include <string>
#include <iostream>

int main()
{
    int escolha, opcao, opcao2, contador;
    int contador2 = 1;
    string apresentacao ("Moriarty é um professor universitário que leciona Matemática");
    string entidade ("A entidade Gatos Unidos é um órgão responsável pelo cuidado e acolhimento de gatinhos de rua");
    string interacao ("O professor Moriarty tem uma relação de apoio com a Gatos Unidos, resgatando gatos de rua e os trazendo para a associação.");
    cout<<"Prontos para o Desafio Técnico 02?" << endl;
    cout<<"Vamos lá!" << endl;
    while (true){

    cout<<"=== Menu ===" << endl;
    cout<<"Hora de conhecer melhor um personagem, vamos?" << endl;
    cout<<"1. Apresentação do personagem" << endl;
    cout<<"2. Apresentação da entidade filantrópica" << endl;
    cout<<"3. Relação do personagem com a entidade" << endl;
    cin>> opcao;
    
    switch (opcao){
        case 1:
        cout<<"Vejo que você deseja conhecer melhor o personagem. Vamos lá." << endl;
        cout<<"Informações do personagem: " << apresentacao << endl;
        break;
        case 2: 
        cout<<"Vejo que você deseja conhecer melhor a entidade filantrópica. Vamos lá." << endl;
        cout<<"Informações da entidade: " << entidade << endl;
        break;
        case 3:
        cout<<"Vejo que você deseja conhecer melhor a relação do personagem com a entidade. Vamos lá." << endl; 
        cout<<"Relação do personagem: " << interacao << endl;
        break;
        default:
        cout<<"Você escolheu uma opção inválida! Por favor, digite um número dentre os disponíveis." << endl;
        break;
    }
    cout<<"Nosso pequeno tour de informações acabou, você deseja receber um extra de curiosidades?" << endl;
    cout<<"1. Sim" << endl;
    cout<<"2. Não" << endl;
    cin>> opcao2; 
    if (opcao == 1){
        cout<<"O professor Moriarty obteve seu amor por gatos após adotar um pequeno filhote chamado Aurora." << endl;
    }
    else if (opcao!=1) {
        cout<<"Vejo que você não quer receber uma curiosidade extra, infelizmente." << endl;
    }
    else {
        cout<<"ERR0: Por favor, digite um número válido." << endl;
    }
   cout<<"Quantos gatinhos você acha que tem na entidade Gatos Unidos?" << endl;
   cin>> contador;
   for (contador = 0; contador < 10; contador+1)
    {
    cout<<"Você errou! São na verdade 20 gatinhos acolhidos pela associação!" << endl;
    break;
    }
    do {
        cout<<"O tour foi finalizado com sucesso!" << endl;
        cout<<"Caso você deseje obter novas respostas com outras escolhas, reinicie o nosso tour clicando em:" << endl;
        cout<<"Stop" << endl;
        cout<<"E depois em: " << endl;
        cout<<"Run" << endl;
        cout<<"Obrigado :D" << endl;
        contador2++;
    } while (contador2<=1);
    return 0;
}
    
}
