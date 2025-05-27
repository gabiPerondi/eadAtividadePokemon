

namespace eadatividadePokemon
{
    public class Pokemon
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public List<Tipo> Tipos = new List<Tipo>();
        public List<Ataque> Ataques = new List<Ataque>();

        public Pokemon(string nome, double peso, double altura)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
        }

        public void AprenderAtaque(Ataque ataque)
        {
            if (Ataques.Count < 4)// o .count é para saber quantos ataques o Pokémon ja aprendeuu
                Ataques.Add(ataque);
        }

public void RemoverAtaque(string nomeAtaque)
{
    foreach (var ataque in Ataques)
    {
        if (ataque.Nome == nomeAtaque)
        {
            Ataques.Remove(ataque);
                    break;
        }
    }
}
        public void MostrarDados()
        {
            Console.WriteLine($"Olá! Eu sou {Nome}!");
            Console.WriteLine($"Peso: {Peso}kg");
            Console.WriteLine($"Altura: {Altura}m");
            Console.WriteLine("Tipos:");
            foreach (var tipo in Tipos)
                Console.WriteLine($" - {tipo.Nome}");

            Console.WriteLine("Ataques:");
            foreach (var ataque in Ataques)
                Console.WriteLine($" - {ataque}");
        }
    }
}
