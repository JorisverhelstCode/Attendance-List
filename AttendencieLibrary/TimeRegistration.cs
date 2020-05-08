//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AttendencieLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class TimeRegistration
    {
        public int ID { get; set; }
        public System.DateTime DateTime { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> ParticipantID { get; set; }
    
        public virtual CourseInfo CourseInfo { get; set; }
        public virtual Participant Participant { get; set; }

        public override string ToString()
        {
            return DateTime.Day + "/" + DateTime.Month + "/" + DateTime.Year;
        }
    }
}
