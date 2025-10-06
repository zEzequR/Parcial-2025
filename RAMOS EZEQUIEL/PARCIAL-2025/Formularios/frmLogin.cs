using PARCIAL_2025.Formularios;
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

namespace PARCIAL_2025
{
    public partial class frmLogin : Form
    {
        char status = 'A';
        Controladores controladores = new Controladores();
        Conexion conexion = new Conexion();
        public frmLogin()
        {
            InitializeComponent();
            conexion.Connect();
            controladores.MostrarDatos("spu_mostrar_usuarios", usersTable, new List<string> {"Nombre de usuario", "Contraseña"});
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            var userInps = (userInp.Text, passwrdInp.Text);
            var users = new List<(string, string)>();
            bool response = controladores.Logincomparision(usersTable, userInps, users);
            if (response)
            {
                MessageBox.Show("Bienvenido " + userInp.Text, "Sesión inicada con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                controladores.LimpiarCampos(new List<TextBox> { userInp, passwrdInp });
                frmMain main = new frmMain();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Por favor, intente nuevamente.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                controladores.LimpiarCampos(new List<TextBox> { userInp, passwrdInp });
            }
        }

        private void seePswBtn_Click(object sender, EventArgs e)
        {
            if (status == 'A')
            {
                passwrdInp.UseSystemPasswordChar = false;
                status = 'D';
                seePswBtn.Image = Image.FromFile(@"C:\Users\EZEQUIELEITOR\source\repos\PARCIAL 2025\RAMOS EZEQUIEL\PARCIAL-2025\Img\desactivar.png");
            }
            else
            {
                passwrdInp.UseSystemPasswordChar = true;
                seePswBtn.Image = Image.FromFile(@"C:\Users\EZEQUIELEITOR\source\repos\PARCIAL 2025\RAMOS EZEQUIEL\PARCIAL-2025\Img\activar.png");
                status = 'A';
            }
        }
    }
}
