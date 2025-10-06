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
    public partial class frmImprimirStock : Form
    {
        Controladores controladores = new Controladores();
        public frmImprimirStock(char mode, List<string> parameters)
        {
            InitializeComponent();
            switch (mode)
            {
                case 'I':
                    this.rptViewverStock.RefreshReport();
                    DataTable dtI = controladores.ObtenerDatosParaReporteXparametros("spu_mostrar_itemsdepositos_x_items", 
                        new List<string> { "@cod_item" },
                        parameters);

                    this.rptViewverStock.Reset();
                    this.rptViewverStock.ProcessingMode = ProcessingMode.Local;

                    this.rptViewverStock.LocalReport.ReportEmbeddedResource = "PARCIAL_2025.Reportes.RptStock.rdlc";

                    this.rptViewverStock.LocalReport.DataSources.Clear();
                    this.rptViewverStock.LocalReport.DataSources.Add(new ReportDataSource("dsStock", dtI));
                    this.rptViewverStock.RefreshReport();
                    break;
                case 'D':
                    this.rptViewverStock.RefreshReport();
                    DataTable dtD = controladores.ObtenerDatosParaReporteXparametros("spu_mostrar_itemsdepositos_x_depositos",
                        new List<string> { "@num_dep" },
                        parameters);

                    this.rptViewverStock.Reset();
                    this.rptViewverStock.ProcessingMode = ProcessingMode.Local;

                    this.rptViewverStock.LocalReport.ReportEmbeddedResource = "PARCIAL_2025.Reportes.RptStock.rdlc";

                    this.rptViewverStock.LocalReport.DataSources.Clear();
                    this.rptViewverStock.LocalReport.DataSources.Add(new ReportDataSource("dsStock", dtD));
                    this.rptViewverStock.RefreshReport();
                    break;
                case '2':
                    this.rptViewverStock.RefreshReport();
                    DataTable dt2 = controladores.ObtenerDatosParaReporteXparametros("spu_mostrar_itemsdepositos_x_dos",
                        new List<string> { "@cod_item", "@num_dep" },
                        parameters);

                    this.rptViewverStock.Reset();
                    this.rptViewverStock.ProcessingMode = ProcessingMode.Local;

                    this.rptViewverStock.LocalReport.ReportEmbeddedResource = "PARCIAL_2025.Reportes.RptStock.rdlc";

                    this.rptViewverStock.LocalReport.DataSources.Clear();
                    this.rptViewverStock.LocalReport.DataSources.Add(new ReportDataSource("dsStock", dt2));
                    this.rptViewverStock.RefreshReport();
                    break;
                case 'T':
                    this.rptViewverStock.RefreshReport();
                    DataTable dt = controladores.ObtenerDatosParaReporte("spu_mostrar_items_depositos");

                    this.rptViewverStock.Reset();
                    this.rptViewverStock.ProcessingMode = ProcessingMode.Local;

                    this.rptViewverStock.LocalReport.ReportEmbeddedResource = "PARCIAL_2025.Reportes.RptStock.rdlc";

                    this.rptViewverStock.LocalReport.DataSources.Clear();
                    this.rptViewverStock.LocalReport.DataSources.Add(new ReportDataSource("dsStock", dt));
                    this.rptViewverStock.RefreshReport();
                    break;
                default:
                    MessageBox.Show("Por favor, seleccione un modo de visualización antes de imprimir.", "Modo no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
