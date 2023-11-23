using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.Models.Entities
{
    public class clsPersona
    {
        #region atributos
        private int id;
        private string nombre;
        private string apellido;
        private string telefono;
        private string direccion;
        private string foto;
        private DateTime fechaNacimiento;
        private int idDepartamento;
        #endregion

        #region constructores
        public clsPersona()
        {
            this.nombre = "Angel";
            this.apellido = "Navarro";
            this.telefono = "123456789";
            this.direccion = "";
            this.foto = "";
            this.fechaNacimiento = new DateTime();
            this.idDepartamento = 0;
        }

        public clsPersona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public clsPersona(int id,string nombre, string apellido, string telefono, int idDepartamento)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.idDepartamento = idDepartamento;
        }

        public clsPersona(string nombre, string apellido, string telefono, string direccion, string foto, DateTime fechaNacimiento, int idDepartamento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.foto = foto;
            this.fechaNacimiento = fechaNacimiento;
            this.idDepartamento = idDepartamento;
        }
        #endregion

        #region propiedades
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public String NombreCompleto
        {
            get { return $"{nombre} {apellido}"; }
        }
        #endregion
    }
}
