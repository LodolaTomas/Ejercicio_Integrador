using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        #region Atributo
        protected float cilindrada;
        #endregion

        #region Constructor

        public Moto(string patente, byte cantRuedas, EMarcas marca, int cantidadAsientos, float cilindrada)
                                                        : base(patente, cantRuedas, marca)
        {
            this.cilindrada = cilindrada;
        }

        #endregion

        #region Metodos

        public string MostrarMoto()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Mostrar());
            sb.Append("Cilindrada:");
            sb.AppendLine(cilindrada.ToString());

            return sb.ToString();
        }

        #endregion
    }
}
