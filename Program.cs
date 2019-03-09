using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace inss
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            double salario;

            // Solicitar as informações para o usuário
            Console.WriteLine("Informe o ano");
            ano = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe o salario");
            salario = double.Parse(Console.ReadLine());

            // Chama a Função responsável pelo calculo da taxa
            var ICalculadorInss = new ICalculadorInss();
            double desconto = ICalculadorInss.CalcularDesconto(ano, salario);

            Console.Clear();
            Console.Write("-----------------------------------------\n");
            Console.Write("Ano:" + ano+"\n");
            Console.Write("-----------------------------------------\n");
            Console.Write("Salario:" + salario.ToString("C") + "\n");
            Console.Write("-----------------------------------------\n");
            Console.Write("Valor de Desconto:" + desconto.ToString("C") + "\n");
            Console.Write("-----------------------------------------\n");
            Console.Write("Valor de Liquido:" + (salario - desconto).ToString("C"));
            Console.Read();
        }
    }
}
