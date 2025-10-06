using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_2025.Clases
{
    internal class Depositos
    {
        public int nro_deposito;
        public string nombre_deposito;

        public Depositos setDepositos(int nro_deposito, string nombre_deposito)
        {
            Depositos deposito = new Depositos();
            deposito.nro_deposito = nro_deposito;
            deposito.nombre_deposito = nombre_deposito;
            return deposito;
        }
    }
}
