using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        #region Atributo
        protected int cantidadAsientos;
        #endregion

        #region Constructor

        public Auto(string patente, byte cantRuedas, EMarcas marca,int cantidadAsientos) 
                                                        : base(patente,cantRuedas,marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }

        #endregion

        #region Metodos

        public string MostrarAuto()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Mostrar());
            sb.Append("Cantidad de Asientos:");
            sb.AppendLine(cantidadAsientos.ToString());

            return sb.ToString();
        }

        #endregion
    }
}
