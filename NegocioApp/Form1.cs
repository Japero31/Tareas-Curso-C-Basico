using NegocioApp.Class;

namespace NegocioApp
{
    public partial class Form1 : Form
    {
        NegocioDao negocioDao;
        public Form1()
        {
            this.negocioDao = new NegocioDao();
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Negocio newEmpleado = new Negocio()
            {
                Nombres = txtnombre.Text,
                Apellidos = txtapellido.Text,
                Codigo = txtcode.Text,
                Correo = txtcorreo.Text,
                Direccion = txtdireccion.Text,
                Departamento = txtdepa.Text,
                Posicion = txtposicion.Text,
                FechaContrato = dtpcontra.Value,
                Telefono = txttelefono.Text
            };

            this.negocioDao.Guardar(newEmpleado);

            var negocios = this.negocioDao.ObtenerDatos();

            this.dgvempleados.DataSource = negocios.ToArray();
            this.dgvempleados.Refresh();

            Limpiar();
        }

        void Limpiar()
        {
            txtapellido.Text = string.Empty;
            txtcorreo.Text = string.Empty;
            txtdepa.Text = string.Empty;
            txtdireccion.Text = string.Empty;
            txtnombre.Text = string.Empty;
            txtposicion.Text = string.Empty;
            txttelefono.Text = string.Empty;
            dtpcontra.Value = DateTime.Now;
            txtcode.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}