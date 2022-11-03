﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class InfiniteDBEntities : DbContext
    {
        public InfiniteDBEntities()
            : base("name=InfiniteDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductSale> ProductSales { get; set; }
        public virtual DbSet<project> projects { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_Department> tbl_Department { get; set; }
        public virtual DbSet<tbl_Employee> tbl_Employee { get; set; }
        public virtual DbSet<dummy> dummies { get; set; }
    
        [DbFunction("InfiniteDBEntities", "GetEmployeeByname")]
        public virtual IQueryable<GetEmployeeByname_Result> GetEmployeeByname(Nullable<int> did)
        {
            var didParameter = did.HasValue ?
                new ObjectParameter("did", did) :
                new ObjectParameter("did", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetEmployeeByname_Result>("[InfiniteDBEntities].[GetEmployeeByname](@did)", didParameter);
        }
    
        [DbFunction("InfiniteDBEntities", "inlinetablefunc1")]
        public virtual IQueryable<inlinetablefunc1_Result> inlinetablefunc1(Nullable<int> did)
        {
            var didParameter = did.HasValue ?
                new ObjectParameter("did", did) :
                new ObjectParameter("did", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<inlinetablefunc1_Result>("[InfiniteDBEntities].[inlinetablefunc1](@did)", didParameter);
        }
    
        public virtual ObjectResult<Nullable<double>> Errhandler1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<double>>("Errhandler1");
        }
    
        public virtual ObjectResult<FewEmployee_Result> FewEmployee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FewEmployee_Result>("FewEmployee");
        }
    
        public virtual ObjectResult<getEmployeebyId_Result> getEmployeebyId(Nullable<int> eid)
        {
            var eidParameter = eid.HasValue ?
                new ObjectParameter("eid", eid) :
                new ObjectParameter("eid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getEmployeebyId_Result>("getEmployeebyId", eidParameter);
        }
    
        public virtual int getEmployeeSalary(string name, ObjectParameter sal)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("getEmployeeSalary", nameParameter, sal);
        }
    
        public virtual int getMarks(string name, string sub)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var subParameter = sub != null ?
                new ObjectParameter("sub", sub) :
                new ObjectParameter("sub", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("getMarks", nameParameter, subParameter);
        }
    
        public virtual ObjectResult<string> getno_ofemployees(Nullable<int> did)
        {
            var didParameter = did.HasValue ?
                new ObjectParameter("did", did) :
                new ObjectParameter("did", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("getno_ofemployees", didParameter);
        }
    
        public virtual ObjectResult<string> getno_ofemployees_new(Nullable<int> did)
        {
            var didParameter = did.HasValue ?
                new ObjectParameter("did", did) :
                new ObjectParameter("did", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("getno_ofemployees_new", didParameter);
        }
    
        public virtual int insertproc(string dname, Nullable<int> dage)
        {
            var dnameParameter = dname != null ?
                new ObjectParameter("dname", dname) :
                new ObjectParameter("dname", typeof(string));
    
            var dageParameter = dage.HasValue ?
                new ObjectParameter("dage", dage) :
                new ObjectParameter("dage", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertproc", dnameParameter, dageParameter);
        }
    
        public virtual ObjectResult<proc1_Result> proc1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc1_Result>("proc1");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_insertstudent(string sname, string mail, ObjectParameter id)
        {
            var snameParameter = sname != null ?
                new ObjectParameter("sname", sname) :
                new ObjectParameter("sname", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_insertstudent", snameParameter, mailParameter, id);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int spSellProduct(Nullable<int> productid, Nullable<int> qtyToSell)
        {
            var productidParameter = productid.HasValue ?
                new ObjectParameter("productid", productid) :
                new ObjectParameter("productid", typeof(int));
    
            var qtyToSellParameter = qtyToSell.HasValue ?
                new ObjectParameter("QtyToSell", qtyToSell) :
                new ObjectParameter("QtyToSell", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSellProduct", productidParameter, qtyToSellParameter);
        }
    }
}
