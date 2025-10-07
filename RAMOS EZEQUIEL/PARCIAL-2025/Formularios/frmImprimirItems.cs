using Microsoft.Reporting.WinForms;
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
    public partial class frmImprimirItems : Form
    {
        Controladores controladores = new Controladores();
        public frmImprimirItems()
        {
            InitializeComponent();
        }

        private void frmImprimirItems_Load(object sender, EventArgs e)
        {

            this.rptViewverItems.RefreshReport();
            DataTable dt = controladores.getData("spu_mostrar_items", new List<string> { }, new List<string> { }, 'N');

            this.rptViewverItems.Reset();
            this.rptViewverItems.ProcessingMode = ProcessingMode.Local;

            this.rptViewverItems.LocalReport.ReportEmbeddedResource = "PARCIAL_2025.Reportes.RptItems.rdlc";

            this.rptViewverItems.LocalReport.DataSources.Clear();
            this.rptViewverItems.LocalReport.DataSources.Add(new ReportDataSource("dsItems", dt)); 
            this.rptViewverItems.RefreshReport();
        }
    }
}
