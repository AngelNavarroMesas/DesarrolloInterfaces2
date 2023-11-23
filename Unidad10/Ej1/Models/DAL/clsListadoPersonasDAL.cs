using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej1.Models.Entities;

namespace Ej1.Models.DAL
{
    public class clsListadoPersonasDAL
    {
        public List<clsPersona> listadoPersona()
        {
            /// <summary>
            /// Función que nos devuelve un listado de todas las personas
            /// </summary>
            /// <returns>listaPersonas</returns>
            List<clsPersona> listaPersonas = new List<clsPersona>()
        {
            new clsPersona(1,"Teniente", "Dan","",10),
            new clsPersona(2,"Angel", "Navarro","",9),
            new clsPersona(3,"Fernando", "Galiana","",8),
            new clsPersona(4,"Antonio", "Navarro","",7),
            new clsPersona(5,"Fernando", "Miguel","",6),
            new clsPersona(6,"Juanma", "Sanchez","",5),
            new clsPersona(7,"Yeray", "Jimenez","",4),
            new clsPersona(8,"Ruben", "Lindes","",3),
            new clsPersona(9,"Javier", "Sequera","",2),
            new clsPersona(10,"David", "Perea","",1)
        };
            return listaPersonas;
        }
    }
}


