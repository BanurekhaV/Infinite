//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tbl_Employee
    {
        public int EmpNo { get; set; }
        public string EName { get; set; }
        public string job { get; set; }
        public Nullable<int> manager_id { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public Nullable<decimal> salary { get; set; }
        public Nullable<decimal> commision { get; set; }
        public Nullable<int> DeptNo { get; set; }
    
        public virtual tbl_Department tbl_Department { get; set; }
    }
}