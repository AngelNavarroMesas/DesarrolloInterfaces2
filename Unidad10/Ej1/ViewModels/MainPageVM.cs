using Ej1.Models.DAL;
using Ej1.Models.Entities;
using Ej1.ViewModels.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1.ViewModels
{
    public class MainPageVM : clsVMBase
    {
        #region Atributos
        private DelegateCommand buscarCommand;
        private DelegateCommand eliminarCommand;
        private List<clsPersona> listaPersonas;
        private clsPersona personaSeleccionada;
        private String textoBusqueda;
        #endregion Atributos

        #region Constructores
        public MainPageVM()
        {
            listaPersonas = clsListadoPersonasDAL listadoPersonas;
            buscarCommand = new DelegateCommand(BuscarCommandExecute, buscarCommandCanExecute)
        }
        #endregion

        #region Propiedades
        public DelegateCommand BuscarCommand
        {
            get { return buscarCommand; }
        }
        public DelegateCommand EliminarCommand
        {
            get { return eliminarCommand; }
        }
        public List<clsPersona> ListadoPersonas
        { 
            get { return listaPersonas; }
        }
        public clsPersona PersonaSeleccionada
        {
            set { personaSeleccionada = value; }
        }
        #endregion

        #region Comandos
        private bool eliminarComandoCanExecute()
        {
            bool habilitadoEliminar = false;
            if (personaSeleccionada !=null)
            {
                habilitadoEliminar = true;
            }

            return habilitadoEliminar;
        }

        private void eliminarComandoExecute()
        {
            ListadoPersonas.Remove(personaSeleccionada);
            NotifyPropertyChanged("ListaPersonas");
        }

        private void buscarComandoExecute()
        {
            bool habilitadoBuscar = false;
            if (String.IsNullOrEmpty(textoBusqueda))
            {
                habilitadoBuscar = true;
            }

            return buscarComandoExecute;
        }
        #endregion

        #region Metodos y Funciones

        #endregion
    }
}
