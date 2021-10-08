using System;

namespace OO_Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            Console.WriteLine("Digite o nome do primeiro funcionário: ");
            f1.Nome = Console.ReadLine();            
            System.Console.WriteLine("Digite o salário do primeiro funcionário: ");
            f1.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do segundo funcionário: ");
            f2.Nome = Console.ReadLine();            
            System.Console.WriteLine("Digite o salário do segundo funcionário: ");
            f2.Salario = decimal.Parse(Console.ReadLine());

            decimal media = (f1.Salario + f2.Salario)/2;
            System.Console.WriteLine("Salário médio:"+media);
        }
    }
}
