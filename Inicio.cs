using J1;

namespace LoginSeguro
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Este método puede eliminarse si no lo necesitas
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Este método puede eliminarse si no lo necesitas
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados
            string usuario = txtUsuario.Text;
            string contraseña = txtPassword.Text;

            // Validar credenciales
            if ((usuario == "nestor1" && contraseña == "nestor123") ||
                (usuario == "william1" && contraseña == "william123"))
            {
                Epic inicioForm = new Epic();
                inicioForm.Show(); // MOSTRAR el formulario

                this.Hide(); // Opcional: ocultar en vez de cerrar el login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);

                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }


        private void chkMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            // Si el checkbox está marcado, mostrar la contraseña
            if (chkMostrarContraseña.Checked)
            {
                txtPassword.PasswordChar = '\0'; // Carácter nulo (mostrar texto)
                chkMostrarContraseña.Text = "Ocultar contraseña";
            }
            else
            {
                txtPassword.PasswordChar = '•'; // Carácter de punto medio
                chkMostrarContraseña.Text = "Mostrar contraseña";
            }
        }

        private void LoginSeguro_Load(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}