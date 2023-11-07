
namespace NegocioApp.Class
{
    /// <summary>
    /// Objeto creado para el acceso a los datos del formulario de los empleados.
    /// </summary>
    public class NegocioDao
    {
        private List<Negocio> negocios;

        public NegocioDao()
        {
            this.negocios = new List<Negocio> ();
        }

        /// <summary>
        /// Metodo para guardar un empleado
        /// </summary>
        /// <param name="negocio">empleado que desea guardar</param>
        public void Guardar(Negocio negocio)
        {
            if (negocio == null)
            
                throw new ArgumentNullException("Los datos son necesarios");
                
                this.negocios.Add (negocio);
        }

        public List<Negocio> ObtenerDatos()
        {
            return this.negocios;
        }

        /// <summary>
        /// Obtener el detalle del empleado por la fecha de contratacion
        /// </summary>
        /// <param name="fechaContra">fecha de contrato del empleado</param>
        /// <returns>Empleado encontrado a partir de la fecha de contrato</returns>
        public Negocio ObtenerDato(DateTime fechaContra)
        {
            return this.negocios.FirstOrDefault(co => co.FechaContrato == fechaContra);
        }

        /// <summary>
        /// Metodo para obtener el detalle del empleado a partir del codigo.
        /// </summary>
        /// <param name="codigo">codigo del empleado que desea ver el detalle</param>
        /// <returns>Contacto encontrado a partir del codigo.</returns>
        public Negocio ObtenerDato(string codigo)
        {
            return this.negocios.FirstOrDefault(co => co.Codigo == codigo);
        }
    }
}
