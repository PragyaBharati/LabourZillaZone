//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabourZilla.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class labour
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public string CityAddress { get; set; }
        public string StateL { get; set; }
        public Nullable<int> DailyWages { get; set; }
        public Nullable<System.DateTime> TimeDate { get; set; }
        public string Available { get; set; }
        public string LContact { get; set; }
        public string PasswordC { get; set; }
        public string Confirm_password { get; set; }
        public string LPic { get; set; }
    }
}
