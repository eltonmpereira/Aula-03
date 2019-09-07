using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassePessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome("Elton Medeiros");
            p1.Idade(33);
            p1.Rg("234.567-8");
            

            Console.WriteLine("nome.: " + p1.Nome());
            Console.WriteLine("RG...: " + p1.Rg());
            Console.WriteLine("Idade: " + p1.Idade());

            Console.WriteLine();
            Console.WriteLine();

            Pessoa p2 = new Pessoa("Renata Maria", "3.323-43", 30);

            Console.WriteLine("Nome.:" + p2.Nome());
            Console.WriteLine("Rg...:" + p2.Rg());
            Console.WriteLine("Idade:" + p2.Idade());

            Console.ReadLine();
        }
    }
}
