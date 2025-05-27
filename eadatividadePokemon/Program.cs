using System;

namespace eadatividadePokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon("Charizard", 110.5, 1.7);

            Tipo fogo = new Tipo("Fogo");
            Tipo voador = new Tipo("Voador");
            pokemon.Tipos.Add(fogo);
            pokemon.Tipos.Add(voador);

            pokemon.AprenderAtaque(new Ataque("Explosão de Fogo", fogo, 110, 0.85, 0, "Especial"));
            pokemon.AprenderAtaque(new Ataque("FirePunch", new Tipo("Meele"), 75, 1.0, 0, "Físico"));
            pokemon.AprenderAtaque(new Ataque("Lança chama", fogo, 90, 1.0, 0, "Especial"));
            pokemon.MostrarDados();
        }
    }
}
