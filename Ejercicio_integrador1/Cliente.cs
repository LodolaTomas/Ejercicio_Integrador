using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_integrador1
{
    class Cliente
    {
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;


        private Cliente()
        {
            this._nombre = "NN";
            this._aliasParaIncognito = "Sin alias";
            this._tipoDeCliente = eTipoCliente.SinTIpo;
        }
        public Cliente(eTipoCliente tipoCliente) : this()
        {
            this._tipoDeCliente = tipoCliente;
        }
        public Cliente(eTipoCliente tipoCliente, string nombre) : this(tipoCliente)
        {
            this._nombre = nombre;
        }
        private void CrearAlias()
        {
            var random = new Random();
            this._aliasParaIncognito = Convert.ToString(random.Next(1000, 9999)) +
                                            Convert.ToString(this._tipoDeCliente);

        }
        public string GetAlias()
        {
            if (this._aliasParaIncognito == "Sin alias")
            {
                CrearAlias();
            }
            return this._aliasParaIncognito;
        }
        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre: ");
            sb.AppendLine(Convert.ToString(this._nombre));
            sb.Append("Tipo: ");
            sb.AppendLine(Convert.ToString(this._tipoDeCliente));
            sb.Append("Alias: ");
            sb.AppendLine(this._aliasParaIncognito);

            return sb.ToString();
        }
        public static string RetornarDatos(Cliente uncliente)
        {
            return uncliente.RetornarDatos();
        }
    }
}
