//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Szoftech2_U945X9_Beadandó
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rendelés
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Rendelés()
        {
            this.Rendelt_Termék = new HashSet<Rendelt_Termék>();
        }
    
        public byte RendelésSK { get; set; }
        public Nullable<byte> VásárlóFK { get; set; }
        public Nullable<System.DateTime> Rendelés_Dátum { get; set; }
        public Nullable<bool> Összeszerelés { get; set; }
        public Nullable<byte> FizetésimódFK { get; set; }
    
        public virtual FizetésiMód FizetésiMód { get; set; }
        public virtual Vásárló Vásárló { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rendelt_Termék> Rendelt_Termék { get; set; }
    }
}
