﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace crud_oper
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class db_crudEntities : DbContext
    {
        public db_crudEntities()
            : base("name=db_crudEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<employee> employees { get; set; }
    
        public virtual int sp_insert(string na, Nullable<int> ag, string dec)
        {
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            var agParameter = ag.HasValue ?
                new ObjectParameter("ag", ag) :
                new ObjectParameter("ag", typeof(int));
    
            var decParameter = dec != null ?
                new ObjectParameter("dec", dec) :
                new ObjectParameter("dec", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insert", naParameter, agParameter, decParameter);
        }
    
        public virtual ObjectResult<sp_read_Result> sp_read(string na, Nullable<int> ag, string dec)
        {
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            var agParameter = ag.HasValue ?
                new ObjectParameter("ag", ag) :
                new ObjectParameter("ag", typeof(int));
    
            var decParameter = dec != null ?
                new ObjectParameter("dec", dec) :
                new ObjectParameter("dec", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_read_Result>("sp_read", naParameter, agParameter, decParameter);
        }
    
        public virtual int sp_update(Nullable<int> id, string na, Nullable<int> ag, string dec)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var naParameter = na != null ?
                new ObjectParameter("na", na) :
                new ObjectParameter("na", typeof(string));
    
            var agParameter = ag.HasValue ?
                new ObjectParameter("ag", ag) :
                new ObjectParameter("ag", typeof(int));
    
            var decParameter = dec != null ?
                new ObjectParameter("dec", dec) :
                new ObjectParameter("dec", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_update", idParameter, naParameter, agParameter, decParameter);
        }

        internal object sp_read(string v)
        {
            throw new NotImplementedException();
        }
    }
}
