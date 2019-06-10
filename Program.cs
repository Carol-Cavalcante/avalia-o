using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carol
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float saldo;

            void cadastrar()
            {
                Console.Write("Para fazermos o seu cadastro é necessario que informe o seu nome, por favor:  ");
                nome = Console.ReadLine();
                Console.Write("informe o valor que ira depositar na conta: ");
                saldo = float.Parse(Console.ReadLine());

            }

            float ConsultarSaldo()
            {

                return saldo;
            }

            void depositar(float valor)
            {
                saldo = valor + ConsultarSaldo();
            }

            void sacar(float valor)
            {
                if (valor <= ConsultarSaldo())

                    saldo = ConsultarSaldo() - valor;
                else
                {
                    Console.WriteLine("Saldo insuficiente");
                }
            }


            cadastrar();
            Console.WriteLine("");
            Console.WriteLine(ConsultarSaldo());
            depositar(50);
            Console.WriteLine(ConsultarSaldo());
            sacar(25);
            Console.WriteLine(ConsultarSaldo());
            sacar(234);


            Console.WriteLine("");
            Console.ReadKey();

        }
    }
}
