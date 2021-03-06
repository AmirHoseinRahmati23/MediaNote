//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediaNote.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class MediaNote
    {
        public int MediaId { get; set; }
        public int TypeId { get; set; }
        public int PersonId { get; set; }
        public Nullable<double> RateInIMDB { get; set; }
        public string PersianName { get; set; }
        public string EnglishName { get; set; }
        public string NameInMediaCountry { get; set; }
        public string CreatedBy { get; set; }
        public string Information { get; set; }
        public Nullable<int> ReleaseYear { get; set; }
        public string MediaImage { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual Type Type1 { get; set; }
    }
}
