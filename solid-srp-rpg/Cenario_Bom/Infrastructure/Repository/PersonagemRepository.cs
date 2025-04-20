using solid_srp_rpg.Cenario_Bom.Application.Interfaces;
using solid_srp_rpg.Cenario_Bom.Domain;

namespace solid_srp_rpg.Cenario_Bom.Infrastructure.Repository
{
    public class PersonagemRepository : IPersonagemRepository
    {
        public void SalvarPersonagem(Personagem personagem)
        {
            Console.WriteLine($"Personagem {personagem.Nome} salvo no banco");
            Console.WriteLine($"Atributos: Força: {personagem.Atributos.Forca} | Inteligência: {personagem.Atributos.Inteligencia}");
        }
    }
}