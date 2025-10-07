using PARCIAL_2025.Clases;
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
        Usuario usuario = new Usuario();
        public frmLogin()
        {
            InitializeComponent();
            conexion.Connect();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(passwrdInp.Text, out int psw))
            {
                usuario = usuario.setUsuario(userInp.Text, psw);
                bool response = controladores.Logincomparision("spu_login_usuarios", new List<string> { "@usuario", "psw" }, new List<Object> { usuario.usuario ,usuario.clave});
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
            else
            {
                MessageBox.Show("La contraseña deben ser números. Por favor, intente nuevamente.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                controladores.LimpiarCampos(new List<TextBox> { userInp, passwrdInp });
                return;
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
