using CapaLogica.Servicios;
using System;
using System.Windows.Forms;


namespace CapaPresentacion {
    public partial class FrmLogin:Form {

        private readonly AuthService _authService = new AuthService();
        public FrmLogin() {
            InitializeComponent();
        }

        private void sarauI_PictureBox1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void sarauI_PictureBox2_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            var user = _authService.Login(usuario, contrasena);

            if(user != null) {
                MessageBox.Show($"Bienvenido {user.NombreCompleto} ({user.RolNombre})", "Acceso correcto");
                // Aquí puedes abrir el menú principal o FrmMain
                this.Hide();
                var frmMain = new Form1(); // lo crearemos en el siguiente día
                frmMain.Show();
                //var frmMain = new FrmMain(user); // lo crearemos en el siguiente día
                //frmMain.Show();
            } else {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error");
            }
        }
    }
}
