//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aplicacion_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pet
    {
        public int Id { get; set; }
        public string Pet_Name { get; set; }
        public Nullable<System.DateTime> Day_Birth { get; set; }
        public Nullable<int> Id_Race { get; set; }
        public string Photo { get; set; }
        public int Id_Person { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual Race Race { get; set; }
    }
}
