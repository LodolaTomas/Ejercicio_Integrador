using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_integrador1
{
    class CuentaOffShore
    {
        private Cliente _dueno;
        private int _numeroCuenta;
        private double _saldo;

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public Cliente Duenio
        {
            get { return _dueno; }
        }

        public CuentaOffShore(Cliente dueno, int numero, double saldoInicial)
        {
            this._dueno = dueno;
            this.Saldo = saldoInicial;
            this._numeroCuenta = numero;
        }

        public CuentaOffShore(string nombre, eTipoCliente tipo, int numero, double saldoInicial)
        {
            Cliente dueno = new Cliente(tipo, nombre);
            this._dueno = dueno;
            this.Saldo = saldoInicial;
            this._numeroCuenta = numero;
        }

        public static explicit operator int(CuentaOffShore cos)
        {
            return cos._numeroCuenta;
        }

        public static bool operator !=(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            return !(cos1.Equals(cos2));
        }

        public static bool operator ==(CuentaOffShore cos1, CuentaOffShore cos2)
        {
            bool mismaCuenta = false;

            if ((cos1._dueno.GetAlias() == cos2._dueno.GetAlias()) && (int)cos1 == (int)cos2)
            {
                mismaCuenta = true;
            }
            return mismaCuenta;
        }
        /*public override bool Equals(object obj)
        {
            bool retorno = false;
            if (this is CuentaOffShore && obj is CuentaOffShore)
            {
                retorno = this == (CuentaOffShore)obj;
            }
            return retorno;
        }*/
    }
}
