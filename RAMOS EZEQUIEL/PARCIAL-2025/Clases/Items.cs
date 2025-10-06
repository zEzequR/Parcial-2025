using PARCIAL_2025.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_2025.Clases
{
    internal class Items
    {
        public int cod_item;
        public string desc_item;
        public decimal precio;
        public DateTime fecha_vto;

        public Items setItems(int cod_item, string desc_item, decimal precio, DateTime fecha_vto)
        {
            Items item = new Items();
            item.cod_item = cod_item;
            item.desc_item = desc_item;
            item.precio = precio;
            item.fecha_vto = fecha_vto;
            return item;
        }
    }
}
