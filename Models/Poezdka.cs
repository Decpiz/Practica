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
    
    public partial class Poezdka
    {
        public int ID_Reisa { get; set; }
        public int ID_Goroda { get; set; }
        public Nullable<System.TimeSpan> Vremia { get; set; }
    
        public virtual Gorod Gorod { get; set; }
        public virtual Reisi Reisi { get; set; }
    }
}
