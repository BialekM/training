//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toci.Mvcexample.Models.CoursesSearch
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCourses
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCourses()
        {
            this.tblCourse_KeyWord = new HashSet<tblCourse_KeyWord>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Discipline { get; set; }
        public Nullable<int> Duration { get; set; }
        public string CourseLevel { get; set; }
        public string Location { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCourse_KeyWord> tblCourse_KeyWord { get; set; }
    }
}
