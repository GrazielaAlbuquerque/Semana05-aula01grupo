using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana05
{
    public class PessoaJuridica : Cliente
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }

          public PessoaJuridica (string razaoSocial, string cnpj, int id, string endereco) : base (id, endereco)
       {
           RazaoSocial = razaoSocial;
           CNPJ = cnpj;
       }

    public override void ExibirCliente()
        {
            Console.WriteLine($"Exibir {Id}, {Endereco}, {RazaoSocial} e {CNPJ}");
        }
    }
}