using CapaEntidades.EntidadesA;
using CapaNegocio;
using System.ComponentModel;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
                 
        }

        private void Login_Load(object sender, EventArgs e)
        {
            textbPassword.UseSystemPasswordChar = true;
        }
        private void BuIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios usuarios = new Usuarios();
                usuarios.Username = textbUsername.Text;
                usuarios.PasswordHash = textbPassword.Text;
                bool resultado = LogicaNegocio.ValidarUsario(usuarios);
                if (resultado)
                {
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                    this.Hide();     
                }
                else
                {
                    MessageBox.Show("Email o Contraseña incorrecta", "Credenciales no validas",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Fallo en la operación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textbUsername.Text))
            {
                errorProviderLogin.SetError(this.textbUsername, "El campo de Username no puede estar vacio");
            }
            else
            {
                errorProviderLogin.Clear();
            }
        }

        private void textbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textbPassword.Text))
            {
                errorProviderLogin.SetError(this.textbPassword, "El campo de Password no puede estar vacio");
            }
            else
            {
                errorProviderLogin.Clear();
            }
        }

        private void checkViewPass_CheckedChanged(object sender, EventArgs e)
        {
            textbPassword.UseSystemPasswordChar = !checkViewPass.Checked;
        }
    }
}
