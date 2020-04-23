using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Lavadero
    {
        #region Atributos
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;
        #endregion

        #region Propiedades

        public List<Vehiculo> Vehiculos
        {
            get { return this.vehiculos; }
        }
        
        public string GetLavadero
        {
            
            get 
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Precio Auto :");
                sb.AppendLine(this.precioAuto.ToString());
                sb.Append("Precio Camion :");
                sb.AppendLine(this.precioCamion.ToString());
                sb.Append("Precio Moto :");
                sb.AppendLine(this.precioMoto.ToString());
                sb.AppendLine("");
                foreach (Vehiculo vAux  in this.vehiculos)
                {
                    if(vAux is Auto)
                    {
                        sb.AppendLine("AUTO");
                        sb.AppendLine(((Auto)vAux).MostrarAuto());
                    }
                    if(vAux is Camion)
                    {
                        sb.AppendLine("CAMION");
                        sb.AppendLine(((Camion)vAux).MostrarCamion());
                    }
                    if(vAux is Moto)
                    {
                        sb.AppendLine("MOTO");
                        sb.AppendLine(((Moto)vAux).MostrarMoto());
                    }
                }
                return sb.ToString();
            }
        }

        #endregion

        #region Constructor

        public Lavadero(float precioAuto, float precioCamion, float precioMoto):this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }
        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        #endregion

        #region metodos

        public double MostrarTotalFacturado()
        {
            double totalFacturado=0;

            totalFacturado += MostrarTotalFacturado(EVehiculos.Auto);
            totalFacturado += MostrarTotalFacturado(EVehiculos.Camion);
            totalFacturado += MostrarTotalFacturado(EVehiculos.Moto);


            return totalFacturado;
        }

        public double MostrarTotalFacturado(EVehiculos vehiculo)
        {
            double totalFacturado = 0;

            foreach (Vehiculo item in vehiculos)
            {
                if (vehiculo == EVehiculos.Auto && item is Auto)
                {
                    totalFacturado += precioAuto;
                }
                if (vehiculo == EVehiculos.Camion && item is Camion)
                {
                    totalFacturado += precioAuto;
                }
                if (vehiculo == EVehiculos.Moto && item is Moto)
                {
                    totalFacturado += precioAuto;
                }
            }
            return totalFacturado;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            int retorno = -1;
            string p1=v1.GetPatente;
            string p2=v2.GetPatente;
            int res = p1.CompareTo(p2);
            if (v1==v2)
            {
                retorno = 0;
            }
            if(res >0)
            {
                retorno = 1;
            }

            return retorno;
        }

        public static int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            int retorno = -1;
            string p1 = v1.GetMarca;
            string p2 = v2.GetMarca;
            int res = p1.CompareTo(p2);
            if (v1 == v2)
            {
                retorno = 0;
            }
            if (res > 0)
            {
                retorno = 1;
            }

            return retorno;
        }

        #endregion

        #region Operadores

        public static bool operator ==(Lavadero l1, Vehiculo v1)
        {
            bool boolAux = false;

            foreach (Vehiculo item in l1.vehiculos)
            {
                if(item==v1)
                {
                    boolAux = true;
                    break;
                }
            }
            return boolAux;
        }

        public static bool operator !=(Lavadero l1, Vehiculo v1)
        {
            return !(l1 == v1);
        }

        public static Lavadero operator +(Lavadero l1, Vehiculo v1)
        {
            if(l1 != v1)
            {
                l1.vehiculos.Add(v1);
            }
            return l1;
        }

        public static Lavadero operator -(Lavadero l1, Vehiculo v1)
        {
            if(l1==v1)
            {
                l1.vehiculos.Remove(v1);
            }
            return l1;
        }
        #endregion

    }
}