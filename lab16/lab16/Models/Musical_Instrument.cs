//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab16.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Musical_Instrument
    {
        public int id { get; set; }
        public string names { get; set; }
        public Nullable<int> typeId { get; set; }
        public string brand { get; set; }
        public byte[] photo { get; set; }
    
        public virtual Musical_Instrument_Type Musical_Instrument_Type { get; set; }
    }
}
