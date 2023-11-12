using Operaciones.Clases;

namespace Operaciones
{
    public partial class Form1 : Form
    {

        private Operadores operadores;

        public Form1()
        {
            InitializeComponent();
            operadores = new Operadores();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Operations(() => operadores.Suma());
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Operations(() => operadores.Division());
        }

        private void Operations(Func<double> operacion)
        {
            try
            {
                int valor1 = int.Parse(txtValor1.Text);
                int valor2 = int.Parse(txtValor2.Text);

                operadores.CargarValores(valor1, valor2);

                double resultado = operacion.Invoke();
                MessageBox.Show($"Resultado: {resultado}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese valores enteros válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Operations(() => operadores.Producto());
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Operations(() => operadores.Resta());
        }
    }
}