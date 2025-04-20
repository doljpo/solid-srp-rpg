using solid_srp_rpg.Cenario_Bom.Application.Interfaces;

namespace solid_srp_rpg.Cenario_Bom.Infrastructure.Services
{
    public class NotificadorService : INotificadorService
    {
        public void NotificarGM(string nomePersonagem)
        {
            Console.WriteLine($"Mestre notificado: novo personagem criado - {nomePersonagem}");
        }
    }
}
