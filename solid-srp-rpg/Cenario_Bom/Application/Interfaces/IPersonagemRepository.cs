using solid_srp_rpg.Cenario_Bom.Domain;

namespace solid_srp_rpg.Cenario_Bom.Application.Interfaces
{
    public interface IPersonagemRepository
    {
        void SalvarPersonagem(Personagem personagem);
    }
}
