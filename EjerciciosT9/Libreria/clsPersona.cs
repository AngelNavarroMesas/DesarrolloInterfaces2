using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class clsPersona
    {
        #region atributos
        private string nombre;
        private string apellido;
        #endregion

        #region constructores
        public clsPersona()
        {
            nombre = "Angel";
            apellido = "Navarro";
        }

        public clsPersona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
            }
        }

        public string NombreCompleto
        {
            get { return $"{nombre} {apellido}"; }
        }
        #endregion
    }
}
