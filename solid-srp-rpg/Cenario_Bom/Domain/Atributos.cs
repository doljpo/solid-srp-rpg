using solid_srp_rpg.Cenario_Bom.Domain.Enums;

namespace solid_srp_rpg.Cenario_Bom.Domain
{
    public class Atributos
    {
        public int Forca { get; set; }
        public int Inteligencia { get; set; }

        public static Atributos ObterPorClasse(Classe classe)
        {
            return classe switch
            {
                Classe.Guerreiro => new Atributos { Forca = 10, Inteligencia = 2 },
                Classe.Mago => new Atributos { Forca = 2, Inteligencia = 10 },
                Classe.Ladino => new Atributos { Forca = 6, Inteligencia = 6 },
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
