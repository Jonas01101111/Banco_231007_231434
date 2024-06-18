using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_231007_231434
{
    internal class Program
    {
        static void Saldo(double saldo)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("O saldo é igual a: " + saldo.ToString("C"));
            Console.ResetColor();
        }
         static double Deposito(double saldo)
        {
            double deposito = 0;
            Console.WriteLine("Valor a ser depositado:");
            deposito = double.Parse(Console.ReadLine());
            saldo += deposito;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("DEPOSITO REALIZADO COM SUCESSO");
            Console.ResetColor();
            return saldo;
        }
        static double Saque(double saldo)
        {
            
            double saque = double.MinValue;
            Console.WriteLine("Valor a ser sacado:");
            saque = double.Parse(Console.ReadLine());
            if (saldo < saque) 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("SALDO INSUFICIENTE");
                Console.ResetColor();
            }
            else
            {
                saldo -= saque;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("SAQUE REALIZADO COM SUCESSO");
                Console.ResetColor();
            }
            return saldo;
        }
        static double Pagamento(double saldo)
        {
            double pagamento = double.MinValue;
            Console.WriteLine("Digite o número da conta");
                Console.ReadLine();
            Console.WriteLine("Valor do pagamento:");
            pagamento = double.Parse(Console.ReadLine());
            if (saldo < pagamento) 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed; 
                Console.WriteLine("POBRE");
                Console.ResetColor();
                
            }
            else
            {
                saldo -= pagamento;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("PAGAMENTO CONFIRMADO");
                Console.ResetColor();
            }
            return saldo;
        }
        
        static void Main(string[] args)
        {
            double balance = 0;
            string op;
            while (true)
            {
                Console.WriteLine("###OPÇÕES### \n D-DEPOSITO \n S-SAQUE \n P-PAGAMENTO \n B-SALDO");
                op=Console.ReadLine().ToUpper();
                switch (op)
                {
                    case "D": balance = Deposito(balance); Console.ReadKey(); Console.Clear();  break;
                    case "S": balance = Saque(balance);Console.ReadKey(); Console.Clear(); break;
                    case "P": balance = Pagamento(balance); Console.ReadKey();Console.Clear(); break;
                    case "B": Saldo(balance);Console.ReadKey(); Console.Clear(); break;
                }
                
            }

        }
    }
}
