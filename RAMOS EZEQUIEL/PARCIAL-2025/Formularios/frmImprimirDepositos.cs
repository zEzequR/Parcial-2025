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
    public partial class frmImprimirDepositos : Form
    {
        Controladores controladores = new Controladores();
        public frmImprimirDepositos()
        {
            InitializeComponent();
        }

        private void frmImprimirDepositos_Load(object sender, EventArgs e)
        {

            this.rptViewverDep.RefreshReport();

            this.rptViewverDep.RefreshReport();
            DataTable dt = controladores.ObtenerDatosParaReporte("spu_mostrar_depositos");

            this.rptViewverDep.Reset();
            this.rptViewverDep.ProcessingMode = ProcessingMode.Local;

            this.rptViewverDep.LocalReport.ReportEmbeddedResource = "PARCIAL_2025.Reportes.RptDepositos.rdlc";

            this.rptViewverDep.LocalReport.DataSources.Clear();
            this.rptViewverDep.LocalReport.DataSources.Add(new ReportDataSource("dsDepósitos", dt));
            this.rptViewverDep.RefreshReport();
        }
    }
}
