// See https://aka.ms/new-console-template for more information

using System.Security.AccessControl;

bool deveContinuar = true;

while (deveContinuar)
{
    Console.WriteLine("Bem vindo ao cadastro de alunos");
    Console.WriteLine("Para seguir, escolha uma das opções:\n1 - Cadastrar um aluno\n2 - Remover um aluno\n3 - Listar todos os alunos\n4 - Sair do programa");
    string opcao = Console.ReadLine();

    if (opcao == "1")
    {
        // pedir informacoes para cadastrar aluno
        Console.WriteLine("Qual é o nome do aluno\nA idade do aluno\nE o Cpf do aluno");
        string informacao = Console.ReadLine();
    }
    else if (opcao == "2")
    {
        // pedir para informar qual aluno quer remover
    }
    else if (opcao == "3")
    {
        // listar todos os alunos
    }
    else if (opcao == "4")
    {
        // fechar o programa
        deveContinuar = false;
    }
}

