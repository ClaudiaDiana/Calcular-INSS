using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inss
{
    class Taxa
    {
        public double taxaDesconto(int ano, double salario) {
            double taxa_inss = 0;


            switch(ano){
                case 2011:
                    taxa_inss = this.taxa_2011(salario);
                break;

                case 2012:
                break;
            }

            return taxa_inss;
        }

        
        public double taxa_2011(double salario) {
            double taxa;

            if(salario <= 1106.90){
                taxa = 8;
            } else if (salario >= 1106.91 && salario <= 1844.83){
                taxa = 9;
            }
            else if (salario >= 1844.84 && salario <= 3689.66) {
                taxa = 11;
            } else {
                taxa = 405.86;
            }

            return taxa;
        }


        public double taxa_2012(double salario){
            double taxa;

            if (salario <= 1000)
            {
                taxa = 7;
            }
            else if (salario >= 1000.01 || salario <= 1500)
            {
                taxa = 8;
            }
            else if (salario >= 1500.01 || salario <= 3000)
            {
                taxa = 9;
            }
            else if (salario >= 3000.01 || salario <= 4000)
            {
                taxa = 11;
            }
            else
            {
                taxa = 500.00;
            }

            return taxa;
        }


    }
}
