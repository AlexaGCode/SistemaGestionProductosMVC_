using SistemaGestionProductosMVC.Services;
using SistemaGestionProductosMVC.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionProductosMVC_.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var auth = new AuthService();
            var usuario = auth.Login(txtUsuario.Text.Trim(), txtClave.Text.Trim());

            if (usuario != null)
            {
                SesionUsuario.Actual = usuario;
                this.Hide();
                new FrmGestionProductos().Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }
    }
}
