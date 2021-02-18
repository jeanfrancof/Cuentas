using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuentas
{
    class Cuenta
    {
		int numCuenta;
		float saldoCuenta;

		public Cuenta(int cuenta, float inicial)
		{
			numCuenta = cuenta;
			saldoCuenta = inicial;
		}

		public void consignar(float valor)
		{
			saldoCuenta = saldoCuenta + valor;
		}

		public void retirar(float valor)
		{
			saldoCuenta = saldoCuenta - valor;
		}
		public double saldo()
		{
			return saldoCuenta;
		}
	}
}
