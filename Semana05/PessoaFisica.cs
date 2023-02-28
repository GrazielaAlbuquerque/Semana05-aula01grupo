using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana05
{
    public class PessoaFisica : Cliente
    {
       public string Nome { get; set; }
       public string Cpf { get; set; }


    public PessoaFisica (string nome, string cpf, int id, string endereco) : base (id, endereco)
       {
            Nome = nome;
            Cpf = cpf;  
       }
    

    public override void ExibirCliente()
        {
            Console.WriteLine($"Exibir {Id}, {Endereco}, {Nome} e {Cpf}");
        

    }
}
}

/* 
 public class PessoaFisica : Cliente
    {
       public string Nome { get; set; }
       public string Cpf { get; set; }

       public PessoaFisica (string nome, string cpf, int id, string endereco) : base (id, endereco)
       {
            Nome = nome;
            Cpf = cpf;  
       }

        public override void ExibirCliente()
        {
            Console.WriteLine($"Exibir {Id}, {Endereco}, {Nome} e {Cpf}");
        }

    }
}*/