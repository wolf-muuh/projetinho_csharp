// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456. O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).





Console.WriteLine($"Digite o seu nome e a senha que lhe foi enviada para entrar no sistema: ");
string nome = "";
int senha = 0;


while (senha != 123456 && nome == "")
{
    nome = Console.ReadLine();
    senha = int.Parse(Console.ReadLine());

    if (senha == 123456)
    {
        Console.WriteLine($"Acesso concedido");
        Console.WriteLine(@$"
----------------------------------
|      Passagens aéreas          |
|        VAI COM DEUS            |
| Digite:                        |
|     1)Para cadastrar Mensagem  |
|     2) Listar Passagem         |
|     0) Sair                    |
|  ®Viagens aéreas vai com Deus  |
----------------------------------
      ");
        int nDigitado = int.Parse(Console.ReadLine());

        for (int i = 0; i < 5; i++)
        {
            while (nDigitado != 1 || nDigitado != 0 || nDigitado != 2)
            {
                if (nDigitado == 1)
                {
                    cadastro();
                }
            }
        }


    }

    else
    {
        Console.WriteLine($"acesso negado, Digite a senha novamente");

    }

}

static void cadastro()
{
    string nomePass = "";
    string orig = "";
    string dest = "";
    int dia = 0;
    int mes = 0;
    int ano = 0;

    while (nomePass == "" && orig == "" && dest == "" && dia == 0 && mes == 0 && ano == 0)
    {
        Console.WriteLine($"Digite o nome do passageiro: ");
        nomePass = Console.ReadLine();
        Console.WriteLine($"Digite da onde você ira partir: ");
        orig = Console.ReadLine();
        Console.WriteLine($"Digite qual é o seu destino: ");
        dest = Console.ReadLine();
        Console.WriteLine($"Digite o dia da viagem: ");
        dia = int.Parse(Console.ReadLine());
        Console.WriteLine($"mês: ");
        mes = int.Parse(Console.ReadLine());
        Console.WriteLine($"e ano: ");
        ano = int.Parse(Console.ReadLine());
        

    }

}















