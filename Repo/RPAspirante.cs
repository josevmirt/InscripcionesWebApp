using InscripcionesWebApp.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InscripcionesWebApp.Repo
{
    public class RPAspirante
    {


        public bool VerificarDatos( Aspirante item)
        {
            
            if (item.Edad >99 || item.Edad <0)
            {
                return true;
            }

            if (!item.Nombre.All(char.IsLetter))
            {
                return true;
            }
            if (!item.Apellido.All(char.IsLetter))
            {
                return true;
            }
            if (item.Casa != "Gryffindor" & item.Casa != "Hufflepuff" & item.Casa != "Ravenclaw" & item.Casa != "Slytherin")
            {
                return true;
            }

            return false;
        }

    }
}
