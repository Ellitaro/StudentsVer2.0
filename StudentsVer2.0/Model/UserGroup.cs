//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentsVer2._0.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserGroup
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int GroupID { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual User User { get; set; }
    }
}
