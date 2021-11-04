using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Conceitos
{
    public class Pessoa
    {

        public void apresentar()
        {
            Console.WriteLine("ola");
        }
        public void apresentar(string nome)
        {
            Console.WriteLine("ola" + nome);
        }
        public void apresentar(string nome, int idade)
        {
            Console.WriteLine("ola " + nome + " voce tem " + idade + " anos");
        }
    }
}
