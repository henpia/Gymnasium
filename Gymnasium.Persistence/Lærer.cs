//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gymnasium.Persistence
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lærer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lærer()
        {
            this.Fags = new HashSet<Fag>();
        }
    
        public System.Guid LærerId { get; set; }
        public string CprNummer { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public bool Deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fag> Fags { get; set; }
    }
}
