using solid_srp_rpg.Cenario_Ruim.Domain;

namespace solid_srp_rpg.Cenario_Ruim.Application
{
    public class PersonagemService
    {
        public void CriarPersonagem(string nome, string classe)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new Exception("Nome inválido");

            if (classe != "guerreiro" && classe != "mago" && classe != "ladino")
                throw new Exception("Classe inválida");

            var personagem = new Personagem
            {
                Nome = nome,
                Classe = classe
            };

            switch (classe)
            {
                case "guerreiro":
                    personagem.Forca = 10;
                    personagem.Inteligencia = 2;
                    break;
                case "mago":
                    personagem.Forca = 2;
                    personagem.Inteligencia = 10;
                    break;
                case "ladino":
                    personagem.Forca = 6;
                    personagem.Inteligencia = 6;
                    break;
            }

            // salvar no banco (simulação)
            Console.WriteLine($"Personagem {personagem.Nome} salvo no banco");
            Console.WriteLine($"Atributos: Força: {personagem.Forca} | Inteligência: {personagem.Inteligencia}");

            // enviar notificação (simulação)
            Console.WriteLine($"Mestre notificado: novo personagem criado - {personagem.Nome} ({classe})");
        }
    }

}
