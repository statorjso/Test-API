﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceLibrary.DataContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ExperimentationDBEntities : DbContext
    {
        public ExperimentationDBEntities()
            : base("name=ExperimentationDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Make> Makes { get; set; }
        public virtual DbSet<Model> Models { get; set; }
    
        public virtual ObjectResult<GetCountries_Result> GetCountries()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCountries_Result>("GetCountries");
        }
    
        public virtual ObjectResult<GetModels_Result> GetModels(Nullable<int> makeId)
        {
            var makeIdParameter = makeId.HasValue ?
                new ObjectParameter("MakeId", makeId) :
                new ObjectParameter("MakeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetModels_Result>("GetModels", makeIdParameter);
        }
    }
}
