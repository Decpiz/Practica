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
    
    public partial class Bileti
    {
        public int ID_Bileta { get; set; }
        public int ID_Reisa { get; set; }
        public int ID_Passazhira { get; set; }
        public int ID_Operacii { get; set; }
        public string Nomer_bileta { get; set; }
        public decimal Summa { get; set; }
    
        public virtual Operacii_ Operacii_ { get; set; }
        public virtual Passazhiri Passazhiri { get; set; }
        public virtual Reisi Reisi { get; set; }
    }
}