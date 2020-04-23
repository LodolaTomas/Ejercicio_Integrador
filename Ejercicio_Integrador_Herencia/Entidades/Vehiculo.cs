using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        #region atributos
        protected string patente;
        protected byte cantRuedas;
        protected EMarcas marca;
        #endregion

        #region metodos
        public string GetPatente
        {
            get { return this.patente; }
        }
        public string GetMarca
        {
            get { return this.marca.ToString(); }
        }
        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Patente: ");
            sb.AppendLine(this.patente);
            sb.Append("Cantidad de Ruedas: ");
            sb.AppendLine(this.cantRuedas.ToString()); 
            sb.Append("Marca: ");
            sb.AppendLine(this.marca.ToString());

            return sb.ToString();
        }
        public Vehiculo(string patente,byte cantRuedas,EMarcas marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }
        #endregion

        #region Operadores

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool boolAux = false;
            if( v1.patente == v2.patente && v1.marca == v2.marca)
            {
                boolAux = true;
            }
            return boolAux;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1.Equals(v2));
        }
        #endregion
    }
}
