using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semana05
{
    public abstract class Cliente
    {
        public int Id {get; set; } 
        public string Endereco {get; set; }

        public void ExibirCliente(){
            Console.WriteLine($"Id {Id} e Endereço{Endereço}");

        }

       

    }
}