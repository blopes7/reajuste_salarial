using System;

namespace Reajuste_Salarial
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Informe o valor do salário: ");
            string salario = Console.ReadLine();
            double valorSalario = Convert.ToDouble(salario);
            Console.WriteLine("Informe a porcentagem de reajuste: ");
            string reajuste = Console.ReadLine();
            double valorReajuste = Convert.ToDouble(reajuste);
            double salarioAjustado;
            salarioAjustado = valorSalario+(valorSalario * (valorReajuste / 100));

            Console.WriteLine("O valor do seu salário reajustado é: R$ " + salarioAjustado);

        }
    }
}
