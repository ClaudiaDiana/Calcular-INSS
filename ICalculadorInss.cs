using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inss
{
    class ICalculadorInss
    {
        public double CalcularDesconto(int ano, double salario)
        {
            var Taxa = new  Taxa();
            double taxa_inss = Taxa.taxaDesconto(ano, salario);
            double desconto;

            if (taxa_inss > 11){
                 desconto = taxa_inss;

            } else {
                 desconto = (salario * taxa_inss) / 100;
            }
            return desconto;
        }
    }
}
