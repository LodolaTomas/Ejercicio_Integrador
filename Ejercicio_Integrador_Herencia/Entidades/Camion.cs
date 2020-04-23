using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : Vehiculo
    {
        #region Atributo
        protected float tara;
        #endregion

        #region Constructor

        public Camion(string patente, byte cantRuedas, EMarcas marca, int cantidadAsientos,float tara)
                                                        : base(patente, cantRuedas, marca)
        {
            this.tara = tara;
        }

        #endregion

        #region Metodos

        public string MostrarCamion()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Mostrar());
            sb.Append("Tara:");
            sb.AppendLine(tara.ToString());

            return sb.ToString();
        }

        #endregion
    }
}
