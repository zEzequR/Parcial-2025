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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PARCIAL_2025.Formularios
{
    public partial class frmDepositos : Form
    {
        char status = 'N';
        Clases.Depositos deposito = new Clases.Depositos();
        Controladores controladores = new Controladores();
        Conexion conexion = new Conexion();
        public frmDepositos()
        {
            InitializeComponent();
            conexion.Connect();
            controladores.MostrarDatos("spu_mostrar_depositos", tableDepositos, new List<string> { "Número de Depósito", "Nombre de Depósito" });
            int nroDep = controladores.getLastID("dbo.spu_Obtener_ID_Deposito");
            numDepInp.Text = nroDep.ToString();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if ((status == 'N' || status == 'E' || status == 'U') || status == 'A')
            {
                status = 'A';
                sumbitBtn.Text = "Guardar";
                nomDepInp.ReadOnly = false;
                int nroDep = controladores.getLastID("dbo.spu_Obtener_ID_Deposito");
                numDepInp.Text = nroDep.ToString();
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
                nomDepInp.ReadOnly = true;
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
                nomDepInp.ReadOnly = false;
            }
            else
            {
                sumbitBtn.Text = "-";
            }
        }


        private void tableDepositos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            numDepInp.Text = tableDepositos.Rows[e.RowIndex].Cells[0].Value.ToString();
            nomDepInp.Text = tableDepositos.Rows[e.RowIndex].Cells[1].Value.ToString();
            deposito = deposito.setDepositos(Convert.ToInt32(numDepInp.Text), nomDepInp.Text);
        }


        private void sumbitBtn_Click(object sender, EventArgs e)
        {
            switch (status)
            {
                case 'A':
                    deposito = deposito.setDepositos(int.Parse(numDepInp.Text), nomDepInp.Text);
                    controladores.AgregarDatos("spu_cargar_depositos", new List<string> { "@nro_deposito", "@nombre_deposito" }, new List<Object> { deposito.nro_deposito, deposito.nombre_deposito });
                    break;
                case 'E':
                    deposito = deposito.setDepositos(int.Parse(numDepInp.Text), nomDepInp.Text);
                    controladores.EliminarDatos("spu_eliminar_deposito", new List<string> { "@nro_deposito" }, new List<Object> { deposito.nro_deposito });
                    break;
                case 'U':
                    deposito = deposito.setDepositos(int.Parse(numDepInp.Text), nomDepInp.Text);
                    controladores.ActualizarDatos("spu_modificar_deposito", new List<string> { "@nro_deposito", "@nombre_deposito" }, new List<Object> { deposito.nro_deposito, deposito.nombre_deposito });
                    break;
                default:
                    MessageBox.Show("Seleccione una acción válida (Agregar, Eliminar, Actualizar).", "Acción inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
            controladores.MostrarDatos("spu_mostrar_depositos", tableDepositos , new List<string> { "Número de Depósito", "Nombre de Depósito" });
            int codItem = controladores.getLastID("dbo.spu_Obtener_ID_Deposito");
            numDepInp.Text = codItem.ToString();
            sumbitBtn.Text = "-";
            controladores.LimpiarCampos(new List<System.Windows.Forms.TextBox> { nomDepInp });
            status = 'N';
        }
    }
}
