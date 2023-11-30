using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_aumento {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double salario, novoSalario, aumento, porcentagem;

            Console.Write("Digite o salario da pessoa: ");
            salario = double.Parse(Console.ReadLine(), CI);

            porcentagem = 0;
            if (salario <= 1000.00) {
                porcentagem = 20;
            }
            else if (salario > 1000.00 && salario <= 3000.00) {
                porcentagem = 15;
            }
            else if (salario > 3000.00 && salario <= 8000.00) {
                porcentagem = 10;
            }
            else if (salario > 8000.00) {
                porcentagem = 5;
            }

            novoSalario = salario * (porcentagem / 100) + salario;
            aumento = novoSalario - salario;

            Console.WriteLine("Novo salario = R$ " + novoSalario.ToString("F2"), CI);
            Console.WriteLine("Aumento = R$ " + aumento.ToString("F2"), CI);
            Console.WriteLine("Porcentagem = " + porcentagem + "%");


        }
    }
}
