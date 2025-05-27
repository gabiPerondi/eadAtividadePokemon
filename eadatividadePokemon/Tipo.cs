using System;
using System.Collections.Generic;

namespace eadatividadePokemon
{
    public class Tipo
    {
        public string Nome { get; set; }

        public Tipo(string nome)
        {
            Nome = nome;
        }

        public List<string> ObterFraquezas()
        {
            switch (Nome)
            {
                case "fogo":
                    return new List<string> { "Água", "Rocha", "Terra" };
                case "água":
                    return new List<string> { "Elétrico", "Planta" };
                case "planta":
                    return new List<string> { "Fogo", "Gelo", "Inseto" };
                case "elétrico":
                    return new List<string> { "Terra" };
                case "voador":
                    return new List<string> { "Elétrico", "Gelo", "Rocha" };
                default:
                    return new List<string>();
            }
        }

        public List<string> ObterResistencias()
        {
            switch (Nome)
            {
                case "fogo":
                    return new List<string> { "Planta", "Gelo", "Inseto", "Aço" };
                case "água":
                    return new List<string> { "Fogo", "Gelo", "Aço", "Água" };
                case "planta":
                    return new List<string> { "Água", "Elétrico", "Planta", "Terra" };
                case "elétrico":
                    return new List<string> { "Voador", "Elétrico", "Aço" };
                case "voador":
                    return new List<string> { "Planta", "Inseto", "Lutador" };
                default:
                    return new List<string>();
            }
        }

        public List<string> ObterImunidades()
        {
            switch (Nome)
            {
                case "fantasma":
                    return new List<string> { "Normal", "Lutador" };
                case "terrestre":
                    return new List<string> { "Elétrico" };
                case "aço":
                    return new List<string> { "Venenoso" };
                case "sombrio":
                    return new List<string> { "Psíquico" };
                case "voador":
                    return new List<string> { "Terra" };
                default:
                    return new List<string>();
            }
        }
    }
}
