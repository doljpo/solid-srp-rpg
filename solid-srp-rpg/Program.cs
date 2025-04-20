//#region CENÁRIO RUIM

//using solid_srp_rpg.Cenario_Ruim.Application;

//var personagemService = new PersonagemService();

//bool continuar = true;

//while (continuar)
//{
//    Console.Clear();
//    Console.WriteLine("🧙 Criação de Personagem");
//    Console.WriteLine("------------------------");

//    Console.Write("Digite o nome do personagem: ");
//    string? nome = Console.ReadLine();

//    Console.WriteLine("\nEscolha a classe:");
//    Console.WriteLine("1 - Guerreiro");
//    Console.WriteLine("2 - Mago");
//    Console.WriteLine("3 - Ladino");

//    Console.Write("Opção: ");
//    string? classeOpcao = Console.ReadLine();

//    string classe = classeOpcao switch
//    {
//        "1" => "guerreiro",
//        "2" => "mago",
//        "3" => "ladino",
//        _ => string.Empty
//    };

//    if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrEmpty(classe))
//    {
//        Console.WriteLine("\n❌ Dados inválidos. Pressione qualquer tecla para tentar novamente...");
//        Console.ReadKey();
//        continue;
//    }

//    Console.WriteLine($"\n📋 Resumo:");
//    Console.WriteLine($"Nome: {nome}");
//    Console.WriteLine($"Classe: {classe}");

//    Console.WriteLine("\nDeseja salvar o personagem?");
//    Console.WriteLine("1 - Salvar");
//    Console.WriteLine("2 - Recomeçar");

//    Console.Write("Opção: ");
//    string? acao = Console.ReadLine();

//    if (acao == "1")
//    {
//        personagemService.CriarPersonagem(nome, classe);
//        continuar = false;
//    }
//    else
//    {
//        Console.WriteLine("\n🔁 Recomeçando...");
//        Thread.Sleep(1000);
//    }
//}

//#endregion

#region CENÁRIO BOM

using solid_srp_rpg.Cenario_Bom.Application;
using solid_srp_rpg.Cenario_Bom.Domain.Enums;
using Microsoft.Extensions.Hosting;
using solid_srp_rpg.Cenario_Bom.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

var builder = Host.CreateDefaultBuilder(args)
.ConfigureServices((context, services) =>
{
    services.AddDependencies();
});

var app = builder.Build();

using var scope = app.Services.CreateScope();
var personagemService = scope.ServiceProvider.GetRequiredService<PersonagemService>();


IniciarMenu(personagemService);

void IniciarMenu(PersonagemService personagemService)
{
    bool continuar = true;

    while (continuar)
    {
        Console.Clear();
        Console.WriteLine("🧙 Criação de Personagem");
        Console.WriteLine("------------------------");

        Console.Write("Digite o nome do personagem: ");
        string? nome = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("\n❌ Nome não informado. Pressione qualquer tecla para tentar novamente...");
            Console.ReadKey();
            continue;
        }

        Console.WriteLine("\nEscolha a classe:");
        Console.WriteLine("1 - Guerreiro");
        Console.WriteLine("2 - Mago");
        Console.WriteLine("3 - Ladino");

        Console.Write("Opção: ");
        string? classeOpcao = Console.ReadLine();

        Classe classe = classeOpcao switch
        {
            "1" => Classe.Guerreiro,
            "2" => Classe.Mago,
            "3" => Classe.Ladino,
            _ => Classe.Guerreiro
        };

        Console.WriteLine($"\n📋 Resumo:");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Classe: {classe}");

        Console.WriteLine("\nDeseja salvar o personagem?");
        Console.WriteLine("1 - Salvar");
        Console.WriteLine("2 - Recomeçar");

        Console.Write("Opção: ");
        string? acao = Console.ReadLine();

        if (acao == "1")
        {
            personagemService.CriarPersonagem(nome, classe);
            continuar = false;
        }
        else
        {
            Console.WriteLine("\n🔁 Recomeçando...");
            Thread.Sleep(1000);
        }
    }
}

#endregion