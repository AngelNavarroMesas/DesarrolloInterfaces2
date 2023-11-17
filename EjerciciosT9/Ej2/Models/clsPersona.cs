using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ej2.Models
{
    internal class clsPersona : INotifyPropertyChanged
    {
        #region atributos
        private string nombre;
        private string apellido;
        public event PropertyChangedEventHandler PropertyChanged;
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
                OnpropertyChanged();
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
                OnpropertyChanged();
            }
        }

        public string NombreCompleto
        {
            get { return $"{nombre} {apellido}"; }
        }
        #endregion
        public void OnpropertyChanged([CallerMemberName] string valor = "Angel")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(valor));
        }
    }
}
