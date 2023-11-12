using Edad_de_persona.Clases;

namespace Edad_de_persona
{
    public partial class Form1 : Form
    {

        private Persona persona;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;

            if (int.TryParse(txtEdad.Text, out int edad))
            {
                persona = new Persona(nombre, edad);

                MessageBox.Show($"Nombre: {persona.Nombre}\nEdad: {persona.Edad}\n\n{persona.VerificarMayorEdad()}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}