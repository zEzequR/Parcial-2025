using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_2025.Clases
{
    internal class Items_Depositos
    {
        public int cod_item;
        public int nro_deposito;
        public int cantidad;

        public Items_Depositos setItems_Depositos(int cod_item, int nro_deposito, int cantidad)
        {
            Items_Depositos item_deposito = new Items_Depositos();
            item_deposito.cod_item = cod_item;
            item_deposito.nro_deposito = nro_deposito;
            item_deposito.cantidad = cantidad;
            return item_deposito;
        }
    }
}
