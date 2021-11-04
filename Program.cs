using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.apresentar();
            pessoa.apresentar("João");
            pessoa.apresentar("João", 23);


            Console.ReadLine();
        }
    }
}
