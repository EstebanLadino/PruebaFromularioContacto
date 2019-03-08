using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreubaEstebanLadinoDAL
{
    public class LogicaContacto
    {
        protected ContactoTestDBEntities Context = new ContactoTestDBEntities();

        public List<spConsultarTiposIdentificacion_Result> ObtenerTiposIdentificacion() {
            try
            {
                return Context.spConsultarTiposIdentificacion().ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AlmacenarContacto(string nombres, string apellidos, string correoElectronico, string telefono, string mensaje, string identificacion, Nullable<int> idTipoIdent)
        {
            try
            {
                return Context.spAlmacenarContacto(nombres, apellidos, correoElectronico, telefono, mensaje, identificacion, idTipoIdent);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
