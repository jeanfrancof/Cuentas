using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta(1010, 0);
            Cuenta cuenta2 = new Cuenta(1212, 0);
            cuenta1.consignar(25000) ;
            cuenta1.retirar(20000);
            cuenta1.consignar(55000);
            cuenta1.retirar(50000);
            Console.WriteLine("El saldo es : " + cuenta1.saldo());
            cuenta2.consignar(30000);
            cuenta2.retirar(20000);
            cuenta2.consignar(750000);
            cuenta2.retirar(500000);
            Console.WriteLine("El saldo es: " + cuenta2.saldo());
            Console.ReadKey();
        }
    }
}
