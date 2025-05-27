using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eadatividadePokemon
{
    public class Ataque
    {
        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        public int Poder { get; set; }
        public double Precisao { get; set; }
        public int Prioridade { get; set; }
        public string Categoria { get; set; } 

        public Ataque(string nome, Tipo tipo, int poder, double precisao, int prioridade, string categoria)
        {
            Nome = nome;
            Tipo = tipo;
            Poder = poder;
            Precisao = precisao;
            Prioridade = prioridade;
            Categoria = categoria;
        }

        public bool VerificarSeAtaqueEspecial()
        {
            if (Categoria == "Especial")
                return true;
            else
                return false;
        }

        public bool VerificarSeAtaqueFisico()
        {
            if (Categoria == "Físico")
                return true;
            else
                return false;
        }

        public bool VerificarSeAtaqueDeStatus()
        {
            if (Categoria == "Status")
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return $"{Nome} ({Tipo.Nome})";
        }
    }

}