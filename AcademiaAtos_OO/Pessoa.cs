using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaAtos_OO
{
    internal class Pessoa
    {
        private string Nome { get; set; }
        private int Idade { get; set; }
        private double Salario { get; set; }
        
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Console.WriteLine("Nome: " + nome + " Idade: " + idade);
        }
        public Pessoa(int idade)
        {
            Idade = idade;
            Console.WriteLine("Idade: " + idade);
        }

        private string GetNome()
        {
            return Nome;
        }
    }
}
