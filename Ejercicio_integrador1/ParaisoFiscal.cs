using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_integrador1
{
    class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaInicioActividades;

        public static implicit operator ParaisoFiscal(eParaisosFiscales epf)
        {
            ParaisoFiscal pf = new ParaisoFiscal(epf);
            return pf;
        }

        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("");
            Console.Write("Fecha de Inicio: ");
            Console.WriteLine(fechaInicioActividades.ToString());
            Console.Write("Locacion: ");
            Console.WriteLine(this._lugar.ToString());
            Console.Write("Cantidad de 'cuentitas': ");
            Console.WriteLine(this._listadoCuentas.Count.ToString());
            Console.WriteLine("*************Listado de Cuentas OffShore*************");

            foreach (CuentaOffShore cOffS in _listadoCuentas)
            {
                Console.Write(Cliente.RetornarDatos(cOffS.Duenio));
                Console.Write("Numero de Cuenta: ");
                Console.WriteLine(((int)cOffS).ToString());
                Console.Write("Saldo: ");
                Console.WriteLine(cOffS.Saldo.ToString());
                Console.WriteLine("");
            }

        }

        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }

        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if(pf==cos)
            {
                pf._listadoCuentas.Remove(cos);
                cantidadDeCuentas--;
                Console.WriteLine("Se quito la cuenta del paraiso...");
            }
            else
            {
                Console.WriteLine("La cuenta no existe en el paraiso...");
            }

            return pf;
        }
        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if (pf != cos)
            {
                pf._listadoCuentas.Add(cos);
                cantidadDeCuentas++;
                Console.WriteLine("Se agrego la cuenta al paraiso...");
            }
            else
            {
                foreach (CuentaOffShore item in pf._listadoCuentas)
                {
                    if(item == cos)
                    {
                        item.Saldo += cos.Saldo;
                        Console.WriteLine("Se actualizo el saldo de la cuenta...");
                        break;
                    }
                }
            }
            return pf;
        }
        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool existeCoff = false;

            foreach (CuentaOffShore cuentaAux in pf._listadoCuentas)
            {
                if(cuentaAux == cos)
                {
                    existeCoff = true;
                    break;
                }
            }

            return existeCoff;
        }
        
        static ParaisoFiscal()
        {
            cantidadDeCuentas = 0;
            fechaInicioActividades = DateTime.Now;
            
        }
        private ParaisoFiscal()
        {
            this._listadoCuentas = new List<CuentaOffShore>();
        }

        private ParaisoFiscal(eParaisosFiscales lugar) : this()
        {
            this._lugar = lugar;
            
        }

    }
}
