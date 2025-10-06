using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_2025.Utilidades
{
    internal class Controladores
    {
        public void openMDIContainers(Form formSelected, Form formPadre)
        {
            formSelected.MdiParent = formPadre;
            formSelected.TopLevel = false;
            formSelected.FormBorderStyle = FormBorderStyle.None;
            formSelected.Dock = DockStyle.Fill;
            formSelected.WindowState = FormWindowState.Normal;
            formSelected.Show();
        }

        public void MostrarDatos(string procedureName, DataGridView tableName, List<String> TitleLists)
        {
            var da = new SqlDataAdapter(procedureName, new Conexion().Connect());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            var dt = new DataTable();
            da.Fill(dt);
            tableName.DataSource = dt;
            foreach (DataGridViewColumn column in tableName.Columns)
            {
                tableName.Columns[column.Index].HeaderText = TitleLists[column.Index];
            }
        }


        public void MostrarDatosV2(string procedureName, DataGridView tableName, List<string> sqlParameters, List<object> parameters, List<String> TitleLists)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < sqlParameters.Count; i++)
                {
                    cmd.Parameters.AddWithValue(sqlParameters[i], parameters[i]);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableName.DataSource = dt;
                foreach (DataGridViewColumn column in tableName.Columns)
                {
                    tableName.Columns[column.Index].HeaderText = TitleLists[column.Index];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void AgregarDatos(string procedureName, List<string> sqlParameters, List<Object> parametros)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < sqlParameters.Count; i++)
                {
                    cmd.Parameters.AddWithValue(sqlParameters[i], parametros[i]);
                }
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("ID ya existente. Por favor, verifique los datos ingresados.", "Error de duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 547:
                        MessageBox.Show("ID no encontrado, porfavor ingrese un ID existente", "Error de referencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 515:
                        MessageBox.Show("No se permiten valores nulos en uno o más campos. Por favor, complete todos los campos requeridos.", "Error de valor nulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 8114:
                        MessageBox.Show("Tipo de dato incorrecto. Por favor, verifique los datos ingresados.", "Error de tipo de dato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("Ocurrió un error al agregar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarDatos(string procedureName, List<string> sqlParameters, List<Object> parametros)
        {
            SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < sqlParameters.Count; i++)
            {
                cmd.Parameters.AddWithValue(sqlParameters[i], parametros[i]);
            }
            cmd.ExecuteNonQuery();
        }

        public void ActualizarDatos(string procedureName, List<string> sqlParameters, List<Object> parametros)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < sqlParameters.Count; i++)
                {
                    cmd.Parameters.AddWithValue(sqlParameters[i], parametros[i]);
                }
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 2627:
                        MessageBox.Show("ID ya existente. Por favor, verifique los datos ingresados.", "Error de duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 547:
                        MessageBox.Show("ID no encontrado, porfavor ingrese un ID existente", "Error de referencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("Ocurrió un error al agregar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int getLastID(string procedureName)
        {
            int lastID = 0;
            SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter outputParam = new SqlParameter("@NextID", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(outputParam);
            cmd.ExecuteNonQuery();

            // Leer el valor del parámetro OUTPUT
            lastID = (int)outputParam.Value;
            cmd.ExecuteNonQuery();

            return lastID;
        }


        public DataTable ObtenerDatosParaReporte(string procedureName)
        {
            var dt = new DataTable();

            using (SqlConnection conn = new Conexion().Connect())
            using (SqlCommand cmd = new SqlCommand(procedureName, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                da.Fill(dt);
            }

            return dt;
        }

        public DataTable ObtenerDatosParaReporteXparametros(string procedureName, List<string> SQLParameters, List<string> Parameters)
        {
            var dt = new DataTable();

            using (SqlConnection conn = new Conexion().Connect())
            using (SqlCommand cmd = new SqlCommand(procedureName, conn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < SQLParameters.Count; i++)
                {
                    cmd.Parameters.AddWithValue(SQLParameters[i], 1);
                }

                da.Fill(dt);
            }

            return dt;
        }


        public bool Logincomparision(DataGridView usersTable, (string, string) userInputs, List<(string, string)> users)
        {
            for (int i = 0; i < (usersTable.RowCount - 1); i++)
            {
                users.Add((usersTable.Rows[i].Cells[0].Value.ToString(), usersTable.Rows[i].Cells[1].Value.ToString()));
            }
            for (int i = 0; i < users.Count; i++)
            {
                if (userInputs.Item1 == users[i].Item1 && userInputs.Item2 == users[i].Item2)
                {
                    return true;
                }
            }
            return false;
        }


        public void LimpiarCampos(List<TextBox> textBoxes)
        {
            foreach (TextBox textBox in textBoxes)
            {
                textBox.Clear();
            }
        }
    }
}

