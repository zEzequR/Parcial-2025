using PARCIAL_2025.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_2025.Formularios
{
    public partial class frmItems : Form
    {
        char status = 'N';
        Clases.Items item = new Clases.Items();
        Controladores controladores = new Controladores();
        Conexion conexion = new Conexion();
        public frmItems()
        {
            InitializeComponent();
            conexion.Connect();
            controladores.MostrarDatos("spu_mostrar_items", tableItems , new List<string> { }, new List<object> { }, new List<string> { "Código de Item", "Descripción de Item", "Precio (ARS)", "Fecha de Vencimiento" }, 'N');
            int codItem = controladores.getLastID("dbo.spu_Obtener_codItem");
            codItemInp.Text = codItem.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if ((status == 'N' || status == 'E' || status == 'U') || status == 'A')
            {
                status = 'A';
                sumbitBtn.Text = "Guardar";
                descItemInp.ReadOnly = false;
                precioInp.ReadOnly = false;
                fechaVtoInp.ReadOnly = false;
                int codItem = controladores.getLastID("dbo.spu_Obtener_codItem");
                codItemInp.Text = codItem.ToString();
            }
            else
            {
                sumbitBtn.Text = "-";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if ((status == 'N' || status == 'A' || status == 'U') || status == 'E')
            {
                status = 'E';
                sumbitBtn.Text = "Eliminar";
                descItemInp.ReadOnly = true;
                precioInp.ReadOnly = true;
                fechaVtoInp.ReadOnly = true;

            }
            else
            {
                sumbitBtn.Text = "-";
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if ((status == 'N' || status == 'A' || status == 'E') || status == 'U')
            {
                status = 'U';
                sumbitBtn.Text = "Actualizar";
                descItemInp.ReadOnly = false;
                precioInp.ReadOnly = false;
                fechaVtoInp.ReadOnly = false;
            }
            else
            {
                sumbitBtn.Text = "-";
            }
        }


        private void tableItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            codItemInp.Text = tableItems.Rows[e.RowIndex].Cells[0].Value.ToString();
            descItemInp.Text = tableItems.Rows[e.RowIndex].Cells[1].Value.ToString();
            precioInp.Text = tableItems.Rows[e.RowIndex].Cells[2].Value.ToString();
            fechaVtoInp.Text = tableItems.Rows[e.RowIndex].Cells[3].Value.ToString();
            item = item.setItems(Convert.ToInt32(codItemInp.Text), descItemInp.Text, Convert.ToDecimal(precioInp.Text), Convert.ToDateTime(fechaVtoInp.Text));
        }


        private void sumbitBtn_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case 'A':
                    if (int.TryParse(codItemInp.Text, out int cod_Item) && !string.IsNullOrWhiteSpace(descItemInp.Text) &&
                        decimal.TryParse(precioInp.Text, out decimal precio) && DateTime.TryParse(fechaVtoInp.Text, out DateTime fechaVto))
                    {
                        item = item.setItems(cod_Item, descItemInp.Text, precio, fechaVto);
                        controladores.subirDatos("spu_cargar_items", new List<string> { "@cod_item", "@desc_item", "@precio", "@fecha_vto" },
                            new List<Object> { item.cod_item, item.desc_item, item.precio, item.fecha_vto }, 'A');
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese datos válidos en todos los campos.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        controladores.LimpiarCampos(new List<TextBox> { descItemInp, precioInp, fechaVtoInp });
                    }
                    break;
                case 'E':
                    if (int.TryParse(codItemInp.Text, out int parsedCod_Item))
                    {
                        controladores.subirDatos("spu_eliminar_items", new List<string> { "@cod_item" },
                            new List<Object> { item.cod_item }, 'E');
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un ID válido o seleccione en la tabla el elemento que quiere eliminar", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                case 'U':
                    if (int.TryParse(codItemInp.Text, out int cod_ItemParsed) && !string.IsNullOrWhiteSpace(descItemInp.Text) &&
                        decimal.TryParse(precioInp.Text, out decimal precioParsed) && DateTime.TryParse(fechaVtoInp.Text, out DateTime fechaVtoParsed))
                    {
                        item = item.setItems(cod_ItemParsed, descItemInp.Text, precioParsed, fechaVtoParsed);
                        controladores.subirDatos("spu_modificar_items", new List<string> { "@cod_item", "@desc_item", "@precio", "@fecha_vto" },
                            new List<Object> { item.cod_item, item.desc_item, item.precio, item.fecha_vto }, 'U');
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese datos válidos en todos los campos.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        controladores.LimpiarCampos(new List<TextBox> { descItemInp, precioInp, fechaVtoInp });
                    }

                        break;
                default:
                    MessageBox.Show("Seleccione una acción válida (Agregar, Eliminar, Actualizar).", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
            controladores.MostrarDatos("spu_mostrar_items", tableItems, new List<string> { }, new List<object> { }, new List<string> { "Código de Item", "Descripción de Item", "Precio (ARS)", "Fecha de Vencimiento" }, 'N');
            int codItem = controladores.getLastID("dbo.spu_Obtener_codItem");
            codItemInp.Text = codItem.ToString();
            sumbitBtn.Text = "-";
            controladores.LimpiarCampos(new List<TextBox> { descItemInp, precioInp, fechaVtoInp });
            status = 'N';
        }
    }
}
