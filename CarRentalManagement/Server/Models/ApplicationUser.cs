using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        //Estos campos se agregaron para demostrar que se puede ampliar los datos de los usaurios que acceden a la app.
        //Además también sirven para evidenciar que luego de creada la DB se puede ampliar los campos de las entidades de clase
        //y luego se actualzian las correspondientes tablas en la DB mediante una migración
        public string FistName { get; set; }
        public string LastName { get; set; }
    }
}
