using solid_srp_rpg.Cenario_Bom.Domain.Enums;

namespace solid_srp_rpg.Cenario_Bom.Domain
{
    public class Personagem
    {
        public string Nome { get; private set; }
        public Classe Classe { get; private set; }
        public Atributos Atributos { get; private set; }

        private Personagem(string nome, Classe classe) 
        {
            Nome = nome;
            Classe = classe;
            Atributos = Atributos.ObterPorClasse(classe);
        }

        public static Personagem Criar(string nome, Classe classe)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome inválido");

            return new Personagem(nome, classe);
        }
    }
}
