//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace Toci.Mvcexample.Models.DBContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class devavailabilitydetailed
    {
        [Key]
        public int idDevAvailability { get; set; }
        public int Developer_idDeveloper { get; set; }
        public string LinkToCalendar { get; set; }
    
        public virtual developer developer { get; set; }
    }
}
