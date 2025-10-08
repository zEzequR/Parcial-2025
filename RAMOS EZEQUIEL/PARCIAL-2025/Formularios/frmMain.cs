using PARCIAL_2025.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_2025.Formularios
{
    public partial class frmMain : Form
    {
        Controladores controladores = new Controladores();
        Conexion conexion = new Conexion();
        public frmMain()
        {
            InitializeComponent();
        }

        private void itemsBtn_Click(object sender, EventArgs e)
        {
            controladores.openMDIContainers(new frmItems(), this);
        }

        private void depBtn_Click(object sender, EventArgs e)
        {
            controladores.openMDIContainers(new frmDepositos(), this);
        }

        private void itemsDepBtn_Click(object sender, EventArgs e)
        {
            controladores.openMDIContainers(new frmItemsDeposito(), this);
        }

        private void itemsImprimir_Click(object sender, EventArgs e)
        {
            controladores.openMDIContainers(new frmImprimirItems(), this);
        }

        private void depImprimir_Click(object sender, EventArgs e)
        {
            controladores.openMDIContainers(new frmImprimirDepositos(), this);
        }

        private void stockImprimir_Click(object sender, EventArgs e)
        {
            controladores.openMDIContainers(new frmImprimirStock('T', new List<string> { }), this);
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            DialogResult response = MessageBox.Show("¿Está seguro de que quiere salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (response == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            string procedureName = "spu_backup";
            try
            {
                SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Backup realizado con éxito.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocurrió un error al realizar el backup: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
