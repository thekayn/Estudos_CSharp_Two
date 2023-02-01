using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        { 

        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;

        public string Sobrenome { get; set; }

        public string nomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome nao pode ser vazio");
                }

                _nome = value;

            }
        }
        public int Idade 
        { 
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade nao pode ser menor que zero.");
                }

                _idade = value;
            }

            

    }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome} {Sobrenome}, Idade {Idade}");
            Console.WriteLine($"Nome: {nomeCompleto}, Idade {Idade}");
        }
    }
}