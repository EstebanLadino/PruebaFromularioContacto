using PreubaEstebanLadinoDAL;
using PruebaEstebanLadino.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace PruebaEstebanLadino.Controllers
{
    public class ContactoController : ApiController
    {
        // GET api/Contacto
        /// <summary>
        /// Listado completo de tipos de identificación
        /// </summary>
        /// <returns>Listado completo de tipos de identificación.</returns>
        public IEnumerable<spConsultarTiposIdentificacion_Result> Get()
        {
            LogicaContacto objLogicaContacto = new LogicaContacto();
            return objLogicaContacto.ObtenerTiposIdentificacion();
        }

        // POST api/Contacto
        /// <summary>
        /// Metodo para el almacenamiento de un nuevo registro de formulario de contacto.
        /// </summary>
        /// <returns>Estado de la peticion de guardado.</returns>
        public void Post(ContactoVM newContacto)
        {
            LogicaContacto objLogicaContacto = new LogicaContacto();
            objLogicaContacto.AlmacenarContacto(newContacto.nombres, newContacto.apellidos, newContacto.correoElectronico, 
                newContacto.telefono, newContacto.mensaje, newContacto.identificacion, newContacto.idTipoIdent);
        }
    }
}
