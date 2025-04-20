using solid_srp_rpg.Cenario_Bom.Application.Interfaces;
using solid_srp_rpg.Cenario_Bom.Domain;
using solid_srp_rpg.Cenario_Bom.Domain.Enums;

namespace solid_srp_rpg.Cenario_Bom.Application
{
    public class PersonagemService
    {
        private readonly IPersonagemRepository personagemRepository;
        private readonly INotificadorService notificadorService;

        public PersonagemService(IPersonagemRepository personagemRepository, INotificadorService notificadorService)
        {
            this.personagemRepository = personagemRepository;
            this.notificadorService = notificadorService;
        }

        public void CriarPersonagem(string nome, Classe classe)
        {
            var personagem = Personagem.Criar(nome, classe);

            personagemRepository.SalvarPersonagem(personagem);

            notificadorService.NotificarGM(personagem.Nome);
        }
    }
}
