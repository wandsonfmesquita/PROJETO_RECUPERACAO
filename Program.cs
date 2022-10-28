// menu de boas vindas

using Projeto_Recuperacao.Classes;

Console.WriteLine(@"
============================
|  Bem vindo ao sistema    |
|     de cadastro          |
============================
");

// menu de opcoes
// 1- Cadastrar Pessoa Juridica
// 2- Listar Pessoa Jurídica
// 0 - Sair 

string? opcao;

do
{
    Console.WriteLine(@"
    ================================
    |    Escolha uma das opões     |
    |===============================      
    |   1 - Cadastrar PJ           |
    |   2 - Listar PJ              |
    |                              |
    |   0 - Sair                   |
    |                              |
    ================================
    ");

    opcao = Console.ReadLine();

    PessoaJuridica metodosPj = new PessoaJuridica();


    switch (opcao)
    {
        case "1":
            PessoaJuridica pj = new PessoaJuridica();

            Console.WriteLine("Digite o nome da PJ");
            pj.Nome = Console.ReadLine();

            Console.WriteLine("Informe o rendimento");
            pj.Rendimento = float.Parse(Console.ReadLine());

            bool valido;
            do
            {
                Console.WriteLine("Informe o Cnpj ex: XX.XXX.XXX/0001-XX ou XXXXXXXX0001XX");
                pj.Cnpj = Console.ReadLine();
                valido = pj.ValidarCnpj(pj.Cnpj);
            } while (valido == false);

            metodosPj.Inserir(pj);
            break;
        case "2":
            List<PessoaJuridica> listaPj = metodosPj.Ler();

            foreach (PessoaJuridica cadaItem in listaPj)
            {
                Console.WriteLine(@$"
                    Nome: {cadaItem.Nome}
                    Rendimento: {cadaItem.Rendimento}
                    Cnpj: {cadaItem.Cnpj}
                    ");
                Console.WriteLine("Aperte Enter para continuar");
                Console.ReadLine();
            }
            break;
        case "0":
            break;
        default:
            Console.WriteLine("Opção inválida, escolha outra opção");
            break;
    }



} while (opcao != "0");
