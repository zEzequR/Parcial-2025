using PARCIAL_2025.Clases;
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
    public partial class frmItemsDeposito : Form
    {
        char status = 'N';
        char mode = 'N';
        Clases.Items_Depositos itemDeposito = new Clases.Items_Depositos();
        Controladores controladores = new Controladores();
        Conexion conexion = new Conexion();
        public frmItemsDeposito()
        {
            InitializeComponent();
            controladores.MostrarDatos("spu_mostrar_items_depositos", tableItemsDepositos, new List<string> { }, new List<object> { } ,new List<string> { "Código de Ítem", "Descripción de Ítem", "Número de Depósito", "Nombre de Depósito", "Cantidad" }, 'N');
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if ((status == 'N' || status == 'E' || status == 'U') || status == 'A')
            {
                status = 'A';
                sumbitBtn.Text = "Guardar";
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
            }
            else
            {
                sumbitBtn.Text = "-";
            }
        }


        private void tableItemsDepositos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            numItemInp.Text = tableItemsDepositos.CurrentRow.Cells[0].Value.ToString();
            numDepInp.Text = tableItemsDepositos.CurrentRow.Cells[2].Value.ToString();
            cantInp.Text = tableItemsDepositos.CurrentRow.Cells[4].Value.ToString();
        }

        private void sumbitBtn_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case 'A':
                    if (int.TryParse(numItemInp.Text, out int numItem_Inp) && int.TryParse(numDepInp.Text, out int numDep_Inp) && int.TryParse(cantInp.Text, out int cant_Inp))
                    {
                        itemDeposito = itemDeposito.setItems_Depositos(numItem_Inp, numDep_Inp, cant_Inp);
                        controladores.subirDatos("spu_cargar_items_deposito", new List<string> { "@cod_item", "@nro_deposito", "@cantidad" },
                            new List<Object> { itemDeposito.cod_item, itemDeposito.nro_deposito, itemDeposito.cantidad }, 'A');
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese datos válidos en todos los campos.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        controladores.LimpiarCampos(new List<System.Windows.Forms.TextBox> { numItemInp, numDepInp, cantInp });
                    }
                    break;
                case 'E':
                    if (int.TryParse(numItemInp.Text, out int itemNum) && int.TryParse(numDepInp.Text, out int depNum))
                    {
                        itemDeposito = itemDeposito.setItems_Depositos(itemNum, depNum, int.TryParse(cantInp.Text, out int cantidadInp) ? cantidadInp : 0);
                        controladores.subirDatos("spu_eliminar_items_depositos", new List<string> { "@cod_item", "@nro_deposito"},
                            new List<Object> { itemDeposito.cod_item, itemDeposito.nro_deposito}, 'E');
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese los ID´s válidos o seleccione en la tabla el elemento que quiere eliminar", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        controladores.LimpiarCampos(new List<System.Windows.Forms.TextBox> { numItemInp, numDepInp, cantInp });
                    }

                    break;
                case 'U':
                    if (int.TryParse(numItemInp.Text, out int parsedNumItemInp) && int.TryParse(numDepInp.Text, out int parsedNumDepInp) && int.TryParse(cantInp.Text, out int parsedCantInp))
                    {
                        itemDeposito = itemDeposito.setItems_Depositos(parsedNumItemInp, parsedNumDepInp, parsedCantInp);
                        controladores.subirDatos("spu_update_items_depositos", new List<string> { "@cod_item", "@nro_deposito", "@cantidad" },
                            new List<Object> { itemDeposito.cod_item, itemDeposito.nro_deposito, itemDeposito.cantidad }, 'U');
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese datos válidos en todos los campos.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        controladores.LimpiarCampos(new List<System.Windows.Forms.TextBox> { numItemInp, numDepInp, cantInp });
                    }
                    break;
                default:
                    MessageBox.Show("Seleccione una acción válida (Agregar, Eliminar, Actualizar).", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
            controladores.MostrarDatos("spu_mostrar_items_depositos", tableItemsDepositos, new List<string> { }, new List<object> { }, new List<string> { "Código de Ítem", "Descripción de Ítem", "Número de Depósito", "Nombre de Depósito", "Cantidad" }, 'N');
            controladores.LimpiarCampos(new List<System.Windows.Forms.TextBox> { numItemInp, numDepInp, cantInp });
            sumbitBtn.Text = "-";
            status = 'N';
        }

        private void verXitemsBtn_Click(object sender, EventArgs e)
        {
            mode = 'I';
            if (int.TryParse(verXitemInp.Text, out int verXItem))
            {
                controladores.MostrarDatos("spu_mostrar_itemsdepositos_x_items", tableItemsDepositos,
                    new List<string> { "@cod_item" },
                    new List<object> { verXItem },
                    new List<string> { "Código de Ítem", "Descripción de Ítem", "Número de Depósito", "Nombre de Depósito", "Cantidad" },
                    'P');
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de ítem válido", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                controladores.LimpiarCampos(new List<System.Windows.Forms.TextBox> { verXitemInp });
            }

        }

        private void verXdepBtn_Click(object sender, EventArgs e)
        {
            mode = 'D';
            if (int.TryParse(verXDepInp.Text, out int verXDep))
            {
                controladores.MostrarDatos("spu_mostrar_itemsdepositos_x_depositos", tableItemsDepositos,
                    new List<string> { "@num_dep" },
                    new List<object> { verXDep },
                    new List<string> { "Código de Ítem", "Descripción de Ítem", "Número de Depósito", "Nombre de Depósito", "Cantidad" }, 'P');
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de depósito válido", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                controladores.LimpiarCampos(new List<System.Windows.Forms.TextBox> { verXDepInp });
            }
        }

        private void verXitemsYdep_Click(object sender, EventArgs e)
        {
            mode = '2';
            if (int.TryParse(verXitemInp.Text, out int verXItem) && int.TryParse(verXDepInp.Text, out int verXDep))
            {
                controladores.MostrarDatos("spu_mostrar_itemsdepositos_x_dos", tableItemsDepositos,
                    new List<string> { "@cod_item", "@num_dep" },
                    new List<object> { verXItem, verXDep },
                    new List<string> { "Código de Ítem", "Descripción de Ítem", "Número de Depósito", "Nombre de Depósito", "Cantidad" },
                    'P');
                
            }
            else
            {
                MessageBox.Show("Por favor, ingrese los ID´s válidos", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                controladores.LimpiarCampos(new List<System.Windows.Forms.TextBox> { verXitemInp, verXDepInp });
            }
        }

        private void verTodosBtn_Click(object sender, EventArgs e)
        {
            mode = 'T';
            controladores.MostrarDatos("spu_mostrar_items_depositos", tableItemsDepositos, new List<string> { }, new List<object> { }, new List<string> { "Código de Ítem", "Descripción de Ítem", "Número de Depósito", "Nombre de Depósito", "Cantidad" }, 'N');
            controladores.LimpiarCampos(new List<System.Windows.Forms.TextBox> { verXitemInp, verXDepInp });
        }

        private void imprimirBtn_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 'I':
                    frmImprimirStock imprimirStockXItems = new frmImprimirStock('I', new List<string> { verXitemInp.Text });
                    imprimirStockXItems.ShowDialog();
                    controladores.LimpiarCampos(new List<System.Windows.Forms.TextBox> { verXitemInp });
                    break;
                case 'D':
                    frmImprimirStock imprimirStockXDepositos = new frmImprimirStock('D', new List<string> { verXDepInp.Text });
                    imprimirStockXDepositos.ShowDialog();
                    controladores.LimpiarCampos(new List<System.Windows.Forms.TextBox> { verXDepInp });
                    break;
                case '2':
                    frmImprimirStock imprimirStockXItemsyDepositos = new frmImprimirStock('2', new List<string> { verXitemInp.Text, verXDepInp.Text });
                    imprimirStockXItemsyDepositos.ShowDialog();
                    controladores.LimpiarCampos(new List<System.Windows.Forms.TextBox> { verXitemInp, verXDepInp });
                    break;
                case 'T':
                    frmImprimirStock imprimirStock = new frmImprimirStock('T', new List<string> {  });
                    imprimirStock.ShowDialog();
                    break;
                default:
                    frmImprimirStock imprimir_Stock = new frmImprimirStock('T', new List<string> { });
                    imprimir_Stock.ShowDialog();
                    break;
            }
        }

        private void verItemsBtn_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Está seguro de que quiere ver todos los ítems?", "Ver Ítems", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (response == DialogResult.Yes)
            {
                frmImprimirItems frmImprimirItems = new frmImprimirItems();
                frmImprimirItems.ShowDialog();
            }

        }

        private void verDepositosBtn_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("Está seguro de que quiere ver todos los Depósitos?", "Ver Depósitos", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (response == DialogResult.Yes)
            {
                frmImprimirDepositos frmImprimirDepositos = new frmImprimirDepositos();
                frmImprimirDepositos.ShowDialog();
            }
        }
    }
}
