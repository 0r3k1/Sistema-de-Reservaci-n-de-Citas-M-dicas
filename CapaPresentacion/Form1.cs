using CapaDatos.Database;

namespace CapaPresentacion {
    public partial class Form1:Form {
        public Form1() {
            InitializeComponent();
            InicializarBaseDatos();
        }

        private void InicializarBaseDatos() {
            try {
                InicializarDB.CrearTablas();
                MessageBox.Show("Base de datos inicializada correctamente.", "Éxito");
            } catch(Exception ex) {
                MessageBox.Show("Error al inicializar la base de datos: " + ex.Message);
            }
        }
    }
}
