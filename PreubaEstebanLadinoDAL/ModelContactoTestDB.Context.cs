﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PreubaEstebanLadinoDAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ContactoTestDBEntities : DbContext
    {
        public ContactoTestDBEntities()
            : base("name=ContactoTestDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int spAlmacenarContacto(string nombres, string apellidos, string correoElectronico, string telefono, string mensaje, string identificacion, Nullable<int> idTipoIdent)
        {
            var nombresParameter = nombres != null ?
                new ObjectParameter("Nombres", nombres) :
                new ObjectParameter("Nombres", typeof(string));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("Apellidos", apellidos) :
                new ObjectParameter("Apellidos", typeof(string));
    
            var correoElectronicoParameter = correoElectronico != null ?
                new ObjectParameter("CorreoElectronico", correoElectronico) :
                new ObjectParameter("CorreoElectronico", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var mensajeParameter = mensaje != null ?
                new ObjectParameter("Mensaje", mensaje) :
                new ObjectParameter("Mensaje", typeof(string));
    
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("Identificacion", identificacion) :
                new ObjectParameter("Identificacion", typeof(string));
    
            var idTipoIdentParameter = idTipoIdent.HasValue ?
                new ObjectParameter("IdTipoIdent", idTipoIdent) :
                new ObjectParameter("IdTipoIdent", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAlmacenarContacto", nombresParameter, apellidosParameter, correoElectronicoParameter, telefonoParameter, mensajeParameter, identificacionParameter, idTipoIdentParameter);
        }
    
        public virtual ObjectResult<spConsultarTiposIdentificacion_Result> spConsultarTiposIdentificacion()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spConsultarTiposIdentificacion_Result>("spConsultarTiposIdentificacion");
        }
    }
}