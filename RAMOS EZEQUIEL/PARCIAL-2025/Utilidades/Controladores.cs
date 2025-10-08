using PARCIAL_2025.Clases;
using PARCIAL_2025.Formularios;
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

        public void MostrarDatos(string procedureName, DataGridView tableName, List<string> sqlParameters, List<object> parameters, List<String> TitleLists, char mode)
        {
            if(mode == 'N')
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al buscar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
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
        }


        public void subirDatos(string procedureName, List<string> sqlParameters, List<Object> parametros, char mode)
        {
            if (mode == 'A')
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
            else if (mode == 'E' || mode == 'U')
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
                    if (mode == 'E')
                    {
                        switch (ex.Number)
                        {
                            case 547:
                                MessageBox.Show("ID no encontrado, porfavor ingrese un ID existente", "Error de referencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            default:
                                MessageBox.Show("Ocurrió un error al eliminar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                    else
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
                                MessageBox.Show("Ocurrió un error al modificar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

            lastID = (int)outputParam.Value;
            cmd.ExecuteNonQuery();

            return lastID;
        }


        public DataTable getData(string procedureName, List<string> SQLParameters, List<string> Parameters, char mode)
        {
            if (mode == 'N')
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al obtener los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
                    cmd.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < SQLParameters.Count; i++)
                    {
                        cmd.Parameters.AddWithValue(SQLParameters[i], Parameters[i]);
                    }
                    var response = cmd.ExecuteNonQuery();
                    System.Diagnostics.Debug.WriteLine("RESPUESTA: " + response);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al obtener los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }


        public bool Logincomparision(string procedureName, List<string> parametersSQL, List<Object> parametros)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(procedureName, new Conexion().Connect());
                cmd.CommandType = CommandType.StoredProcedure;
                for (int i = 0; i < parametersSQL.Count; i++)
                {
                    cmd.Parameters.AddWithValue(parametersSQL[i], parametros[i]);
                }
                int respose = Convert.ToInt32(cmd.ExecuteScalar());

                if (respose > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
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

