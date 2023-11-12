using LadosTriangulo.Clases;

namespace LadosTriangulo
{
    public partial class Form1 : Form
    {

        private InicioTriangulo triangulo;
        private Equilatero equilatero;
        private LadoMayor ladoMayor;

        public Form1()
        {
            InitializeComponent();
            triangulo = new InicioTriangulo();
            ladoMayor = new LadoMayor();
            equilatero = new Equilatero();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btonIngresar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLado1.Text, out double lado1) &&
               double.TryParse(txtLado2.Text, out double lado2) &&
               double.TryParse(txtLado3.Text, out double lado3))
            {
                triangulo.IniciarTriangulo(lado1, lado2, lado3);

                double ladoMayorValor = ladoMayor.Calculo(lado1, lado2, lado3);

                bool siEquilatero = equilatero.SiEquilatero(lado1, lado2, lado3);

                // Mostrar resultados
                MessageBox.Show($"Lado Mayor: {ladoMayorValor}\nEs Equilatero: {siEquilatero}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese datos validos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}