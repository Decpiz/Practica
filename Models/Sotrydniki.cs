//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Практика_ТРЗБД_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sotrydniki
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sotrydniki()
        {
            this.Reisi = new HashSet<Reisi>();
            this.Remont = new HashSet<Remont>();
        }
    
        public int ID_Sotrudnika { get; set; }
        public int ID_Dolzhnosti { get; set; }
        public string Familia { get; set; }
        public string Imya { get; set; }
        public string Otchestvo { get; set; }
        public string Nomer_telefona { get; set; }
        public string Pochta { get; set; }
        public System.DateTime Data_trydoystroistva { get; set; }
        public Nullable<int> ID_Ydostoverenia { get; set; }
    
        public virtual Dolzhnosti Dolzhnosti { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reisi> Reisi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Remont> Remont { get; set; }
        public virtual Voditelskoe_ydostoverenie Voditelskoe_ydostoverenie { get; set; }
    }
}