
namespace NegocioApp.Class
{
    public class Negocio
    {
        #region "atributos o campos de nuestra clase"
        private string _name;
        private string _lastname;
        private string _mail;
        private string _phone;
        private string _position;
        private string _address;
        private string _deparment;
        private DateTime _datein;

        #endregion


        /// <summary>
        /// Codigo del empleado
        /// </summary>
        public string Codigo { get; set; }

        /// <summary>
        /// Esta propiedad es para almacenar los nombres del empleoado.
        /// </summary>
        public string Nombres
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Esta propiedad es para almacenar los apellidos del empleado.
        /// </summary>
        public string Apellidos { 
            
            get { return _lastname; }
            set { _lastname = value; }
        }

        /// <summary>
        /// Correo del empleado
        /// </summary>
        public string Correo
        {
            get { return _mail; }
            set { _mail = value; }
        }

        /// <summary>
        /// Telefono del empleado
        /// </summary>
        public string Telefono { 
            
            get { return _phone; }
            set { _phone = value; }
        
        }

        /// <summary>
        /// Posicion del empleado
        /// </summary>
        public string Posicion
        {
            get { return _position; }
            set { _position = value; }
        }

        /// <summary>
        /// Direccion del empleado
        /// </summary>
        public string Direccion
        {
            get { return _address; }
            set { _address = value; }
        }

        /// <summary>
        /// Departamento del empleado
        /// </summary>
        public string Departamento
        {
            get { return _deparment; }

            set { _deparment = value; }
        }

        /// <summary>
        /// Fecha de contratacion del empleado
        /// </summary>
        public DateTime FechaContrato
        {
            get { return _datein; }
            set { _datein = value; }
        } 

        public string FullName
        {
            get { return string.Concat(this._name, " ", this._lastname); }
        }
    }
}
